using System;
using System.Text;
using System.Collections.Generic;


namespace cm.mx.catalogo.Model {
    
    public class Promocion {
        public Promocion() {
			Fechapublicacion = new List<Fechapublicacion>();
			Promociondetalle = new List<Promociondetalle>();
			Promocionmembresia = new List<Promocionmembresia>();
        }

        public virtual void AddDetalle(Promociondetalle oDetalle)
        {
            Promociondetalle.Add(oDetalle);
            oDetalle.Promocion = this;
        }
        public virtual void AddFecha(Fechapublicacion oFecha)
        {
            Fechapublicacion.Add(oFecha);
            oFecha.Promocion = this;
        }
        public virtual void AddMembresia(Promocionmembresia oMembresia)
        {
            Promocionmembresia.Add(oMembresia);
            oMembresia.Promocion = this;
        }
        public virtual int Promocionid { get; set; }
        public virtual string Titulo { get; set; }
        public virtual string Descripcion { get; set; }
        public virtual DateTime Vigenciainicial { get; set; }
        public virtual DateTime Vigenciafinal { get; set; }
        public virtual DateTime Fechaalta { get; set; }
        public virtual int Usuarioaltaid { get; set; }
        public virtual DateTime Fechabaja { get; set; }
        public virtual int Usuariobajaid { get; set; }
        public virtual string Estado { get; set; }
        public virtual string Tipomembresia { get; set; }
        public virtual float Descuento { get; set; }
        public virtual string Tipocliente { get; set; }
        public virtual string Resumen { get; set; }
        public virtual IList<Fechapublicacion> Fechapublicacion { get; set; }
        public virtual IList<Promociondetalle> Promociondetalle { get; set; }
        public virtual IList<Promocionmembresia> Promocionmembresia { get; set; }
    }
}
