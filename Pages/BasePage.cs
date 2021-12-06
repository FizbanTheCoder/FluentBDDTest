using Atata;
using static Atata.TriggerEvents;
namespace IFlow.Testing.Pages
{
    [Screenshot(AfterAnyAction)]
    public abstract class BasePage<TOwner> : Page<TOwner>
        where TOwner : BasePage<TOwner>
    {
        public void AcceptAlert()
        {
            AtataContext.Current.Driver.SwitchTo().Alert().Accept();
        }

        public string GetAlertMessage()
        {
            return AtataContext.Current.Driver.SwitchTo().Alert().Text;
        }
    }
}