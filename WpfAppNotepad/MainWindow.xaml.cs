using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfAppNotepad
{
    public partial class MainWindow : Window
    {

        protected string fileName;
        public string FileName
        {
            get
            {
                return fileName;
            }
            set
            {
                fileName = value;
                this.Title = fileName + " -WPfNotePad";
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            this.Title = "WPfNotePad";


        }

        private void NewCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void NewCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            FileName = txtEditor.Text = "Untitled";
        }

        private void SaveCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {

            e.CanExecute = true;

        }

        private void SaveCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(FileName))
            {
                SaveAsCommand_Executed(sender, e);
            }

            File.WriteAllText(FileName, txtEditor.Text);
            //e.Handled = true;
        }

        private void SaveAsCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            string fileText = txtEditor.Text;

            SaveFileDialog dialog = new SaveFileDialog()
            {
                Filter = "Text Files(*.txt)|*.txt|All(*.*)|*"
            };

            if (dialog.ShowDialog() == true)
            {
                File.WriteAllText(dialog.FileName, fileText);
                FileName = dialog.FileName;
            }
        }

        private void SaveAsCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {

            e.CanExecute = true;

        }

        private void OpenCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {

            e.CanExecute = true;

        }

        private void OpenCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "Text Files(*.txt)|*.txt|All(*.*)|*"
            };
            if (dialog.ShowDialog() == true)
            {
                txtEditor.Text = File.ReadAllText(dialog.FileName);
            }
        }

        private void CopyCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void CopyCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Clipboard.SetText(txtEditor.Text);
        }

        private void PasteCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (Clipboard.ContainsText())
                e.CanExecute = true;
            else
                e.CanExecute = false;
        }

        private void PasteCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Clipboard.SetText(txtEditor.Text);
        }

        private void AbboutCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {

            e.CanExecute = true;

        }

        private void AboutCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void txtEditor_SelectionChanged(object sender, RoutedEventArgs e)
        {

            int row = txtEditor.GetLineIndexFromCharacterIndex(txtEditor.CaretIndex);
            int col = txtEditor.CaretIndex - txtEditor.GetCharacterIndexFromLineIndex(row);
            lblCursorPosition.Text = "Line " + (row + 1) + ", Char " + (col + 1);
        }

        private void ddlFontSize_SelectionChanged(object sender, RoutedEventArgs e)
        {
            double size = 12;
            ComboBox cb = (ComboBox)sender;
            ComboBoxItem cbi = (ComboBoxItem)cb.SelectedItem;

            if (cbi.Content != null)
            {
                string selectedValue = cbi.Content.ToString();
                double.TryParse(selectedValue, out size);
                txtEditor.FontSize = size;
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            //WindowAbout about = new WindowAbout();
            //about.Show();
        }
    }
}
