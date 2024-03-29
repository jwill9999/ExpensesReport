﻿using System.Windows.Controls;


/*
    When you create a new Page file, Visual Studio automatically creates its code-behind file. These code-behind files handle the logic for responding to user input.
 */
namespace ExpenseIt
{
    /// <summary>
    /// Interaction logic for ExpenseReportPage.xaml
    /// </summary>
    public partial class ExpenseReportPage : Page
    {
        public ExpenseReportPage()
        {
            InitializeComponent();
        }
        // Custom constructor to pass expense report data
        public ExpenseReportPage(object data) : this()
        {
            //bind to expense report data 
            DataContext = data;
        }
    }
}
