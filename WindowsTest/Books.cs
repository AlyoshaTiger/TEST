using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsTest
{
    class Books
    {
        public int Id { get; set; }
        public string Uzdanie { get; set; }
        public int Price { get; set; }

        [Required]
        public Books Book { get; set; }
    }
}
