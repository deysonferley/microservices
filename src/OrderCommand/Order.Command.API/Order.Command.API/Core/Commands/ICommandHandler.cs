using System.Threading.Tasks;

namespace Order.Command.API.Core.Commands
{
    public interface ICommandHandler<in TCommand> where TCommand : class, ICommand
    {
        Task<CommandResponse> HandleAsync(TCommand command);
    }
}