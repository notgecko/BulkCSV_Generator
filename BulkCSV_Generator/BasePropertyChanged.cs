using System.ComponentModel;

namespace BulkCSV_Generator
{
    public abstract class BasePropertyChanged : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected void SetValue<Type>(Type src, ref Type dst, string name)
        {
            if (!src.Equals(dst))
            {
                dst = src;
                this.RaisePropertyChanged(name);
            }
        }
    }
}