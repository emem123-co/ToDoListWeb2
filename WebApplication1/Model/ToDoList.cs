using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Model;

public class ToDoList
{
    public int Id { get; set; }

    [StringLength(80)]
    public string Description { get; set; }


    [StringLength(80)]
    public string Status { get; set; } = "Active";


    public DateTime DueDate { get; set; }


    [StringLength(80)]
    public string Priority { get; set; } = "Medium";
}
