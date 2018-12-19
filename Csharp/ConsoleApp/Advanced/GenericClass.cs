using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Advanced
{
    // Generic class: Define class as if class accept parameter: Type (Class) Parameter
    // Usage: Define common (general) type.
    // This concept applies to interface and method dependently.
    // This is a kind of class template
    public class MyStack<T>
    {
        T[] _elements;
        int pos = 0;

        public MyStack()
        {
            _elements = new T[100];
        }

        public void Push(T element)
        {
            _elements[++pos] = element;
        }

        public T Pop()
        {
            return _elements[pos--];
        }

    }

    // T must be Value Type
    public class Generic1<T> where T: struct
    {
        
    }

    // T must be reference Type
    public class Generic2<T> where T : class
    {

    }
    
    // T should have default constructor (constructor with no parameter)
    public class Generic3<T> where T : new()
    {

    }
    
    // T must be derived class of MyBase
    //public class Generic4<T> where T : MyBase
    //{

    //}
    
    // T must inherit IComparable
    public class Generic5<T> where T : IComparable
    {

    }
    
    // more complex constraint
    //class EmployeeList<T> where T : Employee,
    //   IEmployee, IComparable<T>, new()
    //{
    //}

}
