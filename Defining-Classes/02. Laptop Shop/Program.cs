﻿using System;

namespace _02.Laptop_Shop
{
    class Program
    {
        static void Main()
        {
            Laptop laptop1 = new Laptop("Acer", 1400m);
            Laptop laptop2 = new Laptop("Lenovo Yoga 2 Pro", 1400.00m, 
                "Lenovo", "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)", "8 GB", "Intel HD Graphics 4400",
                "128GB SSD",  "13.3\" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display", "Li-Ion, 4-cells, 2550 mAh", 4.5);

            Console.WriteLine(laptop2);
        }
    }
}