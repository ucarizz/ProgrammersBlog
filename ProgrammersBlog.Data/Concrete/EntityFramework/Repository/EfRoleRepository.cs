using Microsoft.EntityFrameworkCore;
using ProgrammersBlog.Data.Abstract;
using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Shared.Data.Concrete.EntityFramwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Data.Concrete.EntityFramework
{
    public class EfRoleRepository : EFEntityRepositoryBase<Role>, IRoleRepository
    {
        public EfRoleRepository(DbContext context) : base(context)
        {

        }
    }
}
