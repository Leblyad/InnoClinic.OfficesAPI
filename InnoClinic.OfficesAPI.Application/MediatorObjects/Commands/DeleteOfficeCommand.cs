using InnoCLinic.OfficesAPI.Core.Contracts.Repositories;
using InnoCLinic.OfficesAPI.Core.Exceptions.UserClassExceptions;
using MediatR;
using MongoDB.Bson;

namespace InnoClinic.OfficesAPI.Application.MediatorObjects.Commands
{
    public record DeleteOfficeCommand(string OfficeId) : IRequest
    {
        public class DeleteOfficeHandler : IRequestHandler<DeleteOfficeCommand, Unit>
        {
            private readonly IRepositoryManager _repositoryManager;

            public DeleteOfficeHandler(IRepositoryManager repositoryManager)
            {
                _repositoryManager = repositoryManager;
            }

            public async Task<Unit> Handle(DeleteOfficeCommand request, CancellationToken cancellationToken)
            {
                var objectId = new ObjectId(request.OfficeId);
                var office = await _repositoryManager.Office.GetOfficeAsync(objectId);

                if (office == null)
                {
                    throw new OfficeNotFoundException(objectId);
                }

                await _repositoryManager.Office.DeleteOfficeAsync(office);

                return Unit.Value;
            }
        }
    }
}
