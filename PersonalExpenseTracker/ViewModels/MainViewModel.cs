using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using PersonalExpenseTracker.Commands;
using PersonalExpenseTracker.Models;

namespace PersonalExpenseTracker.ViewModels
{
    public class MainViewModel
    {
        public ObservableCollection<Expense> Expenses { get; set; }

        public ICommand AddExpenseCommand { get; private set; }
        public ICommand UpdateCommand { get; private set; }
        public ICommand DeleteCommand { get; private set; }

        public MainViewModel()
        {
            Expenses = new ObservableCollection<Expense>();
            AddExpenseCommand = new RelayCommand(OpenAddExpenseWindow, CanAddExpense);
            UpdateCommand = new RelayCommand(ExecuteUpdate, CanAddExpense);
            DeleteCommand = new RelayCommand(ExecuteDelete, CanAddExpense);

            LoadExpenses();
        }

        private void OpenAddExpenseWindow(object obj)
        {
            AddExpense addExpenseWindow = new AddExpense();
            addExpenseWindow.ShowDialog();
        }

        public void LoadExpenses()
        {
            using (var context = new ExpenseContext())
            {
                Expenses.Clear();
                var expenses = context.Expenses.ToList();
                foreach (var expense in expenses)
                {
                    Expenses.Add(expense);
                }
            }
        }

        private bool CanAddExpense(object parameter)
        {
            return true;  // Always allow for now
        }

        private void ExecuteUpdate(object parameter)
        {
            var expense = parameter as Expense;
            var updateWindow = new AddExpense(expense);
            updateWindow.ShowDialog();
            LoadExpenses(); // Refresh the list
        }

        private void ExecuteDelete(object parameter)
        {
            var expense = parameter as Expense;
            if (MessageBox.Show("Are you sure you want to delete this expense?", "Delete Expense", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                using (var context = new ExpenseContext())
                {
                    context.Expenses.Remove(expense);
                    context.SaveChanges();
                }
                LoadExpenses();
            }
        }


    }
}
