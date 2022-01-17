using ProgrammersBlog.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgrammersBlog.Mvc.Areas.Admin.Models
{
    public class CategoryAddAjaxViewModel
    {
        public CategoryDto CategoryDto { get; set; }
        public string CategoryAddPartial { get; set; }
        public CategoryAddDto Category { get; set; }
    }
}
