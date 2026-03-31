using System;

namespace PreguntadOrt.Models
{
  
    public class Categoria
    {
       private int _idCategoria;
       private string _nombre;
       private string _foto;

       public int IdCategoria
       {
         get { return _idCategoria; }
            set
            {
             _idCategoria = value;
            }
        }

        public string Nombre
        {
            get { return _nombre; }
            set
            {
             _nombre = value;
            }
        }

        public string Foto
        {
            get { return _foto; }
            set
            {
             _foto = value;
            }
        }
    
    }

}