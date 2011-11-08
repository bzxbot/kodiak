using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Transformations.Classes
{
    public interface IObserver
    {
        void Notify(object obj);
    }
}
