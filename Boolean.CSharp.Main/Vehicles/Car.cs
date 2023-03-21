﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main.Vehicles
{
    public class Car
    {
        private string _model;
        private string _make;

        public Car()
        {
            _model = string.Empty;
            _make = string.Empty;
        }
        public Car(string Make)
        {
            _make = Make;
            _model = string.Empty;
        }

        public string Make { get => _make; set => _make = value; }
        public string Model { get => _model; set => _model = value; }

    }
}
