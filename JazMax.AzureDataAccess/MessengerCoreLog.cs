//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JazMax.AzureDataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class MessengerCoreLog
    {
        public int MessengerCoreLogId { get; set; }
        public int MessenegerTypeId { get; set; }
        public string MessageFrom { get; set; }
        public string MessageTo { get; set; }
        public string MessageSubject { get; set; }
        public string MessageBody { get; set; }
        public bool IsHTML { get; set; }
        public System.DateTime DateCreated { get; set; }
        public Nullable<System.DateTime> DateSent { get; set; }
        public string MessengerResponse { get; set; }
        public Nullable<bool> IsSent { get; set; }
    }
}
