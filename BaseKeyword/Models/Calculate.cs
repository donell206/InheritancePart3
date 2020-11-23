using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseKeyword.Models
{
    public class Calculate
    {
        public string Item { get; set; }
        public int NumberOfItem{ get; set; }
        public double price { get; set; }
        public double Tax{ get; set; } =21.00;


    }
}
