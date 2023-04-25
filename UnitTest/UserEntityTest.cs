using Apiwadokan.Service;
using Entities.Entities;
using Logic.Logic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MSTest
{
    [TestClass]
    public class UserEntityTest
    {
       
        
            public readonly UserLogic _userLogic;
            [TestMethod]
            public void UserItem_Constructor_IsActiveTrue()
            {
                // Arrange
                var userItem = new UserEntity();

            userItem.IdRol = 1;
            userItem.UserName = "veronicasm79@hotmail.com";
            //userItem.InsertDate = DateTime.Now;
            //userItem.UpdateDate = DateTime.Now;
            userItem.IsActive = true;
            // Act
            // Assert
            Assert.IsTrue(userItem.IsActive);
            }
            [TestMethod]
            public void ValidateModelTest()
            {
            // Arrange

            UserEntity usuarioA = null;
              UserEntity usuarioB = new UserEntity();
              usuarioB.IdRol = 0;
             usuarioB.UserName = "veronicasm79@hotmail.com";
             usuarioB.InsertDate = DateTime.Now;

             UserEntity usuarioC = new UserEntity();
              usuarioC.IdRol = 0;

            usuarioC.UserName = "KarateWadokanSev@gmail.com";

            usuarioC.InsertDate = DateTime.Now.AddDays(1000);

               // Act
             var usuarioAIsValid = UserService.ValidateModel(usuarioA);
               var usuarioBIsValid = UserService.ValidateModel(usuarioB);
               var usuarioCIsValid = UserService.ValidateModel(usuarioC);
              //// Assert
              Assert.AreEqual(false, usuarioAIsValid, "Custom error message");
              Assert.AreEqual(true, usuarioBIsValid, "Custom error message");
              Assert.AreEqual(true, usuarioCIsValid, "Custom error message");
            
            
            //UserEntity usuarioA = null;
            //var userItem = new UserEntity();
            //    var expectedUserName = "veronicasm79@hotmail.com";

            //    var expectedInsertDate = new DateTime(2023, 1, 1);
            //    //var expectedUpdateDate = new DateTime(2023, 1, 1);
            //    // Act
            //    userItem.UserName = expectedUserName;

            //    userItem.InsertDate = expectedInsertDate;
            //    //userItem.UpdateDate = expectedUpdateDate;
            //    // Assert
            //    Assert.AreEqual(expectedUserName, userItem.UserName);

            //    Assert.AreEqual(expectedInsertDate, userItem.InsertDate);
            //    //Assert.AreEqual(expectedUpdateDate, userItem.UpdateDate);
        }
        [TestMethod]
            public void UserEntity_EncryptedPassword_IsNotMappedToDatabase()
            {
                // Arrange
                var userItem = new UserEntity();
                var EncryptedPassword = "mypassword";
                // Act
                userItem.EncryptedPassword = EncryptedPassword;
                // Assert
                Assert.IsNull(userItem.GetType().GetProperty("EncryptedPassword").GetCustomAttributes(typeof(ColumnAttribute), true).FirstOrDefault());
                Assert.AreEqual(EncryptedPassword, userItem.EncryptedPassword);
            }
             //   // Arrange
             //  UserEntity usuarioA = null;
             //  UserEntity usuarioB = new UserEntity();
             //  usuarioB.Id = 0;
             // usuarioB.UserName = "veronicasm79@hotmail.com";
             //  usuarioB.InsertDate = DateTime.Now;

             //  UserEntity usuarioC = new UserEntity();
             //   usuarioC.Id = 0;

             //usuarioC.UserName = "KarateWadokanSev@gmail.com";

             // usuarioC.InsertDate = DateTime.Now.AddDays(1000);

             //   // Act
             //  var usuarioAIsValid = UserService.ValidateModel(usuarioA);
             //   var usuarioBIsValid = UserService.ValidateModel(usuarioB);
             //   var usuarioCIsValid = UserService.ValidateModel(usuarioC);
             //   //// Assert
             //   Assert.AreEqual(false, usuarioAIsValid, "Custom error message");
             //   Assert.AreEqual(true, usuarioBIsValid, "Custom error message");
             //   Assert.AreEqual(false, usuarioCIsValid, "Custom error message");
            }
        }
