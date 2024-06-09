using DesignPattern.Command.ThirdPartyLib;

namespace DesignPattern.Command
{
    public class AddCustomerOnClickCommand : IOnClickCommand
    {
        public void Click()
        {
            var customerService = new CustomerService();
            customerService.AddCustomerToDB();
        }
    }
}