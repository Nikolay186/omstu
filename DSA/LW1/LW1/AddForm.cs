using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LW1
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            BusController.Add(new Bus(Convert.ToInt32(textBox1.Text), textBox2.Text, Convert.ToInt32(textBox3.Text)));
            this.Close();
        }
    }
}
