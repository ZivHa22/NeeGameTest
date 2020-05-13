using NeoGamesZivHajaj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace NeoGamesZivHajaj
{
    public class Service1 : IService1
    {

        public List<Item> Items = new List<Item>();
        Random rnd = new Random();

        public Service1()
        {
            //stub data
            DateTime now = DateTime.Now;
            for(int i = 0; i < 10; i++)
            {
                Items.Add(new Item(i,rnd.Next(1,100), now.AddDays(i).ToString("yyyy-MM-dd HH:MM:ss")));
            }
        }
        public List<Item> GetData(string StartDate, int BulkSize)
        {

            //return data from start date in bulk size
            List<Item> curItems = new List<Item>();

            curItems = Items.Where(x => DateTime.Parse(x.PurchaseDate) > DateTime.Parse(StartDate)).Take(BulkSize).ToList();
            return curItems;
        }
    }
}
