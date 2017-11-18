using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestData.Models
{
    [Table("AA_Items")]
    public class Item
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }

        [Computed]
        public string FullInfo
        {
            get
            {
                //any logic in here required to get the data
                return Title + " " + Description;
            }
            set { }
        }

        public static IEnumerable<Item> GetAll(IDbConnection db)
        {
            return db.GetAll<Item>();
        }

        public static Item GetById(IDbConnection db, int id)
        {
            return db.Get<Item>(id);
        }
    }
}
