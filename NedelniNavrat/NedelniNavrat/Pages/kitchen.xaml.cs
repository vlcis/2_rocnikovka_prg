using NedelniNavrat.messages;
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

namespace NedelniNavrat.Pages
{
    /// <summary>
    /// Interakční logika pro kitchen.xaml
    /// </summary>
    public partial class kitchen : Page
    {
        public kitchen()
        {
            InitializeComponent();
        }

        private void Dvere(object sender, EventArgs e)
        {
           NavigationService.Navigate(new hall());
        }

        private void Lednicka(object sender, EventArgs e)
        {
            new VzkazLednice().ShowDialog();                   
        }

        private void ZatimNic(object sender, EventArgs e)
        {
            new Tady_nic().ShowDialog();
        }

        private void Pizza(object sender, EventArgs e)
        {
            new Pizza().ShowDialog();
        }

        private void Kos(object sender, EventArgs e)
        {
            new Kos().ShowDialog();
        } 

        private void Suplik(object sender, EventArgs e)
        {
            new Suplik().ShowDialog();
        }

        private void Trouba(object sender, EventArgs e)
        {if(Inventory.trouba == true)
            {
                new Tady_nic().ShowDialog();
                Inventory.trouba = true;

            }
            else
            {
                new Trouba().ShowDialog();
            }
                
        }

        private void Skrinka1(object sender, EventArgs e)
        {
            new Skrinka1().ShowDialog();
        }

        private void Skrinka2(object sender, EventArgs e)
        {
            new Skrinka2().ShowDialog();
        }

        private void Skrinka3(object sender, EventArgs e)
        {
            new Skrinka3().ShowDialog();
        }

        private void Skrinka4(object sender, EventArgs e)
        {
            new Skrinka4().ShowDialog();
        }

        private void Skrinka5(object sender, EventArgs e)
        {
            new Skrinka5().ShowDialog();
        }

        private void Skrinka6(object sender, EventArgs e)
        {
            new Skrinka6().ShowDialog();
        }
    }
}
