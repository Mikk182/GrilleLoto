//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GrilleLoto
{
    using System;
    using System.Collections.Generic;
    
    public partial class Partie
    {
        public Partie()
        {
            this.Numbers = new HashSet<Number>();
        }
    
        public int Id { get; set; }
        public int Num { get; set; }
        public System.DateTime Date { get; set; }
        public int Journee_Id { get; set; }
    
        public virtual Journee Journee { get; set; }
        public virtual ICollection<Number> Numbers { get; set; }
    }
}