// using Microsoft.VisualStudio.TestTools.UnitTesting;
// using HairSalon.Models;
// using System.Collections.Generic;
// using System;

// namespace HairSalon.Tests
// {
//   [TestClass]
//   public class StylistTest : IDisposable
//   {

//     public void Dispose()
//     {
//       Client.ClearAll();
//     }

//     public ClientTest()
//     {
//       DBConfiguration.ConnectionString = "server=localhost;user id=root;password=password;port=3306;database=hair_salon_test";
//     }

//     [TestMethod]
//     public void StylistConstructor_CreatesInstanceOfStylist_Stylist()
//     {
//       Stylist newStylist = new Stylist("Ada", "Test Stylist");
//       Assert.AreEqual(typeof(Stylist), newStylist.GetType());
//     }

//     [TestMethod]
//     public void GetName_ReturnsName_String()
//     {
//       string name = "Ada";
//       Stylist newStylist = new Stylist(name);

//       string result = newStylist.Name;

//       Assert.AreEqual(name, result);
//     }

//     [TestMethod]
//     public void GetId_ReturnsId_String()
//     {
//       string name = "Ada";
//       Stylist newStylist = new Stylist(name);

//       int result = newStylist.Id;

//       Assert.AreEqual(1, result);
//     }

//     [TestMethod]
//     public void GetAll_ReturnsAllStylistObjects_StylistList()
//     {
//       string name1 = "test one";
//       string name2 = "test two";
//       Stylist newStylist1 = new Stylist(name1);
//       Stylist newStylist2 = new Stylist(name2);
//       List<Stylist> newList = new List<Stylist> { newStylist1, newStylist2 };

//       List<Stylist> result = Stylist.GetAll();

//       CollectionAssert.AreEqual(newList, result);
//     }

//     [TestMethod]
//     public void Find_ReturnsCorrectStylist_Stylist()
//     {
//       string name1 = "test one";
//       string name2 = "test two";
//       Stylist newStylist1 = new Stylist(name1);
//       Stylist newStylist2 = new Stylist(name2);

//       Stylist result = Stylist.Find(2);

//       Assert.AreEqual(newStylist2, result);
//     }

//     [TestMethod]
//     public void AddItem_AssociatesItemWithStylist_ItemList()
//     {
//       string description = "Walk the dog.";
//       Item newItem = new Item(description);
//       List<Item> newList = new List<Item> { newItem };
//       string name = "Work";
//       Stylist newStylist = new Stylist(name);
//       newStylist.AddItem(newItem);

//       List<Item> result = newStylist.Items;

//       CollectionAssert.AreEqual(newList, result);
//     }
//   }
// }