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
    
    public partial class PRODUCT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRODUCT()
        {
            this.PRODUCT_TRANSLATION = new HashSet<PRODUCT_TRANSLATION>();
            this.SHOP_PRODUCT = new HashSet<SHOP_PRODUCT>();
            this.TRANSACTION_DETAILS = new HashSet<TRANSACTION_DETAILS>();
        }
    
        public int idProduct { get; set; }
        public string barcode { get; set; }
        public decimal purchasePrice { get; set; }
        public decimal salesPrice { get; set; }
        public Nullable<decimal> discountRate { get; set; }
        public byte[] imageProduct { get; set; }
        public int categoryId { get; set; }
        public int ageId { get; set; }
        public int brandId { get; set; }
        public int heroId { get; set; }
    
        public virtual AGE AGE { get; set; }
        public virtual BRAND BRAND { get; set; }
        public virtual CATEGORY CATEGORY { get; set; }
        public virtual HERO HERO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCT_TRANSLATION> PRODUCT_TRANSLATION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SHOP_PRODUCT> SHOP_PRODUCT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRANSACTION_DETAILS> TRANSACTION_DETAILS { get; set; }
    }
}
