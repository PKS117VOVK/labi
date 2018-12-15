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

namespace WpfApp9
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        class Student
        {
            public Student(string n, string sn, string g, int prep)
            {
                Name = n;
                Famil = sn;
                Group = g;
                Ocenka = prep;
            }
            public string Name { get; set; }
            public string Famil { get; set; }
            public string Group { get; set; }
            public int Ocenka { get; set; }
        }
        List<Student> studentlist = new List<Student>();
        public MainWindow()
        {
            InitializeComponent();
            Box1.Items.Add("Отличники");
            Box1.Items.Add("Хорошисты");
            Box1.Items.Add("Должники");
            DataGrid1.AutoGenerateColumns = true;
            DataGrid2.AutoGenerateColumns = true;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            DataGrid1.ItemsSource = null;
            studentlist.Add(new Student(Name.Text, Famil.Text, Group.Text, Convert.ToInt32(ocenka.Text)));
            DataGrid1.ItemsSource = studentlist;
        }
        List<Student> sort = new List<Student>();

        private void poisk_Click(object sender, RoutedEventArgs e)
        {
            DataGrid2.ItemsSource = null;
            sort.Clear();
            for (int i = 0; i < studentlist.Count; i++)
            {
                if (studentlist[i].Ocenka == 5 && Box1.SelectedIndex == 0)
                {
                    sort.Add(studentlist[i]);
                }
            }
            for (int i = 0; i < studentlist.Count; i++)
            {
                if (studentlist[i].Ocenka == 4 && Box1.SelectedIndex == 1)
                {
                    sort.Add(studentlist[i]);
                }
            }
            for (int i = 0; i < studentlist.Count; i++)
            {
                if (studentlist[i].Ocenka == 2 && Box1.SelectedIndex == 2)
                {
                    sort.Add(studentlist[i]);
                }
                DataGrid2.ItemsSource = sort;
            }
        }
    }
}
