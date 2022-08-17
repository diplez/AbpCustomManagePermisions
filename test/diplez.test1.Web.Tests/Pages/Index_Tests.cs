using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace diplez.test1.Pages;

public class Index_Tests : test1WebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
