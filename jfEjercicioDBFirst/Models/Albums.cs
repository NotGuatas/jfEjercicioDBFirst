//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace jfEjercicioDBFirst.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Albums
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Albums()
        {
            this.Canciones = new HashSet<Canciones>();
        }
    
        public int AlbumID { get; set; }
        public int ArtistaID { get; set; }
        public string NombreAlbum { get; set; }
        public int AnioLanzamiento { get; set; }
        public int NumCanciones { get; set; }
    
        public virtual Artistas Artistas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Canciones> Canciones { get; set; }
    }
}
