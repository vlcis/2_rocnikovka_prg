using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace NedelniNavrat.messages
{
    /// <summary>
    /// Interakční logika pro SaveName.xaml
    /// </summary>
    public partial class SaveName : Window
    {
        
        public SaveName()
        {
            InitializeComponent();
        }
        
        private void Save(object sender, RoutedEventArgs e)
        {
            string text;
            try
            {
                text = Potrvdit.Text;
               

            if (Regex.IsMatch(text, @"^[a-zA-Z0-9_-]+$"))
                {
                    Inventory.SaveName = text;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Neplatný název souboru. Použijte pouze písmena, čísla, podtržítka nebo pomlčky.");
                    new SaveName().ShowDialog();
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Neplatný název souboru. Použijte pouze písmena, čísla, podtržítka nebo pomlčky.");
                new SaveName().ShowDialog();
                this.Close();
            }
             
            
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
