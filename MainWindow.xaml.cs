using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Microsoft.Win32;

namespace MarciPad
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool saved;
        public string filename;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CommandManager.InvalidateRequerySuggested();
            MenuItem openMenuItme = (MenuItem)FindName("_Open");
            MenuItem saveMenuItme = (MenuItem)FindName("_Save");
            openMenuItme.IsEnabled = true;
            saveMenuItme.IsEnabled = true;
        }

        private void OpenCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                FileName = "Open",
                DefaultExt = ".txt",
                Filter = "Text Documents  (.txt) | *.txt"
            };

            bool? result = openFileDialog.ShowDialog();
            if (result == true)
            {
                _ = openFileDialog.FileName;
                textBox.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }


        private void SaveCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(filename))
            {
                var saveFileDialog = new SaveFileDialog
                {
                    FileName = "New Document",
                    DefaultExt = ".txt",
                    Filter = "text document (.txt)|*.txt"
                };

                if (saveFileDialog.ShowDialog() == true && saved == false)
                {
                    filename = saveFileDialog.FileName;
                    File.WriteAllText(filename, textBox.Text);
                }
            }
            
            else
            {
                saved = true;
                File.WriteAllText(filename, textBox.Text);
            }
        }
    }
}
