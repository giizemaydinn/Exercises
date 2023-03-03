using Challenge13Library.Business.Concrete;
using Challenge13Library.Entities;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Challenge13Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        StudentBusiness sb = new StudentBusiness();

        public MainWindow()
        {
            InitializeComponent();

            DummyData.FillLists();
            this.Loaded += MainWindow_Loaded;
            this.btnAddStudent.Click += BtnAddStudent_Click;
            this.btnAddBook.Click += btnAddBook_Click;
            this.btnReturnBook.Click += btnReturnBook_Click;
            this.cmbReturnStudent.SelectionChanged += CmbSelectionChanged;


        }

        private void CmbSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FillReturnBooks();
        }

        private void btnReturnBook_Click(object sender, RoutedEventArgs e)
        {
            sb.ReturnBook(Convert.ToInt32(cmbReturnBook.SelectedValue), Convert.ToInt32(cmbStudent.SelectedValue));
            FillBooks();
            FillReturnBooks();

        }

        private void btnAddBook_Click(object sender, RoutedEventArgs e)
        {
            sb.TakeBook(Convert.ToInt32(cmbBook.SelectedValue), Convert.ToInt32(cmbStudent.SelectedValue));
            FillBooks();

        }

        private void BtnAddStudent_Click(object sender, RoutedEventArgs e)
        {
            sb.Add(new Student
            {
                FirstName = txtAd.Text,
                LastName = txtSoyad.Text,
                BirthDate = dpBirthDate.SelectedDate.Value
            });
            FillStudents();
            ClearForm();

        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            FillBooks();
            FillStudents();
        }

        private void FillStudents()
        {
            cmbStudent.Items.Refresh();
            cmbStudent.DisplayMemberPath = "FirstName";
            cmbStudent.SelectedValuePath = "No";
            cmbStudent.ItemsSource = sb.GetStudents();

            cmbReturnStudent.Items.Refresh();
            cmbReturnStudent.DisplayMemberPath = "FirstName";
            cmbReturnStudent.SelectedValuePath = "No";
            cmbReturnStudent.ItemsSource = sb.GetStudents();
        }

        private void FillBooks()
        {
            cmbBook.Items.Refresh();
            cmbBook.DisplayMemberPath = "Name";
            cmbBook.SelectedValuePath = "Id";
            cmbBook.ItemsSource = sb.GetBooks();

            dg.Items.Refresh();
            dg.ItemsSource = sb.GetBooks();
        }

        private void FillReturnBooks()
        {
            List<Return> returnBooks = sb.GetReturns(Convert.ToInt32(cmbReturnStudent.SelectedValue));
            List<Book> rBooks = new List<Book>();

            foreach (var item in returnBooks)
            {
                rBooks.Add(sb.GetBook(item.BookId));
            }

            if (cmbReturnStudent.SelectedItem != null)
            {
                cmbReturnBook.Items.Refresh();

                cmbReturnBook.DisplayMemberPath = "Name";
                cmbReturnBook.SelectedValuePath = "Id";
                cmbReturnBook.ItemsSource = rBooks;

            }
        }
        private void ClearForm()
        {
            txtAd.Text = string.Empty;
            txtSoyad.Text = string.Empty;
            dpBirthDate.Text = string.Empty;
        }
    }
}
