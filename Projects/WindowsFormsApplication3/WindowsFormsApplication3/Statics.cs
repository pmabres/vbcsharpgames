using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    static class Statics
    {
        // creo constantes asi detecto mas facil cuando dibuje una forma de tipo circulo o rectangulo
        public const int GRAPHIC_TYPE_CIRCLE = 0;
        public const int GRAPHIC_TYPE_RECTANGLE = 1;
        // al declararla de tipo estatica lo que hace es declararla como global entonces la puedo usar en todas las clases
        public static Graphics graphics;
    }
}
