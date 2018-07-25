using XFContacts.Model;
using XFContacts.Service;

namespace XFContacts.ViewModel
{
    public class AddContactViewModel : BaseViewModel
    {
        Contact _contact;
        public Contact Contact
        {
            get { return _contact; }
            set { _contact = value; NotifyPropertyChanged(); }
        }

        public AddContactViewModel()
        {
            Contact = new Contact();
            ContactService.Contacts.Add(Contact);
        }
    }
}
