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
    
    public partial class MatchupLog
    {
        public int ID { get; set; }
        public int MatchupID { get; set; }
        public int Quarter { get; set; }
        public string OccurTime { get; set; }
        public int TeamID { get; set; }
        public int PlayerID { get; set; }
        public int ActionTypeID { get; set; }
        public string Remark { get; set; }
    
        public virtual ActionType ActionType { get; set; }
        public virtual Matchup Matchup { get; set; }
        public virtual Player Player { get; set; }
        public virtual Team Team { get; set; }
    }
}