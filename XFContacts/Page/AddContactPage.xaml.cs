using System;
using Xamarin.Forms;
using XFContacts.Service;
using XFContacts.ViewModel;

namespace XFContacts.Page
{
    public partial class AddContactPage : ContentPage
    {
        public AddContactPage()
        {
            InitializeComponent();

            BindingContext = new AddContactViewModel();
        }

        void OnDone(object sender, EventArgs args)
        {
            var contact = (BindingContext as AddContactViewModel).Contact;

            if (string.IsNullOrWhiteSpace(contact.FirstName) && string.IsNullOrWhiteSpace(contact.LastName))
            {
                ContactService.Contacts.Remove(contact);
            }

            Navigation.PopModalAsync();
        }
    }
}
