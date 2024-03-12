using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_4
{
    abstract class Parent<T>: IPrinter
    {
        protected IValueProvider<T> provider;

        protected static Random rnd = new Random();

        protected bool fill = false;

        public Parent(IValueProvider<T> provider, bool fill)
        {
            this.provider = provider;
            this.fill = fill;
            Fill();
        }

        public abstract void RndFill();

        public abstract void UserFill();

        public abstract void Print();

        public void Fill()
        {
            if (fill)
            {
                UserFill();
            }
            else
            {
                RndFill();
            }
        }
    }
}