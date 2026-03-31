using System;

namespace PreguntadOrt.Models
{
  
    public class Juego
    {
       private static string _username;
       private static int _puntajeActual = 0;
        private static int _preguntaActual;
       private static int _cantidadPreguntasCorrectas;
       private static List<Pregunta> _preguntas;
       private static List<Respuesta>_respuestas;
        public static string Username
        {
            get { return _username; }
            
        }
        public static int PuntajeActual
        {
            get { return _puntajeActual; }
            
        }
        public static int PreguntaActual{
        get
        {
            return _preguntaActual;
        }
    }

        public static int CantidadPreguntasCorrectas
        {
            get { return _cantidadPreguntasCorrectas; }
            
        }

        public static List<Pregunta> Preguntas
        {
            get { return _preguntas; }
            
        }

        public static List<Respuesta> Respuestas
        {
            get { return _respuestas; }
            
        }

        public static void InicializarJuego()
        {
            _username = null;
            _puntajeActual = 0;
            _preguntaActual = 1;
            _cantidadPreguntasCorrectas = 0;
            _preguntas = null;
            _respuestas = null;
        }
        public static void CargarPartida(string username, int dificultad, int categoria)
        {
            _username= username;
            _preguntas = BD.ObtenerPreguntas(dificultad, categoria);
            _respuestas = BD.ObtenerRespuestas(_preguntas);
        } 
        public static Pregunta ObtenerProximaPregunta()
        {
            if(_preguntas.Count != 0)
            {
            Random num = new Random();
            return _preguntas[num.Next(_preguntas.Count)];
            }
            else
            {
                return null;
            }
        }
        public static List<Respuesta> ObtenerProximasRespuestas(int idPregunta)
        {
            List<Respuesta> prox = new List<Respuesta>();
            foreach(Respuesta resp in _respuestas)
            {
            if(resp.IdPregunta == idPregunta)
                {
                prox.Add(resp);
                }
            }
        return prox;       
        }
        public static bool VerificarRespuesta(int idPregunta, int idRespuesta)
        {
            bool correcto = false;
            Pregunta pregunta = null;

            foreach(Respuesta i in _respuestas)
            {
                if(idRespuesta==i.IdRespuesta && i.Correcta==true)
                {
                    _puntajeActual = _puntajeActual + 10;
                    _cantidadPreguntasCorrectas ++;
                    correcto = true;
                }
                
            } 
            foreach(Pregunta p in _preguntas)
            {
                if(idPregunta == p.IdPregunta)
                {
                    pregunta = p;
                }
            }
            if (pregunta != null){
                int pos = _preguntas.IndexOf(pregunta);
                _preguntas.RemoveAt(pos);
            }
            _preguntaActual++;
            return correcto;
        }
    }
}