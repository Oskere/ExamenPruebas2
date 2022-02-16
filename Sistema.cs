using System.Collections.Generic;
using System;

using System.Linq;
using Parejas;
namespace Parejas
{
    public class Sistema
    {
        public List<Persona> Personas { get; } = new()
        {
         new Persona("Javier",42,'M'),
         new Persona("Valeria",35,'F'),
         new Persona("Oscar",19,'M'),
         new Persona("Markel",14,'M'),
         new Persona("Pablo",42,'M'),
         new Persona("Maria Luisa",67,'F'),
         new Persona("Ender",18,'M'),
         new Persona("Ane",44,'F'),
         new Persona("Gandalf",94,'M'),
         new Persona("María",25,'F')   
        };

        public List<(Persona, Persona)> PosibleParejas(List<Persona> personas)
        {

            var parejas = new List<(Persona, Persona)>();

            for(int i=0; i<personas.Count-1;i++){
                for (int j=i+1; j<personas.Count;j++){
                    if (AdmitenDescendencia(personas[i],personas[j]))
                        parejas.Add((personas[i],personas[j]));
                }
            }
           
            return parejas;
        }


        public bool AdmitenDescendencia(Persona a, Persona b)
        {
            if(Math.Abs(a.RangoEdad-b.RangoEdad)<=1 && Math.Abs(a.edad-b.edad)<=12 && a.sexo!=b.sexo) 
                return true;
            return false;
        }

        public string Saludo(string nombre) => $"Saludos {nombre}!";


    }
}