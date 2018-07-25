using Xamarin.Forms;
using XFContacts.Model;
using XFContacts.ViewModel;

namespace XFContacts.Page
{
    public partial class ContactListPage : ContentPage
    {
        public ContactListPage()
        {
            InitializeComponent();

            BindingContext = new ContactListViewModel();
        }

        void OnContactSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                Navigation.PushAsync(new ContactDetailPage(e.SelectedItem as Contact), true);
                (sender as ListView).SelectedItem = null;
            }
        }
    }
}
