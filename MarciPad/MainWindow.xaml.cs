using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Microsoft.Win32;

namespace MarciPad
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static bool saved, openedExisitingFile;
        public string filename;
         public static MenuItem openMenuItme, saveMenuItme, closeMenuItme;
        public MainWindow()
        {
            InitializeComponent();
            saved = false;
            openedExisitingFile = false;
        }
        public void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CommandManager.InvalidateRequerySuggested();
            openMenuItme = (MenuItem)FindName("_Open");
            saveMenuItme = (MenuItem)FindName("_Save");
            closeMenuItme = (MenuItem)FindName("_Close");
            openMenuItme.IsEnabled = true;
            saveMenuItme.IsEnabled = true;
            closeMenuItme.IsEnabled = false;
            textBox.Focus();
        }

        #region OPEN, SAVE, CLOSE
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
                textBox.Clear();
                filename = openFileDialog.FileName;
                textBox.Text = File.ReadAllText(openFileDialog.FileName);
                Title = Path.GetFileName(filename);
            }
            openedExisitingFile = true;
            closeMenuItme.IsEnabled = true;
        }
        private void CloseCurrentDocument(object sender, RoutedEventArgs e)
        {
            MessageBoxResult areYouSureMessageBox = MessageBox.Show("Are you sure you want to close this document? " +
                "Make sure you have saved it first!", "Are you sure?", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (areYouSureMessageBox == MessageBoxResult.Yes)
            {
                textBox.Clear();
                filename = string.Empty;
                saved = false;
                Title = "MarciPad";
            }
            else
            {
                return;
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

                if (saveFileDialog.ShowDialog() == true && saved == false && openedExisitingFile == false)
                {
                    filename = saveFileDialog.FileName;
                    File.WriteAllText(filename, textBox.Text);
                    Title = Path.GetFileName(filename);
                }
                openedExisitingFile = true;
                saveMenuItme.IsEnabled = true;
                closeMenuItme.IsEnabled = true;
            }
            
            else
            {
                saved = true;
                if(!string.IsNullOrEmpty(textBox.Text))
                {
                    File.WriteAllText(filename, textBox.Text);
                }
                else
                {
                    MessageBox.Show("Nothing to save.");
                }
            }
        }
        #endregion
        #region COPY CUT PASTE
        private void Cut_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (textBox.SelectedText != "")
            {
                Clipboard.SetText(textBox.SelectedText);
                textBox.Text = textBox.Text.Remove(textBox.SelectionStart, textBox.SelectionLength);
            }
        }

        private void Copy_Executed(object sender, ExecutedRoutedEventArgs e)
        {
             Clipboard.SetText(textBox.SelectedText);
        }
        private void Paste_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                textBox.Paste();
            }
        }
        #endregion
        #region THEMES
        private void Darken_Click(object sender, RoutedEventArgs e)
        {
            Themes.DarkTheme(textBox);
        }
        private void Light_Click(object sender, RoutedEventArgs e)
        {
            Themes.LightTheme(textBox);
        }
        #endregion
        #region CLOSE
        private void Exit_App(object sender, RoutedEventArgs e)
        {
            MessageBoxResult areYouSureMessageBox = MessageBox.Show("Are you sure you want to close this document? " +
               "Make sure you have saved it first!", "Are you sure?", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (areYouSureMessageBox == MessageBoxResult.Yes)
            {
                Close();
            }
            else
            {
                return;
            }
            
        }
        #endregion
    }
}
