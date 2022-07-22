﻿using Medical.Models;
using Medical.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medical.Controllers
{
    public class ClinicDetailController : Controller
    {
        
        private readonly MedicalContext _context;
        public ClinicDetailController(MedicalContext medicalContext)
        {
            _context = medicalContext;
        }
        


        public IActionResult List()
        {


            ViewBag.Time = DateTime.Now.ToString("yyyy/MM/dd");

            int hour = DateTime.Now.Hour;
            int Period = 0;

            if (hour <= 12)
            {
                Period = 1; //上午時段
            }
            if (hour > 12 &&hour<17)
            {
                Period = 2; //下午時段
            }
            if (hour > 17 && hour < 21)
            {
                Period = 3; //晚上時段
            }
            ViewBag.period = Period;
            var result = _context.ClinicDetails.Where(a => a.ClinicDate.Value.Date.Equals(DateTime.Today.Date))

                .Select(a => new CClinicDetailViewModel {
                    clinicDetail=a,
                    Doctor=a.Doctor,
                    Department=a.Department,
                    Room=a.Room,
                    Period=a.Period
                                                   
                });
                 


            return View(result);
        }

        

    }
}
