//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Inventory_movements
    {
        public int movement_id { get; set; }
        public string type_movement { get; set; }
        public int product_id { get; set; }
        public int quantity_moved { get; set; }
    
        public virtual Inventory Inventory { get; set; }
    }
}
