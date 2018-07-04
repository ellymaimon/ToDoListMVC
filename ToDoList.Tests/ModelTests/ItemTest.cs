using ToDoList.Models;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ToDoList.Tests
{
    [TestClass]
  public class ItemTest
  {
    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      //Arrange
      string description = "Walk the dog.";
      Item newItem = new Item(description);

      //Act
      string result = newItem.GetDescription();

      //Assert
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      //Arrange
      string description = "Walk the dog.";
      Item newItem = new Item(description);

      //Act
      newItem.SetDescription("Do the dishes");
      string result = newItem.GetDescription();

      //Assert
      Assert.AreEqual(description, result);
    }
  }
}
