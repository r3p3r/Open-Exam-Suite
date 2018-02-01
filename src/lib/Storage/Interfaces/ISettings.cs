﻿using System.Collections.Generic;

namespace Storage.Interfaces
{
    public interface ISettings
    {
        void Add(ISettings settings);
        void Clear();
        IEnumerable<ISettings> GetAll();
    }
}