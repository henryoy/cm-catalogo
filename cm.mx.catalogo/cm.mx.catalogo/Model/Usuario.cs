using System;
using System.Text;
using System.Collections.Generic;


namespace cm.mx.catalogo.Model {
    
    public class Usuario {
        public virtual int Usuarioid { get; set; }
        public virtual string Correo { get; set; }
        public virtual string Nombre { get; set; }
        public virtual string Password { get; set; }
        public virtual DateTime Fechanacimiento { get; set; }
        public virtual int Totalvisitas { get; set; }
        public virtual int Visitasactuales { get; set; }
        public virtual DateTime Fecharegistro { get; set; }
        public virtual string Tipologin { get; set; }
        public virtual DateTime Ultimoinicio { get; set; }
        public virtual int Membresiaactual { get; set; }
        public virtual string Tipo { get; set; }
        public virtual string Codigo { get; set; }
    }
}
