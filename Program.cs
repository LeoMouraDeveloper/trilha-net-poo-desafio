using DesafioPOO.Models;
using System.Collections.Generic;

List<Smartphone> aparelhos = new List<Smartphone>();

while (true)
{
    Console.WriteLine("\nO que deseja fazer?");
    Console.WriteLine("1 - Cadastrar aparelho");
    Console.WriteLine("2 - Listar aparelhos");
    Console.WriteLine("3 - Sair");
    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Qual smartphone deseja cadastrar? (1 - Nokia, 2 - iPhone)");
            string tipo = Console.ReadLine();

            switch (tipo)
            {
                case "1":
                    Console.WriteLine("Cadastro do smartphone Nokia:");
                    Console.Write("Digite o número: ");
                    string numeroNokia = Console.ReadLine();
                    Console.Write("Digite o modelo: ");
                    string modeloNokia = Console.ReadLine();
                    Console.Write("Digite o IMEI: ");
                    string imeiNokia = Console.ReadLine();
                    Console.Write("Digite a memória (GB): ");
                    int memoriaNokia = int.Parse(Console.ReadLine());

                    Nokia nokia = new Nokia(numero: numeroNokia, modelo: modeloNokia, imei: imeiNokia, memoria: memoriaNokia);
                    aparelhos.Add(nokia);
                    Console.WriteLine("Nokia cadastrado com sucesso!");
                    break;

                case "2":
                    Console.WriteLine("Cadastro do smartphone iPhone:");
                    Console.Write("Digite o número: ");
                    string numeroIphone = Console.ReadLine();
                    Console.Write("Digite o modelo: ");
                    string modeloIphone = Console.ReadLine();
                    Console.Write("Digite o IMEI: ");
                    string imeiIphone = Console.ReadLine();
                    Console.Write("Digite a memória (GB): ");
                    int memoriaIphone = int.Parse(Console.ReadLine());

                    Iphone iphone = new Iphone(numero: numeroIphone, modelo: modeloIphone, imei: imeiIphone, memoria: memoriaIphone);
                    aparelhos.Add(iphone);
                    Console.WriteLine("iPhone cadastrado com sucesso!");
                    break;

                default:
                    Console.WriteLine("Opção de aparelho inválida.");
                    break;
            }
            break;

        case "2":
            if (aparelhos.Count == 0)
            {
                Console.WriteLine("Nenhum aparelho cadastrado.");
            }
            else
            {
                Console.WriteLine("Aparelhos cadastrados:");
                foreach (var aparelho in aparelhos)
                {
                    string tipoAparelho = aparelho is Nokia ? "Nokia" : "iPhone";
                    Console.WriteLine($"{tipoAparelho} - Modelo: {aparelho.GetModelo()} - Memória: {aparelho.GetMemoria()}GB - Número: {aparelho.Numero}");
                }
            }
            break;

        case "3":
            Console.WriteLine("Encerrando o programa...");
            return;

        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
}


