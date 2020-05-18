using System;
using System.Collections.Generic;
using System.Text;

namespace KR2
{
    class Wine
    {
        private string _marka;
        private string _alcohol;
        private string _volume;
        private double _price;
        public Wine()
        {
            _marka = " Cabernet Sauvignon";
            _alcohol = "15";
            _volume = "0.75";
            _price = 15000;
        }

        public Wine(string marka, string alcohol, string volume, double price)
        {
            _marka = marka;
            _alcohol = alcohol;
            _volume = volume;
            _price = price;
        }

        public void GetInformation()
        {
            Console.Write("  Марка вина - ");
            _marka = Convert.ToString(Console.ReadLine());
            Console.Write("  Міцність - ");
            _alcohol = Convert.ToString(Console.ReadLine());
            Console.Write("  Об'єм - ");
            _volume = Convert.ToString(Console.ReadLine());
            Console.Write("  Ціна - ");
            _price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
        }

        public override string ToString()
        {
            return string.Format(" Wine\n Марка = {0}\n Міцність = {1}\n Об'єм = {2}\n Ціна = {3}\n", 
            _marka, _alcohol, _volume, _price);
        }
    }
}
