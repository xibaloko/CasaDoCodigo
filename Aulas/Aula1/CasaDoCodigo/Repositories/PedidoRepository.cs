using CasaDoCodigo.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Repositories
{
    public interface IPedidoRepository
    {

    }

    public class PedidoRepository : BaseRepository<Pedido>, IPedidoRepository
    {
        private readonly IHttpContextAccessor _contextAccessor;

        public PedidoRepository(AppContext context, IHttpContextAccessor contextAccessor) : base(context)
        {
            _contextAccessor = contextAccessor;
        }

        public int? GetPedidoId()
        {
            return _contextAccessor.HttpContext.Session.GetInt32("pedidoId");
        }

        public void SetPedidoId(int pedidoId)
        {
            _contextAccessor.HttpContext.Session.SetInt32("pedidoId", pedidoId);
        }
    }
}
