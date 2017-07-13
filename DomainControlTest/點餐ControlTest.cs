using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using minidining.control;
using minidining.control.dto;

namespace minidining.control.test
{
    [TestClass]
    public class 點餐ControlTest
    {
        private 點餐Control control;

        [TestInitialize]
        // 初始化資源。在執行每一個測試方法之前，會執行本測試方法
        public void Setup()
        {
            control = new 點餐Control();
        }

        [TestMethod]
        public void test列出菜單編號1菜名()
        {
            string expected;      // 期望值
            string actual;         // 實際值

            expected = "主餐-義大利麵";

            List<菜單項目> itemList = new List<菜單項目>();
            itemList = control.列出本日菜單();
            actual = itemList[0].name;  // 應該以 "id: 001" 搜尋對應的項目

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void test確認點餐總額()
        {
            // 點1份主餐、2杯素咖啡
            int expected = 460;  // 期望值
            int actual;          // 實際值

            點餐 dining = this.submit點餐();
            actual = control.確認點餐資訊(dining).totalPrice;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void test儲存點餐交易NotYet寫入DB()
        {
            bool expected = false;  // 期望值
            bool actual;            // 實際值
            actual = control.儲存點餐交易();

            Assert.AreEqual(expected, actual);
        }

        // 模擬從表單傳送進來的點餐資訊
        private 點餐 submit點餐()
        {
            點餐 dining = new 點餐();
            List<點餐項目> itemList = new List<點餐項目>();
            點餐項目 diningItem1 = new 點餐項目();
            點餐項目 diningItem2 = new 點餐項目();

            // 勾選菜單列表上的1份主餐、2杯素食咖啡
            菜單項目 item1, item2;
            item1 = new 菜單項目();
            item1.id = "001";
            item1.name = "主餐-義大利麵";
            item1.price = 280;

            item2 = new 菜單項目();
            item2.id = "003";
            item2.name = "附餐-素咖啡";
            item2.price = 90;

            // 點餐項目
            diningItem1.item = item1;
            diningItem1.quantity = 1;
            diningItem2.item = item2;
            diningItem2.quantity = 2;

            // 點餐
            dining.tableNo = "8";    // 桌號：8
            itemList.Add(diningItem1);
            itemList.Add(diningItem2);
            dining.itemList = itemList;

            return dining;
        }
    }
}