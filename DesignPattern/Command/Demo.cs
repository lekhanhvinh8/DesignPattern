using DesignPattern.Command.ThirdPartyLib;

namespace DesignPattern.Command
{
    public static class Demo
    {
        public static void Play()
        {
            var addCustomerOnClickCommand = new AddCustomerOnClickCommand();
            var button = new Button(addCustomerOnClickCommand);
            
            // The click method base on the addCustomerOnClick, we can stored the addCustomerOnClick in variable, list, database to dynamically use it
            button.CLick();
        }
    }
}