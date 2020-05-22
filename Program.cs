using System;

namespace Veiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro[] carros = new Carro[300];
            Caminhao[] caminhoes = new Caminhao[200];
            int x, cadastroCarro=0, CadastroCaminhao=0, opcao = 1;
            string strProcura;

            do
            {
                Console.Clear();
                Console.WriteLine("------------------Gestão de veiculos-------------\n1-Cadastrar Carro\n2-Cadastrar Caminhão\n3-Consulta por Placa\n4-Consulta Camihão " +
                    "por Modelo\nConsulta Carro por cor \nExibir todos os carros cadastrados\n7Exibir todos os Caminhões cadastrados\n0-Sair");
                opcao = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Cadastro carro");
                        if (cadastroCarro < 300)
                        {
                            carros[cadastroCarro] = new Carro();
                            Console.Write("Modelo: ");
                            carros[cadastroCarro].Modelo = Console.ReadLine();
                            Console.Write("\nFabricante: ");
                            carros[cadastroCarro].Fabricante = Console.ReadLine();
                            Console.Write("\nPlaca: ");
                            carros[cadastroCarro].Placa = Console.ReadLine();
                            Console.Write("\nAno");
                            carros[cadastroCarro].Ano = int.Parse(Console.ReadLine());
                            Console.Write("\nCor");
                            carros[cadastroCarro].Cor = Console.ReadLine();
                            Console.Write("\nQuantidades de Portas: ");
                            carros[cadastroCarro].Numero_portas = int.Parse(Console.ReadLine());
                            Console.Write("\nCapacidade porta malas: ");
                            carros[cadastroCarro].Mala = int.Parse(Console.ReadLine());
                            Console.Write("\nBagageiro, 1-Sim 2Não: ");
                            carros[cadastroCarro].Bagageiro = Convert.ToBoolean(int.Parse(Console.ReadLine()));
                            Console.Write("\nTipo de combustivel: ");
                            carros[cadastroCarro].Combustivel = Console.ReadLine();
                            cadastroCarro++;
                        }
                        else
                        {
                            Console.WriteLine("Banco de Dados Cheio !!!");
                            Console.ReadKey();
                        }
                        break;

                    case 2:
                        {
                            Console.WriteLine("Cadastrar caminhão");

                            if (CadastroCaminhao < 200)
                            {
                                caminhoes[CadastroCaminhao] = new Caminhao();
                                Console.WriteLine("Modelo: ");
                                caminhoes[CadastroCaminhao].Modelo = Console.ReadLine();
                                Console.WriteLine("Fabricante: ");
                                caminhoes[CadastroCaminhao].Fabricante = Console.ReadLine();
                                Console.WriteLine("Placa: ");
                                caminhoes[CadastroCaminhao].Placa = Console.ReadLine();
                                Console.WriteLine("Ano: ");
                                caminhoes[CadastroCaminhao].Ano = int.Parse(Console.ReadLine());
                                Console.WriteLine("Cor: ");
                                caminhoes[CadastroCaminhao].Cor = Console.ReadLine();
                                Console.WriteLine("Numero de Portas: ");
                                caminhoes[CadastroCaminhao].Numero_portas = int.Parse(Console.ReadLine());
                                Console.WriteLine("Numero de eixos: ");
                                caminhoes[CadastroCaminhao].Numero_eixos = int.Parse(Console.ReadLine());
                                Console.WriteLine("Peso maximo de Carga: ");
                                caminhoes[CadastroCaminhao].Peso = double.Parse(Console.ReadLine());
                                Console.WriteLine("Tipo de carreta: ");
                                caminhoes[CadastroCaminhao].Carreta = Console.ReadLine();
                                cadastroCarro++;
                            }
                            else
                            {
                                Console.WriteLine("Banco de Dados cheio !!!");
                                Console.ReadKey();

                            }
                        }
                        break;

                    case 3:
                        {
                            Console.WriteLine("Consulta por placa ");
                            if(cadastroCarro>0 || CadastroCaminhao > 0)
                            {
                                Console.WriteLine("Placa: ");
                                strProcura = Console.ReadLine();
                                Console.WriteLine("Modelo   Fabricate   Placa   Ano     Cor     Portas");
                                for (x = 0; x < cadastroCarro; x++)
                                {
                                    if (carros[x].Placa == strProcura)
                                    {
                                        Console.WriteLine("{0,-10}  {1,-10}   {2,-8}    {3,4}   {4,-10} {5,6}",
                                            carros[x].Modelo, carros[x].Fabricante, carros[x].Placa, carros[x].Ano, carros[x].Cor, carros[x].Numero_portas);
                                    }
                                }
                                for (x=0; x<CadastroCaminhao; x++)
                                {
                                    if (caminhoes[x].Placa == strProcura)
                                    {
                                        Console.WriteLine("{0,-10} {1,-10}  {2,-8}  {3,4}  {4,-10}  {5,6}",
                                            caminhoes[x].Modelo, caminhoes[x].Fabricante, caminhoes[x].Placa, caminhoes[x].Placa, caminhoes[x].Ano, caminhoes[x].Cor, caminhoes[x].Numero_portas);

                                    }
                                }
                                Console.ReadKey();
                            }
                        }break;

                    case 4:
                        {
                            Console.Write("\nModelo/Marca a procurar: ");
                            strProcura = Console.ReadLine();
                            Console.WriteLine("Modelo   fabricante   placa    ano   cor  portas   eixos  carga   carreta ");

                            if (CadastroCaminhao > 0)
                            {
                                for (x = 0; x < CadastroCaminhao; x++)
                                {
                                    if (caminhoes[x].Modelo == strProcura || caminhoes[x].Fabricante == strProcura)
                                    {
                                        Console.WriteLine("{0,-10}   {1,-10}  {2,-8}  {3,4}  4,-10}  {5,6}  {6,5}  {7,5}  {8}", caminhoes[x].Modelo, caminhoes[x].Fabricante, caminhoes[x].Placa, caminhoes[x].Ano, caminhoes[x].Peso, caminhoes[x].Carreta);
                                    }
                                    Console.ReadKey();
                                }
                            }

                            else
                            {
                                Console.WriteLine("Banco de dados vazio !!!");
                            }
                            
                            Console.ReadKey();
                        }break;

                    case 5:
                        {
                            Console.WriteLine("Consulta por cor");
                            if (cadastroCarro > 0)
                            {
                                Console.WriteLine("Cor a procurar: ");
                                strProcura = Console.ReadLine();
                                Console.WriteLine("Modelo  Fabricante   Placa   Cor   Portas  P.malas   Bagageiro  Combustivel");
                                
                                for(x=0; x<cadastroCarro; x++)
                                {
                                    if (carros[x].Cor == strProcura)
                                    {
                                        Console.WriteLine("{0,-10}  {1,-10}  {2,-8}   {3,4}  {4,-10}  {5,6}  {6,7}  {7,9}  {8}", carros[x].Modelo, carros[x].Fabricante, carros[x].Placa, carros[x].Ano, carros[x].Cor, carros[x].Numero_portas, carros[x].Mala, carros[x].Bagageiro, carros[x].Combustivel);

                                    }
                                }
                                Console.ReadKey();
                            }
                            else { Console.WriteLine("Banco de dados vazio !!!");
                                Console.ReadKey();
                            }
                            
                        }
                        break;

                    case 6:
                        {
                            Console.WriteLine("Exibir todos os carros cadastrados ");

                            if (cadastroCarro > 0)
                            {
                                Console.WriteLine("Modelo  Fabricante   Placa  Ano   Cor  Portas  P.malas  Bagageiro  Combustivel ");

                                for(x=0; x<cadastroCarro; x++)
                                {
                                    Console.WriteLine("{0,-10}  {1,-10} {2,-8}  {3,4}  {4,-10}  {5,6}  {6,7} {7,9}  {8}", carros[x].Modelo, carros[x].Fabricante, carros[x].Placa, carros[x].Ano, carros[x].Cor, carros[x].Numero_portas, carros[x].Mala, carros[x].Bagageiro, carros[x].Combustivel);

                                }Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("Banco de dados Vazio!!!");
                                Console.ReadKey();
                            }

                        }break;

                    case 7:
                        {
                            Console.WriteLine("exibir todos os caminhões cadastrados ");

                            if (CadastroCaminhao > 0)
                            {
                                Console.WriteLine("Modelo  Fabricante  Placa  Cor  Portas  Carreta  N.eixos  Peso de carga  ");
                                for(x=0; x<CadastroCaminhao; x++)
                                {
                                    Console.WriteLine("{0,-10}  {1,-10}  {2,-8}  {3,4}  {4,10}  {5,6}  {6,5}  {7,5} {8}", caminhoes[x].Modelo, caminhoes[x].Fabricante, caminhoes[x].Placa, caminhoes[x].Ano, caminhoes[x].Cor, caminhoes[x].Numero_portas, caminhoes[x].Carreta, caminhoes[x].Numero_eixos, caminhoes[x].Peso) ;
                                }
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("Banco de dados vazio !!!");
                                Console.ReadKey();
                            }

                        }break;
                }
            } while (opcao != 0);
        }
    }
}
