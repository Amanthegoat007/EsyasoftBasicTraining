using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    // Meter Object class
    public class MeterObject
    {
        public string Name { get; set; }
        public ObisCode Obis { get; set; }
        public int Value { get; set; }

        public MeterObject(string name, ObisCode obis, int value = 0)
        {
            Name = name;
            Obis = obis;
            Value = value;
        }
    }
