using Microsoft.AspNetCore.Mvc;
using OrthoModual.IServices;
using OrthoModual.Models;
using OrthoModual.Services;

namespace OrthoModual.Controllers
{
    public class OrthoController : Controller
    {
        public readonly IOrthoFormService orthoFormService;

        public OrthoController(IOrthoFormService orthoFormService)
        {
            this.orthoFormService = orthoFormService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddOrthoForm()
        {
            try
            {
                OrthoFormModel orthoFormModel = new OrthoFormModel();
                orthoFormModel.titleKeyValueModels = orthoFormService.GetKeyValueList("GenderTitle");
                orthoFormModel.initialKeyValueModels = orthoFormService.GetKeyValueList("Initial");
                orthoFormModel.InjuryTypeKeyValueModels = orthoFormService.GetKeyValueList("InjuryType");
                orthoFormModel.OngoingTypeKeyValueModels = orthoFormService.GetKeyValueList("OngoingType");
                orthoFormModel.PhotoIdKeyValueModels = orthoFormService.GetKeyValueList("PhotoId");
                orthoFormModel.GaitTypeKeyValueModels = orthoFormService.GetKeyValueList("GaitType");
                orthoFormModel.PostureKeyValueModels = orthoFormService.GetKeyValueList("Posture");
                orthoFormModel.NoOfSessionKeyValueModels = orthoFormService.GetKeyValueList("NoOfSession");
                orthoFormModel.RefferdKeyValueModels = orthoFormService.GetKeyValueList("Refferd");
                
                return View(orthoFormModel);
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult AddOrthoForm(OrthoFormModel model)
        {
            try
            {
                int res = orthoFormService.AddOrthoFormDetails(model);

                OrthoFormModel orthoFormModel = new OrthoFormModel();
                orthoFormModel.titleKeyValueModels = orthoFormService.GetKeyValueList("GenderTitle");
                orthoFormModel.initialKeyValueModels = orthoFormService.GetKeyValueList("Initial");
                orthoFormModel.InjuryTypeKeyValueModels = orthoFormService.GetKeyValueList("InjuryType");
                orthoFormModel.OngoingTypeKeyValueModels = orthoFormService.GetKeyValueList("OngoingType");
                orthoFormModel.PhotoIdKeyValueModels = orthoFormService.GetKeyValueList("PhotoId");
                orthoFormModel.GaitTypeKeyValueModels = orthoFormService.GetKeyValueList("GaitType");
                orthoFormModel.PostureKeyValueModels = orthoFormService.GetKeyValueList("Posture");
                orthoFormModel.NoOfSessionKeyValueModels = orthoFormService.GetKeyValueList("NoOfSession");
                orthoFormModel.RefferdKeyValueModels = orthoFormService.GetKeyValueList("Refferd");
                return View(orthoFormModel);
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }
    }
}
