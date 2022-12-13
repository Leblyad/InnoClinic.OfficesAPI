﻿using InnoClinic.OfficesAPI.Application.DataTransferObjects;
using MediatR;

namespace InnoClinic.OfficesAPI.Application.MediatorObjects.Queries
{
    public record GetOfficeQuery(string officeId) : IRequest<OfficeDTO>;
}