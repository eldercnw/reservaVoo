using System;
using System.IO;

    class VooComercial : Voo
    {
        public int qtdPermitidaComercial { get; set; }
        public float valorPassagemn { get; set; }



       public VooComercial(int numeroVoo,string aeroportoSaida, string aeroportoChegada, string horaSaida, string horaChegada, string dataVoo ,int qtdPermitidaComercial, float valorPassagemn):base(numeroVoo,aeroportoSaida,aeroportoChegada,horaSaida,horaChegada,dataVoo)
    {
      this.qtdPermitidaComercial = qtdPermitidaComercial;
      this.valorPassagemn = valorPassagemn;
    }


    public void reservar (){
      try{
        if(this.qtdPermitidaComercial == 0){
          throw new ArgumentException ("Não há mais passagens disponiveis");
        }
        this.qtdPermitidaComercial--;
      Console.WriteLine("\nPassagem comprada com sucesso! " + this.qtdPermitidaComercial + " Disponiveis");
      }catch(Exception e){
        Console.WriteLine("Não há mais passagens disponiveis");
      }
    
    }

   

    public float getValor(){
      return this.valorPassagemn;
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

  

  
