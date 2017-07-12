using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using minidining.control;

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
        public void test列出本日菜單()
        {
            string expected = "";  // 期望值
            string actual;         // 實際值
            actual = control.列出本日菜單();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void test確認點餐資訊()
        {
            string expected = "";  // 期望值
            string actual;         // 實際值
            actual = control.確認點餐資訊();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void test儲存點餐交易()
        {
            bool expected = false;  // 期望值
            bool actual;            // 實際值
            actual = control.儲存點餐交易();

            Assert.AreEqual(expected, actual);
        }
    }
}