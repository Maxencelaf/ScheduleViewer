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

namespace ScheduleViewer
{
    /// <summary>
    /// Interaction logic for FirstWindow.xaml
    /// </summary>
    public partial class FirstWindow : Window
    {
        public FirstWindow()
        {
            InitializeComponent();
            Label newlabel = new Label();
            newlabel.SetValue(MainWindow.ContentProperty, CreatingBlock(2, 2, "Green", "Circuits"));
        }

        public Label CreatingBlock(int row1, int col1, string color, string content)
        {
            //Add Column Span
            Label label = new Label();
            label.SetValue(Grid.RowProperty, row1.ToString());
            label.SetValue(Grid.ColumnProperty, col1.ToString());
            label.SetValue(Grid.ColumnSpanProperty, 2);
            label.SetValue(BackgroundProperty, color.ToString());
            label.Content = content;
            return label;
        }

        private void Button_Click_Generate(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow1 = new MainWindow();
            mainWindow1.Show();
        }

        private void Button_Click_Ajouter(object sender, RoutedEventArgs e)
        {
            if (nomCoursTextBox.Text.StartsWith(" ") || nomCoursTextBox.Text == "")
            {
                nomCoursTextBox.Text = "";
            }
            else
            {
                coursAjouteText.Text += nomCoursTextBox.Text + "\n";
                nomCoursTextBox.Text = "";
            }
            
        }

        private void nomCoursTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Button_Click_Ajouter(sender, e);
            }
        }
    }
}
