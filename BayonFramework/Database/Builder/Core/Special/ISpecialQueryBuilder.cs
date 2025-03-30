using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BayonFramework.Database.Builder.Core.Special
{
    public interface ISpecialQueryBuilder
    {
        SqlQuery Build();
    }
}
