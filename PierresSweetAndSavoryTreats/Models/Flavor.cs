using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PierresSweetAndSavoryTreats.Models
{
  public class Flavor
  {
    public int FlavorId { get; set; }
    [Required(ErrorMessage = "The Flavor's name is required!")]
    public string FlavorName { get; set; }
    [Required(ErrorMessage = "The Flavor's ingredients are required!")]
    public string Ingredients { get; set; }
    [Required(ErrorMessage= "A description is required!")]
    public string Description { get; set; }
    public List<FlavorTreat> JoinEntities { get; }
    public ApplicationUser User { get; set; }

  }

}