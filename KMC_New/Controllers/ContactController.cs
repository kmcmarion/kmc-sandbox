using ClientDependency.Core;
using KMC_New.Models;
using System;
using System.IO;
using System.Web;
using System.Web.Mvc;
using Umbraco.Core;
using Umbraco.Core.Models;
using Umbraco.Core.Services;
using Umbraco.Web.Mvc;

namespace KMC_New.Controllers
{
    public class ContactFormController : SurfaceController
    {
        [HttpPost]
        public ActionResult Submit(ContactFormViewModel model)
        {
            if (!ModelState.IsValid)
                return CurrentUmbracoPage();

            var contentService = Services.ContentService;

            var parentId = Guid.Parse("e7853e02-1f94-4fc9-8cc8-8fd2b2853676");

            var person = contentService.Create(model.Name, parentId, "communityArticle");

            person.SetValue("personName", model.Name );
            person.SetValue("department", model.Department );
            person.SetValue("position", model.Position );
            person.SetValue("whatDoYourParentsThinkYouDo", model.YourWork );
            person.SetValue("whatDoYouActuallyDo", model.YourActualWork);
            person.SetValue("bestThingsAboutWorkingAtKMC", model.ThreeThings);
            person.SetValue("whatDoYouLoveAboutYourJob", model.ILoveMyJob);
            person.SetValue("timeToTakeABreakWhatSYourGoToMeriendaOfficeSnack", model.Merienda);
            person.SetValue("whatDoYouDoToRelax", model.Relax);
            person.SetValue("whatSYourGuiltyPleasure", model.GuiltyPleasure);
            person.SetValue("location", model.Location);

            person.SetValue("pageTitle", model.Name);
            person.SetValue("metaDescription", model.Name);

            // Use your file here
            //using (MemoryStream memoryStream = new MemoryStream())
            //{
            //    model.YourPhoto.InputStream.CopyTo(memoryStream);
            //    model.KMCPhotos1.InputStream.CopyTo(memoryStream);
            //    model.KMCPhotos2.InputStream.CopyTo(memoryStream);
            //    model.KMCPhotos3.InputStream.CopyTo(memoryStream);
            //}

            person.SetValue(Services.ContentTypeBaseServices, "kMCPhoto1", "kmcPhoto1", model.KMCPhotos1);
            person.SetValue(Services.ContentTypeBaseServices, "kMCPhoto2", "kmcPhoto2", model.KMCPhotos2);
            person.SetValue(Services.ContentTypeBaseServices, "kMCPhoto3", "kmcPhoto3", model.KMCPhotos3);
            person.SetValue(Services.ContentTypeBaseServices, "uploadYourFavoritePhotoOfYou", "newFileNameCommunity", model.YourPhoto);

            //TempData.Add("status", "Your profile is submitted and will be reviewed. Please wait it to be posted in");
            TempData["status"] = "Test TempData";
            contentService.Save(person);

            return RedirectToCurrentUmbracoPage();
        }
    }
}