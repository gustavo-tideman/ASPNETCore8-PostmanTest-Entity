using Microsoft.AspNetCore.Mvc;
using WebAPI.Entity;

namespace ASPNETCore8_PostmanTest_Entity.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class EntityController : Controller
    {
        private readonly Context _context;

        public EntityController(Context context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult SaveData()
        {
            PostmanPipeline model = new PostmanPipeline
            {
                Text = "Test +  " + DateTime.Now.ToString()
            };

            _context.PostmanPipeline.Add(model);
            _context.SaveChanges();

            return Ok(model);
        }

        [HttpGet]
        public List<PostmanPipeline> ListData()
        {
            List<PostmanPipeline> test = _context.PostmanPipeline.ToList();

            return test;
        }

        [HttpGet]
        public IActionResult GetData(Guid id)
        {
            PostmanPipeline? test = _context.PostmanPipeline.Where(p => p.Id == id).FirstOrDefault();

            if (test != null)
            {
                return Ok(test);
            }

            return NotFound();
        }

        [HttpPut]
        public IActionResult UpdateData(Guid id)
        {
            PostmanPipeline model = new PostmanPipeline
            {
                Id = id,
                Text = "Updated +  " + DateTime.Now.ToString()
            };

            _context.PostmanPipeline.Update(model);
            _context.SaveChanges();

            return Ok(model);
        }

        [HttpDelete]
        public IActionResult DeleteData(Guid id)
        {
            PostmanPipeline? test = _context.PostmanPipeline.Where(p => p.Id == id).FirstOrDefault();

            if (test != null)
            {
                _context.PostmanPipeline.Remove(test);
                _context.SaveChanges();
                return Ok();
            }

            return NotFound();
        }
    }
}
