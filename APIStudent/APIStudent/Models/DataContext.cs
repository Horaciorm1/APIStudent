using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace APIStudent.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection") //Constructor
        {

                
        }

        public System.Data.Entity.DbSet<APIStudent.Models.Student> Students { get; set; }
    }
}