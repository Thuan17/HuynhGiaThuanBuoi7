using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Khach
    {


        public String Name;
        public Khach(string name)
        {
            this.Name = name;

        }
        public string getName
        { get { return this.Name; } }
        public void setName(string name)
        {
            this.Name = name;
        }


    }
}
