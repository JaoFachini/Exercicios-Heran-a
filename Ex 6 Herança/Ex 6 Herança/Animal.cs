namespace Ex_6_Herança
{
    public abstract class Animal
    {
        public string Especie { get; set; }

        public abstract void EmitirSom();
    }

    public class Gato : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Miau! Miau!");
        }
    }

    public class Cachorro : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Oink! Oink!");
        }
    }

    public class Gaviao : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Ahn! Ahn!");
        }
    }
}
