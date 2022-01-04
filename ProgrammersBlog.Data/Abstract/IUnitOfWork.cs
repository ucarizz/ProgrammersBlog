using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Data.Abstract
{
    public interface IUnitOfWork: IAsyncDisposable//?IDisposable
    {
        IArticleRepository Articles { get; }
        ICategoryRepository Categorires { get; }
        ICommentRepository Comments { get;}
        IRoleRepository Roles { get; }
        IUserRepository Users { get; }

        Task<int> SaveAsync();
    }
}
