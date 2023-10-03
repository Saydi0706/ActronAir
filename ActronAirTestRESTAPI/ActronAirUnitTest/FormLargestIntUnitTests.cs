using ActronAirTestRESTAPI.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace ActronAirUnitTest;

[TestClass]
public class FormLargestIntUnitTests
{
    [TestMethod]
    public void ValidInputResult()
    {
        // Arrange
        var controller = new LargestIntController();
        var inputModel = new InputModel { Input = new int[] { 10, 223, 78, 90, 99 } };


        // Act

        var result = controller.FormLargestInt(inputModel) as OkObjectResult;


        // Assert
        Assert.IsNotNull(result);
        Assert.AreEqual(200, result.StatusCode);
        Assert.AreEqual("99907822310", (result.Value as OutputModel)?.Output);

    }


    [TestMethod]
    public void InvalidInputResult()
    {
        // Arrange
        var controller = new LargestIntController();
        var inputModel = new InputModel { Input = null }; 

        // Act
        var result = controller.FormLargestInt(inputModel) as BadRequestObjectResult;

        // Assert
        Assert.IsNotNull(result);
        Assert.AreEqual(400, result.StatusCode);
        Assert.AreEqual("Invalid input array [non positive integers or empty array]", result.Value);
    }
}
