using System;

class MainClass { 
  public static void Main (string[] args) {
    int tipoCliente = 0; 
    VooComercial boingComercial = new VooComercial(20520,"Vitória", "São Paulo", "8:00h", "11:00h","21/06/2020",5,300f);
    VooEmpresarial boingEmpresarial = new VooEmpresarial(20600,"Vitória", "Rio de Janeiro", "13:00h", "14:00h", "22/06/2020",4);
    VooParticular boingParticular = new VooParticular(20707, "Vitória", "Estados Unidos", "20:00", "03:00", "23/06/2020",1000f,"5 dias",5);

    int sair = 1;

    while(sair ==1){
      Console.WriteLine("Bem vindo ao Sistema de reserva de passagens! \n Para darmos proseguimento favor inserir seus dados: ");
      Console.WriteLine($"1. Para Pessoa Fisica\n" + $"2. Para Pessoa Juridica\n");
      tipoCliente = int.Parse(Console.ReadLine());
  
      switch(tipoCliente){
        //Case pessoa Fisica
        case 1:
          PessoaFisica passageiroF = new PessoaFisica();
          Console.WriteLine("Digite seu nome: ");
          string nome = Console.ReadLine();
          passageiroF.setNome(nome);
          Console.WriteLine("Digite seu CPF: ");
          string cpf = Console.ReadLine();
          Console.WriteLine("Digite sua Idade: ");
          int idade = int.Parse(Console.ReadLine());
          Console.WriteLine("Digite seu Telefone: ");
          string telefone = Console.ReadLine();
          Console.WriteLine("Digite seu Email: ");
          string email = Console.ReadLine();
          Console.WriteLine("Qual o tipo de Voo desejado?");
          Console.WriteLine($"1. Voo Comercial\n" + $"2. Voo Particular\n");
          int tipoVoo = int.Parse(Console.ReadLine());

          switch(tipoVoo){
            //Case Voo Comercial
            case 1:
              Console.WriteLine("Deseja confirmar a compra da passagem com destino a " + boingComercial.getAeroportoChegada() +" com valor de R$"+boingComercial.getValor() +",00 ?");
              Console.WriteLine($"1. Para sim\n" + $"2. Para não\n");
              int continuar = int.Parse(Console.ReadLine());
              if(continuar==1){
                boingComercial.reservar();
                Console.WriteLine("Saída: " + boingComercial.getAeroportoSaida());
                Console.WriteLine("Destino: " + boingComercial.getAeroportoChegada());
                Console.WriteLine("Nome: " + passageiroF.getNome());
                Console.WriteLine("Data: " + boingComercial.getDataVoo());
                Console.WriteLine("Horario de Saída: " + boingComercial.getHoraSaida());
                Console.WriteLine("Previsão de Chegada: " + boingComercial.getHoraChegada());
                Console.WriteLine("Número do Voo: " + boingComercial.getNumeroVoo());
                Console.WriteLine("\nDeseja continuar a compra de mais passagens?\n");
                Console.WriteLine($"1. Para sim\n" + $"2. Para não\n");
                continuar = int.Parse(Console.ReadLine());
                  if(continuar == 1){

                  }else{
                    Console.WriteLine("Obrigado por comprar com a gente, volte sempre!");
                    sair = 2;
                  }

                }else{
                  Console.WriteLine("Obrigado por utilizar nosso sistema, volte sempre!");
                  sair = 2;
                }

                break;
            //Case Voo Particular
            case 2:
              Console.WriteLine("Deseja confirmar a compra da passagem com destino a " + boingParticular.getAeroportoChegada() +" com valor de R$"+boingParticular.getPrecoDia() +",00 ?");
              Console.WriteLine($"1. Para sim\n" + $"2. Para não\n");
              int prosseguir = int.Parse(Console.ReadLine());
              if(prosseguir==1){
                boingParticular.reservar2();
                Console.WriteLine("Saída: " + boingParticular.getAeroportoSaida());
                Console.WriteLine("Destino: " + boingParticular.getAeroportoChegada());
                Console.WriteLine("Nome: " + passageiroF.getNome());
                Console.WriteLine("Data: " + boingParticular.getDataVoo());
                Console.WriteLine("Horario de Saída: " + boingParticular.getHoraSaida());
                Console.WriteLine("Previsão de Chegada: " + boingParticular.getHoraChegada());
                Console.WriteLine("Número do Voo: " + boingParticular.getNumeroVoo());
                Console.WriteLine("\nDeseja continuar a compra de mais passagens?\n");
                Console.WriteLine($"1. Para sim\n" + $"2. Para não\n");
                prosseguir = int.Parse(Console.ReadLine());
                  if(prosseguir == 1){

                  }else{
                    Console.WriteLine("Obrigado por comprar com a gente, volte sempre!");
                    sair = 2;
                  }

                }else{
                  Console.WriteLine("Obrigado por utilizar nosso sistema, volte sempre!");
                  sair = 2;
                }
                break;
   
        
            }

            break;
        //Case pessoa Juridica 
        case 2:
          PessoaJuridica passageiroJ = new PessoaJuridica();
          Console.WriteLine("Digite o nome da sua empresa: ");
          string nomeEmpresa = Console.ReadLine();
          passageiroJ.setNome(nomeEmpresa);
          Console.WriteLine("Digite o CNPJ de sua empresa: ");
          string cnpj = Console.ReadLine();
          Console.WriteLine("Digite sua Idade: ");
          int idadeJ = int.Parse(Console.ReadLine());
          Console.WriteLine("Digite seu Telefone: ");
          string telefoneJ = Console.ReadLine();
          Console.WriteLine("Digite seu Email: ");
          string emailJ = Console.ReadLine();
          Console.WriteLine("Qual o tipo de Voo desejado?");
          Console.WriteLine($"1. Voo Empresarial\n" + $"2. Voo Particular\n");
          int tipoVooJ = int.Parse(Console.ReadLine());

          switch(tipoVooJ){
            //Case Voo Empresarial - Juridica
            case 1:
              Console.WriteLine("Deseja confirmar a compra da passagem com destino a " + boingEmpresarial.getAeroportoChegada());
              Console.WriteLine($"1. Para sim\n" + $"2. Para não\n");
              int seguir = int.Parse(Console.ReadLine());
              if(seguir==1){
                boingEmpresarial.reservar3();
                Console.WriteLine("Saída: " + boingEmpresarial.getAeroportoSaida());
                Console.WriteLine("Destino: " + boingEmpresarial.getAeroportoChegada());
                Console.WriteLine("Nome: " + passageiroJ.getNome());
                Console.WriteLine("Data: " + boingEmpresarial.getDataVoo());
                Console.WriteLine("Horario de Saída: " + boingEmpresarial.getHoraSaida());
                Console.WriteLine("Previsão de Chegada: " + boingEmpresarial.getHoraChegada());
                Console.WriteLine("Número do Voo: " + boingEmpresarial.getNumeroVoo());
                Console.WriteLine("\nDeseja continuar a compra de mais passagens?\n");
                Console.WriteLine($"1. Para sim\n" + $"2. Para não\n");
                seguir = int.Parse(Console.ReadLine());
                  if(seguir == 1){

                  }else{
                    Console.WriteLine("Obrigado por comprar com a gente, volte sempre!");
                    sair = 2;
                  }

                }else{
                  Console.WriteLine("Obrigado por utilizar nosso sistema, volte sempre!");
                  sair = 2;
                }

                break;
            //Case Voo Particular - Juridica
            case 2:
              Console.WriteLine("Deseja confirmar a compra da passagem com destino a " + boingParticular.getAeroportoChegada() +" com valor de R$"+boingParticular.getPrecoDia() +",00 ?");
              Console.WriteLine($"1. Para sim\n" + $"2. Para não\n");
              int darContinuidade = int.Parse(Console.ReadLine());
              if(darContinuidade==1){
                boingParticular.reservar2();
                Console.WriteLine("Saída: " + boingParticular.getAeroportoSaida());
                Console.WriteLine("Destino: " + boingParticular.getAeroportoChegada());
                Console.WriteLine("Nome: " + passageiroJ.getNome());
                Console.WriteLine("Data: " + boingParticular.getDataVoo());
                Console.WriteLine("Horario de Saída: " + boingParticular.getHoraSaida());
                Console.WriteLine("Previsão de Chegada: " + boingParticular.getHoraChegada());
                Console.WriteLine("Número do Voo: " + boingParticular.getNumeroVoo());
                Console.WriteLine("\nDeseja continuar a compra de mais passagens?\n");
                Console.WriteLine($"1. Para sim\n" + $"2. Para não\n");
                darContinuidade = int.Parse(Console.ReadLine());
                  if(darContinuidade == 1){

                  }else{
                    Console.WriteLine("Obrigado por comprar com a gente, volte sempre!");
                    sair = 2;
                  }

                }else{
                  Console.WriteLine("Obrigado por utilizar nosso sistema, volte sempre!");
                  sair = 2;
                }
                break;
   
        
            }

            break;

        }

      }
    }
  }