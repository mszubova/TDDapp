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

namespace TDDapp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Dictionary<string, DateTime> friendArray = new Dictionary<string, DateTime> {
                {
                    "Masha",
                    new DateTime(2001,01,2)
                },
                {
                    "Sasha",
                    new DateTime(2003,05,12)
                },
                {
                    "Pasha",
                    new DateTime(2000,11,09)
                },
                {
                    "Kasha",
                    new DateTime(1990,07,02)
                }
            };
            LVFriends.ItemsSource = friendArray;

        }


    }
}
