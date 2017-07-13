using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using minidining.control;
using minidining.control.dto;

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
        public void test�C�X���s��1��W()
        {
            string expected;      // �����
            string actual;         // ��ڭ�

            expected = "�D�\-�q�j�Q��";

            List<��涵��> itemList = new List<��涵��>();
            itemList = control.�C�X������();
            actual = itemList[0].name;  // ���ӥH "id: 001" �j�M����������

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void test�T�{�I�\�`�B()
        {
            // �I1���D�\�B2�M���@��
            int expected = 460;  // �����
            int actual;          // ��ڭ�

            �I�\ dining = this.submit�I�\();
            actual = control.�T�{�I�\��T(dining).totalPrice;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void test�x�s�I�\���NotYet�g�JDB()
        {
            bool expected = false;  // �����
            bool actual;            // ��ڭ�
            actual = control.�x�s�I�\���();

            Assert.AreEqual(expected, actual);
        }

        // �����q���ǰe�i�Ӫ��I�\��T
        private �I�\ submit�I�\()
        {
            �I�\ dining = new �I�\();
            List<�I�\����> itemList = new List<�I�\����>();
            �I�\���� diningItem1 = new �I�\����();
            �I�\���� diningItem2 = new �I�\����();

            // �Ŀ���C��W��1���D�\�B2�M�����@��
            ��涵�� item1, item2;
            item1 = new ��涵��();
            item1.id = "001";
            item1.name = "�D�\-�q�j�Q��";
            item1.price = 280;

            item2 = new ��涵��();
            item2.id = "003";
            item2.name = "���\-���@��";
            item2.price = 90;

            // �I�\����
            diningItem1.item = item1;
            diningItem1.quantity = 1;
            diningItem2.item = item2;
            diningItem2.quantity = 2;

            // �I�\
            dining.tableNo = "8";    // �ู�G8
            itemList.Add(diningItem1);
            itemList.Add(diningItem2);
            dining.itemList = itemList;

            return dining;
        }
    }
}