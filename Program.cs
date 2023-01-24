using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Escolha a opção de smartphone:");
Console.WriteLine("Digite 1 - Nokia");
Console.WriteLine("Digite 2 - Iphone");
int opcao = int.Parse(Console.ReadLine());

Console.Write("Informe o número do celular: ");
string numero = Console.ReadLine();
Console.Write("Informe o modelo: ");
string modelo = Console.ReadLine();
Console.Write("Informe o IMEI: ");
string imei = Console.ReadLine();
Console.Write("Informe a capacidade de memória: ");
int memoria = int.Parse(Console.ReadLine());

if (opcao == 1)
{
    Console.WriteLine($"Smartphone Nokia. Numero: {numero}, Modelo: {modelo}, IMEI: {imei}, Memoria: {memoria}");
    Smartphone nokia = new Nokia(numero, modelo, imei, memoria);
    nokia.Ligar();
    nokia.InstalarAplicativo("Instagram");
}
else if (opcao == 2)
{
    Console.WriteLine($"Smartphone Iphone. Numero: {numero}, Modelo: {modelo}, IMEI: {imei}, Memoria: {memoria}");
    Smartphone iphone = new Iphone(numero, modelo, imei, memoria);
    iphone.Ligar();
    iphone.InstalarAplicativo("Facebook");
}

