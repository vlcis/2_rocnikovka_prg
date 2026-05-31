using System;
using System.IO;
using System.Linq;
using System.Windows;

namespace NedelniNavrat.messages
{
    public partial class LoadGame : Window
    {
        private string saveFolder;

        public LoadGame()
        {
            InitializeComponent();

            saveFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Saves");

            if (!Directory.Exists(saveFolder))
                Directory.CreateDirectory(saveFolder);

            LoadSaves();
        }

        private void LoadSaves()
        {
            var files = Directory.GetFiles(saveFolder, "*.txt")
                .Select(f => new
                {
                    Name = Path.GetFileNameWithoutExtension(f),
                    Time = File.GetLastWriteTime(f).ToString("dd.MM.yyyy HH:mm")
                })
                .ToList();

            SaveList.ItemsSource = files;
        }

        private void Load_Click(object sender, RoutedEventArgs e)
        {
            if (SaveList.SelectedItem == null) return;

            dynamic selected = SaveList.SelectedItem;

            string path = Path.Combine(saveFolder, selected.Name + ".txt");

            string data = File.ReadAllText(path);

            GameState.Nacist(data);

            Close();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (SaveList.SelectedItem == null) return;

            dynamic selected = SaveList.SelectedItem;

            string path = Path.Combine(saveFolder, selected.Name + ".txt");

            if (File.Exists(path))
                File.Delete(path);

            LoadSaves();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}