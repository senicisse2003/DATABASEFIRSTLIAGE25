//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DATABASEFIRSTLIAGE25
{
    using System;
    using System.Collections.Generic;
    
    public partial class Products
    {
        public long ProductId { get; set; }
        public string Name { get; set; }
        public Nullable<double> Price { get; set; }
        public long CategoryId { get; set; }
    
        public virtual Categories Categories { get; set; }
    }
}
