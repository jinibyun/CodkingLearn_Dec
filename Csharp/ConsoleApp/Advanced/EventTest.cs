using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Advanced
{
    // Event is special kind of delegate
    // Event is meaningful only between classes: One is publisher (invoking event, invoking delegate), other one is subscriber    
    // publisher and subscriber model: Event-Driven Programming Model
    // publisher: using delegate, raise event
    // subscriber: consume to event raised: event handler

    public delegate void ButtonClickedHandler();
    public class Publisher
    {
        // all event is type of delegate
        public event ButtonClickedHandler ButtonClicked;
        
        public void Test()
        {
            if(ButtonClicked != null)
            {
                ButtonClicked(); // ButtonClicked.Invoke();
            }
        }
    }
}
