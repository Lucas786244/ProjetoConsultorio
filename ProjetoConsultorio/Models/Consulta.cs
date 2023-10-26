namespace ProjetoConsultorio.Models
{
    public class Consulta
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNasc { get; set; }
        public string Convenio { get; set; }
        public DateTime DataConsulta { get; set; }
        public string Observacoes { get; set; }
    }
}
