//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectManager.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CostEstimateSheetDetail
    {
        public System.Guid DetailGUID { get; set; }
        public int DetailID { get; set; }
        public Nullable<System.Guid> SheetGUID { get; set; }
        public Nullable<System.Guid> TaskGUID { get; set; }
        public Nullable<int> ResourceCategoryID { get; set; }
        public Nullable<decimal> Amount { get; set; }
    }
}