using RepositoryPattern.Data;
using RepositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPattern.Repository
{
    public class Employee : RepositoryBase<Employee>, IEmployee
    {

        public Employee(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }
    }
}
