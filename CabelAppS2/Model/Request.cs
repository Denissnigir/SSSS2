//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CabelAppS2.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Request
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int ContractId { get; set; }
        public int ServiceId { get; set; }
        public int ServiceVariation { get; set; }
        public int ServiceType { get; set; }
        public int Status { get; set; }
        public string EquipmentType { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> DateOfEnd { get; set; }
        public int ProblemTypeId { get; set; }
    
        public virtual ProblemType ProblemType { get; set; }
        public virtual RequestStatus RequestStatus { get; set; }
        public virtual Service Service { get; set; }
        public virtual ServiceType ServiceType1 { get; set; }
        public virtual ServiceVariation ServiceVariation1 { get; set; }
    }
}
