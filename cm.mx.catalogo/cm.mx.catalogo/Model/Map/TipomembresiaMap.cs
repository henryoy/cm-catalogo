using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using cm.mx.catalogo.Model; 

namespace cm.mx.catalogo.Model.Map {
    
    
    public class TipomembresiaMap : ClassMap<Tipomembresia> {
        
        public TipomembresiaMap() {
			Table("TipoMembresia");
			LazyLoad();
			Id(x => x.Membresiaid).GeneratedBy.Identity().Column("MembresiaId");
			Map(x => x.Nombre).Column("Nombre").Not.Nullable();
			Map(x => x.Numerodevisitas).Column("NumeroDeVisitas").Not.Nullable();
			Map(x => x.Porcientodescuento).Column("PorcientoDescuento");
			Map(x => x.Color).Column("Color").Not.Nullable();
			Map(x => x.Estado).Column("Estado").Not.Nullable();
			HasMany(x => x.Promocionmembresia).KeyColumn("MembresiaId");
        }
    }
}
