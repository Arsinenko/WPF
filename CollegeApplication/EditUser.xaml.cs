using System.Windows;

namespace CollegeApplication
{
    /// <summary>
    /// Логика взаимодействия для EditUser.xaml
    /// </summary>
    public partial class EditUser : Window
    {
        public User user;
        public EditUser(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void btnSubmitChanges_Click(object sender, RoutedEventArgs e)
        {
            user.Login = txtLoginChange.Text;
            user.Password = pswdChange.Password;
            ClassDB.Entities.SaveChanges();
            this.Close();
            
        }
    }
}
