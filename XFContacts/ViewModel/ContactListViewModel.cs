using System.Collections.ObjectModel;

namespace XFContacts.ViewModel
{
    public class ContactListViewModel : BaseViewModel
    {
        public class Contact
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        readonly ObservableCollection<Contact> _contacts = new ObservableCollection<Contact>();
        public ObservableCollection<Contact> Contacts { get { return _contacts; } }

        public ContactListViewModel()
        {
            RefreshContacts();
        }

        void RefreshContacts()
        {
            for (int i = 0; i < 100; i++)
            {
                Contacts.Add(new Contact { FirstName = $"FirstName {i}", LastName = $"LastName {i}" });
            }
        }
    }
}
