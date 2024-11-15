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
    /// Логика взаимодействия для EditPage.xaml
    /// </summary>
    public partial class EditPage : Page
    {
        List<Book> books = GlobalVariables.books;
        public EditPage(Book book)
        {
            InitializeComponent();
            Title.Text = book.Title;
            Autor.Text = book.Author;
            Genre.Text = book.Genre;
            Year.Text = book.Year.ToString();
            PagesCount.Text = book.PagesCount.ToString();
        }

        private void AddBook(object sender, RoutedEventArgs e)
        {
            Book item = new Book(Title.Text, Autor.Text, Genre.Text, int.Parse(Year.Text), int.Parse(PagesCount.Text));
            books.Add(item);
            NavigationService.Navigate(new BookList());
        }
    }

}

