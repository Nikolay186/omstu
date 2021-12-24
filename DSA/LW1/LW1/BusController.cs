using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LW1
{
    class BusController
    {
        private static CList list = new CList();

        public static bool Add(Bus newBus)
        {
            try
            {
                list.Add(newBus);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            return true;
        }

        public static bool SendOnTheRoute(int busId)
        {
            try
            {
                list.Find(busId).onRoute = true;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        public static bool TakeOffTheRoute(int busId)
        {
            try
            {
                list.Find(busId).onRoute = false;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        public static CList GetInfo(bool onRoute)
        {
            try
            {
                return list.FindAll(onRoute);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }

        public static CList GetAll()
        {
            return list;
        }
    }
}