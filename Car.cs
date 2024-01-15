using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Classes_StephanieLopez
{
    internal class Car
    {
        //Fields!
        private string _make;
        private string _model;
        private int _year;
        private string _color;
        private int _mileage;

        //Properties!
        public string Make { get => _make; set => _make = value; }
        public string Model { get => _model; set => _model = value; }
        public int Year { get => _year; set => _year = value; }
        public string Color { get => _color; set => _color = value; }
        public int Mileage { get => _mileage; set => _mileage = value; }

    }
}
