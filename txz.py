from typing import List
from selenium import webdriver
from selenium.webdriver.common.keys import Keys
import time
import re
import xlrd
import os
#def input_data(data):


# 打开excel表格
def ReadExcel(excel):
    table=excel.sheets()[0]
    n_rows=table.nrows
    data=list()
    for i in range(n_rows):
        row_data=table.row_values(i,start_colx=0,end_colx=None)
        data.append(row_data)
        print(n_rows,row_data)
    return data

def Submit(data):
    brower = webdriver.Firefox()
    time.sleep(2)
    brower.get("http://mitpassh5.3-3.me/#/pages/login/login?openId=oMcj9jiaHvs8-uJEUI_1-reBjF7c")
    time.sleep(1)
    brower.find_element_by_class_name('nav-name').click()
    time.sleep(1)
    for people in data:
        #姓名
        brower.find_element_by_class_name('padding').click()
        time.sleep(1)
        brower.find_element_by_xpath('/html/body/uni-app/uni-page/uni-page-wrapper/uni-page-body/uni-view/uni-view[3]/uni-view/uni-view[1]/uni-view[1]/uni-input/div/input').send_keys(people[0])
        #车牌号
        brower.find_element_by_xpath('/html/body/uni-app/uni-page/uni-page-wrapper/uni-page-body/uni-view/uni-view[3]/uni-view/uni-view[1]/uni-view[2]/uni-input/div/input').send_keys(people[1])
        #身份证号
        brower.find_element_by_xpath('/html/body/uni-app/uni-page/uni-page-wrapper/uni-page-body/uni-view/uni-view[3]/uni-view/uni-view[1]/uni-view[3]/uni-input/div/input').send_keys(people[2])
        #手机号
        brower.find_element_by_xpath('/html/body/uni-app/uni-page/uni-page-wrapper/uni-page-body/uni-view/uni-view[3]/uni-view/uni-view[1]/uni-view[4]/uni-input/div/input').send_keys(people[3])
        #同行人员
        brower.find_element_by_xpath('/html/body/uni-app/uni-page/uni-page-wrapper/uni-page-body/uni-view/uni-view[3]/uni-view/uni-view[1]/uni-view[6]/uni-view[2]/uni-button').click()
        time.sleep(1)
        #同行人员信息
        brower.find_element_by_xpath('/html/body/uni-app/uni-page/uni-page-wrapper/uni-page-body/uni-view/uni-view[3]/uni-view/uni-view[1]/uni-view[7]/uni-view[1]/uni-input/div/input').send_keys(people[4])
        brower.find_element_by_xpath('/html/body/uni-app/uni-page/uni-page-wrapper/uni-page-body/uni-view/uni-view[3]/uni-view/uni-view[1]/uni-view[7]/uni-view[2]/uni-input/div/input').send_keys(people[5])
        brower.find_element_by_xpath('/html/body/uni-app/uni-page/uni-page-wrapper/uni-page-body/uni-view/uni-view[3]/uni-view/uni-view[1]/uni-view[7]/uni-view[3]/uni-input/div/input').send_keys(people[6])
        brower.find_element_by_xpath('/html/body/uni-app/uni-page/uni-page-wrapper/uni-page-body/uni-view/uni-view[3]/uni-view/uni-view[5]/uni-button').click()
        time.sleep(1)
        brower.find_element_by_xpath('/html/body/uni-app/uni-page/uni-page-wrapper/uni-page-body/uni-view/uni-view[3]/uni-view/uni-view[2]/uni-view[2]/uni-view/uni-view/uni-view[1]/uni-view/uni-view[1]/uni-text').click()
        time.sleep(1)
        ##选择日期
        brower.find_element_by_xpath('/html/body/uni-app/uni-page/uni-page-wrapper/uni-page-body/uni-view/uni-view[3]/uni-view/uni-view[2]/uni-view[2]/uni-view/uni-view/uni-view[3]/uni-view/uni-view[2]/uni-view/uni-view[2]/uni-view[5]/uni-view[6]').click()
        os.system("pause")
        brower.find_element_by_xpath('/html/body/uni-app/uni-page/uni-page-wrapper/uni-page-body/uni-view/uni-view[3]/uni-view/uni-view[5]/uni-button[2]').click()
        time.sleep(1)
        brower.find_element_by_xpath('/html/body/uni-app/uni-page/uni-page-wrapper/uni-page-body/uni-view/uni-view[3]/uni-view/uni-view[3]/uni-view[1]/uni-input/div/input').send_keys(people[14])
        brower.find_element_by_xpath('/html/body/uni-app/uni-page/uni-page-wrapper/uni-page-body/uni-view/uni-view[3]/uni-view/uni-view[3]/uni-view[2]/uni-input/div/input').send_keys(people[15])
        brower.find_element_by_xpath('/html/body/uni-app/uni-page/uni-page-wrapper/uni-page-body/uni-view/uni-view[3]/uni-view/uni-view[3]/uni-view[3]/uni-input/div/input').send_keys(people[11])
        brower.find_element_by_xpath('/html/body/uni-app/uni-page/uni-page-wrapper/uni-page-body/uni-view/uni-view[3]/uni-view/uni-view[3]/uni-view[4]/uni-input/div/input').send_keys(people[12])
        brower.find_element_by_xpath('/html/body/uni-app/uni-page/uni-page-wrapper/uni-page-body/uni-view/uni-view[3]/uni-view/uni-view[3]/uni-view[7]/uni-input/div/input').send_keys(people[13])
        os.system("pause")
        brower.find_element_by_xpath('/html/body/uni-app/uni-page/uni-page-wrapper/uni-page-body/uni-view/uni-view[3]/uni-view/uni-view[5]/uni-button[2]').click()
        os.system("pause")

excel=xlrd.open_workbook('test.xls')
data=ReadExcel(excel)
Submit(data)



