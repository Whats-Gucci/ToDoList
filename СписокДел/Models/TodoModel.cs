using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СписокДел.Models
{
    class TodoModel: INotifyPropertyChanged 
    {
        private bool _Status;
        private string _Task;
        public DateTime CreationDate { get; set; } = DateTime.Now;
                      
        public bool Status
        {
            get { return _Status; }
            set 
            {
                if (_Status == value)
                    return;
                _Status = value; 
                OnPropertyChanged("Status");
            }
        }
                
        public string Task
        {
            get { return _Task; }
            set 
            {
                if (_Task == value)
                    return;
                _Task = value;
                OnPropertyChanged("Task");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string PropertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));

        }
    }
}
