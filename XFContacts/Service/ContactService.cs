using System.Collections.ObjectModel;
using XFContacts.Model;

namespace XFContacts.Service
{
    public class ContactService
    {
        public static readonly ObservableCollection<Contact> Contacts = new ObservableCollection<Contact>();
    }
}
