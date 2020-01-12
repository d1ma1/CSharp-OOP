﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalCentre.Models.Entities.AnimalsFolder
{
    public class Lion : Animal
    {
        public Lion(string name, int energy, int happiness, int procedureTime) : base(name, energy, happiness, procedureTime)
        {
        }
        public override string ToString()
        {
            return $"Animal type: {this.GetType().Name} - {Name} - Happiness: {Happiness} - Energy: {Energy}";
        }
    }
}
