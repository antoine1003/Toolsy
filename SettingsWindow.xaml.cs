using Microsoft.Win32;
using System.Windows;
using Toolsy.Services;

namespace Toolsy
{
    /// <summary>
    /// Logique d'interaction pour SettingsWindow.xaml
    /// </summary>
    public partial class SettingsWindow : Window
    {
        private bool save = false;
        public SettingsWindow()
        {
            InitializeComponent();
            txtPath.Text = string.IsNullOrWhiteSpace(Properties.Settings.Default.TilesPath) ? "No file selected" : Properties.Settings.Default.TilesPath;
        }

        private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Json files (*.json)|*.json|Text files (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == true)
            {
                if (JsonService.isJsonFormatCorrect(openFileDialog.FileName))
                {
                    save = true;
                    txtPath.Text = openFileDialog.FileName;
                } else
                {
                    save = false;
                    txtError.Text = "JSON file is not properly formatted, read to the documentation.";
                }
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (save)
            {
                Properties.Settings.Default.TilesPath = txtPath.Text;
                Properties.Settings.Default.Save();
            }
            Close();
        }

        private void txtDocu_PreviewMouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
            {
                FileName = "https://github.com/antoine1003/toolsy",
                UseShellExecute = true,
                Verb = "open"
            });
        }
    }
}
