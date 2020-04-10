using System;
using System.ComponentModel.DataAnnotations;

namespace api_angular_1.Models
{
    public class Employee
    {
        
        public int eid { get; set; }
        public string ename { get; set; }
        public string edesig { get; set; }
        public Employee()
        {
        }
    }
}
