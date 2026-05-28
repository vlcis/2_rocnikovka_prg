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
using System.Windows.Shapes;

namespace NedelniNavrat.messages
{
    /// <summary>
    /// Interakční logika pro VzkazTrouba.xaml
    /// </summary>
    public partial class VzkazTrouba : Window
    {
        public VzkazTrouba()
        {
            InitializeComponent();
        }

        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
