//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WIMORepository.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int IDUser { get; set; }
        public int IDHuman { get; set; }
        public int IDRole { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string RegCode { get; set; }
    
        public virtual Human Human { get; set; }
        public virtual Role Role { get; set; }
    }
}