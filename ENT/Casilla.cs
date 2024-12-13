using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class Casilla : VMBase
    {
        private String _imagen;
        private Boolean _esMina;
        private Boolean _esVolteada;
        public String Imagen { 
            get {
                return _imagen;
            }
        }
        public Boolean EsMina { get { return _esMina; } }
        public Boolean EsVolteada { 
            get {
                return _esVolteada;
            } 
            set {
                if (_esVolteada && _esMina)
                {
                    _imagen = "anverso_mina.png";
                }
                else if (_esVolteada && !_esMina)
                {
                    _imagen = "anverso_ok.png";
                }
                else {
                    _imagen = "reverso.png";
                }
            } 
        }
    }
}
