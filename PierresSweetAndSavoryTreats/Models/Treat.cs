using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PierresSweetAndSavoryTreats.Models
{
  public class Treat
  {
    public int TreatId { get; set; }
    [Required(ErrorMessage = "The Treat's Name is required!")]
    public string TreatName { get; set; }
    [Required(ErrorMessage = "The Treat's ingredients are required!")]
    public string Ingredients { get; set; }
    [Required(ErrorMessage = "A description is required!")]
    public string Description { get; set; }
    public List<FlavorTreat> JoinEntities { get; }
    public ApplicationUser User { get; set; }
  }

}