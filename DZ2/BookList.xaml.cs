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
    /// Логика взаимодействия для BookList.xaml
    /// </summary>
    public partial class BookList : Page
    {
        List<Book> books = GlobalVariables.books;
        public BookList()
        {
            InitializeComponent();
            DataContext = GlobalVariables.books;

        }
      

        private void AddBook_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddPage());
        }

        private void RemoveBook_Click(object sender, RoutedEventArgs e)
        {
            if (ViewBooks.SelectedItem != null)
            {
                var selectedBook = (Book)ViewBooks.SelectedItem;
                GlobalVariables.books.Remove(selectedBook);
                ViewBooks.Items.Refresh();
            }
        }

        private void EditBook_Click(object sender, RoutedEventArgs e)
        {
            if (ViewBooks.SelectedItem != null)
            {
                var selectedBook = (Book)ViewBooks.SelectedItem;
                NavigationService.Navigate(new EditPage(selectedBook));
                books.Remove(selectedBook);
            }
        }
    }
}
