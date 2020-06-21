using System;

class Cliente
    {
        
        public int idade { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }



        public Cliente(){
          idade = 0;
          telefone = "";
          email = "";
        }

        public Cliente (int idade, string telefone, string email)
        {
            this.idade = idade ;
            this.telefone = telefone ;
            this.email = email;
        }

        


    }
