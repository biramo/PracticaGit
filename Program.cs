using System;
namespace PracticaGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("Arnau",19);
            Salutador salutador = new Salutador();

            salutador.Saluda(persona);
        }
    }
}