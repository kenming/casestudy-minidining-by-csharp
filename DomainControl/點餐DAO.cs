using System;
using System.Collections.Generic;
using System.Text;
using minidining.control.dto;

namespace minidining.control.dao
{
    public class 點餐DAO
    {
        public List<菜單項目> list菜單()
        {
            // 暫以虛擬DB回傳 pseudo 資料
            點餐VDB vdb = new 點餐VDB();

            return vdb.get菜單();
        }

        public bool Save點餐交易(點餐 dining)
        {
            // 未來實做 INSERT 至 RDB，尚未完成前先回傳 false
            return false;
        }
    }

    internal class 點餐VDB
    {
        public List<菜單項目> get菜單()
        {
            List<菜單項目> itemList = new List<菜單項目>();
            itemList = this.create菜單(itemList);

            return itemList;
        }

        private List<菜單項目> create菜單(List<菜單項目> itemList)
        {
            菜單項目 item1, item2, item3;

            item1 = new 菜單項目();
            item1.id = "001";
            item1.name = "主餐-義大利麵";
            item1.price = 280;

            item2 = new 菜單項目();
            item2.id = "002";
            item2.name = "附餐-起司蛋糕";
            item2.price = 120;

            item3 = new 菜單項目();
            item3.id = "003";
            item3.name = "附餐-素咖啡";
            item3.price = 90;

            itemList.Add(item1);
            itemList.Add(item2);
            itemList.Add(item3);

            return itemList;
        }
    }
}