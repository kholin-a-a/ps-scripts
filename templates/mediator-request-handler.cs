using MediatR;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace WTM.BusinessLogic.Mediator
{
  public class $($Name): IRequestHandler<$($Name -replace "Handler", "")>
  {
    public $Name ()
    {

    }

    public async Task<Unit> Handle($($Name -replace "Handler", "") request, CancellationToken cancellationToken)
    {
      throw new NotImplementedException();
    }
  }
}