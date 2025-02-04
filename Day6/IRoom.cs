﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal interface IRoom<T>
    {
        IEnumerable<T> GetAll();
        void AddRoom(T item);

    }
}
