using System;


    class VooParticular : Voo
    {
        public float preçoDia;
        public string tempoAluguel;
        public int qtdPermitidaParticular  { get; set; }





      public VooParticular(int numeroVoo,string aeroportoSaida, string aeroportoChegada, string horaSaida, string horaChegada, string dataVoo ,float preçoDia, string tempoAluguel, int qtdPermitidaParticular):base(numeroVoo,aeroportoSaida,aeroportoChegada,horaSaida,horaChegada,dataVoo)
      {
      this.preçoDia = preçoDia;
      this.tempoAluguel = tempoAluguel;
      this.qtdPermitidaParticular = qtdPermitidaParticular;
      }


      public void reservar2 (){
        try{
          if(this.qtdPermitidaParticular == 0){
            throw new ArgumentException ("Não há mais passagens disponiveis");
          }
          this.qtdPermitidaParticular--;
          Console.WriteLine("\nPassagem comprada com sucesso!" + this.qtdPermitidaParticular + " Disponiveis");
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

    

