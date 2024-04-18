using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        List<Furniture> furnitureCollection = new List<Furniture>();
        public Form1()
        {
            InitializeComponent();
        }
        // Додавання об'єктів меблів до колекції
        private void button1_Click(object sender, EventArgs e)
        {
            furnitureCollection.Add(new Kitchen(textBox1.Text, "yes"));
            furnitureCollection.Add(new Upholstered(textBox2.Text, 10, "no"));
            furnitureCollection.Add(new Office(textBox3.Text, "occupied"));
        }
        // Відображення всієї колекції
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Furniture item in furnitureCollection)
            {
                MessageBox.Show(item.ToString());
            }
        }
    }
}
