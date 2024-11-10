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

namespace CollegeApplication
{
    /// <summary>
    /// Логика взаимодействия для PageDtgUsers.xaml
    /// </summary>
    public partial class PageDtgUsers : ContentControl
    {
        public PageDtgUsers()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            
            dtgUsers.ItemsSource = ClassDB.Entities.User.ToList();
        }

        private void dtgUsers_PreparingCellForEdit(object sender, DataGridPreparingCellForEditEventArgs e)
        {
            User user = e.Row.DataContext as User;
            Window editUser = new EditUser(user);
            editUser.Show();
            dtgUsers.CancelEdit();
        }

        private void RemoveUserBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddUserBtn_Click(object sender, RoutedEventArgs e)
        {
            AddUserWindow addUserWindow = new AddUserWindow(LoadData);
            addUserWindow.Show();
        }
    }
}
