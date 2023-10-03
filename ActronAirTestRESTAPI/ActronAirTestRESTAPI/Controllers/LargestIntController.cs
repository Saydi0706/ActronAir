using Microsoft.AspNetCore.Mvc;


namespace ActronAirTestRESTAPI.Controllers
{

    public class InputModel
    {
        public int[] Input { get; set; }
    }

    public class OutputModel
    {
        public string Output { get; set; }
    }


    [Route("api/v0/formLargestInt")]

    public class LargestIntController : Controller
    {

        [HttpPost]
        public IActionResult FormLargestInt([FromBody] InputModel inputModel)
        {
            if (inputModel == null || inputModel.Input == null || inputModel.Input.Length == 0)
            {
                return BadRequest("Invalid input array [non positive integers or empty array]");
            }

            var sortedIntegers = inputModel.Input.OrderByDescending(num => num.ToString(),
                StringComparer.Create(System.Globalization.CultureInfo.InvariantCulture, false)).ToArray();

            var largestInt = string.Join("", sortedIntegers);

            return Ok(new OutputModel { Output = largestInt });
        }

    }
}

