namespace GithubActionsLab;

[TestClass]
public class Addition
{
	[TestMethod]
	public void Add_Valid_Patino()
	{
		Assert.AreEqual(3, Program.Add("1", "2"));
		Assert.AreEqual(5, Program.Add("3", "2"));
		Assert.AreEqual(12, Program.Add("5", "7"));
	}

	[TestMethod]
	public void Add_Invalid_Patino()
	{
		Assert.ThrowsException<FormatException>(() => Program.Add("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "a"));
	}

	[TestMethod]
	public void Add_Null_Patino()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, null));
	}
}

[TestClass]

public class Subtraction
{
	[TestMethod]
	public void Subtract_Valid_Harris() 	
	{
		Assert.AreEqual(1, Program.Subtract("3", "2"));
		Assert.AreEqual(0, Program.Subtract("2", "2"));
		Assert.AreEqual(-5, Program.Subtract("2", "7"));
    }

	[TestMethod]
	public void Subtract_Invalid_Harris() 	
	{
		Assert.ThrowsException<FormatException>(() => Program.Subtract("1", "b"));
		Assert.ThrowsException<FormatException>(() => Program.Subtract("b", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Subtract("b", "b"));
    }

	[TestMethod]
	public void Subtract_Null_Harris() 	
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, null));
    }
}

[TestClass]
public class Multiplication
{
	[TestMethod]
	public void Multiply_Valid_Harris() 	
	{
		Assert.AreEqual(6, Program.Multiply("3", "2"));
		Assert.AreEqual(0, Program.Multiply("2", "0"));
		Assert.AreEqual(14, Program.Multiply("2", "7"));
    }

	[TestMethod]
	public void Multiply_Invalid_Harris() 	
	{
		Assert.ThrowsException<FormatException>(() => Program.Multiply("1", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Multiply("c", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Multiply("c", "c"));
    }

	[TestMethod]
	public void Multiply_Null_Harris() 	
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, null));
    }
}

[TestClass]
public class Division
{
	[TestMethod]
	public void Divide_Valid_Harris() 	
	{
		Assert.AreEqual(2, Program.Divide("4", "2"));
		Assert.AreEqual(5, Program.Divide("10", "2"));
		Assert.AreEqual(3, Program.Divide("9", "3"));
	}

	[TestMethod]
	public void Divide_Invalid_Harris() 	
	{
		Assert.ThrowsException<FormatException>(() => Program.Divide("1", "d"));
		Assert.ThrowsException<FormatException>(() => Program.Divide("d", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Divide("d", "d"));
	}

	[TestMethod]
	public void Divide_Null_Harris() 	
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Divide("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, null));
	}