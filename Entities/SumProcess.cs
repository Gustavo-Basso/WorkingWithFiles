using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesTestes.Entities {
    internal class SumProcess {

        public string Item { get; set; }
        public double Price { get; set; }
        public int Quant { get; set; }
        public double TotalPrice { get; set; }

        public SumProcess() { }
        public SumProcess(string item, double price, int quant) {

            Item = item;
            Price = price;
            Quant = quant;

        }

        public void totalPrice() {

            TotalPrice = Quant * Price;
        }

        public override string ToString() {

            return Item + " (" + TotalPrice + ")";

        }

    }
}
