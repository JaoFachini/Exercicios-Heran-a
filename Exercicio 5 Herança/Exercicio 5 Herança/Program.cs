using Exercicio_5_Herança;

//instancia uma classe
using Exercicio_5_Herança;

Funcionario func1 = new Funcionario { Nome = "Joao", Idade = 18 };
Funcionario func2 = new Funcionario { Nome = "Vinicius", Idade = 17 };
Funcionario func3 = new Funcionario { Nome = "Livia", Idade = 16 };
Funcionario funcN = new Funcionario { Nome = "Joao", Idade = 18 };
Funcionario funcN2 = new Funcionario { Nome = "Vinicius", Idade = 17 };
Funcionario funcN3 = new Funcionario { Nome = "Livia", Idade = 17 };

//chama o metodo enelhecer 

func1.Envelhecer(10);//somar a idade que voce passou para a variavel func1 mais 10
func2.Envelhecer(10);
func3.Envelhecer(10);

funcN.Rejunelhecer(6);
funcN2.Rejunelhecer(6);
funcN3.Rejunelhecer(6);

//exibindo as informaçoes  dos funcionarios
Console.WriteLine($"\nNome: {func1.Nome} \nIdade envelhecer: {func1.Idade} \n idade rejuvelhecer {funcN.Idade} ");
Console.WriteLine($"\nNome: {func2.Nome} \nIdade envelhecer: {func2.Idade} \n idade rejuvelhecer {funcN2.Idade} ");
Console.WriteLine($"\nNome: {func3.Nome} \nIdade envelhecer: {func3.Idade} \n idade rejuvelhecer {funcN3.Idade} ");


Console.ReadKey();

