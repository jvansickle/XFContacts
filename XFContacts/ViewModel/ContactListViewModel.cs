using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using XFContacts.Model;

namespace XFContacts.ViewModel
{
    public class ContactListViewModel : BaseViewModel
    {
        readonly ObservableCollection<Contact> _contacts = new ObservableCollection<Contact>();
        public ObservableCollection<Contact> Contacts { get { return _contacts; } }

        public ICommand RefreshContactsCommand => new Command(RefreshContacts);

        bool _isRefreshingContacts;
        public bool IsRefreshingContacts
        {
            get { return _isRefreshingContacts; }
            set { _isRefreshingContacts = value; NotifyPropertyChanged(); }
        }

        int contactCount;

        public ContactListViewModel()
        {
            RefreshContacts();
        }

        void RefreshContacts()
        {
            for (int i = contactCount; i < contactCount + 100; i++)
            {
                Contacts.Add(new Contact { FirstName = $"FirstName {i}", LastName = $"LastName {i}" });
            }
            contactCount += 100;

            IsRefreshingContacts = false;
        }
    }
}
