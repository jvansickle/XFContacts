using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using XFContacts.Model;
using XFContacts.Service;

namespace XFContacts.ViewModel
{
    public class ContactListViewModel : BaseViewModel
    {
        public ObservableCollection<Contact> Contacts { get { return ContactService.Contacts; } }

        public ICommand RefreshContactsCommand => new Command(RefreshContacts);

        public ICommand DeleteContactCommand => new Command(DeleteContact);

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

        void DeleteContact(object contact)
        {
            ContactService.Contacts.Remove((Contact)contact);
        }
    }
}
