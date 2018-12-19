using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Intermediate
{
    public abstract class FourLeggedAnimal
    {
        public virtual string Describe()
        {
            return "Not much is known about this four legged animal!";
        }

        public abstract void Cry();
    }

    public class Dog : FourLeggedAnimal
    {
        //public override string Describe()
        //{
        //    string result = base.Describe();
        //    result += " In fact, it's a dog!";
        //    return result;
        //}
        public override void Cry()
        {
            throw new NotImplementedException();
        }
    }
}
