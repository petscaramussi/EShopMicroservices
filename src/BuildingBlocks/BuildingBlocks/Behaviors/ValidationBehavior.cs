using BuildingBlocks.CQRS;
using MediatR;

namespace BuildingBlocks.Behaviors;

internal class ValidationBehavior<TRequest, TResponse>
    : IPipelineBehavior<TRequest, TResponse>
    where TRequest : ICommand<TRequest>
{
    public Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}

