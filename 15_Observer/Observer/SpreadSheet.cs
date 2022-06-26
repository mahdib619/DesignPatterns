﻿using System;

namespace P05_Observer
{
    class SpreadSheet : IObserver
    {
        private readonly DataSource _dataSource;

        public SpreadSheet(DataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public void Update()
        {
            Console.WriteLine($"Cells updated with value {_dataSource.Value}");
        }
    }
}
