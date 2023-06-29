using Polymorphism;
using Shouldly;

namespace UnitTest.OOP
{
    public class PolymorphismUnitTest
    {
        [Fact]
        public void GivenDrawUIControlMethod_WhenIInitiateWithTextBox_AndCallDraw_ItShouldDrawATextBox()
        {
            Main.DrawAnUiControl(new TextBox()).ShouldBeEquivalentTo(new TextBox().Draw());
        }

        [Fact]
        public void GivenDrawUIControlMethod_WhenIInitiateWithCheckBox_ItShouldDrawACheckBox()
        {
            Main.DrawAnUiControl(new CheckBox()).ShouldBeEquivalentTo(new CheckBox().Draw());
        }

        [Fact]
        public void GivenDrawUIControlMethod_WhenIInitiateWithUnImplementedUIControl_ItShouldThrowNotImplementedException()
        {
            Action drawUiAction = () => Main.DrawAnUiControl(new UnImplementedUiControl());
            drawUiAction.ShouldThrow<NotImplementedException>();
        }
    }
}