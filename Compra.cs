using System;



    class Compra
    {
      public string data { get; set; }
      public float preço { get; set; }


      public Compra (string data, float preço){
        this.data = data;
        this.preço = preço;
      }

      public void ComprarPassagem(string ComprarPassagem){
        if(ComprarPassagem == "1"){
          Console.WriteLine("Compra efetuada com sucesso");
        }else{
          Console.WriteLine("Compra cancelada");
        }
      }
    }

