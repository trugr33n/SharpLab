using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPproject.Model.Discounts
{
    public class PointsDiscount : IDiscount
    {
        private int _pointsCount;
        public string Info { get { return $"Накопительная – {PointsCount} баллов"; } }

        public PointsDiscount() {
            SetPointsCount = 0;
        }

        public int PointsCount { get { return this._pointsCount; } }
        private int SetPointsCount { 
            set { if (value < 0) { throw new Exception($"{value} < 0"); } this._pointsCount = value; } 
        }

        public decimal Calculate(List<Item> items) { 
            decimal totalCost = 0m;
            foreach (var thing in items) {
                totalCost += thing.Cost;
            }
            decimal maxSale = totalCost * 0.30m;
            if (maxSale <= PointsCount) { return maxSale; }
            else { return PointsCount; }
        }
        public decimal Apply(List<Item> items) { 
            decimal sale = Calculate(items);
            decimal saleForItem = sale / items.Count;
            foreach (var thing in items) { 
                thing.Cost = thing.Cost - saleForItem;
            }
            SetPointsCount = PointsCount + (int)sale;
            return sale;
        }
        public void Update(List<Item> items) { 
            foreach(var thing in items) {
                SetPointsCount = PointsCount + (int)(thing.Cost * 0.10m);
            }
        }
    }
}
