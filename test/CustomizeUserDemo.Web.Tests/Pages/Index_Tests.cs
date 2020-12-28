using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace CustomizeUserDemo.Pages
{
    public class Index_Tests : CustomizeUserDemoWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
