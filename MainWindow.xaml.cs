using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Toolsy.Models;
using Toolsy.Services;

namespace Toolsy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Tile[] Tiles { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            reloadData();
        }

        private void reloadData()
        {
            if (isPathPresentAndCorrect())
            {
                if (JsonService.isJsonFormatCorrect(Properties.Settings.Default.TilesPath))
                {
                    string json = File.ReadAllText(Properties.Settings.Default.TilesPath);
                    List<Tile> tiles = JsonConvert.DeserializeObject<List<Tile>>(json);
                    Tiles = tiles.ToArray();
                    lbTiles.ItemsSource = Tiles;

                    txtError.Text = string.Empty;
                } else
                {
                    txtError.Text = "JSON file is not properly formatted, read to the documentation.";
                }
            } else
            {
                txtError.Text = "JSON file has not been found. Please check on the settings menu if the path is correct.";
            }
        }

        private bool isPathPresentAndCorrect()
        {
            string path = Properties.Settings.Default.TilesPath;
            return !string.IsNullOrWhiteSpace(path) && File.Exists(path);
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Tile tile = Tiles.First(t => t.Name.Equals((sender as Button).Content));
            Type t = tile.Value.GetType();
            switch (tile.Type)
            {
                case "link":
                case "file":
                    if (t.Name.Equals("JArray"))
                    {
                        string[] values = ((JArray)tile.Value).ToObject<string[]>();
                        foreach (string url in values)
                        {
                            OpenWithDefaultProgram(url);
                        }
                    } else
                    {
                        OpenWithDefaultProgram(tile.Value.ToString());
                    }
                    break;
                case "folder":
                    if (t.Name.Equals("JArray"))
                    {
                        string[] values = ((JArray)tile.Value).ToObject<string[]>();
                        foreach (string path in values)
                        {
                            OpenFolder(path);
                        }
                    }
                    else
                    {
                        OpenFolder(tile.Value.ToString());
                    }
                    break;
                default:
                    break;
            }
        }

        public static void OpenWithDefaultProgram(string path)
        {
            using System.Diagnostics.Process fileopener = new System.Diagnostics.Process();

            fileopener.StartInfo.FileName = "explorer";
            fileopener.StartInfo.Arguments = "\"" + path + "\"";
            fileopener.Start();
        }

        public static void OpenFolder(string path)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
            {
                FileName = path,
                UseShellExecute = true,
                Verb = "open"
            });
        }

        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {
            SettingsWindow s = new SettingsWindow();
            s.ShowDialog();
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            reloadData();
        }
    }
}
