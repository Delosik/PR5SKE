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
    
    public partial class PlayerInteam
    {
        public int ID { get; set; }
        public int PlayerID { get; set; }
        public int TeamID { get; set; }
        public int SeasonID { get; set; }
        public string ShirtNumber { get; set; }
        public decimal Salary { get; set; }
        public int StartIndex { get; set; }
    
        public virtual Player Player { get; set; }
        public virtual Season Season { get; set; }
        public virtual Team Team { get; set; }
    }
}
