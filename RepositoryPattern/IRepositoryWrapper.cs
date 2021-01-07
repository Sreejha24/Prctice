using RepositoryPattern.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPattern
{
    public interface IRepositoryWrapper
    {
        IPerson Person { get; }

        IEmployee Employees { get; }

        void Save();
    }
}
