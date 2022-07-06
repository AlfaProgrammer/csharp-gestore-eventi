// See https://aka.ms/new-console-template for more information


using GestoreEventi;

try
{
    var evento = new Evento("MioEvento", new DateTime(2012, 5, 12), 4512);
}
catch (Exception err)
{

    Console.WriteLine(err.Message);
}
