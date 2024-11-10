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
    /// Логика взаимодействия для PageMenuTeacherxaml.xaml
    /// </summary>
    public partial class PageMenuTeacher : ContentControl
    {
        public PageMenuTeacher()
        {
            InitializeComponent();
        }

        private void btnUsers_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.frameContent.Content = new PageDtgUsers();
        }
    }
}
