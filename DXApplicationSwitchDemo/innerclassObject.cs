using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplicationSwitchDemo
{
    public class innerclassObject : Object, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        DateTime? _birthDate = DateTime.Now;
        public DateTime? BirthDate
        {
            get
            {
                return _birthDate;
            }
            set
            {
                _birthDate = value;
            }
        }

        String _testString = null;
        public String TestString
        {
            get
            {
                return _testString;
            }
            set
            {
                _testString = value;
            }
        }

        int? _age = 100;
        public int? Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }
    }

}
