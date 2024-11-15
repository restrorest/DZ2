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

namespace DZ2
{
    /// <summary>
    /// Логика взаимодействия для AddPage.xaml
    /// </summary>
    public partial class AddPage : Page
    {
        List<Book> books = GlobalVariables.books;
        public AddPage()
        {
            InitializeComponent();
            
        }

        private void AddBook(object sender, RoutedEventArgs e)
        {
            try
            {
                Book item = new Book(Title.Text, Autor.Text, Genre.Text, int.Parse(Year.Text), int.Parse(PagesCount.Text));
                books.Add(item);
                NavigationService.Navigate(new BookList());
            }
            catch
            {

            }
        }
    }
}
