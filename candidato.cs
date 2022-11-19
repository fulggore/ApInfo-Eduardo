//Eduardo Cavalcante - 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

public class Candidato
{
    private String nome;
    private String sexo;
    private DateTime nascimento;
    private String estado;
    private String cidade;
    private String cep;
    private String bairro;
    private String telefone;
    private String email;
    private String cpf;
    private String senha;
    private String frasesecreta;
    private String curriculo;


    //Metodo Construtor
    public Candidato(String p_nome, String p_sexo, DateTime p_nascimento, String p_estado, String p_cidade, String p_cep, String p_bairro, String p_telefone, String p_email, String p_cpf, String p_senha, String p_frasesecreta, String p_curriculo)
    {
        this.nome = p_nome;
        this.sexo = p_sexo;
        this.nascimento = p_nascimento;
        this.estado = p_estado;
        this.cidade = p_cidade;
        this.cep = p_cep;
        this.bairro = p_bairro;
        this.telefone = p_telefone;
        this.email = p_email;
        this.cpf = p_cpf;
        this.senha = p_senha;
        this.frasesecreta = p_frasesecreta;
        this.curriculo = p_curriculo;

    }
    public Candidato()
    {
        this.nome = "Lethicia";
        this.sexo = "Feminino";
        this.nascimento = DateTime.Parse("1999-06-21");
        this.estado = "São Paulo";
        this.cidade = "Mogi das Cruzes";
        this.cep = "654987-900";
        this.bairro = "Mogicoiso";
        this.telefone = "12345678978";
        this.email = "email@email.com";
        this.cpf = "45143562956";
        this.senha = "123";
        this.frasesecreta = "Uma senha muito facil";
        this.curriculo = "Gosto de nao passar fome me contratem";

    }
    public String getNome()
    {
        return this.nome;
    }

    public void setNome(String p_nome)
    {
        this.nome = p_nome;
    }

    public String getSexo()
    {
        return this.sexo;
    }

    public void setSexo(String p_sexo)
    {
        this.sexo = p_sexo;
    }

    public DateTime getNascimento()
    {
        return this.nascimento;
    }

    public void setNascimento(DateTime p_nascimento)
    {
        this.nascimento = p_nascimento;
    }

    public String getEstado()
    {
        return this.estado;
    }

    public void setEstado(String p_estado)
    {
        this.estado = p_estado;
    }

    public String getCidade()
    {
        return this.cidade;
    }

    public void setCidade(String p_cidade)
    {
        this.cidade = p_cidade;
    }

    public String getCep()
    {
        return this.cep;
    }

    public void setCep(String p_cep)
    {
        this.cep = p_cep;
    }
    public String getBairro()
    {
        return this.bairro;
    }

    public void setBairro(String p_bairro)
    {
        this.bairro = p_bairro;
    }

    public String getTelefone()
    {
        return this.telefone;
    }

    public void setTelefone(String p_telefone)
    {
        this.telefone = p_telefone;
    }
    public String getEmail()
    {
        return this.email;
    }

    public void setEmail(String p_email)
    {
        this.email = p_email;
    }

    public String getCpf()
    {
        return this.cpf;
    }

    public void setCpf(String p_cpf)
    {
        this.cpf = p_cpf;
    }

    public String getSenha()
    {
        return this.senha;
    }

    public void setSenha(String p_senha)
    {
        this.senha = p_senha;
    }

    public String getFrase()
    {
        return this.frasesecreta;
    }

    public void setFrase(String p_frasesecreta)
    {
        this.frasesecreta = p_frasesecreta;
    }
    public String getCurriculo()
    {
        return this.curriculo;
    }

    public void setCurriculo(String p_curriculo)
    {
        this.curriculo = p_curriculo;
    }
}
