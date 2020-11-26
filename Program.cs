using System;

namespace ProjetoPassagensAereas
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string [5];
            string[] origem = new string [5];
            string[] destino = new string [5];
            string[] data = new string [5];
            
            Console.Clear();
            Console.WriteLine("Sistema de Passagens Aéreas");
            Console.WriteLine("----------------------------");

            
            bool senhaValida = false;
            do{
                Console.Write("Digite sua senha: ");
                string senha = Console.ReadLine();
                senhaValida = EfetuarLogin(senha);
            } while (! senhaValida);
            Console.Clear();

            //Menu
            int escolha;
            int i = 0; //contador
            do
            {
                Console.WriteLine("Menu Inicial");
                Console.WriteLine("Selecione uma opção:");
                Console.WriteLine("[1] - Cadastrar Passagem");
                Console.WriteLine("[2] - Listar Passagens");
                Console.WriteLine("[0] - Sair");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                    //Cadastro de Passagem
                    string resposta;
                    
                        do
                        {
                            if (i < 5)
                            {
                                Console.Write($"Digite o nome do {i+1}° Passageiro: ");
                                nomes[i] = Console.ReadLine();
                                Console.Write($"Digite a origem do {i+1}° Passageiro: ");
                                origem[i] = Console.ReadLine();
                                Console.Write($"Digite o destino do {i+1}° Passageiro: ");
                                destino[i] = Console.ReadLine();
                                Console.Write($"Digite a data do voô do {i+1}° Passageiro: ");
                                data[i] = Console.ReadLine();
                                i++;
                            }else{
                               Console.WriteLine("Limite de passagens excedido"); 
                               break;
                            }
    
                            

                            Console.WriteLine("Gostaria de cadastrar um novo passageiro? (s/n)");
                            resposta = Console.ReadLine();
                        }while(resposta == "s");
                        break;
                    case 2:
                    //Listar Passagens
                        for (var cont = 0; cont < 5; cont++)
                        {
                            Console.WriteLine($"Passageiro {nomes[cont]}");
                            Console.WriteLine($"Voô {origem[cont]} para {destino[cont]}");
                            Console.WriteLine($"Data do Voô {data[cont]}");
                            Console.WriteLine("----------------------------------------------");
                        }
                        break;
                    case 0:
                    //Sair
                        Console.WriteLine("Obrigado, Volte sempre!");
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
                

            } while (escolha != 0);



            //Funções
            bool EfetuarLogin (string senha){
                if(senha == "123456"){
                    return true;

                }else{
                    Console.WriteLine("Senha Incorreta");
                    return false;
                }
            }

        }
    }
}
