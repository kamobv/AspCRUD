using AspCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspCRUD.ViewModels
{
    public class VmProductEdit
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
    }
}