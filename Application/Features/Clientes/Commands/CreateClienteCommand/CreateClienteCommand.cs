using Application.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Clientes.Commands.CreateClienteCommand
{
   public class CreateClienteCommand : IRequest<Response<int>>
    {

        private int _edad;
        public string NOmbre { get; set; }
        public String Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public String Telefono { get; set; }
        public String Email { get; set; }
        public String Direccion { get; set; }
    }
    public class CreateClienteCommandHandler : IRequestHandler<CreateClienteCommand, Response<int>>
{
        public async Task<Response<int>> Handle(CreateClienteCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
