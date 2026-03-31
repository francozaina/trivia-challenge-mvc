using System;

namespace PreguntadOrt.Models
{
  
    public class Ranking
    {
       private int _puntajeFinal;
       private string _nombreUser;

       public int PuntajeFinal
       {
         get { return _puntajeFinal; }
            set
            {
             _puntajeFinal = value;
            }
        }

        public string NombreUser
        {
            get { return _nombreUser; }
            set
            {
             _nombreUser = value;
            }
        }    
    }    
}
