﻿using System;

namespace DesignPatterns.Adapter
{
    class AdapterDemo
    {
        public void Run()
        {
            // Non-adapted chemical compound
            //Compound unknown = new Compound("Unknown");
            //unknown.Display();

            // Adapted chemical compounds
            Compound water = new RichCompound("Water");
            water.Display();

            Compound benzene = new RichCompound("Benzene");
            benzene.Display();

            Compound ethanol = new RichCompound("Ethanol");
            ethanol.Display();

            // Wait for user
            Console.ReadKey();
        }
    }
}
