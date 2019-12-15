using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HairSalon.Models;
using MySql.Data.MySqlClient;


namespace HairSalon.Tests
{
  [TestClass]
  public class ClientTest : IDisposable
  {

    public void Dispose()
    {
      Client.ClearAll();
    }

    public ClientTest()
    {
      DBConfiguration.ConnectionString = "server=localhost;user id=root;password=password;port=3306;database=hair_salon_test";
    }

    // [TestMethod]
    // public void ClientConstructor_CreatesInstanceOfClient_Client()
    // {
    //   Client newClient = new Client("test");
    //   Assert.AreEqual(typeof(Client), newClient.GetType());
    // }

    // [TestMethod]
    // public void GetDescription_ReturnsDescription_String()
    // {
    //   string description = "Walk the dog.";
    //   Client newClient = new Client(description);

    //   string result = newClient.Description;

    //   Assert.AreEqual(description, result);
    // }

    // [TestMethod]
    // public void SetDescription_SetDescription_String()
    // {
    //   string description = "Walk the dog.";
    //   Client newClient = new Client(description);

    //   string updatedDescription = "Do the dishes";
    //   newClient.Description = updatedDescription;
    //   string result = newClient.Description;

    //   Assert.AreEqual(updatedDescription, result);
    // }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_ClientList()
    {
      List<Client> newList = new List<Client> { };

      List<Client> result = Client.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    // [TestMethod]
    // public void Equals_ReturnsTrueIfDescriptionsAreTheSame_Client()
    // {
    //   Client firstClient = new Client("Mow the lawn");
    //   Client secondClient = new Client("Mow the lawn");

    //   Assert.AreEqual(firstClient, secondClient);
    // }

    // [TestMethod]
    // public void Save_SavesToDatabase_ClientList()
    // {
    //   Client testClient = new Client("Mow the lawn");

    //   testClient.Save();
    //   List<Client> result = Client.GetAll();
    //   List<Client> testList = new List<Client>{testClient};

    //   CollectionAssert.AreEqual(result,testList);
    // }

    // [TestMethod]
    // public void GetAll_ReturnsClients_ClientList()
    // {
    //   string description01 = "Walk the dog";
    //   string description02 = "Do the dishes";
    //   Client newClient1 = new Client(description01);
    //   newClient1.Save();
    //   Client newClient2 = new Client(description02);
    //   newClient2.Save();
    //   List<Client> newList = new List<Client> { newClient1, newClient2 };

    //   List<Client> result = Client.GetAll();

    //   CollectionAssert.AreEqual(newList, result);
    // }

    // [TestMethod]
    // public void GetId_ClientsInstantiateWithAnIdAndGetterReturns_Int()
    // {
    //   string description = "Walk the dog";
    //   Client newClient = new Client(description);

    //   int result = newClient.Id;

    //   Assert.AreEqual(1,result);
    // }

    // [TestMethod]
    // public void Find_ReturnsCorrectClientFromDatabase_Client()
    // {
    //   string description01 = "Walk the dog";
    //   string description02 = "Wash the Dishes";
    //   Client newClient1 = new Client(description01);
    //   newClient1.Save();
    //   Client newClient2 = new Client(description02);
    //   newClient2.Save();


    //   Client result = Client.Find(newClient2.Id);

    //   Assert.AreEqual(newClient2, result);
    // }
  }
}