using Bunit;
using Microsoft.Extensions.DependencyInjection;
using HealthVault4.Pages;

namespace TestHealthVault4
{
	[Collection("HealthVault4")]
	public class TestEmergency
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			var componentUnderTest = ctx.RenderComponent<Emergency>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
