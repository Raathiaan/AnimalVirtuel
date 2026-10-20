using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalVirtuel.Models
{
    public class Animal
    {
        public string Nom { get; set;  }

        public int Faim { get; set; } = 70;

        public int Bonheur { get; set; } = 70;

        public int Energie { get; set; } = 100;

        public EspeceAnimal Espece { get; set; }

    }
}
