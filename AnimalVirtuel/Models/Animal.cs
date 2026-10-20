using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalVirtuel.Models
{
    public class Animal
    {
        public string Nom { get; set;  }

        public enum Espece { }

        public int Faim {  get; set; }

        public int Bonheur { get; set; }

        public int Energie { get; set; }

    }
}
