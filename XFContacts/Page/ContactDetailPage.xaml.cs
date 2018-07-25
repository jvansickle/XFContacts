using System;
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

            NavigationPage.SetBackButtonTitle(this, "Done");
        }

        void OnEditContact(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EditContactPage((BindingContext as ContactDetailViewModel).Contact), true);
        }
    }
}
