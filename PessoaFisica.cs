using System;


    class PessoaFisica : Cliente
    {
        public string nome;
        public int cpf;
      


    public PessoaFisica(){
      nome = "";
      cpf = 0;
    }

    public PessoaFisica(string nome,int cpf,int idade, string telefone, string email):base(idade, telefone, email){
      this.nome = nome;
      this.cpf = cpf;
    }


    public void setNome(string n){
      nome=n ;
    }

    public void setCpf(int c){
      cpf=c ;
    }

    public void setIdade(int i){
      idade = i;
    }

    public void setTelefone(string t){
      telefone = t;
    }

    public void setEmail(string e){
      email = e;
    }

    public string getNome(){
      return nome;
    }

    
  public override string ToString(){
    return String.Format("{0},{1},{2},{3},{4}", nome, cpf, idade, telefone, email);
  }





    }


