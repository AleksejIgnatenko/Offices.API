using MediatR;
using Offices.Application.Offices.Models;

namespace Offices.Application.Offices.UseCases.GetAll;

public sealed class GetAllOfficesQuery : IRequest<IEnumerable<GetAllOfficesResponse>>
{
}