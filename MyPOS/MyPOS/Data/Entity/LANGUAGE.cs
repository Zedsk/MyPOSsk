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
    
    public partial class LANGUAGE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LANGUAGE()
        {
            this.AGE_TRANSLATION = new HashSet<AGE_TRANSLATION>();
            this.CATEGORY_TRANSLATION = new HashSet<CATEGORY_TRANSLATION>();
            this.HERO_TRANSLATION = new HashSet<HERO_TRANSLATION>();
            this.PRODUCT_TRANSLATION = new HashSet<PRODUCT_TRANSLATION>();
            this.SHOP_TRANSLATION = new HashSet<SHOP_TRANSLATION>();
            this.TICKET_MESSAGE_TRANSLATION = new HashSet<TICKET_MESSAGE_TRANSLATION>();
            this.TRANSACTIONS = new HashSet<TRANSACTION>();
        }
    
        public int idLanguage { get; set; }
        public string nameLanguage { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AGE_TRANSLATION> AGE_TRANSLATION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CATEGORY_TRANSLATION> CATEGORY_TRANSLATION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HERO_TRANSLATION> HERO_TRANSLATION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCT_TRANSLATION> PRODUCT_TRANSLATION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SHOP_TRANSLATION> SHOP_TRANSLATION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TICKET_MESSAGE_TRANSLATION> TICKET_MESSAGE_TRANSLATION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRANSACTION> TRANSACTIONS { get; set; }
    }
}