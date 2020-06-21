using System;


    class VooParticular : Voo
    {
        public float preçoDia;
        public string tempoAluguel;
        public int qtdPermitidaParticular;





      public VooParticular(int numeroVoo,string aeroportoSaida, string aeroportoChegada, string horaSaida, string horaChegada, string dataVoo ,float preçoDia, string tempoAluguel, int qtdPermitidaParticular):base(numeroVoo,aeroportoSaida,aeroportoChegada,horaSaida,horaChegada,dataVoo)
      {
      this.preçoDia = preçoDia;
      this.tempoAluguel = tempoAluguel;
      }


      public void reservar2 (){
        try{
          if(this.qtdPermitidaParticular == 0){
            throw new ArgumentException ("Não há mais passagens disponiveis");
          }
            this.qtdPermitidaParticular--;
            Console.WriteLine(this.qtdPermitidaParticular);
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
    public float getPrecoDia(){
      return preçoDia;
    }
    
}

    

