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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lesson1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int clickCount = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            clickCount = -1;
        }

        private void ChangeText(object sender, RoutedEventArgs e)
        {
            if (clickCount == 0)
            {
                UiTextBlock.Text = "New Zinno";
                UiTextBlock.Foreground = Brushes.Blue;
            }
            else if (clickCount == 1)
            {
                UiTextBlock.Text = "New Zinno 1";
                UiTextBlock.Foreground = Brushes.Green;
            }

            clickCount++;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selectedItem = (ComboBoxItem)UiComboBox.SelectedItem;
            UiTextBlock.Text = selectedItem.Content.ToString();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBoxItem selectedItem = (ListBoxItem)UiListBox.SelectedItem;
            UiTextBlock.Text = selectedItem.Content.ToString();
        }

        private void AddNewColor(object sender, RoutedEventArgs e)
        {
            string newColor = UiColorTextBox.Text;
            ListBoxItem newItem = new ListBoxItem() { Content = newColor };
            UiListBox.Items.Add(newItem);

            List<string> data = new List<string>();
            foreach(ListBoxItem item in UiListBox.Items)
            {
                data.Add(item.Content.ToString());
            }

            Users.GetData(data);
        }

        
    }
}
