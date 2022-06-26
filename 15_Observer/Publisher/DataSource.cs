using System.Collections.Generic;

namespace P05_Observer
{
    public class DataSource
    {
        private readonly List<IObserver> _commands = new();
        private string _value; 
        public string Value
        {
            get => _value;
            set
            {
                _value = value;
                NotifyObservers();
            }
        }

        public void NotifyObservers()
        {
            _commands.ForEach(c => c.Update());
        }

        public void AddObserver(IObserver observer)
        {
            _commands.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _commands.Remove(observer);
        }
    }
}
