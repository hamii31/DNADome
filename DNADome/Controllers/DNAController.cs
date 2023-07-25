namespace DNADome.Controllers
{
    using DNADome.Models;
    using DNADome.Services.Interfaces;
    using Microsoft.AspNetCore.Mvc;

    public class DNAController : Controller
    {
        private readonly IDNAReader dnaReader;
        public DNAController(IDNAReader dnaReader)
        {
            this.dnaReader = dnaReader;
        }

        [HttpGet]
        public IActionResult Read()
        {
            DNAFormModel formModel = new DNAFormModel();
            if (!this.ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }
            return View(formModel);
        }
        [HttpPost]
        public IActionResult Read(DNAFormModel formModel)
        {
            DNAFormModel model = this.dnaReader.ReadDNA(formModel);
            return View(model);
        }
    }
}
