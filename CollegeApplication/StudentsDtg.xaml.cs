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
    /// Логика взаимодействия для Schedule.xaml
    /// </summary>
    public partial class StudentsDtg : UserControl
    {
        public StudentsDtg()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            
            StudentsDatagrid.ItemsSource = ClassDB.Entities.Student.ToList();
        }
    }
}