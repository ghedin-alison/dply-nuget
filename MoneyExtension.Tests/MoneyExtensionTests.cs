namespace MoneyExtension.Tests;

[TestClass]
public class MoneyExtensionTests
{
    [TestMethod]
    public void ShouldConvertDecimalToInt()
    {
        decimal valor = new decimal(279.98);

        var cents = valor.ToCents();
        
        Assert.AreEqual(27998, cents);
    }
}