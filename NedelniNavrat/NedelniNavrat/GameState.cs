using NedelniNavrat.messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;

namespace NedelniNavrat
{
    class GameState
    {
        public static void Ulozit()
        {
            if (Inventory.SaveName == "NotSaved")
            {
                new SaveName().ShowDialog();
            }

            List<string> StavHry = new List<string>();

            StavHry.Add(Inventory.SaveName);

            if (Inventory.klicObyvak)
                StavHry.Add("KlicObyvak");

            if (Inventory.klicKuchyn)
                StavHry.Add("KlicKuchyn");

            if (Inventory.ovladac)
                StavHry.Add("Ovladac");

            if (Inventory.trouba)
                StavHry.Add("Trouba");

            string saveData = string.Join(";", StavHry);

            string folder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Saves");

            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            string path = Path.Combine(folder, Inventory.SaveName + ".txt");
            
            File.WriteAllText(path, saveData);

            MessageBox.Show(
                "Hra byla úspěšně uložena!",
                "Uložení hry",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
        }



        public static void Nacist(string data)
        {
            string[] parts = data.Split(';');

            Inventory.SaveName = parts[0];

            Inventory.klicObyvak = parts.Contains("KlicObyvak");
            Inventory.klicKuchyn = parts.Contains("KlicKuchyn");
            Inventory.ovladac = parts.Contains("Ovladac");
            Inventory.trouba = parts.Contains("Trouba");
        }
        
    }
}
