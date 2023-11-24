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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }
        private void Math_Click(object sender, RoutedEventArgs e)
        {
            int k = int.Parse(AA.Text);
            int n = 4;
            string d = "";
            if (k >= 1 && k <= 365)
            {
                k = (n + k - 1) % 7;
                switch (k)
                {
                    case 1: d = "Понедельник"; break;
                    case 2: d = "Вторник"; break;
                    case 3: d = "Среда"; break;
                    case 4: d = "Четверг"; break;
                    case 5: d = "Пятница"; break;
                    case 6: d = "Суббота"; break;
                    case 0: d = "Воскресенье"; break;
                }
            }
            else
            {
                d = "Число вне диапозона";
            }

            Rez.Text = $"{d}";
        }
    }
}
