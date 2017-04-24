using System;
using System.Collections.Generic;
using SearchPersonDomain.Classes;
using SearchPersonDomain.DataModel;
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
using System.Collections.ObjectModel;

namespace WpfShare
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ConnectedRepository _repo = new ConnectedRepository();
        private Person _currentPerson;
        private bool _isLoading;
        private bool _isPersonListChanging;
        private ObjectDataProvider _personViewSource;
        private ObservableCollection<Interests> _observableInterests;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _isLoading = true;
            _personViewSource = ((ObjectDataProvider)(FindResource("personViewSource")));
            dataGridPerson.SelectedItem = 0;
            _isLoading = false;
        }

        private void SortNinjaList()
        {
            var dataView = CollectionViewSource.GetDefaultView(dataGridPerson.ItemsSource);
            dataView.Refresh();
            dataGridPerson.SelectedItem = _currentPerson;
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            bool continueProcess;
            if(_isLoading)
            {
                continueProcess = true;
            }
            else
            {
                continueProcess = true;
            }
            if(!continueProcess)
            {
                return;
            }

            //RefreshPerson();
            _isPersonListChanging = false;
        }

        private void datagridinterests_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            bool continueProcess;
            if (_isLoading)
            {
                continueProcess = true;
            }
            else
            {
                continueProcess = true;
            }
            if (!continueProcess)
            {
                return;
            }
            _currentPerson = _repo.GetPersonWithInterests(((int)dataGridPerson.SelectedValue));

            //RefreshPerson();
            _isPersonListChanging = false;
        }

        //private void RefreshPerson()
        //{
            //_isPersonListChanging = true;
            //_personViewSource.ObjectInstance = _currentPerson;
            //_observableInterests = new ObservableCollection<Interests>(_currentPerson.Hobbies);
            //dataGridInterests.ItemsSource = _observableInterests;

            //_isPersonListChanging = false;
        //}

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string name = searchbox.ToString();  //Some garbage is in this need to split or form a new string with just the name.
                                                 //Then we can use to search the database.
            string[] almostuseablename = name.Split(new char[0]); //Useable string is in index one.
                                                                  //test.Text = useablename[1];

            string usablename = almostuseablename[1];

            List<Person> people;
            List<Interests> hobbies;
            using (var context = new SearchPersonContext())
            {
                people = context.People.Where(p => p.FirstName.Equals(usablename) || p.LastName.Equals(usablename)).ToList();
                //hobbies = context.
            }

            dataGridPerson.ItemsSource = people;
        }
    }
}
