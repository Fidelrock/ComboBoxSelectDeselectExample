using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ComboBoxExample
{
    public partial class MainWindow : Window
    {
        private bool isItemClicked;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (ComboBoxItem item in comboBox.Items)
            {
                item.MouseUp += ComboBoxItem_MouseUp;
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //if (comboBox.SelectedItem != null && !isItemClicked)
            //{
            //    //MessageBox.Show($"Selected: {((ComboBoxItem)comboBox.SelectedItem).Content}");
            //}
            isItemClicked = false;
        }

        private void ComboBoxItem_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (comboBox.SelectedItem == sender)
            {
                isItemClicked = true;
                comboBox.SelectedItem = null;
            }
        }
    }
}
