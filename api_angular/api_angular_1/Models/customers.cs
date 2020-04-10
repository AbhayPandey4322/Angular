using System;
using System.ComponentModel.DataAnnotations;

namespace api_angular_1.Models
{
    public class customers
    {
        [Key]
        public int CID { get; set; }
        public string CName { get; set; }
        public DateTime DOB { get; set; }
        [MaxLength(4)]
        public int CPin { get; set; }
        public customers()
        {
        }
    }
}
