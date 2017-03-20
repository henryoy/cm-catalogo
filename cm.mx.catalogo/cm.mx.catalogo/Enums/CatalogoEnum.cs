using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cm.mx.catalogo.Enums
{
    // se pretende no eliminar ningun elemento, sino solo dar de baja por seguiridad el sistema 
    enum Estatus
    {
        ALTA,//alta en general
        INACTIVO,//inactivo
        BAJA,//Eliminado
    }
}
