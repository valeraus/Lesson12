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

namespace AddTask
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private EventHandler myEvemt = null; //Создание поля типа EventHandler
        public MainWindow() //Конструктор по умолчанию
        {
            InitializeComponent();
            new Presenter(this); //Связываем View и Presenter
        }

        internal Presenter Presenter
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public event EventHandler MyEvent //Создания события с двумя методами
        {
            add { myEvemt += value; } //Метод подписка на событие
            remove { myEvemt -= value; } //Метод отписки на событие
        }

        private void button1_Click(object sender, RoutedEventArgs e) //Обработчик события нажатия по кнопке
        {
            myEvemt.Invoke(sender, e); //Вызов обработчика события
        }
    }
}
