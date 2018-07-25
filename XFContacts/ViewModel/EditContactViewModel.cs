using XFContacts.Model;

namespace XFContacts.ViewModel
{
    public class EditContactViewModel : BaseViewModel
    {
        public Contact Contact { get; }

        public EditContactViewModel(Contact contact)
        {
            Contact = contact;
        }
    }
}
