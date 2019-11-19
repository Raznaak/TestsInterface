using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PoolSaison2019.Controllers;
using PoolSaison2019.Data;
using PoolSaison2019.Models;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public async Task Test_Joueur_Index_Returns_A_ViewResult()
        {
            // Arrange
            var mockRepo = new MockJoueurRepository();
            var controller = new JoueursController(mockRepo);

            // Act
            var result = await controller.Index();

            // Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public async Task Test_Joueur_Index_Model_Is_An_Enumerable_Model_of_Joueurs()
        {
            // Arrange
            var mockRepo = new MockJoueurRepository();
            var controller = new JoueursController(mockRepo);

            //Act
            var result = await controller.Index() as ViewResult;
            var model = result.ViewData.Model;

            //Assert
            Assert.IsAssignableFrom<IEnumerable<Joueur>>(model);
        }

        [Fact]
        public async Task Test_Index_Model_Contains_Joueurs()
        {
            // Arrange
            var mockRepo = new MockJoueurRepository();
            var controller = new JoueursController(mockRepo);

            //Act
            var result = await controller.Index() as ViewResult;
            var model = result.ViewData.Model;
            var list = model as IEnumerable<Joueur>;

            //Assert
            Assert.Equal(3, list.Count());
        }
    }
}
