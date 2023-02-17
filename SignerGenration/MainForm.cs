﻿using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using Microsoft.International.Converters.PinYinConverter;
using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SignerGenration
{
    public partial class MainForm : Form
    {
        public static readonly Dictionary<string, string> dic = new Dictionary<string, string>
    {
        { "滕州人力行政中心", "HR & Admin Center." },
        { "key2", "value2" },
        { "key3", "value3" }
    };
        public MainForm()
        {
            InitializeComponent();
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            //警告信息
            string warning1 = "本邮件载有秘密信息，请您恪守保密义务；未经授权者不得复印、公开、使用本邮件及内容！谢谢合作！";
            string warning2 = "This email communication is confidential, Recipient(s) named above is (are) obligated to maintain secrecy. ";
            string warning3 = "Any unauthorized dissemination, distribution or copying of this communication is (are) strictly prohibited. ";
            string warning4 = "Thank you.";

            string companyInfo = "联泓新材料科技股份有限公司  山东省滕州市鲁南高科技化工园区";
            string companyInfoEnglish = "Levima Advanced Materials Corporation  www.levima.cn（0632）2226016";

            //logo信息
            byte[] imageBytes = Convert.FromBase64String(logo);
            System.Drawing.Image logoImage;
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                logoImage = System.Drawing.Image.FromStream(ms);
            }
            // 获取姓名和职位
            string name = inputname.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("请输入姓名");
                return;
            }

            //获取姓名拼音
            String pinyin = pinyininput.Text.Trim();
            if (string.IsNullOrEmpty(pinyin))
            {
                MessageBox.Show("请输入姓名拼音");
                return;
            }

            //获取部门信息
            string selectdepartment = "";
            if (department.SelectedItem != null)
            {
                selectdepartment = department.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("请选择所在部门");
                return;
            }

            //手机号
            string phoneNumber = "";
            phoneNumber=phone.Text.Trim();
            if (string.IsNullOrEmpty(phoneNumber) || !IsPhoneNumber(phoneNumber))
            {
                MessageBox.Show("手机号输入有误，请重新输入");
                return;
            }

            //座机号
            string telephoneNumber = "";
            telephoneNumber=telephone.Text.Trim();
            if (string.IsNullOrEmpty(telephoneNumber) )
            {
                MessageBox.Show("请输入座机号码");
                return;
            }

            //个人邮箱
            string personalEmail = "";
            personalEmail=email.Text.Trim();
            if (string.IsNullOrEmpty(personalEmail))
            {
                MessageBox.Show("请输入个人邮箱");
                return;
            }
            //获取部门名称翻译
            string departmentTranslation = dic[selectdepartment];


            // 设置个人信息字体格式
            Font font = new Font("微软雅黑", 9, FontStyle.Bold);
            Brush brush = new SolidBrush(Color.FromArgb(23, 54, 93));

            //警告信息字体格式
            Font warnfont = new Font("微软雅黑", 9, FontStyle.Regular);
            Brush warnbrush = new SolidBrush(Color.FromArgb(166, 166, 166));

            // 创建画布并设置大小
            Bitmap bmp = new Bitmap(670, 220);

            // 获取绘图对象
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White);

            //绘制虚线
            using (Graphics graphics = Graphics.FromImage(bmp))
            {
                Pen pen = new Pen(Color.FromArgb(23, 54, 93));
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                graphics.DrawLine(pen, new Point(0, 2), new Point(780, 2));
                graphics.DrawLine(pen, new Point(0, 127), new Point(780, 127));
            }

            
            //绘制logo
            g.DrawImage(logoImage, new Point(480, 40));

            
            //绘制警告信息
            g.DrawString(warning1, warnfont, warnbrush, 0, 140);
            g.DrawString(warning2, warnfont, warnbrush, 0, 160);
            g.DrawString(warning3, warnfont, warnbrush, 0, 180);
            g.DrawString(warning4, warnfont, warnbrush, 0, 200);


            // 绘制签名第一行
            g.DrawString(string.Concat(name," | ",selectdepartment), font, brush, 0, 20);

            // 获取姓名绘制区域
            //SizeF textSize = g.MeasureString(name, font);

            // 计算部门开始绘制坐标值
           // PointF rbCorner = new PointF(textSize.Width, textSize.Height);

            
            //绘制所属部门
            //g.DrawString(string.Concat(" | ",selectdepartment), font, brush, rbCorner);


            //绘制手机号电话号邮箱
            g.DrawString(string.Concat(phoneNumber, " | ", telephoneNumber, " | ", personalEmail), font, brush, 0, 40);

            g.DrawString(companyInfo,font, brush, 0,60);

            //g.DrawString(pinyin, font, brush, 0, 110);
            // 获取姓名拼音绘制区域
            //SizeF pinyinSize = g.MeasureString(pinyin, font);

            // 计算部门翻译开始绘制坐标值
            //PointF pinyinCorner = new PointF(pinyinSize.Width, 110);
            //绘制部门翻译
            g.DrawString(string.Concat(pinyin," | ", departmentTranslation), font, brush, 0,80);

            //
            g.DrawString(companyInfoEnglish, font, brush, 0, 100);

            

            

            // 释放资源
            g.Dispose();

            // 显示绘制结果
            //resultLabel.Text = $"({rbCorner.X}, {rbCorner.Y})";

            // 保存图片
            bmp.Save("个人签名.png", ImageFormat.Png);

            // 打开保存的图片
            System.Diagnostics.Process.Start("个人签名.png");


            // 读取图片文件
            //System.Drawing.Image image = System.Drawing.Image.FromFile("logo.png");

            
        }
        public static bool IsPhoneNumber(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, @"^1(3[0-9]|5[0-9]|7[6-8]|8[0-9])[0-9]{8}$");
        }

        private void inputText_TextChanged(object sender, EventArgs e)
        {

        }

        private void department_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pinyininput_TextChanged(object sender, EventArgs e)
        {

        }

        private void phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void telephone_TextChanged(object sender, EventArgs e)
        {

        }
        private void email_TextChanged(object sender, EventArgs e)
        {

        }
        public static string logo = "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";
    }
}
