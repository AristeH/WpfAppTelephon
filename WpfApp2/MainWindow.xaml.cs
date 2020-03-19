using DataModels;
using LinqToDB.Data;
using System;
using System.Linq;
using System.Windows;



namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {

            InitializeComponent();
        }



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var path = System.IO.Path.GetFullPath(@"c:\obmen\first.fdb");
            using (var db = new DataConnection(LinqToDB.ProviderName.Firebird, @"DataSource = localhost; Database = C:\obmen\First.fdb; User Id = SYSDBA; Password = masterkey"))

            {
                IQueryable<PERSONEL> cusTab = db.GetTable<PERSONEL>();

                PERSONEL[] deps = cusTab.ToArray();

                WPFDataGrid.ItemsSource = deps;
            }
        }
    }
}
