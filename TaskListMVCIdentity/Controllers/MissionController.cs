using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TaskListMVCIdentity.Models;

namespace TaskListMVCIdentity.Controllers
{
    public class MissionController : Controller
    {
        private readonly OfficialTaskListDbContext _context;
        public MissionController(OfficialTaskListDbContext context)
        {
            _context = context;
        }

        public IActionResult MissionIndex()
        {
            var id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var thisUsersMissions = _context.Mission.Where(x => x.UserId == id).ToList();

            if(thisUsersMissions.Count != 0)
            {
                List<Mission> superMissions = _context.Mission.Where(x => x.UserId == id).ToList();
                return View(thisUsersMissions);
            }
            else
            {
                return View("AddMission");
            }
        }

        [HttpGet]
        public IActionResult AddMission()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMission(Mission newMission)
        {
            newMission.UserId = User.FindFirst(ClaimTypes.NameIdentifier).Value;

            if (ModelState.IsValid)
            {
                _context.Mission.Add(newMission);
                _context.SaveChanges();
                return RedirectToAction("MissionIndex");
            }
            else
            {
                return View();
            }
        }

        public IActionResult DeleteMission(int Id)
        {
            Mission found = _context.Mission.Find(Id);
            if (found != null)
            {
                _context.Mission.Remove(found);
                _context.SaveChanges();
            }
            return RedirectToAction("MissionIndex");
        }

        public IActionResult ChangeMissionCompleteStatus(int id)
        {
            Mission found = _context.Mission.Find(id);

            if (found != null)
            {
                found.Completed = !found.Completed;

                _context.Entry(found).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.Update(found);
                _context.SaveChanges();
            }
            return RedirectToAction("MissionIndex", new { id = found.Id });
        }

        [HttpGet]
        public IActionResult UpdateMission(int id)
        {
            Mission found = _context.Mission.Find(id);
            return View(found);
        }

        [HttpPost]
        public IActionResult UpdateMission(Mission newMission)
        {
            Mission oldMission = _context.Mission.Find(newMission.Id);

            if (ModelState.IsValid)
            {
                oldMission.DueDate = newMission.DueDate;
                oldMission.MissionDescription = newMission.MissionDescription;
                oldMission.Completed = newMission.Completed;

                _context.Entry(oldMission).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.Update(oldMission);
                _context.SaveChanges();
            }

            return RedirectToAction("MissionIndex");
        }
    }
}
