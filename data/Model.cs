using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace efdd.data
{
    public class Model : DbContext
    {
        public DbSet<Item> Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=data/objects.db3");
        }
    }

    public class Item
    {
        [Key] public int Uid { get; set; }
        public string Name { get; set; }
        public char Symbol { get; set; }
        public int Ink { get; set; }
        public int Paper { get; set; }
        //public int Category { get; set; }
        //public int SubCategory { get; set; }
        //public string Description { get; set; }
        //public int Mass { get; set; }
        //public int Cost { get; set; }
        //public bool IsEquipment { get; set; }
    }
}