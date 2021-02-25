using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Scrabble.Models;
using System;

namespace Scrabble.Tests
{
  [TestClass]
  public class ScrabbleTests : IDisposable
  {

    public void Dispose()
    {
      // ScrabbleScore.ClearAll();`
    }

    [TestMethod]
    public void ScrabbleScoreConstructor_CreatesInstanceOfScrabbleScore_ScrabbleScore()
    {
    ScrabbleScore newScore = new ScrabbleScore();
    Assert.AreEqual(typeof(ScrabbleScore), newScore.GetType());
    }

    [TestMethod]
    public void ScrabbleScoreDictionary_CreatesInstanceOfScrabbleScoreDictionary_ScrabbleScoreBoard()
    {
    // ScrabbleScore newScore = new ScrabbleScore();
    Dictionary<int, List<string>> test = new Dictionary<int, List<string>>() {
      {1, new List<string> {"A", "B"}} 
    };
    Dictionary<int, List<string>> result = ScrabbleScore.scrabbleScoreBoard;
    string test1 = string.Join(" ", test[1]);
    string result1 = string.Join(" ", result[1]);
    Assert.AreEqual(test1, result1);
    }

  }
}
  
  //   [TestMethod]
  //   public void GetDescription_ReturnsDescription_String()
  //   {
  //     //Arrange
  //     string description = "Walk the dog.";

  //     //Act
  //     Item newItem = new Item(description);
  //     string result = newItem.Description;

  //     //Assert
  //     Assert.AreEqual(description, result);
  //   }

  //   [TestMethod]
  //   public void SetDescription_SetDescription_String()
  //   {
  //     //Arrange
  //     string description = "Walk the dog.";
  //     Item newItem = new Item(description);

  //     //Act
  //     string updatedDescription = "Do the dishes";
  //     newItem.Description = updatedDescription;
  //     string result = newItem.Description;

  //     //Assert
  //     Assert.AreEqual(updatedDescription, result);
  //   }

  //   [TestMethod]
  //   public void GetAll_ReturnsEmptyList_ItemList()
  //   {
  //     // Arrange
  //     List<Item> newList = new List<Item> { };

  //     // Act
  //     List<Item> result = Item.GetAll();

  //     // Assert
  //     CollectionAssert.AreEqual(newList, result);
  //   }

  //   [TestMethod]
  //   public void GetAll_ReturnsItems_ItemList()
  //   {
  //     //Arrange
  //     string description01 = "Walk the dog";
  //     string description02 = "Wash the dishes";
  //     Item newItem1 = new Item(description01);
  //     Item newItem2 = new Item(description02);
  //     List<Item> newList = new List<Item> { newItem1, newItem2 };

  //     //Act
  //     List<Item> result = Item.GetAll();

  //     //Assert
  //     CollectionAssert.AreEqual(newList, result);
  //   }
  // }