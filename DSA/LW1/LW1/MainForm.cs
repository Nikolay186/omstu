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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            bool test = BusController.Add(new Bus(0, "test", 10));
            BusController.Add(new Bus(1, "test1", 110));
            BusController.Add(new Bus(2, "test2", 108));
            BusController.Add(new Bus(3, "test3", 23));
            BusController.Add(new Bus(4, "test4", 4));
            BusController.Add(new Bus(5, "test5", 59));
            BusController.Add(new Bus(6, "test6", 73));
            BusController.Add(new Bus(7, "test7", 335));
            BusController.Add(new Bus(8, "test8", 12));
            BusController.Add(new Bus(9, "test9", 11));
            BusController.Add(new Bus(10, "test10", 106));
        }

        private void AddNewButton_Click(object sender, EventArgs e)
        {
            using (AddForm form = new AddForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                    form.Show();
            }

            UpdateInfo();
        }

        private void sendOnTheRouteButton_Click(object sender, EventArgs e)
        {
            using (SendForm form = new SendForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                    form.Show();
            }

            UpdateInfo();
        }

        private void takeOffTheRouteButton_Click(object sender, EventArgs e)
        {
            using (TakeOffForm form = new TakeOffForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                    form.Show();
            }

            UpdateInfo();
        }

        private void UpdateInfo()
        {
            // Update source list
            sourceDataGrid.Rows.Clear();
            CList lst = BusController.GetAll();
            for (int i = 0; i < lst.Size(); i++)
                sourceDataGrid.Rows.Add(lst[i].id, lst[i].driver, lst[i].route);

            // Update active buses list
            routeDataGrid.Rows.Clear();
            lst = BusController.GetInfo(true);
            for (int i = 0; i < lst.Size(); i++)
                routeDataGrid.Rows.Add(lst[i].id, lst[i].driver, lst[i].route);

            // Update waiting buses list
            waitingDataGrid.Rows.Clear();
            lst = BusController.GetInfo(false);
            for (int i = 0; i < lst.Size(); i++)
                waitingDataGrid.Rows.Add(lst[i].id, lst[i].driver, lst[i].route);
        }
    }
}
