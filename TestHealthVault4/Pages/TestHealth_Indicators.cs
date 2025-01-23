using Bunit;
using Microsoft.Extensions.DependencyInjection;
using HealthVault4.Pages;
using HealthVault4.PatientDashboard;

namespace TestHealthVault4
{
	[Collection("HealthVault4")]
	public class TestHealth_Indicators
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbCategoryChartModule));
			ctx.Services.AddScoped<IPatientDashboardService>(sp => new MockPatientDashboardService());
			var componentUnderTest = ctx.RenderComponent<Health_Indicators>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
