using System.ComponentModel.DataAnnotations;

namespace ParkApi.Models
{
  public class Park
  {
    public int ParkId { get; set; }
    public string ParkName { get; set; }
    public string ParkDescription { get; set; }
    public string AmenitiesFacilities { get; set; }
    public string Region { get; set; }
  }
}