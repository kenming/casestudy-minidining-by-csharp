using System;
using System.Collections.Generic;
using System.Text;

namespace minidining.control.dto
{
    // MenuItem
    public class 菜單項目
    {
        public string id { get; set; }      // 菜單編號
        public string name { get; set; }    // 菜單名稱
        public string price { get; set; }   // 售價
    }

    // 點餐 (表頭)
    public class 點餐
    {
        public string orderDate { get; set; }  // 點餐日期
        public string tableNo { get; set; }    // 桌耗
        public int totalPrice { get; set; }    // 總額
    }

    // 點餐項目 (表身)
    public class 點餐項目
    {
        public string id { get; set; }         // 菜單編號
        public string name { get; set; }       // 菜單名
        public int price { get; set; }         // 售價
        public int quanity { get; set; }       // 數量
        public int subTotalPrice { get; set; } // 小計
    }
}

