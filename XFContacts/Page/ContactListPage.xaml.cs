using System;
using System.Collections.Generic;

using Xamarin.Forms;
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
    }
}
