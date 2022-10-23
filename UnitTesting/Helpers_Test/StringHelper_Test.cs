using Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Helpers_Test
{
  [TestClass]
  public class StringHelper_Test
  {
    [TestMethod]
    public void Excess_Spaces_Should_Be_Deleted_StartEnd()
    {
      //Arrange

      var text = " deneme ";
      var excepted = "deneme";

      //Act
      var happening = StringHelper.DeleteBlanks(text);

      //Assert
      Assert.AreEqual(excepted, happening);
    }
    [TestMethod]
    public void Excess_Spaces_Should_Be_Deleted()
    {
      //Arrange

      var text = "deneme   deneme    deneme deneme    deneme ";
      var excepted = "deneme deneme deneme deneme deneme";

      //Act
      var happening = StringHelper.DeleteBlanks(text);

      //Assert
      Assert.AreEqual(excepted, happening);
    }
  }
 }

