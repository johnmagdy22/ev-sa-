using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ev_sa_task.Models
{
    public class Product
    {
      
            public int Id { get; set; }
            [Required]
            public string Name { get; set; }
        }
    }
