using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeCalanderBackend.Model;

public class Appointment
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int id { get; set; }

    [Required] public DateTime from { get; set; }
    [Required] public DateTime to { get; set; }
    [Required] public string title { get; set; }
    public string description { get; set; }
    [Required] public int user_id { get; set; }
    [Required] public int type_id { get; set; }
}