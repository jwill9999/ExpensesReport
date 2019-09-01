using System.Windows;
using System.Windows.Controls;

/*
    When you create a new Page file, Visual Studio automatically creates its code-behind file. These code-behind files handle the logic for responding to user input.
 */

namespace ExpenseIt
{
    /// <summary>
    /// Interaction logic for ExpenseItHome.xaml
    /// </summary>
    public partial class ExpenseItHome : Page
    {
        public ExpenseItHome()
        {
            InitializeComponent();
        }

        /* add a button click event handler. The event handler opens the ExpenseReportPage page. */
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ExpenseReportPage expenseReportPage = new ExpenseReportPage(peopleListBox.SelectedItem);
            NavigationService.Navigate(expenseReportPage);
        }

        private void PeopleListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
