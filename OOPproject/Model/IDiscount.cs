using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPproject.Model
{
    public interface IDiscount
    {
        string Info { get; }
        decimal Calculate(List<Item> items);
        decimal Apply(List<Item> items);
        void Update(List<Item> items);
    }
}
