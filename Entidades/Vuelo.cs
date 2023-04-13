/*
* Author: Jose Rodolfo Rojas OCampo
* Ced: 702390149
* E-mail: joserodolfo_coco@hotmail.com
* Date: 13/03/2023
* Version 2.0 
*/

using System;

namespace Entidades;

public class Vuelo
{
    // Propiedades de la clase
    public int id { set; get; }
    public Aerolinea aerolinea { set; get; }
    public Aeropuerto origen { set; get; }
    public Aeropuerto destino { set; get; }
    public DateTime duracion { set; get; }
    public int capacidad { set; get; }

}
