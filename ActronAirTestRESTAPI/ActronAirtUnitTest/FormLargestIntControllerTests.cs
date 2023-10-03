using ActronAirTestRESTAPI.

namespace ActronAirtUnitTest;

[TestClass]
public class FormLargestIntControllerTests
{
    [TestMethod]
    public void FormLargestInt_ValidInput_ReturnsCorrectResult()
    {

        var controller = new LargestIntController ();
        var inputModel = new InputModel { Input = new int[] { 10, 223, 78, 90, 99 } };

    }
}
