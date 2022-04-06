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

namespace project
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Starting(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Всё готово!!!");
        }
        private void Authors(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Давыдов Денис - студент ТГПУ им. Л.Н.Толстого направления подготовки 'Прикладная информатика в здравоохранении'\n\n " +
                "Медвецкий Никита - студент ТГПУ им. Л.Н.Толстого направления подготовки 'Прикладная информатика в здравоохранении'\n\n" +
                "Болгов Андрей - студент ТГПУ им. Л.Н.Толстого направления подготовки 'Прикладная информатика в здравоохранении'\n\n" +
                "Шмаков Матвей - студент ТГПУ им. Л.Н.Толстого направления подготовки 'Прикладная информатика в здравоохранении'");
        }
    }
}
