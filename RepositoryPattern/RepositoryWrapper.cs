using RepositoryPattern.Data;
using RepositoryPattern.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPattern
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        public IPerson _person;
        public IEmployee _employee;
        public RepositoryContext _context;
        public RepositoryWrapper(RepositoryContext context)
        {
            _context = context;
        }
        public IPerson Person
        {
            get
            {
                if(_person == null)
                {
                    _person = new Person(_context);
                }
                return _person;
            }
        }
        public IEmployee Employee
        {
            get
            {
                if(_employee == null)
                {
                    _employee = new Employee(_context);
                }
                return _employee;
            }
        }

        public IEmployee Employees => throw new NotImplementedException();

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
