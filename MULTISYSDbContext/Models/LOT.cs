using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Linq.Mapping;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MULTISYSDbContext.Models
{
    [Table(Name = "LOTs")]
    public class LOT
    {
        public LOT()
        {

        }

        [Column(Name = "Id", IsDbGenerated = true, IsPrimaryKey = true, DbType = "INTEGER")]
        [Key]
        public int Id { get; set; }

        [Column(Name = "EmpName", DbType = "VARCHAR")]
        public string Name { get; set; }

        [Column(Name = "Color")]
        public int Color { get; set; }

        [Column(Name = "Description", DbType = "VARCHAR")]
        public string Description { get; set; }


        public override string ToString()
        {
            return Name;
        }

    }
}
