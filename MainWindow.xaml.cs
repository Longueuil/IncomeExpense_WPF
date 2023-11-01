using System;
using System.Windows;
using System.Windows.Controls;

namespace IncomeExpense_WPF
{
    public partial class MainWindow : Window
    {
      
        public DateTime DateToday { get; set; } = DateTime.Today;

        public MainWindow()
        {
            InitializeComponent();
            int year = DateToday.Year;
            int month = DateToday.Month;
            int daysInMonth = DateTime.DaysInMonth(year, month);
            
           // MessageBox.Show(daysInMonth.ToString());
    }
        private bool isEditing = false;
        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            
            
            if (!isEditing)
            {
                registrationField.Visibility = Visibility.Visible;
                btnAdd.Content = "Save";
                isEditing = true;
            }
            else
            {
                MessageBox.Show("HOP");
                btnAdd.Content = "Add";
                isEditing = false;
                registrationField.Visibility = Visibility.Collapsed;
            }
        }
        private void Update_Button_Click(object sender, RoutedEventArgs e)
        {

        }
        

        private void Delete_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Close_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void DragWindow(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            try
            {
                DragMove();
            }
            catch(Exception ex)
            {

            }
        }
        // will autosize the widt of the ListView
        private void ListView_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (listViewData.View is GridView gridView)
            {
                int numColumns = gridView.Columns.Count;
                double availableWidth = listViewData.ActualWidth;

                foreach (GridViewColumn column in gridView.Columns)
                {
                    column.Width = availableWidth / numColumns;
                }
            }
        }
    }
}
