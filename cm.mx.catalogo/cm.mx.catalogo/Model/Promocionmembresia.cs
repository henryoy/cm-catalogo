using System;
using System.Text;
using System.Collections.Generic;


namespace cm.mx.catalogo.Model {
    
    public class Promocionmembresia {
        public virtual int Promocionid { get; set; }
        public virtual int Membresiaid { get; set; }
        public virtual Promocion Promocion { get; set; }
        public virtual Tipomembresia Tipomembresia { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as Promocionmembresia;
			if (t == null) return false;
			if (Promocionid == t.Promocionid
			 && Membresiaid == t.Membresiaid)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ Promocionid.GetHashCode();
			hash = (hash * 397) ^ Membresiaid.GetHashCode();

			return hash;
        }
        #endregion
    }
}
