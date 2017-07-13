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
        public int price { get; set; }      // 售價
    }

    // 點餐 (表頭)
    public class 點餐
    {
        public string orderDate { get; set; }           // 點餐日期
        public string tableNo { get; set; }             // 桌號
        public List<點餐項目> itemList { get; set; }    // 點餐項目集合
        public int totalPrice { get; set; }             // 總額
    }

    // 點餐項目 (表身)
    public class 點餐項目
    {
        public 菜單項目 item { get; set; }     // 菜單
        public int quantity { get; set; }       // 數量
        public int subTotalPrice { get; set; } // 小計
    }
}

