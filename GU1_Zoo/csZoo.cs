﻿using System;
using Helpers;

namespace GU1_Zoo
{
    public class csZoo
    {
        public List<csAnimal> ListOfAnimal { get; set; } = new List<csAnimal>();
        public string Name { get; set; }

        public override string ToString()
        {
            string sRet = $"\n{Name}:";
            foreach (var item in ListOfAnimal)
            {
                sRet += $"\n{item}";
            }
            return sRet;
        }

        public csZoo(int nrAnimals, string name)
        {
            Name = name;
            var rnd = new csSeedGenerator();
            for (int i = 0; i < nrAnimals; i++)
            {
                ListOfAnimal.Add(new csAnimal(rnd));
            }
        }
        public csZoo()
        {
            Name = "Referce Zoo";
            var rnd = new csSeedGenerator();
            foreach (enAnimalKind kind in typeof(enAnimalKind).GetEnumValues())
            {
                foreach (enAnimalMood mood in typeof(enAnimalMood).GetEnumValues())
                {
                    ListOfAnimal.Add(new csAnimal(rnd) { Kind = kind, Mood = mood });
                }
            }

        }
    }

}
