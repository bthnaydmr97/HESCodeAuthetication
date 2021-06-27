using Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{   //Core Layer is using diffrent project. So Do not referance.
    //Generic Struct
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
       //filter  can be null this method. 
        List<T> GetAll(Expression<Func<T,bool>> filter=null);

        T Get(Expression<Func<T, bool>> filter);
    }
}
