using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using cm.mx.catalogo.Model; 

namespace cm.mx.catalogo.Model.Map {
    
    
    public class UsuarioMap : ClassMap<Usuario> {
        
        public UsuarioMap() {
			Table("Usuario");
			LazyLoad();
			Id(x => x.Usuarioid).GeneratedBy.Identity().Column("UsuarioId");
			Map(x => x.Correo).Column("Correo").Not.Nullable();
			Map(x => x.Nombre).Column("Nombre").Not.Nullable();
			Map(x => x.Password).Column("Password").Not.Nullable();
			Map(x => x.Fechanacimiento).Column("FechaNacimiento").Not.Nullable();
			Map(x => x.Totalvisitas).Column("TotalVisitas").Not.Nullable();
			Map(x => x.Visitasactuales).Column("VisitasActuales").Not.Nullable();
			Map(x => x.Fecharegistro).Column("FechaRegistro").Not.Nullable();
			Map(x => x.Tipologin).Column("TipoLogin").Not.Nullable();
			Map(x => x.Ultimoinicio).Column("UltimoInicio").Not.Nullable();
			Map(x => x.Membresiaactual).Column("MembresiaActual").Not.Nullable();
			Map(x => x.Tipo).Column("Tipo").Not.Nullable();
			Map(x => x.Codigo).Column("Codigo").Not.Nullable();
        }
    }
}
