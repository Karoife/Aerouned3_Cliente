/*
* Author: Jose Rodolfo Rojas OCampo
* Ced: 702390149
* E-mail: joserodolfo_coco@hotmail.com
* Date: 13/03/2023
* Version 2.0 
*/

using System;

namespace Entidades;

public class Cliente
{
    // Propiedades de la clase encapculadas
    public String id { get; set; }
    public String nombre { get; set; }
    public String primApell { get; set; }
    public String segApell { get; set; }
    public DateTime dataNaci { get; set; } // Esta clase funciona para guardar fechas
    public char genero { get; set; }
    
}


