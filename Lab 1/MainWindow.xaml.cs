using System.Windows;

namespace Lab_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnClick(object sender, RoutedEventArgs e)
        {
            string firstName = FirstName.Text;
            string lastName = LastName.Text;

            string pigFirst;
            string pigLast;

            firstName = firstName.ToLower();
            lastName = lastName.ToLower();
            int firstLength = firstName.Length;
            int lastLength = lastName.Length;

            pigFirst = firstName.Substring(1, firstLength - 1) + firstName.Substring(0, 1) + "ay";
            int pigFirstLength = pigFirst.Length;
            pigFirst = pigFirst.Substring(0, 1).ToUpper() + pigFirst.Substring(1, pigFirstLength - 1);
            pigLast = lastName.Substring(1, lastLength - 1) + lastName.Substring(0, 1) + "ay";
            int pigLastLength = pigLast.Length;
            pigLast = pigLast.Substring(0, 1).ToUpper() + pigLast.Substring(1, pigLastLength - 1);

            Output.Text = pigFirst + " " + pigLast;
        }
    }
}
