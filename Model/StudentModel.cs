

using System;
using System.ComponentModel;

namespace MVVMExample.Model
{
    public class StudentModel { }
    public class Student : INotifyPropertyChanged
    {
        private string _firstName;
        private string _lastName;

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (_firstName != value)
                {
                    _firstName = value;
                    RaisePropertyChanged("FirstName");
                    RaisePropertyChanged("FullName");
                }
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (_lastName != value)
                {
                    _lastName = value;
                    RaisePropertyChanged("LastName");
                    RaisePropertyChanged("FullName");
                }
            }
        }

        public string FullName
        {
            get { return _firstName + " " + _lastName; }
        }


        public event PropertyChangedEventHandler PropertyChanged;



        private void RaisePropertyChanged(string property)
        {
            // PropertyChanged?.Invoke checks the property for not beeing null
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }

}
