using RepositoryPattern.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPattern.Repository
{
    public class Person : RepositoryBase<Person>, IPerson
    {
        public Person(RepositoryContext context ): base(context)
        {

        }
    }
}
