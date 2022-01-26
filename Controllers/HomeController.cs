using LumenWorks.Framework.IO.Csv;
using System.IO;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using design_pattern_arch_project.Models;
using System.Data;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using design_pattern_arch_project.Models.Repos;

namespace design_pattern_arch_project.Controllers
{
    public class HomeController : Controller
    {
        //here createing HOMEREPO variable from ReposInterface in Model folder to allow us call its methods
        private ReposInterface HomeRepo;

        private IHostingEnvironment Environment;

        // constructor func to call methods and repo interface
        public HomeController(ReposInterface HomeRepo, IHostingEnvironment _environment)
        {
            this.HomeRepo = HomeRepo;
            Environment = _environment;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        //when user upload file of date csv  call this function
        public IActionResult Index(IFormFile postedFile)
        {
            if (postedFile != null)
            {
                string path = Path.Combine(this.Environment.WebRootPath, "Uploads");
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                string fileName = Path.GetFileName(postedFile.FileName);
                string filePath = Path.Combine(path, fileName);
                using (FileStream stream = new FileStream(filePath, FileMode.Create))
                {
                    postedFile.CopyTo(stream);
                }
                string csvData = System.IO.File.ReadAllText(filePath);
                DataTable dt = new DataTable();
                // add column to datatable
                dt.Columns.AddRange(new DataColumn[5] {
                    new DataColumn("Date", typeof(string)),
                    new DataColumn("Time", typeof(string)),
                    new DataColumn("Speed", typeof(double)),
                    new DataColumn("Distance",typeof(string)),
                    new DataColumn("Describtion", typeof(string)),
                });
                // loop on data from csv file
                foreach (string row in csvData.Split('\n'))
                {
                    if (!string.IsNullOrEmpty(row))
                    {
      
                       dt.Rows.Add();
                       int i = 0;

                        //Execute a loop over the columns.
                        foreach (string cell in row.Split(','))
                        {
                            if ((i) == 0)
                            {
                                dt.Rows[dt.Rows.Count - 1][i] = HomeRepo.convertDate(cell);i++;
                                continue;

                            } else if ((i) == 1)
                            {
                                dt.Rows[dt.Rows.Count - 1][i] = HomeRepo.convertTo24Hr(cell);i++;
                                continue;
                            }
                            else if ((i) == 2)
                            {
                                dt.Rows[dt.Rows.Count - 1][i] = HomeRepo.convertKMPHToKnotPH(cell); i++;
                                continue;
                            }
                            else if ((i) == 3)
                            {
                                dt.Rows[dt.Rows.Count - 1][i] = HomeRepo.convertKmphTOmph(cell); i++;
                                continue;
                            }
                            dt.Rows[dt.Rows.Count - 1][i] = cell;
                            i++;
                        }


                    }
                }

                return View(dt);
            }

            return View();
        }
    }
}

