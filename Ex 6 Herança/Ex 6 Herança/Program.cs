using Ex_6_Herança;

Gato gato1 = new Gato
{
    Especie = "Felino"
};

Console.WriteLine("A especie do gato é uma especie de:" + gato1.Especie);
gato1.EmitirSom();

Cachorro cachorro1 = new Cachorro
{
    Especie = "Mamifero"
};

Console.WriteLine("\nA especie do cachorro é uma especie de:" + cachorro1.Especie);
cachorro1.EmitirSom();

Gaviao gaviao1 = new Gaviao
{
    Especie = "Ave"
};

Console.WriteLine("\nO gaviao  é uma especie de:" + gaviao1.Especie);
gaviao1.EmitirSom();

Console.ReadKey();
