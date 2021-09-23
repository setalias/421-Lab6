using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Properties
{
    interface IGraph<T> : ICloneable<T>
    {

        void print(Graphics g);

        void create();

        void revise();

        void copy();

        void getID();

    }
}
