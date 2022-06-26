using System;

namespace P05_Observer
{
    public class PieChart : IObserver
    {
        private readonly DataSource _dataSource;

        public PieChart(DataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public void Update()
        {
            Console.WriteLine($"PieChart updated with value {_dataSource.Value}");
        }
    }
}
