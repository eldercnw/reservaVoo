using System;


    class PessoaJuridica : Cliente
    {
        public string nomeEmpresa;
        public string cnpj;


        public PessoaJuridica(){
          nomeEmpresa = "";
          cnpj = "";
        }

        public PessoaJuridica(string nomeEmpresa,string cnpj,int idade, string telefone, string email):base(idade, telefone, email){
          this.nomeEmpresa = nomeEmpresa;
          this.cnpj = cnpj;
        }

        public string getNome(){
          return nomeEmpresa;
        }

        public void setNome(string nE){
          nomeEmpresa= nE ;
    }
    }

