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
using System.Windows.Shapes;

namespace CollegeApplication
{
    /// <summary>
    /// Логика взаимодействия для AddUserWindow.xaml
    /// </summary>
    public partial class AddUserWindow : Window
    {
        public delegate void edited();
        edited Updated;

        
        
        public AddUserWindow(edited Updated)
        {
            this.Updated = Updated;
            InitializeComponent();
            SetComboboxValues();
        }

        public void SetComboboxValues()
        {
            RoleComboBox.ItemsSource = ClassDB.Entities.Role.ToList();    
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public void CreateUser()
        {
            User currentUser = new User();
            Role role = (Role)RoleComboBox.SelectedItem;    
            currentUser.IdRole = role.IdRole;
            currentUser.Login = LoginTextBox.Text;
            currentUser.Password = PasswordBox.Password;

            try
            {
                ClassDB.Entities.User.Add(currentUser);
                ClassDB.Entities.SaveChanges();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            CreateUser();
            Updated();

            this.Close();

        }
    }
}
