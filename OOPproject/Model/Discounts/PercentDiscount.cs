using OOPproject.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPproject.Model.Discounts
{
    public class PercentDiscount : IDiscount
    {
        private decimal _discount;
        private Category _category;
        private decimal _spendInCategory;

        public PercentDiscount(Category category)
        {
            Discount = 0.01m;
            Category = category;
            SpendInCategory = 0;
        }

        public string Info { get { return $"Процентная «{Category}» - {Discount * 100}%"; } }
        public decimal Discount
        {
            get { return _discount; }
            set { if (value > 0.1m) { throw new Exception($"{value} > 10"); } _discount = value; }
        }
        public Category Category { get { return _category; } set { _category = value; } }
        public decimal SpendInCategory { get { return _spendInCategory; } set { _spendInCategory = value; } }

        public decimal Calculate(List<Item> items)
        {
            decimal totalDiscount = 0;
            foreach (var thing in items) {
                if (thing.ItemCategory == Category) {
                    totalDiscount += thing.Cost * Discount;
                }
            }
            return totalDiscount;
        }
        public decimal Apply(List<Item> items)
        {
            foreach (var thing in items)
            {
                if (thing.ItemCategory == Category)
                {
                    SpendInCategory = SpendInCategory + thing.Cost;
                }
            }
            return Calculate(items);
        }
        public void Update(List<Item> items)
        {
            if (SpendInCategory % 1000 >= 1 && SpendInCategory % 1000 < 10)
            {
                Discount = SpendInCategory % 100_000;
            }
        }
    }
}
