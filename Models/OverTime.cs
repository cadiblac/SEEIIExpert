//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace SEEIPro.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OverTime
    {
        public int oId { get; set; }
        public string overtimeReason { get; set; }
        public Nullable<System.DateTime> startDate { get; set; }
        public Nullable<System.DateTime> endDate { get; set; }
        public Nullable<double> overtimeCount { get; set; }
        public Nullable<int> isDepartment { get; set; }
        public Nullable<int> isHrResourse { get; set; }
        public Nullable<int> isPresident { get; set; }
        public Nullable<int> proser { get; set; }
        public Nullable<int> isValid { get; set; }
        public Nullable<int> isDel { get; set; }
    }
}