//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyPOS.Data.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class PERSON
    {
        public int idPerson { get; set; }
        public string namePerson { get; set; }
        public string firstname { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
    
        public virtual CUSTOMER CUSTOMER { get; set; }
        public virtual USER USER { get; set; }
        public virtual BRAND BRAND { get; set; }
    }
}