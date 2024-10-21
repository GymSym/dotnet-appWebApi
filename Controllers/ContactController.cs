using dotnet_appWebApi.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace dotnet_appWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private List<Contact> contacts = new List<Contact>
        {
            new Contact { Id = 1,FirstName="Mayank", LastName="Sharma",Place="Delhi"},
            new Contact { Id = 2,FirstName="Chandan", LastName="Sah",Place="Tamil Nadu"}
        };

        // GET: api/<ContactController>
        [HttpGet]
        public ActionResult<IEnumerable<Contact>> Get()
        {
            //return new string[] { "value1", "value2" };
            return contacts;
        }

        // GET api/<ContactController>/5
        [HttpGet("{id}")]
        public ActionResult<Contact> Get(int id)
        {
            Contact contact = contacts.FirstOrDefault(c => c.Id == id);
            if(contact == null)
            {
                return NotFound(new {Message ="Contact has not been found"});
            }
            return Ok(contact);
        }

        // POST api/<ContactController>
        [HttpPost]
        public ActionResult<IEnumerable<Contact>> Post(Contact contact)
        {
          contacts.Add(contact);
            return contacts;
        }

        // PUT api/<ContactController>/5
        [HttpPut("{id}")]
        public ActionResult<IEnumerable<Contact>> Put(int id, Contact updatecontact)
        {
            Contact contact = contacts.FirstOrDefault(c=>c.Id == id);
            if(contact == null)
            {
                return NotFound("Contact has not been found");
            }
            contact.LastName = updatecontact.LastName;
            contact.FirstName = updatecontact.FirstName;

            return contacts;
        }

        // DELETE api/<ContactController>/5
        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<Contact>> Delete(int id)
        {
            Contact contact = contacts.FirstOrDefault(c => c.Id == id);
            if (contact == null)
            {
                return NotFound("Contact has not been found");
            }

            contacts.Remove(contact);

            return contacts;
        }
    }
}
