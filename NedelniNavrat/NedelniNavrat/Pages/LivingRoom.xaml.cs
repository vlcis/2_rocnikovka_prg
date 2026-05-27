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
    /// Interakční logika pro LivingRoom.xaml
    /// </summary>
    public partial class LivingRoom : Page
    {
        public LivingRoom()
        {
            InitializeComponent();
        }

        private void Rohozka(object sender, RoutedEventArgs e)
        {
            if (Inventory.klicObyvak == false)
            {
                Inventory.klicObyvak = true;
                new Nasel_klic_oby().ShowDialog();
            }
            else
            {
                new Tady_nic().ShowDialog();
            }
        }

        private void Dvere(object sender, RoutedEventArgs e)
        {
            if (Inventory.klicObyvak == true)
            {
                NavigationService.Navigate(new hall());
            }
            else
            {
                new Zamceno().ShowDialog();
            }
        }

        private void Polstar(object sender, RoutedEventArgs e)
        {
            if (Inventory.ovladac == false)
            {
                Inventory.ovladac = true;
                new Ovladac().ShowDialog();
            }
            else
            {
                new Tady_nic().ShowDialog();
            }
        }

        private void ZatimNic(object sender, RoutedEventArgs e)
        {
            new Tady_nic().ShowDialog();
        }

        private void VzkazObyvak(object sender, RoutedEventArgs e)
        {
            //new Vzkaz_obyvak().ShowDialog();
        }
    }
}

