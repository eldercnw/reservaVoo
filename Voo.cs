using System;



    class Voo
    {
        public int numeroVoo { get; set; }
        public string aeroportoSaida { get; set; }
        public string aeroportoChegada { get; set; }
        public string horaSaida { get; set; }
        public string horaChegada { get; set; }
        public string dataVoo { get; set; }
       
       

       public Voo(int numeroVoo,string aeroportoSaida, string aeroportoChegada, string horaSaida, string horaChegada, string dataVoo){
         this.numeroVoo = numeroVoo;
         this.aeroportoSaida = aeroportoSaida;
         this.aeroportoChegada = aeroportoChegada;
         this.horaSaida = horaSaida;
         this.horaChegada = horaChegada;
         this.dataVoo = dataVoo;
       }

       public int getnumeroVoo(){
         return this.numeroVoo;
       }
    }



