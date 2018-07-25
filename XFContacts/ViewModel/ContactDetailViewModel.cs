using XFContacts.Model;

namespace XFContacts.ViewModel
{
    public class ContactDetailViewModel : BaseViewModel
    {
        Contact _contact;
        public Contact Contact
        {
            get { return _contact; }
            set { _contact = value; NotifyPropertyChanged(); }
        }

        public ContactDetailViewModel(Contact contact)
        {
            Contact = contact;
        }
    }
}
