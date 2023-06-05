using System.Threading.Tasks;
using myLinkify.Models.TokenAuth;
using myLinkify.Web.Controllers;
using Shouldly;
using Xunit;

namespace myLinkify.Web.Tests.Controllers
{
    public class HomeController_Tests: myLinkifyWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}