using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Restaurant.Model
{
    public class BaseModel : INotifyPropertyChanged
    {
        private int id;
        private bool isChanged;

        public int Id
        {
            get => id;
            set
            {
                if (value == id) return;
                id = value;
                OnPropertyChanged();
                //OnPropertyChanged(nameof(Id));
                //OnPropertyChanged(nameof(Id), nameof(IsChanged));
            }
        }
        public bool IsChanged
        {
            get => isChanged;
            set
            {
                if (value == isChanged) return;
                isChanged = value;
                OnPropertyChanged();
                //OnPropertyChanged(nameof(IsChanged));
            }
        }


        public virtual event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (propertyName != nameof(IsChanged) && IsChanged != true)
            {
                IsChanged = true;
            }
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected virtual void OnPropertyChanged(params string[] propertyNames)
        {
            foreach (string propertyName in propertyNames)
            {
                if (propertyName != nameof(IsChanged) && IsChanged != true)
                {
                    IsChanged = true;
                }
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
