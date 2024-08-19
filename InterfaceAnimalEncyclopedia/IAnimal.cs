using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAnimalEncyclopedia
{
    public　interface IAnimal
    {
        string MakeSound();
    }

    public class Dog : IAnimal
    {
        public string MakeSound()
        {
            return "ワンワン";
        }
    }

    public class Cat : IAnimal
    {
        public string MakeSound()
        {
            return "ニャー";
        }
    }

    public class Bird : IAnimal
    {
        public string MakeSound()
        {
            return "ピーピー";
        }
    }

}
