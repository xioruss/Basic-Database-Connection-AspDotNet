using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection.MODEL.Entities
{
    public class MyTable
    {
        public MyTable()
        {
            CreatedDate= DateTime.Now;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
