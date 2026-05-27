using NedelniNavrat.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NedelniNavrat.messages
{
    /// <summary>
    /// Interakční logika pro DvereVchod.xaml
    /// </summary>
    public partial class DvereVchod : Window
    {
        public bool isValid = false;
        public DvereVchod()
        {
            InitializeComponent();
            isValid = false;
        }

        private void Send(object sender, RoutedEventArgs e)
        {
            
            try {
                string code = Passwd.Text;

                char[] chars = code.ToCharArray();
                Array.Sort(chars);

                string sorted = new string(chars);

                if (sorted == "137")
                {
                    isValid = true;
                }
                else
                {
                    new SpatnyKod().ShowDialog();
                }
            }
            catch
            {
                new SpatnyKod().ShowDialog();
            }
            this.Close();
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
