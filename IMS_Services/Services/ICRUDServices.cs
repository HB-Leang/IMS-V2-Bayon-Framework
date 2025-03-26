using IMS_Services.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS_Services.Services;

public interface ICRUDServices<T, ID>
{
    static abstract IEnumerable<T> GetAll();
    static abstract IEnumerable<T> GetByName(string name);
    static abstract T GetById(ID id);
    static abstract ID Add(T entity);
    static abstract bool Update(T entity);
    static abstract bool Delete(ID id);

}
