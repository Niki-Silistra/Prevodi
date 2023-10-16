using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prevodi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string language = comboBox1.Text;
            if (language == String.Empty)
            {
                label8.Text = "Моля изберете език за превод!";
                return;
            }
            int pages = (int)numericUpDown1.Value;
            if (pages == 0)
            {
                label8.Text = "Моля изберете брой страници за превод!";
                return;
            }
            label8.Text = "";
            double pricePerPage =
                language == "иврит" ? 20 :
                language == "норвежки" ? 14 :
                language == "гръцки" || language == "турски" || language == "унгарски" ? 11 : 7;
            double Sum = pages * pricePerPage * (radioButton2.Checked ? 1.5 : radioButton3.Checked ? 2 : 1);
            textBox3.Text = Sum.ToString("0.00") + " лв.";
            pictureBox1.Visible = true;
        }
    }
}
