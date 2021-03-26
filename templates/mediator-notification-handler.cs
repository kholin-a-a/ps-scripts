using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace WTM.BusinessLogic.Mediator
{
  public class $($Name): INotificationHandler<$($Name -replace "Handler", "")>
  {
    public $Name()
    {
    }

    public Task Handle($($Name -replace "Handler", "") notification, CancellationToken cancellationToken)
    {
      return Task.CompletedTask;
    }
  }
}
