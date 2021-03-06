using Bunit;
using Xunit;

namespace Radzen.Blazor.Tests
{
    public class LinkTests
    {
        [Fact]
        public void Link_Renders_TextParameter()
        {
            using var ctx = new TestContext();

            var component = ctx.RenderComponent<RadzenLink>();

            var text = "Test";

            component.SetParametersAndRender(parameters => parameters.Add(p => p.Text, text));

            Assert.Contains(@$">{text}</span>", component.Markup);
            Assert.Contains(@$"class=""rz-link-text""", component.Markup);
        }

        [Fact]
        public void Link_Renders_IconParameter()
        {
            using var ctx = new TestContext();

            var component = ctx.RenderComponent<RadzenLink>();

            var icon = "Test";

            component.SetParametersAndRender(parameters => parameters.Add(p => p.Icon, icon));

            Assert.Contains(@$"<i class=""rzi"">{icon}</i>", component.Markup);
        }

        [Fact]
        public void Link_Renders_PathParameter()
        {
            using var ctx = new TestContext();

            var component = ctx.RenderComponent<RadzenLink>();

            var path = "Test";

            component.SetParametersAndRender(parameters => parameters.Add(p => p.Path, path));

            Assert.Contains(@$"<a href=""{path}""", component.Markup);
        }

        [Fact]
        public void Link_Renders_TargetParameter()
        {
            using var ctx = new TestContext();

            var component = ctx.RenderComponent<RadzenLink>();

            var target = "_blank";

            component.SetParametersAndRender(parameters => parameters.Add(p => p.Target, target));

            Assert.Contains(@$"target=""{target}""", component.Markup);
        }

        [Fact]
        public void Icon_Renders_UnmatchedParameter()
        {
            using var ctx = new TestContext();

            var component = ctx.RenderComponent<RadzenIcon>();

            component.SetParametersAndRender(parameters => parameters.AddUnmatched("autofocus", ""));

            Assert.Contains(@$"autofocus", component.Markup);
        }
    }
}
