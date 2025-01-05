using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class Animal
    {
        public string Name { get; set; }
        public string FavouriteFood { get; set; }

        public Animal(string name, string favouriteFood)
        {
            Name = name;
            FavouriteFood = favouriteFood;
        }

        public virtual string ExplainSelf()
        {
            return $"I am {Name} and my favorite food is {FavouriteFood}";
        }
    }
}
