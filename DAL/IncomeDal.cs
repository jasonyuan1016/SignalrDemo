using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMOA.DAL;

namespace DAL
{
    public class IncomeDal : BaseDal
    {

        public bool Insert(Dictionary<string, object> paras)
        {
            int result = StandardInsert("income", paras, "id");
            return result > 0;
        }


        public bool Update(Dictionary<string, object> paras)
        {
            int result = StandardUpdate("income", paras, "id");
            return result > 0;
        }

        
        public IEnumerable<T> QryList<T>()
        {
            return QueryList<T>("SELECT * FROM income ORDER BY state");
        }
    }
}
