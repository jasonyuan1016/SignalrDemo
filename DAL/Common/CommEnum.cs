using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YMOA.DAL
{
    /// <summary>
    /// 操作类型
    /// </summary>
    public enum OperateType
    {
        /// <summary>
        /// 其他
        /// </summary>
        None = 0,
        /// <summary>
        /// 系统
        /// </summary>
        System = 1,
        /// <summary>
        /// 金流
        /// </summary>
        Cash = 2,
        /// <summary>
        /// 用户
        /// </summary>
        User = 3
    }
}
