using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using minidining.control;

namespace minidining.control.test
{
    [TestClass]
    public class �I�\ControlTest
    {
        private �I�\Control control;

        [TestInitialize]
        // ��l�Ƹ귽�C�b����C�@�Ӵ��դ�k���e�A�|���楻���դ�k
        public void Setup()
        {
            control = new �I�\Control();
        }

        [TestMethod]
        public void test�C�X������()
        {
            string expected = "";  // �����
            string actual;         // ��ڭ�
            actual = control.�C�X������();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void test�T�{�I�\��T()
        {
            string expected = "";  // �����
            string actual;         // ��ڭ�
            actual = control.�T�{�I�\��T();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void test�x�s�I�\���()
        {
            bool expected = false;  // �����
            bool actual;            // ��ڭ�
            actual = control.�x�s�I�\���();

            Assert.AreEqual(expected, actual);
        }
    }
}