using System;


   class VooEmpresarial : Voo
    {
        public string nomeEmpresa { get; set; }
        public int qtdPermitidaEmpresarial;



        public VooEmpresarial(int numeroVoo,string aeroportoSaida, string aeroportoChegada, string horaSaida, string horaChegada, string dataVoo, int qtdPermitidaEmpresarial):base(numeroVoo,aeroportoSaida,aeroportoChegada,horaSaida,horaChegada,dataVoo)
        {
        this.nomeEmpresa = nomeEmpresa;
        this.qtdPermitidaEmpresarial = qtdPermitidaEmpresarial;
        }

        public void reservar3 (){
      try{
        if(this.qtdPermitidaEmpresarial == 0){
          throw new ArgumentException ("Não há mais passagens disponiveis");
        }
        this.qtdPermitidaEmpresarial--;
        Console.WriteLine("\nPassagem comprada com sucesso! " + this.qtdPermitidaEmpresarial + " Disponiveis");
      }catch(Exception e){
        Console.WriteLine("Não há mais passagens disponiveis");
      }
    
    }

        

        public int getNumeroVoo(){
          return numeroVoo;
      
        }
        public string getAeroportoSaida(){
          return aeroportoSaida;
        }
        public string getAeroportoChegada(){
          return aeroportoChegada;
        }
        public string getHoraSaida(){
          return horaSaida;
        }
        public string getHoraChegada(){
          return horaChegada;
        }
        public string getDataVoo(){
          return dataVoo;
        }











    }

