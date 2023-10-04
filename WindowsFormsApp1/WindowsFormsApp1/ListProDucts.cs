using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class ListProDucts
    {
        public double Price;
        public ListProDucts(double price)
        {

            Price = price;
        }
        public double getName
        { get { return this.Price; } }
        public void setName(double price)
        {
            this.Price = price;
        }

        //public double TongTien()
        //{
        //    int sum = Convert.ToInt32(Price.Compute("SUM(Salary)", string.Empty));
        //    return sum
        //}

    }
}
