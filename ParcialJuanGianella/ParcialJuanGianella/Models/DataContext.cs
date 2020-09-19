using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ParcialJuanGianella.Models
{
    public class DataContext: DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<ParcialJuanGianella.Models.Pais> Pais { get; set; }
    }
}