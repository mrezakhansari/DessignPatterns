﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Adapter
{
    public class MeatDetails : Meat
    {
        private MeatDatabase _meatDatabase;
        public MeatDetails(string name)
        {
            MeatName = name;
        }
        public override void LoadData()
        {
            // The Adaptee
            _meatDatabase = new MeatDatabase();

            SafeCookTempFahrenheit = _meatDatabase.GetSafeCookTemp(MeatName, TemperatureType.Fahrenheit);
            SafeCookTempCelsius = _meatDatabase.GetSafeCookTemp(MeatName, TemperatureType.Celsius);
            CaloriesPerOunce = _meatDatabase.GetCaloriesPerOunce(MeatName);
            ProteinPerOunce = _meatDatabase.GetProteinPerOunce(MeatName);

            Console.WriteLine("\n Meat: {0} -------",MeatName);

            Console.WriteLine("  Safe Cook Temp (F): {0}",SafeCookTempFahrenheit);
            Console.WriteLine("  Safe Cook Temp (C): {0}",SafeCookTempCelsius);
            Console.WriteLine("  Calories per Ounce: {0}",CaloriesPerOunce);
            Console.WriteLine("  Protein per Ounce: {0}",ProteinPerOunce);

        }
    }
}