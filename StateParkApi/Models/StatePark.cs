using System.ComponentModel.DataAnnotations;

namespace StateParksApi.Models
{
  public class StatePark
  {
    public int StateParkId { get; set; }
    public string ParkName { get; set; }
    public string ParkDescription { get; set; }
    public string AmenitiesFacilities { get; set; }
    public string Region { get; set; }
  }
}