using Bunit;
using Microsoft.Extensions.DependencyInjection;
using HealthVault4.Pages;

namespace TestHealthVault4
{
	[Collection("HealthVault4")]
	public class TestHome
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbListModule),
				typeof(IgbIconButtonModule),
				typeof(IgbRippleModule));
			var componentUnderTest = ctx.RenderComponent<Home>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
