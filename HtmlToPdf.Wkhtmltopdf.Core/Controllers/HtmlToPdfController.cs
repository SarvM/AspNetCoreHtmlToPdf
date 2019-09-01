using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Wkhtmltopdf.NetCore;
using HtmlToPdf.Wkhtmltopdf.Core.Models;

namespace HtmlToPdf.Wkhtmltopdf.Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HtmlToPdfController : ControllerBase
    {
        readonly IGeneratePdf _generatePdf;
        public HtmlToPdfController(IGeneratePdf generatePdf)
        {
            _generatePdf = generatePdf;
        }

        [HttpGet]
        [Route("Get")]
        public async Task<IActionResult> Get()
        {
            var data  = new ProfileCard
            {
                Name = "Susan Doe",
                Designation = "CEO & Co-Founder",
                Company = "Doe Company"
            };

            var htmlPage = await System.IO.File.ReadAllTextAsync("Templates/ProfileCard.cshtml");

            return await _generatePdf.GetPdfViewInHtml(htmlPage, data);
        }

    }

}