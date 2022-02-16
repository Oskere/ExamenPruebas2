namespace Parejas
{
    public enum Rangos{
        MuyJoven,Joven,Plenitud,Madurez,Vejez
    }
    public class Persona
    {
        public Persona(string nombre, int edad, char sexo){
            this.nombre=nombre;
            this.edad=edad;
            this.sexo=sexo;
        }
        public string nombre {get; set;}
        public int edad {get; set;}

        public Rangos RangoEdad{ 
            get => edad switch{
                <20 => Rangos.MuyJoven,
                <30 => Rangos.Joven,
                <40 => Rangos.Plenitud,
                <50 => Rangos.Madurez,
                _ => Rangos.Vejez
            };
        }

        public char sexo {get;set;}

        public override string ToString() => $"<- Parejas posibles";
    }
}