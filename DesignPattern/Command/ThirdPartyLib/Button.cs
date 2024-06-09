namespace DesignPattern.Command.ThirdPartyLib
{
    // Invoker
    public class Button
    {
        private readonly IOnClickCommand _onClickCommand;

        public Button(IOnClickCommand onClickCommand)
        {
            this._onClickCommand = onClickCommand;
        }

        public void CLick()
        {
            this._onClickCommand.Click();
        }
    }
}