//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApiCarSharing.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UyeBilgi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UyeBilgi()
        {
            this.Adres = new HashSet<Adres>();
            this.Arac = new HashSet<Arac>();
            this.Odemeler = new HashSet<Odemeler>();
            this.Onay = new HashSet<Onay>();
            this.Yolculuk = new HashSet<Yolculuk>();
            this.Yolculuk1 = new HashSet<Yolculuk>();
        }
    
        public int UserId { get; set; }
        public System.Guid Apikey { get; set; }
        public string Role { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public System.DateTime DogumTarihi { get; set; }
        public string Sigara { get; set; }
        public string ResimYol { get; set; }
        public string EMail { get; set; }
        public string Sifre { get; set; }
        public string TC { get; set; }
        public string Telefon { get; set; }
        public System.DateTime UyeKayitTarihi { get; set; }
        public string Deneyim { get; set; }
        public short YapilanYolculukSayisi { get; set; }
        public byte MusteriPuan { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Adres> Adres { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Arac> Arac { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Odemeler> Odemeler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Onay> Onay { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Yolculuk> Yolculuk { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Yolculuk> Yolculuk1 { get; set; }
    }
}