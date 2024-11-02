using PersonalExpenseTracker.Models;
using System.Windows;

namespace PersonalExpenseTracker
{
    public partial class AddExpense : Window
    {
        private Expense currentExpense;
        public AddExpense()
        {
            InitializeComponent();
            currentExpense = new Expense();
            this.DataContext = currentExpense;
        }

        public AddExpense(Expense expense) : this()
        {
            currentExpense = expense;
            this.DataContext = currentExpense;
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            currentExpense.Date = datePicker.SelectedDate ?? DateTime.Now;

            using (var context = new ExpenseContext())
            {
                // Check if the expense is being tracked and set state accordingly
                var trackedExpense = context.Expenses.Find(currentExpense.ExpenseId);
                if (trackedExpense == null)
                {
                    context.Expenses.Add(currentExpense); 
                }
                else
                {
                    // Update properties if expense exists
                    context.Entry(trackedExpense).CurrentValues.SetValues(currentExpense);
                }

                context.SaveChanges();
            }

            // Inform MainWindow to reload updated expenses list
            ((MainWindow)Application.Current.MainWindow).ViewModel.LoadExpenses();
            this.Close(); 
        }
    }
}
