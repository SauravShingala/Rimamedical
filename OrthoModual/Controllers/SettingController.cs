using Microsoft.AspNetCore.Mvc;
using OrthoModual.IServices;
using OrthoModual.Models;

namespace OrthoModual.Controllers
{
    public class SettingController : Controller
    {
        public readonly IAddSubmenuService addSubmenuService;

        public SettingController(IAddSubmenuService addSubmenuService)
        {
            this.addSubmenuService = addSubmenuService;
        }

        [HttpGet]
        public IActionResult AddGenderTitle()
        {
            try
            {
                AddSubMenuModel addSubMenuModel = new AddSubMenuModel();
                addSubMenuModel.KeyName = "GenderTitle";
                addSubMenuModel.getSubMenuModels = addSubmenuService.GetSubmenu(addSubMenuModel.KeyName);
                ViewBag.Header = "Gender Title";
                ViewBag.Action = "AddGenderTitle";
                return View("AddSubMenu",addSubMenuModel);
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult AddGenderTitle(AddSubMenuModel addSubMenuModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    addSubMenuModel.KeyName = "GenderTitle";
                    bool response = addSubmenuService.AddSubMenu(addSubMenuModel);
                    ModelState.Clear();
                    if (response)
                    {
                        ViewBag.Sucsess = "Gender Title Add SucsessFully";
                    }
                }

                AddSubMenuModel addSubMenu = new AddSubMenuModel();
                addSubMenu.KeyName = "GenderTitle";
                addSubMenu.getSubMenuModels = addSubmenuService.GetSubmenu(addSubMenu.KeyName);
                ViewBag.Header = "Gender Title";
                ViewBag.Action = "AddGenderTitle";
                return View("AddSubMenu", addSubMenu);
            }
            catch(Exception ex)
            {
                return View(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult AddInjury()
        {
            try
            {
                AddSubMenuModel addSubMenuModel = new AddSubMenuModel();
                addSubMenuModel.KeyName = "InjuryType";
                addSubMenuModel.getSubMenuModels = addSubmenuService.GetSubmenu(addSubMenuModel.KeyName);
                ViewBag.Header = "Injury Type";
                ViewBag.Action = "AddInjury";
                return View("AddSubMenu", addSubMenuModel);
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult AddInjury(AddSubMenuModel addSubMenuModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    addSubMenuModel.KeyName = "InjuryType";
                    bool response = addSubmenuService.AddSubMenu(addSubMenuModel);
                    ModelState.Clear();
                    if (response)
                    {
                        ViewBag.Sucsess = "Injury Add SucsessFully";
                    }
                }
                AddSubMenuModel addSubMenu = new AddSubMenuModel();
                addSubMenu.KeyName = "InjuryType";
                addSubMenu.getSubMenuModels = addSubmenuService.GetSubmenu(addSubMenu.KeyName);
                ViewBag.Header = "Injury Type";
                ViewBag.Action = "AddInjury";
                return View("AddSubMenu", addSubMenu);
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult AddInitial()
        {
            try
            {
                AddSubMenuModel addSubMenuModel = new AddSubMenuModel();
                addSubMenuModel.KeyName = "Initial";
                addSubMenuModel.getSubMenuModels = addSubmenuService.GetSubmenu(addSubMenuModel.KeyName);
                ViewBag.Header = "Initial";
                ViewBag.Action = "AddInitial";
                return View("AddSubMenu", addSubMenuModel);
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult AddInitial(AddSubMenuModel addSubMenuModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    addSubMenuModel.KeyName = "Initial";
                    bool response = addSubmenuService.AddSubMenu(addSubMenuModel);
                    ModelState.Clear();
                    if (response)
                    {
                        ViewBag.Sucsess = "Initial Add SucsessFully";
                    }
                }
                AddSubMenuModel addSubMenu = new AddSubMenuModel();
                addSubMenu.KeyName = "Initial";
                addSubMenu.getSubMenuModels = addSubmenuService.GetSubmenu(addSubMenu.KeyName);
                ViewBag.Header = "Initial";
                ViewBag.Action = "AddInitial";
                return View("AddSubMenu", addSubMenu);
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult AddOngoingType()
        {
            try
            {
                AddSubMenuModel addSubMenuModel = new AddSubMenuModel();
                addSubMenuModel.KeyName = "OngoingType";
                addSubMenuModel.getSubMenuModels = addSubmenuService.GetSubmenu(addSubMenuModel.KeyName);
                ViewBag.Header = "Ongoing Type";
                ViewBag.Action = "AddOngoingType";
                return View("AddSubMenu", addSubMenuModel);
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult AddOngoingType(AddSubMenuModel addSubMenuModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    addSubMenuModel.KeyName = "OngoingType";
                    bool response = addSubmenuService.AddSubMenu(addSubMenuModel);
                    ModelState.Clear();
                    if (response)
                    {
                        ViewBag.Sucsess = "Ongoing Type Add SucsessFully";
                    }
                }
                AddSubMenuModel addSubMenu = new AddSubMenuModel();
                addSubMenu.KeyName = "OngoingType";
                addSubMenu.getSubMenuModels = addSubmenuService.GetSubmenu(addSubMenu.KeyName);
                ViewBag.Header = "Ongoing Type";
                ViewBag.Action = "AddOngoingType";
                return View("AddSubMenu", addSubMenu);
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult AddPhotoId()
        {
            try
            {
                AddSubMenuModel addSubMenuModel = new AddSubMenuModel();
                addSubMenuModel.KeyName = "PhotoId";
                addSubMenuModel.getSubMenuModels = addSubmenuService.GetSubmenu(addSubMenuModel.KeyName);
                ViewBag.Header = "PhotoId";
                ViewBag.Action = "AddPhotoId";
                return View("AddSubMenu", addSubMenuModel);
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult AddPhotoId(AddSubMenuModel addSubMenuModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    addSubMenuModel.KeyName = "PhotoId";
                    bool response = addSubmenuService.AddSubMenu(addSubMenuModel);
                    ModelState.Clear();
                    if (response)
                    {
                        ViewBag.Sucsess = "Photo Id Add SucsessFully";
                    }
                }
                AddSubMenuModel addSubMenu = new AddSubMenuModel();
                addSubMenu.KeyName = "PhotoId";
                addSubMenu.getSubMenuModels = addSubmenuService.GetSubmenu(addSubMenu.KeyName);
                ViewBag.Header = "PhotoId";
                ViewBag.Action = "AddPhotoId";
                return View("AddSubMenu", addSubMenu);
            }
            catch(Exception ex)
            {
                return View(ex.Message);
                }
        }

        [HttpGet]
        public IActionResult AddGaitType()
        {
            try
            {
                AddSubMenuModel addSubMenuModel = new AddSubMenuModel();
                addSubMenuModel.KeyName = "GaitType";
                addSubMenuModel.getSubMenuModels = addSubmenuService.GetSubmenu(addSubMenuModel.KeyName);
                ViewBag.Header = "Gait Type";
                ViewBag.Action = "AddGaitType";
                return View("AddSubMenu", addSubMenuModel);
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult AddGaitType(AddSubMenuModel addSubMenuModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    addSubMenuModel.KeyName = "GaitType";
                    bool response = addSubmenuService.AddSubMenu(addSubMenuModel);
                    ModelState.Clear();
                    if (response)
                    {
                        ViewBag.Sucsess = "Gait Type Add SucsessFully";
                    }
                }
                AddSubMenuModel addSubMenu = new AddSubMenuModel();
                addSubMenu.KeyName = "GaitType";
                addSubMenu.getSubMenuModels = addSubmenuService.GetSubmenu(addSubMenu.KeyName);
                ViewBag.Header = "Gait Type";
                ViewBag.Action = "AddGaitType";
                return View("AddSubMenu", addSubMenu);
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult AddPosture()
        {
            try
            {
                AddSubMenuModel addSubMenuModel = new AddSubMenuModel();
                addSubMenuModel.KeyName = "Posture";
                addSubMenuModel.getSubMenuModels = addSubmenuService.GetSubmenu(addSubMenuModel.KeyName);
                ViewBag.Header = "Posture";
                ViewBag.Action = "AddPosture";
                return View("AddSubMenu", addSubMenuModel);
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult AddPosture(AddSubMenuModel addSubMenuModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    addSubMenuModel.KeyName = "Posture";
                    bool response = addSubmenuService.AddSubMenu(addSubMenuModel);
                    ModelState.Clear();
                    if (response)
                    {
                        ViewBag.Sucsess = "Posture SucsessFully";
                    }
                }
                AddSubMenuModel addSubMenu = new AddSubMenuModel();
                addSubMenu.KeyName = "Posture";
                addSubMenu.getSubMenuModels = addSubmenuService.GetSubmenu(addSubMenu.KeyName);
                ViewBag.Header = "Posture";
                ViewBag.Action = "AddPosture";
                return View("AddSubMenu", addSubMenu);
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult AddNoofSession()
        {
            try
            {
                AddSubMenuModel addSubMenuModel = new AddSubMenuModel();
                addSubMenuModel.KeyName = "NoOfSession";
                addSubMenuModel.getSubMenuModels = addSubmenuService.GetSubmenu(addSubMenuModel.KeyName);
                ViewBag.Header = "No of Session";
                ViewBag.Action = "AddNoofSession";
                return View("AddSubMenu", addSubMenuModel);
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult AddNoofSession(AddSubMenuModel addSubMenuModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    addSubMenuModel.KeyName = "NoOfSession";
                    bool response = addSubmenuService.AddSubMenu(addSubMenuModel);
                    ModelState.Clear();
                    if (response)
                    {
                        ViewBag.Sucsess = "No Of Session Add SucsessFully";
                    }
                }
                AddSubMenuModel addSubMenu = new AddSubMenuModel();
                addSubMenu.KeyName = "NoOfSession";
                addSubMenu.getSubMenuModels = addSubmenuService.GetSubmenu(addSubMenu.KeyName);
                ViewBag.Header = "No of Session";
                ViewBag.Action = "AddNoofSession";
                return View("AddSubMenu", addSubMenu);
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult AddRefferd()
        {
            try
            {
                AddSubMenuModel addSubMenuModel = new AddSubMenuModel();
                addSubMenuModel.KeyName = "Refferd";
                addSubMenuModel.getSubMenuModels = addSubmenuService.GetSubmenu(addSubMenuModel.KeyName);
                ViewBag.Header = "Refferd";
                ViewBag.Action = "AddRefferd";
                return View("AddSubMenu", addSubMenuModel);
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult AddRefferd(AddSubMenuModel addSubMenuModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    addSubMenuModel.KeyName = "Refferd";
                    bool response = addSubmenuService.AddSubMenu(addSubMenuModel);
                    ModelState.Clear();
                    if (response)
                    {
                        ViewBag.Sucsess = "Refferd Add SucsessFully";
                    }
                }
                AddSubMenuModel addSubMenu = new AddSubMenuModel();
                addSubMenu.KeyName = "Refferd";
                addSubMenu.getSubMenuModels = addSubmenuService.GetSubmenu(addSubMenu.KeyName);
                ViewBag.Header = "Refferd";
                ViewBag.Action = "AddRefferd";
                return View("AddSubMenu", addSubMenu);
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }
    }
}
