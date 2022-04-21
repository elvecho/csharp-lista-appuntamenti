using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAppuntamenti
{
    internal class Appuntamento
    {
        public DateTime DataeOra;
        public string nome;
        public string località;

        public Appuntamento(DateTime DataeOra, string nome, string località)
        {
            this.DataeOra = DataeOra;
            this.nome = nome;
            this.località = località;
        }
        public virtual void NomeEsteso()
        {
            Console.WriteLine("l appuntamento: all ora: " + DataeOra + "nome: " + nome + " località: " + località);
        }
        public override string ToString()
        {
            string rappresentazioneInStringa = "";

            rappresentazioneInStringa += "---- appuntamento ---- \n";
            rappresentazioneInStringa += "Iva: " + this.DataeOra + "\n";
            rappresentazioneInStringa += "Nome: " + this.nome + "\n";
            rappresentazioneInStringa += "Descrizione: " + this.località + "\n";
           
           

            return rappresentazioneInStringa;
        }
        public void Cambiadata(DateTime Nuovadata)
        {
            DataeOra = Nuovadata;
            Console.WriteLine(DataeOra);
          
  
        }
    }
}
