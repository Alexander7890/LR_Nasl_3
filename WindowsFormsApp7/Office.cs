using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    public class Office : Furniture
    {
        public string Status { get; set; }

        public Office(string name, string status) : base(name)
        {
            Status = status;
            Set();
        }

        public void Set()
        {
            Status = "Vilna";
        }

        public override string ToString()
        {
            return base.ToString() + $", Status: {Status}";
        }
    }
}
