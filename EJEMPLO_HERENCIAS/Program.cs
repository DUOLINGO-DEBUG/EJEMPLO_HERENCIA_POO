namespace EJEMPLO_HERENCIAS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MAGO Mago1 = new MAGO("chala", 100, 2, "black_user.png", 50, "Visión Nocturna");

            Console.WriteLine("//ESTADISTICAS DEL PERSONAJE " + Mago1.Obtener_Nombre);
            Console.WriteLine("Nombre: " + Mago1.Obtener_Nombre);
            Console.WriteLine("Inteligencia" + Mago1.Obtener_inteligencia);
            Console.WriteLine("Skins: " + Mago1.Obtener_skins);
            Console.WriteLine("Magia: " + Mago1.Obtener_Magia);
            Console.WriteLine("Poción: " + Mago1.Obtener_Pociones);
            Console.WriteLine("");

            Mago1.Atacar();
            
            Console.WriteLine("");
            Console.WriteLine("////////////////////////////////////////////////////////////////");

            GUERRERO Guerrero1 = new GUERRERO("Casimiro", 100, 2, "white_user.png", 200, "Machete");

            Console.WriteLine("//ESTADISTICAS DEL PERSONAJE " + Guerrero1.Obtener_Nombre);
            Console.WriteLine("Nombre: " + Guerrero1.Obtener_Nombre);
            Console.WriteLine("Inteligencia" + Guerrero1.Obtener_inteligencia);
            Console.WriteLine("Skins: " + Guerrero1.Obtener_skins);
            Console.WriteLine("Fuerza: " + Guerrero1.Obtener_Fuerza);
            Console.WriteLine("Arma: " + Guerrero1.Obtener_Arma);
            Console.WriteLine("");

            Guerrero1.Atacar();


        }
    }
}
