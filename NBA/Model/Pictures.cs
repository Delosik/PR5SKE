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
    
    public partial class Pictures
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public int NumberOfLike { get; set; }
        public System.DateTime Createtime { get; set; }
        public byte[] Img { get; set; }
    }
}