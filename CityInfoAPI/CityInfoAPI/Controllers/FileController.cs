using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;

namespace CityInfoAPI.Controllers
{
    [Route("/api/files")]
    [ApiController]
    public class FileController : ControllerBase
    {

        private readonly FileExtensionContentTypeProvider _contentTypeProvider;

        public FileController(
            FileExtensionContentTypeProvider contentTypeProvider)
        {
            _contentTypeProvider = contentTypeProvider 
                ?? throw new ArgumentNullException(nameof(contentTypeProvider));
        }

        [HttpGet("{fileId}")]
        public ActionResult GetFile(string fileId)
        {
            var pathToFile = "image01.png";
            if (!System.IO.File.Exists(pathToFile))
            {
                return NotFound();
            }
            if(!_contentTypeProvider.TryGetContentType(pathToFile, out var contentType))
            {
                contentType = "application/octet-stream";

            }
            var bytes = System.IO.File.ReadAllBytes(pathToFile);
            return File(bytes, contentType, Path.GetFileName(pathToFile));
        }

        [HttpPost]
        public async Task<ActionResult> CreateFile(IFormFile file)
        {
            if(file.Length == 0 || file.Length > 20971520 
                || file.ContentType != "application/pdf")
            {
                return BadRequest("No file or an invalid one has been inputed.");
            }

            var path = Path.Combine(
                Directory.GetCurrentDirectory(), 
                $"uploaded_file_{Guid.NewGuid()}.pdf");

            using (var streem = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(streem);
            }

            return Ok("Your file has been uploaded successfully");

        }
    }
}
