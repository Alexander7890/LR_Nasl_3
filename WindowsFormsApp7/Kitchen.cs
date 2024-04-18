using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    public class Kitchen : Furniture
    {
        public string ConnectionStatus { get; set; }

        public Kitchen(string name, string connectionStatus) : base(name)
        {
            ConnectionStatus = connectionStatus;
            Set();
        }

        public void Set()
        {
            ConnectionStatus = "yes";
        }

        public override string ToString()
        {
            return base.ToString() + $", Connection Status: {ConnectionStatus}";
        }
    }
}
