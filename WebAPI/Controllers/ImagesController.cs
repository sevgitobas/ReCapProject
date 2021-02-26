using Business.Abstract;
using Core.Utilities.FileOperations;
using Entities.Concrete;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        ICarImageService _carImageService;
        IWebHostEnvironment _webHostEnvironment;
        

        public ImagesController(ICarImageService carImageService, IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
            _carImageService = carImageService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var context = _carImageService.GetAll();
            if (!context.Success)
            {
                return BadRequest(context);
            }
            return Ok(context);
        }

        [HttpPost("add")]
        public IActionResult Add(IFormFile imageFile, int carId)
        {
            if (!FileOperations.CheckImageFile(imageFile))
            {
                return BadRequest(new { Message = "Resim dosya formatı hatalı!" });
            }
            string newImageName = Guid.NewGuid() + Path.GetExtension(imageFile.FileName);
            var result = _carImageService.Add(new CarImage { CarId = carId, ImagePath = newImageName });
            if (result.Success)
            {
                FileOperations.WriteImageFile(imageFile, @"wwwroot\images", newImageName);
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(CarImage carImage)
        {
            var context = _carImageService.Delete(carImage);
            if (context.Success)
            {
                return Ok(context);
            }
            return BadRequest(context);
        }

        [HttpPost("update")]
        public IActionResult Update(CarImage carImage)
        {
            var context = _carImageService.Update(carImage);
            if (context.Success)
            {
                return Ok(context);
            }
            return BadRequest(context);
        }
    }
}
