//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NBA.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Admin
    {
        public string JobNumber { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string RoleID { get; set; }
    
        public virtual Role Role { get; set; }
    }
}