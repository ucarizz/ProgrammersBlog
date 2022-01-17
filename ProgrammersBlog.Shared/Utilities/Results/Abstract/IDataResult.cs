using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Shared.Utilities.Results.Abstract
{
    public interface IDataResult<out T> : IResult
    {
        public T Data { get; }//new DataResuılt<Category>(ResultStatus.Succes,category)
                              //new DataResuılt<IList<Category>>(ResultStatus.Succes,category)
   
    }                           //out T yazılış nedeni

 


}
