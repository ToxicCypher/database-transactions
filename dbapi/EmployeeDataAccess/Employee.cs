//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmployeeDataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public long id { get; set; }
        public Nullable<long> badgeNum { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
        public Nullable<int> age { get; set; }
        public Nullable<bool> isSalary { get; set; }
    }
}