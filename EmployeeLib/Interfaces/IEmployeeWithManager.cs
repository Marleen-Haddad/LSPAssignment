using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeLib.Interfaces
{
    public interface IEmployeeWithManager
    {
        public Manager Manager { get; set; }
        public void AssignManager(Manager manager);
    }
}
