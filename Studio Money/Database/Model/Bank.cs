using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("tbBank")]
public class Bank
{
    public Bank() { }

    [Key]
    public int nBank { get; set; }
    public string sBank { get; set; }
}