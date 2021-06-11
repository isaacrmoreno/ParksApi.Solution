using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Linq;
using System;
using StateParksApi.Models;

namespace StateParksApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class StateParksController : ControllerBase
  {
    private readonly StateParksApiContext _db;
    public StateParksController(StateParksApiContext db)
    {
      _db = db;
    } 
    [HttpGet]
    public async Task<ActionResult<IEnumerable<StatePark>>> Get(string ParkName, string ParkDescription, string AmenitiesFacilities, string Region)
    {
      var query = _db.StateParks.AsQueryable();
      {
        if (ParkName != null)
        {
          query = query.Where(entry => entry.ParkName == ParkName);
        }
        if (ParkDescription != null)
        {
          query = query.Where(entry => entry.ParkDescription == ParkDescription);
        }
        if (AmenitiesFacilities != null)
        {
          query = query.Where(entry => entry.AmenitiesFacilities == AmenitiesFacilities);
        }
        if (Region != null)
        {
          query = query.Where(entry => entry.Region == Region);
        }
        return await query.ToListAsync();
      }
    }
    [HttpGet("{id}")]
    public async Task<ActionResult<StatePark>> GetStatePark(int id)
    {
      var statePark = await _db.StatePark.FindAsync(id);

      if (statePark == null)
      {
        return NotFound();
      }
      return statePark;
    }
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, StatePark statePark)
    {
      if (id != statePark.StateParkId)
      {
        return BadRequest();
      }
      _db.Entry(statePark).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!StateParkExist(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }
      return NoContent();
    }
    [HttpPost]
    public async Task<ActionResult<StatePark>> PostPark(StatePark statePark)
    {
      _db.StateParks.Add(statePark);
      await _db.SaveChangesAsync();

      return CreatedAtAction("GetPark", new { id = statePark.StateParkId}, statePark);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePark(int id)
    {
      var statePark = await _db.StateParks.FindAsync(id);
      if (statePark == null)
      {
        return NotFound();
      }

      _db.StateParks.Remove(statePark);
      await _db.SaveChangesAsync();

      return NoContent();
    }
    private bool StateParkExist(int id)
    {
      return _db.StateParks.Any(entry => entry.StateParkId == id);
    }
  }
}