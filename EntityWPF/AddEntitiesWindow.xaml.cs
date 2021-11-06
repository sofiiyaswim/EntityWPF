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
using System.Windows.Shapes;

namespace EntityWPF
{
    /// <summary>
    /// Логика взаимодействия для AddEntitiesWindow.xaml
    /// </summary>
    public partial class AddEntitiesWindow : Window
    {
        public AddEntitiesWindow()
        {
            InitializeComponent();
            countTxtBox.Text = "1";
            LoginWindow.DB.category.Load();
            categotyCmbAddWin.ItemsSource = LoginWindow.DB.category.Local;
        }

        private void countScrollBar_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {
            countTxtBox.Text = Math.Round(-1*countScrollBar.Value).ToString();
        }
      


        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            vedomost newVedomost = new vedomost();
            newVedomost.category = (category)categotyCmbAddWin.SelectedItem;
            newVedomost.description = descriptionTxtBox.Text;
            newVedomost.count = int.Parse(countTxtBox.Text);
            newVedomost.cena = int.Parse(priceTxtBox.Text);//Проверить на точку или запятую и поменять тип с int на decimal
            newVedomost.date = DateTime.Today;

            LoginWindow.DB.vedomost.Load();
            List<vedomost> vedomosts = new List<vedomost>();
            vedomosts = LoginWindow.DB.vedomost.Local.ToList();
            newVedomost.id_vedomost = vedomosts.Count + 1;

            LoginWindow.DB.vedomost.Add(newVedomost);
            LoginWindow.DB.SaveChanges();
            this.Close();

        }
    }
}
