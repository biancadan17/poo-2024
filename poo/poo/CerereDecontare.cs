namespace poo;

public class CerereDecontare
{
    public int Id { get; set; }
    public int IdCererePreAprobare { get; set; }
    public List<DocumentJustificativ> Documente { get; set; } = new List<DocumentJustificativ>();
    public bool Aprobat{get;set;}

}