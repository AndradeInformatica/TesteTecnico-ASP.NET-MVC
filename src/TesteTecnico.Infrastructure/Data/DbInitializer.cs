using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace TesteTecnico.Infrastructure.Data
{
    public static class DbInitializer
    {
        public static void Initialize(TesteTecnicoContext context)
        {
            if (context.People.Any())
                return;
        }
    }
}
