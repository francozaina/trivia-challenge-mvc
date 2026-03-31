using System;

namespace PreguntadOrt.Models
{
  
    public class Dificultad
    {
       private int _idDificultad;
       private string _nombre;

       public int IdDificultad
       {
         get { return _idDificultad; }
            set
            {
             _idDificultad = value;
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
    
    }

}