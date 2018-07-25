using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace XFContacts.Model
{
    public class Contact : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; NotifyPropertyChanged(); }
        }

        string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; NotifyPropertyChanged(); }
        }

        void NotifyPropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
