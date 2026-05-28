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
        {
            new Trouba().ShowDialog();
        }
    }
}
