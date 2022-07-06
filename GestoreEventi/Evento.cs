using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    class Evento
    {
        private string _titolo;
        private DateTime _date;
        public string Titolo
        {
            get
            {
                return this._titolo;
            }

            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    this._titolo = value;
                }
                else
                {
                    throw new Exception("Il titolo non può essere Nullo o Vuoto");
                }
            }
        }
        public DateTime Data { 
            get
            {
                return this._date;
            }
            set
            {
                var currentDate = DateTime.Now;
                var comparison = value.CompareTo(currentDate);
                if( comparison == -1)
                {
                    throw new Exception("Hai impostato la data nel passato");
                }
                else
                {
                    this._date = value;
                }
            }       
        }

        public uint Capienza { get; }
        public int PostiPrenotati { get;}

        public Evento(string titolo, DateTime data, uint capienza )
        {
            this.Titolo = titolo;
            this.Data = data;
            this.Capienza = capienza;
            this.PostiPrenotati = 0;
        }
    }
}
