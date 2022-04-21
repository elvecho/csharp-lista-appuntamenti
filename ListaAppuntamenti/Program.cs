// See https://aka.ms/new-console-template for more information
using ListaAppuntamenti;
Console.WriteLine("Hello, World!");
List<Appuntamento> listaDiAppuntamento = new List<Appuntamento>();
Console.WriteLine("quanti appuntamenti vuoi aggiungere?");
 int appuntamenti = int.Parse(Console.ReadLine());

for(int i = 0; i < appuntamenti; i++)
{

    Console.Write("Inserisci una data: ");
    string dataInserita = Console.ReadLine();

    DateTime dataUtente = DateTime.Parse(dataInserita);
    Console.Write("Inserisci il nome ");
    string nomeA = Console.ReadLine();

    Console.Write("Inserisci una località ");
    string località = Console.ReadLine();

    Appuntamento appuntamento = new Appuntamento(dataUtente, nomeA, località);
    listaDiAppuntamento.Add(appuntamento);


  appuntamento.NomeEsteso();
    Console.WriteLine("inserisci una nuova data");

    DateTime Nuovadata = DateTime.Parse(Console.ReadLine());
    appuntamento.Cambiadata(Nuovadata);

}
foreach (Appuntamento prodottoNellaLista in listaDiAppuntamento)
{
    Console.WriteLine(prodottoNellaLista.ToString());
}







