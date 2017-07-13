using System;
using System.Collections.Generic;
using System.Text;
using minidining.control.dao;
using minidining.control.dto;

namespace minidining.control
{
    public class 點餐Control
    {
        private 點餐DAO dao;

        // constructor
        public 點餐Control()
        {
            dao = new 點餐DAO();
        }

        public List<菜單項目> 列出本日菜單()
        {
            return dao.list菜單();
        }

        public 點餐 確認點餐資訊(點餐 dining)
        {
            // 計算點餐總額
            int total = 0;
            foreach (點餐項目 diningItem in dining.itemList)
            {
                // 計算點餐項目分項金額
                int subtotal = diningItem.item.price * diningItem.quantity;
                total = total + subtotal;
                diningItem.subTotalPrice = subtotal;
            }
            dining.totalPrice = total;

            return dining;
        }

        public bool 儲存點餐交易()
        {
            return false;
        }
    }
}