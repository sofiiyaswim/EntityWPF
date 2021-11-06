using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace EntityWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            LoginWindow.DB.vedomost.Load();
            dgTableTovar.ItemsSource = LoginWindow.DB.vedomost.Local;
        }


        public static vedomost selectVedomost = new vedomost();
        private void delButton_Click(object sender, RoutedEventArgs e)
        {
            selectVedomost = (vedomost)dgTableTovar.SelectedItem;
            DeleteEntitiesWindow deleteEntitiesWindow = new DeleteEntitiesWindow();
            deleteEntitiesWindow.Show();
            
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            AddEntitiesWindow addEntitiesWindow = new AddEntitiesWindow();
            addEntitiesWindow.Show();
        }
    }
}
