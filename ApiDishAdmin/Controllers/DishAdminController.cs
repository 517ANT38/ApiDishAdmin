using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiDishAdmin.Controllers
{
    [Route("api/adminDishes")]
    //[EnableCors("MyPolicy")]
    [ApiController]
    public class DishAdminController : ControllerBase
    {
        private IRepository repository=new Repository();
        // GET: api/<DishAdminController>
        [HttpGet("all")]

        public IEnumerable<Dish> Get()
        {
            
            return repository.GetAll();
        }




        // POST api/<DishAdminController>
        [HttpPost("add")]
        public PostResponse  Post([FromBody] NewDish value)
        {
            //Console.WriteLine(value.Img);
            var id = new PostResponse() { PostId = repository.Add(value) };
            Console.WriteLine(id.PostId);
             return   id;
        }

       

        // DELETE api/<DishAdminController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            repository.Delete(id);  
        }
    }
}
