using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExSqlCompare.CustomControl.Interfaces.DbConnectionBox
{
    public interface IExSqlCompareConnectionUserControl
    {
        void Initialize(IExSqlCompareConnectionProperties connectionProperties);
        void LoadProperties();
    }
}
