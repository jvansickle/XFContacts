using System;
using Xamarin.Forms;
using XFContacts.Model;
using XFContacts.ViewModel;

namespace XFContacts.Page
{
    public partial class EditContactPage : ContentPage
    {
        public EditContactPage(Contact contact)
        {
            InitializeComponent();

            BindingContext = new EditContactViewModel(contact);
        }

        void OnDone(object sender, EventArgs e)
        {
            Navigation.PopAsync(true);
        }
    }
}
