using Xamarin.Forms;
using XFContacts.Model;
using XFContacts.ViewModel;

namespace XFContacts.Page
{
    public partial class ContactDetailPage : ContentPage
    {
        public ContactDetailPage(Contact contact)
        {
            InitializeComponent();

            BindingContext = new ContactDetailViewModel(contact);
        }
    }
}
