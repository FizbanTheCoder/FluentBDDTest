using System;
using System.Collections.Generic;
using System.Text;
using Atata;
using static Atata.TriggerEvents;
namespace IFlow.WebTests.Pages
{
    [Screenshot(AfterAnyAction)]
    public abstract class BasePage<TOwner> : Page<TOwner>
        where TOwner : BasePage<TOwner>
    {
  
    }
}