using System;


   class VooEmpresarial : Voo
    {
        public string nomeEmpresa { get; set; }



      public VooEmpresarial(int numeroVoo,string aeroportoSaida, string aeroportoChegada, string horaSaida, string horaChegada, string dataVoo):base(numeroVoo,aeroportoSaida,aeroportoChegada,horaSaida,horaChegada,dataVoo)
      {
      this.nomeEmpresa = nomeEmpresa;
      }











    }

