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
    
    public partial class Job
    {
        public int jId { get; set; }
        public string jobName { get; set; }
        public string jobDemands { get; set; }
        public string workPlace { get; set; }
        public string treatment { get; set; }
        public Nullable<System.DateTime> releaseDate { get; set; }
        public Nullable<int> isValid { get; set; }
        public string companyName { get; set; }
        public string enterpriseType { get; set; }
        public string contactName { get; set; }
        public string telephone { get; set; }
        public string mobilePhone { get; set; }
    }
}
