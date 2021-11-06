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

namespace EntityWPF
{
    /// <summary>
    /// Логика взаимодействия для DeleteEntitiesWindow.xaml
    /// </summary>
    public partial class DeleteEntitiesWindow : Window
    {
        public DeleteEntitiesWindow()
        {
            InitializeComponent();
            textDelEntitiesWindow.Text += " " + MainWindow.selectVedomost.description + "?";
        }

        private void cancelBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow.DB.vedomost.Remove(MainWindow.selectVedomost);
            LoginWindow.DB.SaveChanges();
            this.Close();
        }
    }
}
