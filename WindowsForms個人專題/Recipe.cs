//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsForms個人專題
{
    using System;
    using System.Collections.Generic;
    
    public partial class Recipe
    {
        public int RecipeID { get; set; }
        public int UserID { get; set; }
        public string FoodName { get; set; }
        public string Description { get; set; }
        public Nullable<int> CookingTime { get; set; }
        public Nullable<int> Amount { get; set; }
        public string Photo { get; set; }
        public string Tips { get; set; }
    
        public virtual User User { get; set; }
    }
}
