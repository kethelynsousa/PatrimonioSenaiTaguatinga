
namespace PatrimonioSenaiTaguatinga.Entities;
public class Usuario{
    public Usuario(string nome, string sobrenome, string login, string senha, int nivelId)
    {
        Nome = nome;
        Sobrenome = sobrenome;
        Login = login;
        this.Senha = senha;
        NivelId = nivelId;
    }

    public int Id { get;set;}

public string Nome {get;set;}
public string Sobrenome {get;set;}
public string Login{get;set;}
public string Senha  {get;set;}
public int NivelId{get;set;}
public Nivel Nivel{get;set;} = null!;
}


