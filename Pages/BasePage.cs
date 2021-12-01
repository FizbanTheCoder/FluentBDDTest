using Atata;
using static Atata.TriggerEvents;
namespace IFlow.Testing.Pages
{
    [Screenshot(AfterAnyAction)]
    public abstract class BasePage<TOwner> : Page<TOwner>
        where TOwner : BasePage<TOwner>
    {
        public int[] GetElementSize(Text<TOwner> element)
        {
            var mesurements = new int[2] { element.ComponentSize.Width.Value, element.ComponentSize.Height.Value };
            return mesurements;
        }
    }
}