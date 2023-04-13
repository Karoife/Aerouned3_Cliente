/*
* Author: Jose Rodolfo Rojas OCampo
* Ced: 702390149
* E-mail: joserodolfo_coco@hotmail.com
* Date: 13/03/2023
* Version 2.0 
*/

namespace Entidades;

public class Boleto
{
    // Propiedades de la clase
    public int numero { set; get; }
    public Vuelo vuelo { set; get; }
    public DateTime fecha { set; get; }
    public Cliente cliente { set; get; }
    public int asientos { set; get; }


}