using KMC_New.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace KMC_New.Controllers
{
    public class CareersController : SurfaceController
    {
        public const string PARTIAL_VIEW_FOLDER = "~/Views/Careers/";
        // GET: Careers
        public ActionResult RenderActiveJob()
        {
            var jobs = Task.Run(() => GetJobOpenings()).Result;

            ViewData["Jobs"] = jobs;

            return PartialView(PARTIAL_VIEW_FOLDER + "_jobOpenings.cshtml");
        }

        public ActionResult RenderActiveAllCareers(string search)
        {
            List<ActiveJobs> jobs = new List<ActiveJobs>();

            var activeJobs = Task.Run(() => GetJobOpenings()).Result;

            var keyword = search.ToLower();

            if (keyword == "")
            {
                ViewData["Jobs"] = activeJobs;
            }
            else
            {
                foreach (var jobPosition in activeJobs)
                {
                    if (jobPosition.position.ToLower().Contains(keyword) || jobPosition.category.ToLower().Contains(keyword))
                    {
                        jobs.Add(new ActiveJobs
                        {
                            id = jobPosition.id,
                            position = jobPosition.position,
                            category = jobPosition.category
                        });
                    }
                    else if (jobPosition.workExperience != null)
                    {
                        if (jobPosition.workExperience.ToLower().Contains(keyword))
                        {
                            jobs.Add(new ActiveJobs
                            {
                                id = jobPosition.id,
                                position = jobPosition.position,
                                category = jobPosition.category
                            });
                        }
                    }
                }

                ViewData["Jobs"] = jobs;
            }
            return PartialView(PARTIAL_VIEW_FOLDER + "_jobAllCareers.cshtml");
        }


        private async Task<ICollection<ActiveJobs>> GetJobOpenings()
        {
            var client = new HttpClient();

            var config = "https://careers.kmc.solutions/api/jobs/active-jobs";

            var path = config;
            var jobList = new List<ActiveJobs>();

            try
            {
                HttpResponseMessage response = await client.GetAsync(path);
                if (response.IsSuccessStatusCode)
                {
                    try
                    {
                        var jSonString = await response.Content.ReadAsStringAsync();
                        var jobs = JsonConvert.DeserializeObject<List<ActiveJobs>>(jSonString);
                        return jobs.OrderBy(a => a.position).ToArray();
                    }
                    catch
                    {
                        //throw ex;
                        return null;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        //Open a specific Position
        [Route("position")]
        public async Task<ActionResult> Position(int id)
        {
            var job = (await GetJobOpenings()).FirstOrDefault(a => a.id == id);

            if (job != null)
            {
                return Redirect($"/careers/?p={job.id}&position_applying_for={job.position}");
            }
            return null;
        }


        public ActionResult SearchJob()
        {
            List<ActiveJobs> jobs = new List<ActiveJobs>();

            var keyword = (Request.QueryString["search"]).ToString().ToLower();

            var activeJobs = Task.Run(() => GetJobOpenings()).Result;

            foreach (var jobPosition in activeJobs)
            {
                if (jobPosition.position.ToLower().Contains(keyword) || jobPosition.category.ToLower().Contains(keyword))
                {
                    jobs.Add(new ActiveJobs
                    {
                        id = jobPosition.id,
                        position = jobPosition.position
                    });
                }
                else if (jobPosition.workExperience != null)
                {
                    if (jobPosition.workExperience.ToLower().Contains(keyword))
                    {
                        jobs.Add(new ActiveJobs
                        {
                            id = jobPosition.id,
                            position = jobPosition.position
                        });
                    }
                }
            }

            ViewData["Jobs"] = jobs;

            return PartialView(PARTIAL_VIEW_FOLDER + "_jobAllCareers.cshtml");
        }

        //Get Job Desciption
        public ActionResult JobDescription(int id)
        {
            var jobs = Task.Run(() => GetJobOpenings()).Result;

            if (jobs != null)
            {
                foreach (var jobsItems in jobs)
                {
                    if (jobsItems.id.ToString() == id.ToString())
                    {
                        ViewData["Jobs"] = jobsItems;
                        return PartialView(PARTIAL_VIEW_FOLDER + "_jobDescription.cshtml");
                    }
                }
            }
            return PartialView(PARTIAL_VIEW_FOLDER + "_jobDescription.cshtml");
        }
    }
}