using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp40
{
    internal class Group
    {
        public Group(string a,int b)
        {
            this._no= a;
            this._studentLimit= b;

        }
        private string _no;
        private int _studentLimit;
        public string Nooo { get =>
                this._no;
                set
                
            {
                if (charstr(value))
                {
                    this._no = value;

                }

            }
        }
        public int MyProperty { get => this._studentLimit;
                set 
            {
                if (value==15)
                {
                    this._studentLimit = value;

                }
            }
        }
        public bool charstr( string a)
        {
            if (string.IsNullOrWhiteSpace(a) && a.Length==5)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (char.IsUpper(a[0]) && char.IsUpper(a[1]) && char.IsDigit(a[2]) && char.IsDigit(a[3]))
                    {
                        return true;

                    }

                }

            }
            return false;





        }
    }
}
