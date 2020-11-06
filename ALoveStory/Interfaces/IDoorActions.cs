using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALoveStory.Interfaces
{
    interface IDoorActions
    {
        void Knock();
        void Open(string name);
        void Close(string name);

    }
}
