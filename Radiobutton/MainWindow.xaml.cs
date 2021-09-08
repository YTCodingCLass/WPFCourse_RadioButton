using System.Windows;
using System.Windows.Controls;

namespace Radiobutton
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string chosenColor;
        private string chosenGender;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string text = $"Your chosen Color is: {chosenColor}\nYour chosen gender is: {chosenGender}";
            MessageBox.Show(text);

        }

        private void ColorsRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            chosenColor = (sender as RadioButton).Content.ToString();
        }

        private void GenderRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            chosenGender = (sender as RadioButton).Content.ToString();
        }
    }
}
