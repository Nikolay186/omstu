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
    public partial class TakeOffForm : Form
    {
        public TakeOffForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BusController.TakeOffTheRoute(Convert.ToInt32(textBox1.Text));
            this.Close();
        }
    }
}
