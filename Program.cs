namespace SUAatualizado
{

    using System.Drawing;
    class Image
    {
        internal static Image FromFile(string v)
        {
            throw new NotImplementedException();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {  
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Image minhaImagem = Image.FromFile("LOGO.png");
            
            

            Console.Write("Por favor digite o seu nome: ");
            string nomedousuario1 = Console.ReadLine();

            Console.Write("Por favor digite o seu CPF: ");
            string cpf = Console.ReadLine();

            Console.Write("Por favor digite o seu endereço: ");
            string endereço = Console.ReadLine();

            Console.WriteLine("Por favor digite os seus sintomas: ");
            string sintomas = Console.ReadLine();

            Console.WriteLine("Escolha a cor de prioridade:");
            Console.WriteLine("1 - Vermelho - Emergência (Necessita atendimento imediato) ");
            Console.WriteLine("2 - Laranja - Muito Urgente (Necessita de atendomento praticamente imediato)");
            Console.WriteLine("3 - Amarelo - Urgente (Necessita de atendimento rápdio)");
            Console.WriteLine("4 - Verde - Pouco Urgente (Pode aguardar atendimento)");
            Console.WriteLine("5 - Azul - Não Urgente (Pode aguardar atendimento)");

            string Priodidadepaciente1 = Console.ReadLine();

            if (Priodidadepaciente1 == "1")
            {
                Console.WriteLine("Emergência");
            }
            else if (Priodidadepaciente1 == "2")
            {
                Console.WriteLine("Muito Urgente");
            }
            else if (Priodidadepaciente1 == "3")
            {
                Console.WriteLine("Urgente");
            }
            else if (Priodidadepaciente1 == "4")
            {
                Console.WriteLine("Pouco Urgente");
            }
            else if (Priodidadepaciente1 == "5")
            {
                Console.WriteLine("Não Urgente");
            }
            else
            {
                Console.WriteLine("Opição invalida");
            }

            Console.Clear();

            Console.Write("Seu nome é: " + nomedousuario1);
            Console.Write("Seu CPF é: " + cpf);
            Console.Write("Seu endereço é: " + endereço);
            Console.Write("Nível de prioridade do paciente " + nomedousuario1 + " é: " + Priodidadepaciente1);

            Console.Clear(); /// outra pessoa

            Console.Write("Por favor digite o seu nome: ");
            string nomedousuario2 = Console.ReadLine();

            Console.Write("Por favor digite o seu CPF: ");
            string cpf2 = Console.ReadLine();

            Console.Write("Por favor digite o seu endereço: ");
            string endereço2 = Console.ReadLine();

            Console.WriteLine("Por favor digite os seus sintomas: ");
            string sintomas2 = Console.ReadLine();

            Console.WriteLine("Escolha a cor de prioridade:");
            Console.WriteLine("1 - Vermelho - Emergência (Necessita atendimento imediato) ");
            Console.WriteLine("2 - Laranja - Muito Urgente (Necessita de atendomento praticamente imediato)");
            Console.WriteLine("3 - Amarelo - Urgente (Necessita de atendimento rápdio)");
            Console.WriteLine("4 - Verde - Pouco Urgente (Pode aguardar atendimento)");
            Console.WriteLine("5 - Azul - Não Urgente (Pode aguardar atendimento)");

            string Priodidadepaciente2 = Console.ReadLine();

            if (Priodidadepaciente2 == "1")
            {
                Console.WriteLine("Emergência");
            }
            else if (Priodidadepaciente2 == "2")
            {
                Console.WriteLine("Muito Urgente");
            }
            else if (Priodidadepaciente2 == "3")
            {
                Console.WriteLine("Urgente");
            }
            else if (Priodidadepaciente2 == "4")
            {
                Console.WriteLine("Pouco Urgente");
            }
            else if (Priodidadepaciente2 == "5")
            {
                Console.WriteLine("Não Urgente");
            }
            else
            {
                Console.WriteLine("Opição invalida");
            }

            Console.Clear();

            Console.Write("Seu nome é: " + nomedousuario2);
            Console.Write("Seu CPF é: " + cpf2);
            Console.Write("Seu endereço é: " + endereço2);
            Console.Write("Nível de prioridade do paciente " + nomedousuario2 + " é: " + Priodidadepaciente2);

            Console.Clear(); //Outra Pessoa

            Console.Write("Por favor digite o seu nome: ");
            string nomedousuario3 = Console.ReadLine();

            Console.Write("Por favor digite o seu CPF: ");
            string cpf3 = Console.ReadLine();

            Console.Write("Por favor digite o seu endereço: ");
            string endereço3 = Console.ReadLine();

            Console.WriteLine("Por favor digite os seus sintomas: ");
            string sintomas3 = Console.ReadLine();

            Console.WriteLine("Escolha a cor de prioridade:");
            Console.WriteLine("1 - Vermelho - Emergência (Necessita atendimento imediato)");
            Console.WriteLine("2 - Laranja - Muito Urgente (Necessita de atendomento praticamente imediato)");
            Console.WriteLine("3 - Amarelo - Urgente (Necessita de atendimento rápdi)");
            Console.WriteLine("4 - Verde - Pouco Urgente (Pode aguardar atendimento)");
            Console.WriteLine("5 -Azul - Não Urgente (Pode aguardar atendimento)");

            string Priodidadepaciente3 = Console.ReadLine();

            if (Priodidadepaciente3 == "1")
            {
                Console.WriteLine("Emergência");
            }
            else if (Priodidadepaciente3 == "2")
            {
                Console.WriteLine("Muito Urgente");
            }
            else if (Priodidadepaciente3 == "3")
            {
                Console.WriteLine("Urgente");
            }
            else if (Priodidadepaciente3 == "4")
            {
                Console.WriteLine("Pouco Urgente");
            }
            else if (Priodidadepaciente3 == "5")
            {
                Console.WriteLine("Não Urgente");
            }
            else
            {
                Console.WriteLine("Opição invalida");
            }

            Console.Clear();

            Console.Write("Seu nome é: " + nomedousuario3);
            Console.Write("Seu CPF é: " + cpf3);
            Console.Write("Seu endereço é: " + endereço3);
            Console.Write("Nível de prioridade do paciente " + nomedousuario3 + " é: " + Priodidadepaciente3);

            Console.Clear();// Outra pessoa

            Console.Write("Por favor digite o seu nome: ");
            string nomedousuario4 = Console.ReadLine();

            Console.Write("Por favor digite o seu CPF: ");
            string cpf4 = Console.ReadLine();

            Console.Write("Por favor digite o seu endereço: ");
            string endereço4 = Console.ReadLine();

            Console.WriteLine("Por favor digite os seus sintomas: ");
            string sintomas4 = Console.ReadLine();

            Console.WriteLine("Escolha a cor de prioridade:");
            Console.WriteLine("1 - Vermelho - Emergência (Necessita atendimento imediato)");
            Console.WriteLine("2 - Laranja - Muito Urgente (Necessita de atendomento praticamente imediato)");
            Console.WriteLine("3 - Amarelo - Urgente (Necessita de atendimento rápdio)");
            Console.WriteLine("4 - Verde - Pouco Urgente (Pode aguardar atendimento)");
            Console.WriteLine("5 - Azul - Não Urgente (Pode aguardar atendimento)");

            string Priodidadepaciente4 = Console.ReadLine();

            if (Priodidadepaciente4 == "1")
            {
                Console.WriteLine("Emergência");
            }
            else if (Priodidadepaciente4 == "2")
            {
                Console.WriteLine("Muito Urgente");
            }
            else if (Priodidadepaciente4 == "3")
            {
                Console.WriteLine("Urgente");
            }
            else if (Priodidadepaciente4 == "4")
            {
                Console.WriteLine("Pouco Urgente");
            }
            else if (Priodidadepaciente4 == "5")
            {
                Console.WriteLine("Não Urgente");
            }
            else
            {
                Console.WriteLine("Opição invalida");
            }

            Console.Clear();

            Console.Write("Seu nome é: " + nomedousuario4);
            Console.Write("Seu CPF é: " + cpf4);
            Console.Write("Seu endereço é: " + endereço4);
            Console.Write("Nível de prioridade do paciente " + nomedousuario4 + " é: " + Priodidadepaciente4);

            Console.Clear();//Outra pessoa

            Console.Write("Por favor digite o seu nome: ");
            string nomedousuario5 = Console.ReadLine();

            Console.Write("Por favor digite o seu CPF: ");
            string cpf5 = Console.ReadLine();

            Console.Write("Por favor digite o seu endereço: ");
            string endereço5 = Console.ReadLine();

            Console.WriteLine("Por favor digite os seus sintomas: ");
            string sintomas5 = Console.ReadLine();

            Console.WriteLine("Escolha a cor de prioridade:");
            Console.WriteLine("1 - Vermelho - Emergência (Necessita atendimento imediato)");
            Console.WriteLine("2 - Laranja - Muito Urgente (Necessita de atendomento praticamente imediato)");
            Console.WriteLine("3 - Amarelo - Urgente (Necessita de atendimento rápdio)");
            Console.WriteLine("4 - Verde - Pouco Urgente (Pode aguardar atendimento)");
            Console.WriteLine("5 - Azul - Não Urgente (Pode aguardar atendimento)");

            string Priodidadepaciente5 = Console.ReadLine();

            if (Priodidadepaciente5 == "1")
            {
                Console.WriteLine("Emergência");
            }
            else if (Priodidadepaciente5 == "2")
            {
                Console.WriteLine("Muito Urgente");
            }
            else if (Priodidadepaciente5 == "3")
            {
                Console.WriteLine("Urgente");
            }
            else if (Priodidadepaciente5 == "4")
            {
                Console.WriteLine("Pouco Urgente");
            }
            else if (Priodidadepaciente5 == "5")
            {
                Console.WriteLine("Não Urgente");
            }
            else
            {
                Console.WriteLine("Opição invalida");
            }

            Console.Clear();

            Console.Write("Seu nome é: " + nomedousuario5);
            Console.Write("Seu CPF é: " + cpf5);
            Console.Write("Seu endereço é: " + endereço5);
            Console.Write("Nível de prioridade do paciente " + nomedousuario5 + " é: " + Priodidadepaciente5);

            Console.Clear();//finaliza

            Console.WriteLine("Por favor escolha qual usuário vc deseja verificar: ");
            Console.WriteLine(nomedousuario1);
            Console.WriteLine(nomedousuario2);
            Console.WriteLine(nomedousuario3);
            Console.WriteLine(nomedousuario4);
            Console.WriteLine(nomedousuario5);

            string escolha = Console.ReadLine();

            if (escolha == nomedousuario1)
            {
                Console.Clear();
                Console.WriteLine(nomedousuario1);
                Console.WriteLine("CPF do paciente: " + cpf);
                Console.WriteLine("Seu endereço do paciente: " + endereço);
                Console.WriteLine("Sintomas do paciente: " + sintomas);
                Console.WriteLine("Por favor digite o relatório médico: ");
                string relatoriomédico1dopaciente1 = Console.ReadLine();

                Console.WriteLine("Escolha:");
                Console.WriteLine("Encaminhar para exame.");
                Console.WriteLine("Terminar a consulta médica.");

                string paciente1escolha1 = Console.ReadLine();

                if (paciente1escolha1 == "Encaminhar para exame")
                {
                    Console.Clear();
                    Console.WriteLine(nomedousuario1);
                    Console.WriteLine("CPF do paciente: " + cpf);
                    Console.WriteLine("Seu endereço do paciente: " + endereço);
                    Console.WriteLine("Sintomas do paciente: " + sintomas);
                    Console.WriteLine("Relatório médico:\n" + relatoriomédico1dopaciente1);
                    Console.WriteLine("Por favor digite o relatório do exame: ");
                    string relatoriodoexame1 = Console.ReadLine();

                    Console.WriteLine("Escolha:");
                    Console.WriteLine("Voltar para consulta médica");
                    Console.WriteLine("Finalizar atendimento");

                    string pacienteescolha01 = Console.ReadLine();

                    if (pacienteescolha01 == "Voltar para consulta médica")
                    {
                        Console.Clear();
                        Console.WriteLine(nomedousuario1);
                        Console.WriteLine("CPF do paciente: " + cpf);
                        Console.WriteLine("Seu endereço do paciente: " + endereço);
                        Console.WriteLine("Sintomas do paciente: " + sintomas);
                        Console.WriteLine("Relatório médico:\n" + relatoriomédico1dopaciente1);
                        Console.WriteLine("Relatório do exame:\n " + relatoriodoexame1);
                        Console.WriteLine("Por favor digite o relátório da segunda consulta médica: ");
                        string relatoriomédicodopacinte01 = Console.ReadLine();
                    }
                    else if (pacienteescolha01 == "Finalizar atendimento")
                    {
                        Console.WriteLine("Atendimento finalizado");
                    }
                    else
                    {
                        Console.WriteLine("Opição invalida");
                    }

                }
                else if (paciente1escolha1 == "Terminar a consulta médica")
                {
                    Console.WriteLine("Consulta finalizada");
                }
                else
                {
                    Console.WriteLine("Opição invalida");
                }
            }
            else if (escolha == nomedousuario2)
            {
                Console.Clear();
                Console.WriteLine(nomedousuario2);
                Console.WriteLine("CPF do paciente: " + cpf2);
                Console.WriteLine("Seu endereço do paciente: " + endereço2);
                Console.WriteLine("Sintomas do paciente: " + sintomas2);
                Console.WriteLine("Por favor digite o relatório médico: ");
                string relatoriomédico1dopaciente2 = Console.ReadLine();

                Console.WriteLine("Escolha:");
                Console.WriteLine("Encaminhar para exame.");
                Console.WriteLine("Terminar a consulta médica.");

                string paciente1escolha2 = Console.ReadLine();

                if (paciente1escolha2 == "Encaminhar para exame")
                {
                    Console.Clear();
                    Console.WriteLine(nomedousuario2);
                    Console.WriteLine("CPF do paciente: " + cpf2);
                    Console.WriteLine("Seu endereço do paciente: " + endereço2);
                    Console.WriteLine("Sintomas do paciente: " + sintomas2);
                    Console.WriteLine("Relatório médico:\n" + relatoriomédico1dopaciente2);
                    Console.WriteLine("Por favor digite o relatório do exame: ");
                    string relatoriodoexame2 = Console.ReadLine();

                    Console.WriteLine("Escolha:");
                    Console.WriteLine("Voltar para consulta médica");
                    Console.WriteLine("Finalizar atendimento");

                    string pacienteescolha02 = Console.ReadLine();

                    if (pacienteescolha02 == "Voltar para consulta médica")
                    {
                        Console.Clear();
                        Console.WriteLine(nomedousuario2);
                        Console.WriteLine("CPF do paciente: " + cpf);
                        Console.WriteLine("Seu endereço do paciente: " + endereço);
                        Console.WriteLine("Sintomas do paciente: " + sintomas);
                        Console.WriteLine("Relatório médico:\n" + relatoriomédico1dopaciente2);
                        Console.WriteLine("Relatório do exame:\n " + relatoriodoexame2);
                        Console.WriteLine("Por favor digite o relátório da segunda consulta médica: ");
                        string relatoriomédicodopacinte02 = Console.ReadLine();
                    }
                    else if (pacienteescolha02 == "Finalizar atendimento")
                    {
                        Console.WriteLine("Atendimento finalizado");
                    }
                    else
                    {
                        Console.WriteLine("Opição invalida");
                    }

                }
                else if (paciente1escolha2 == "Terminar a consulta médica")
                {
                    Console.WriteLine("Consulta finalizada");
                }
                else
                {
                    Console.WriteLine("Opição invalida");
                }
            }
            else if (escolha == nomedousuario3)
            {
                Console.Clear();
                Console.WriteLine(nomedousuario3);
                Console.WriteLine("CPF do paciente: " + cpf3);
                Console.WriteLine("Seu endereço do paciente: " + endereço3);
                Console.WriteLine("Sintomas do paciente: " + sintomas3);
                Console.WriteLine("Por favor digite o relatório médico: ");
                string relatoriomédico1dopaciente3 = Console.ReadLine();

                Console.WriteLine("Escolha:");
                Console.WriteLine("Encaminhar para exame.");
                Console.WriteLine("Terminar a consulta médica.");

                string paciente1escolha3 = Console.ReadLine();

                if (paciente1escolha3 == "Encaminhar para exame")
                {
                    Console.Clear();
                    Console.WriteLine(nomedousuario3);
                    Console.WriteLine("CPF do paciente: " + cpf3);
                    Console.WriteLine("Seu endereço do paciente: " + endereço3);
                    Console.WriteLine("Sintomas do paciente: " + sintomas3);
                    Console.WriteLine("Relatório médico:\n" + relatoriomédico1dopaciente3);
                    Console.WriteLine("Por favor digite o relatório do exame: ");
                    string relatoriodoexame3 = Console.ReadLine();

                    Console.WriteLine("Escolha:");
                    Console.WriteLine("Voltar para consulta médica");
                    Console.WriteLine("Finalizar atendimento");

                    string pacienteescolha03 = Console.ReadLine();

                    if (pacienteescolha03 == "Voltar para consulta médica")
                    {
                        Console.Clear();
                        Console.WriteLine(nomedousuario3);
                        Console.WriteLine("CPF do paciente: " + cpf);
                        Console.WriteLine("Seu endereço do paciente: " + endereço);
                        Console.WriteLine("Sintomas do paciente: " + sintomas);
                        Console.WriteLine("Relatório médico:\n" + relatoriomédico1dopaciente3);
                        Console.WriteLine("Relatório do exame:\n " + relatoriodoexame3);
                        Console.WriteLine("Por favor digite o relátório da segunda consulta médica: ");
                        string relatoriomédicodopacinte03 = Console.ReadLine();
                    }
                    else if (pacienteescolha03 == "Finalizar atendimento")
                    {
                        Console.WriteLine("Atendimento finalizado");
                    }
                    else
                    {
                        Console.WriteLine("Opição invalida");
                    }

                }
                else if (paciente1escolha3 == "Terminar a consulta médica")
                {
                    Console.WriteLine("Consulta finalizada");
                }
                else
                {
                    Console.WriteLine("Opição invalida");
                }
            }
            else if (escolha == nomedousuario4)
            {
                Console.Clear();
                Console.WriteLine(nomedousuario4);
                Console.WriteLine("CPF do paciente: " + cpf4);
                Console.WriteLine("Seu endereço do paciente: " + endereço4);
                Console.WriteLine("Sintomas do paciente: " + sintomas4);
                Console.WriteLine("Por favor digite o relatório médico: ");
                string relatoriomédico1dopaciente4 = Console.ReadLine();

                Console.WriteLine("Escolha:");
                Console.WriteLine("Encaminhar para exame.");
                Console.WriteLine("Terminar a consulta médica.");

                string paciente1escolha4 = Console.ReadLine();

                if (paciente1escolha4 == "Encaminhar para exame")
                {
                    Console.Clear();
                    Console.WriteLine(nomedousuario4);
                    Console.WriteLine("CPF do paciente: " + cpf4);
                    Console.WriteLine("Seu endereço do paciente: " + endereço4);
                    Console.WriteLine("Sintomas do paciente: " + sintomas4);
                    Console.WriteLine("Relatório médico:\n" + relatoriomédico1dopaciente4);
                    Console.WriteLine("Por favor digite o relatório do exame: ");
                    string relatoriodoexame4 = Console.ReadLine();

                    Console.WriteLine("Escolha:");
                    Console.WriteLine("Voltar para consulta médica");
                    Console.WriteLine("Finalizar atendimento");

                    string pacienteescolha04 = Console.ReadLine();

                    if (pacienteescolha04 == "Voltar para consulta médica")
                    {
                        Console.Clear();
                        Console.WriteLine(nomedousuario4);
                        Console.WriteLine("CPF do paciente: " + cpf4);
                        Console.WriteLine("Seu endereço do paciente: " + endereço4);
                        Console.WriteLine("Sintomas do paciente: " + sintomas4);
                        Console.WriteLine("Relatório médico:\n" + relatoriomédico1dopaciente4);
                        Console.WriteLine("Relatório do exame:\n " + relatoriodoexame4);
                        Console.WriteLine("Por favor digite o relátório da segunda consulta médica: ");
                        string relatoriomédicodopacinte03 = Console.ReadLine();
                    }
                    else if (pacienteescolha04 == "Finalizar atendimento")
                    {
                        Console.WriteLine("Atendimento finalizado");
                    }
                    else
                    {
                        Console.WriteLine("Opição invalida");
                    }
                }
                else if (escolha == nomedousuario5)
                {
                    Console.Clear();
                    Console.WriteLine(nomedousuario5);
                    Console.WriteLine("CPF do paciente: " + cpf5);
                    Console.WriteLine("Seu endereço do paciente: " + endereço5);
                    Console.WriteLine("Sintomas do paciente: " + sintomas5);
                    Console.WriteLine("Por favor digite o relatório médico: ");
                    string relatoriomédico1dopaciente5 = Console.ReadLine();

                    Console.WriteLine("Escolha:");
                    Console.WriteLine("Encaminhar para exame.");
                    Console.WriteLine("Terminar a consulta médica.");

                    string paciente1escolha5 = Console.ReadLine();

                    if (paciente1escolha5 == "Encaminhar para exame")
                    {
                        Console.Clear();
                        Console.WriteLine(nomedousuario5);
                        Console.WriteLine("CPF do paciente: " + cpf5);
                        Console.WriteLine("Seu endereço do paciente: " + endereço5);
                        Console.WriteLine("Sintomas do paciente: " + sintomas5);
                        Console.WriteLine("Relatório médico:\n" + relatoriomédico1dopaciente5);
                        Console.WriteLine("Por favor digite o relatório do exame: ");
                        string relatoriodoexame5 = Console.ReadLine();

                        Console.WriteLine("Escolha:");
                        Console.WriteLine("Voltar para consulta médica");
                        Console.WriteLine("Finalizar atendimento");

                        string pacienteescolha05 = Console.ReadLine();

                        if (pacienteescolha05 == "Voltar para consulta médica")
                        {
                            Console.Clear();
                            Console.WriteLine(nomedousuario5);
                            Console.WriteLine("CPF do paciente: " + cpf5);
                            Console.WriteLine("Seu endereço do paciente: " + endereço5);
                            Console.WriteLine("Sintomas do paciente: " + sintomas5);
                            Console.WriteLine("Relatório médico:\n" + relatoriomédico1dopaciente5);
                            Console.WriteLine("Relatório do exame:\n " + relatoriodoexame5);
                            Console.WriteLine("Por favor digite o relátório da segunda consulta médica: ");
                            string relatoriomédicodopacinte05 = Console.ReadLine();
                        }
                        else if (pacienteescolha05 == "Finalizar atendimento")
                        {
                            Console.WriteLine("Atendimento finalizado");
                        }
                        else
                        {
                            Console.WriteLine("Opição invalida");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Opição invalida");
                    }

                    Console.Write("akamdskma");
                    Console.ReadKey(true);
                }
            }
        }

    }
}
        