using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace A_Classes_StephanieLopez
{
    internal class Bike
    {
        //Fields!
        private string _brand;
        private string _type;
        private string _color1;
        private int _numberofwheels;

        //Properties!
        public string Brand { get => _brand; set => _brand = value; }
        public string Type { get => _type; set => _type = value; }
        public string Color1 { get => _color1; set => _color1 = value; }
        public int _NumberOfWheels { get => _numberofwheels; set => _numberofwheels = value; }
    }
}
