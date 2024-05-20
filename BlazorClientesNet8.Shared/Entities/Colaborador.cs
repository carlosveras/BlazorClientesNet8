using System.ComponentModel.DataAnnotations;

namespace BlazorClientesNet8.Shared.Entities;

public class Colaborador
{
    public int Id { get; set; }
    public string NomeCompleto { get; set; }
    public bool FuncionarioEstrangeiro { get; set; }
    public string NumeroIdentificacaoFiscal { get; set; }
    public string EmailPessoal { get; set; }
    public DateTime DataNascimento { get; set; }
    public DateTime DataAdmissao { get; set; }
    public DateTime DataFinal { get; set; }
    public int DepartamentoId { get; set; }
    public int LocalidadeId { get; set; }

    public bool AcessoEmail { get; set; }
    public string Area { get; set; }
    public string Cargo { get; set; }
    public string CentroDeCusto { get; set; }
    public string CentroDeResultado { get; set; }

    public int TipoContratacaoId {get; set; }

    public Localidade Localidade { get; set; }

    public Departamento Departamento { get; set; }

    public TipoContratacao TipoContratacao { get; set;}

}
