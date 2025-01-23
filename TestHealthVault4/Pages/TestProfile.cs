using Bunit;
using Microsoft.Extensions.DependencyInjection;
using HealthVault4.Pages;

namespace TestHealthVault4
{
	[Collection("HealthVault4")]
	public class TestProfile
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			var componentUnderTest = ctx.RenderComponent<Profile>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
