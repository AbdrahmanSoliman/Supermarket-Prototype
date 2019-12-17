using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApplication3
{
    interface Item
    {
        string name();
        double price();
        int Count();
        void minize();

    }
    //classe of rise//
    class Rice : Item
    {
        static int count=0 ;
        string n = "Rice";
        
        public int Countof
        {
            get { return count; }
            set { count = value; }
        }
        public int Count()
        {
            if (count > 0)
            {
                return count;
            }
            else
            {
                return 0;
            }
            
        }
        public string name()
        {
            return n;
        }

        public double price()
        {
            return 14.5;
        }
        public void minize()
        {
            count--;
        }


    }
    //classe of oil//
    class oil : Item
    {
        static int count = 0;
        string n = "Oil";
        public int Countof
        {
            get { return count; }
            set { count = value; }
        }
        public int Count()
        {
            if (count > 0)
            {
                return count;
            }
            else
            {
                return 0;
            }
        }
        public string name()
        {
            return n;
        }

        public double price()
        {
            return 20.5;
        }
        public void minize()
        {
            count--;
        }



    }
    //calss of sugar//
    class sugar : Item
    {
        static int count = 0;
        string n = "Sugar";
        public int Countof
        {
            get { return count; }
            set { count = value; }
        }
        public int Count()
        {
            if (count > 0)
            {
                return count;
            }
            else
            {
                return 0;
            }
        }
        public string name()
        {
            return n;
        }

        public double price()
        {
            return 11.5;
        }
        public void minize()
        {
            count--;
        }


    }
    //class pf meat//
    class Meat : Item
    {
        static int count = 0;
        string n = "Meat";
        public int Countof
        {
            get { return count; }
            set { count = value; }
        }
        public int Count()
        {
            if (count > 0)
            {
                return count;
            }
            else
            {
                return 0;
            }
        }
        public string name()
        {
            return n;
        }

        public double price()
        {
            return 100;
        }
        public void minize()
        {
            count--;
        }

    }
    //class of fish//
    class fish : Item
    {
        static int count = 0;
        string n = "Fish";
        public int Countof
        {
            get { return count; }
            set { count = value; }
        }
        public int Count()
        {
            if (count > 0)
            {
                return count;
            }
            else
            {
                return 0;
            }
        }
        public string name()
        {
            return n;
        }

        public double price()
        {
            return 60;
        }
        public void minize()
        {
            count--;
        }

    }
    //class of chicken//
    class Chicken : Item
    {
        static int count = 0;
        string n = "Chicken";
        public int Countof
        {
            get { return count; }
            set { count = value; }
        }
        public int Count()
        {
            if (count > 0)
            {
                return count;
            }
            else
            {
                return 0;
            }
        }
        public string name()
        {
            return n;
        }

        public double price()
        {
            return 30;
        }
        public void minize()
        {
            count--;
        }

    }
    //class of pasta//
    class Pasta : Item
    {
        static int count = 0;
        string n = "Pasta";
        public int Countof
        {
            get { return count; }
            set { count = value; }
        }
        public int Count()
        {
            return count;
        }
        public string name()
        {
            return n;
        }

        public double price()
        {
            return 15.30;
        }
        public void minize()
        {
            count--;
        }

    }
    //class of milk//
    class Milk : Item
    {
        static int count = 0;
        string n = "Milk";
        public int Countof
        {
            get { return count; }
            set { count = value; }
        }
        public int Count()
        {
            if (count > 0)
            {
                return count;
            }
            else
            {
                return 0;
            }
        }
        public string name()
        {
            return n;
        }

        public double price()
        {
            return 50;
        }
        public void minize()
        {
            count--;
        }

    }
    //class of Water//
    class Water : Item
    {
        static int count = 0;
        string n = "Water";
        public int Countof
        {
            get { return count; }
            set { count = value; }
        }
        public int Count()
        {
            if (count > 0)
            {
                return count;
            }
            else
            {
                return 0;
            }
        }
        public string name()
        {
            return n;
        }

        public double price()
        {
            return 20.5;
        }
        public void minize()
        {
            count--;
        }

    }
}
