using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestApi.Controllers.api
{
    [Route("api/order")]
    [ApiController]

    public class OrderController : ControllerBase
    {

        private IOrderService _orderService;

        public OrderController()
        {
            //Dependency Injection ile
            //OrderService üzerinden order managere gevşek bağımlılık yaptık.

            _orderService = new OrderManager(new EfOrderDal());
        }

        [HttpGet]
        public IActionResult Get()
        {
            // Order listesi dondurmek ıcın gerekli api
            var orders = _orderService.GetAll();
            if (orders != null)
            {
                return Ok(orders);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            //Tek bir order dondurmek ıcın gerekli api
            var order = _orderService.GetById(id);
            if (order != null)
            {
                return Ok(order);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult Add([FromBody] Order order)
        {        
           //Order ekleme işlemi için gerekli api
           if (order == null) return BadRequest();

            var obj = _orderService.Add(order); 

            if (obj != null) return Ok();

            else return NotFound();
        }
    }
}
