using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace NeoGamesZivHajaj.Models
{
    public class Item
    {
        //Model of a item
        [DataMember]
        public int ItemNo { get; set; }
        [DataMember]
        public int Amount { get; set; }
        [DataMember]
        public string PurchaseDate { get; set; }

        public Item(int ItemNo, int Amount, string PurchaseDate)
        {
            this.ItemNo = ItemNo;
            this.Amount = Amount;
            this.PurchaseDate = PurchaseDate;
        }
        public Item()
        {
            ItemNo = 0;
            Amount = 0;
            PurchaseDate = new DateTime().ToString();
        }
    }
}