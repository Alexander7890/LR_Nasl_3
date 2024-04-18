using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{   
    // Підклас для оббитих меблів

    public class Upholstered : Furniture
    {
        public int Area { get; set; }
        public string Cleanliness { get; set; }

        public Upholstered(string name, int area, string cleanliness) : base(name)
        {
            Area = area;
            Cleanliness = cleanliness;
            Set();
        }

        public void Set()
        {
            Cleanliness = "yes";
        }

        public override string ToString()
        {
            return base.ToString() + $", Area: {Area}, Cleanliness: {Cleanliness}";
        }
    }
}
