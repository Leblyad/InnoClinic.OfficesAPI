using InnoClinic.OfficesAPI.Application.DataTransferObjects;
using MediatR;

namespace InnoClinic.OfficesAPI.Application.MediatorObjects.Commands
{
    public class OfficeForUpdateCommand : OfficeForManipulation, IRequest
    {
        private string Id;

        public string GetId()
        {
            return Id;
        }

        public void SetId(string id)
        {
            Id = id;
        }
    }
}
