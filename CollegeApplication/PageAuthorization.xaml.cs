using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
    /// Логика взаимодействия для PageAuthorization.xaml
    /// </summary>
    public partial class PageAuthorization : ContentControl
    {
        public PageAuthorization()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var user = ClassDB.Entities.User.Where(x => x.Login == txtLogin.Text && x.Password == pswdBox.Password).FirstOrDefault();

            if (user != null)
            {
                switch (user.IdRole)
                {
                    case 1:
                        

                        ClassFrame.frameAuth.Content = null;
                        ClassFrame.frameMenu.Content = new PageMenuStudent();
                        break;

                    case 2:
                        
                        ClassFrame.frameAuth.Content = null;
                        ClassFrame.frameMenu.Content = new PageMenuTeacher();
                        break;
                    case 3:
                        
                        ClassFrame.frameAuth.Content = null;
                        ClassFrame.frameMenu.Content = new PageMenuAdmin();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Incorrect user data");
            }
            
        }
    }
}
