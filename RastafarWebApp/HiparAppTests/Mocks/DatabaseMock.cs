using Microsoft.EntityFrameworkCore;
using RastafarWebApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiparAppTests.Mocks
{
	public static class DatabaseMock
	{
        public static RastafarContext Instance { 
			get
			{
				var options = new DbContextOptionsBuilder<RastafarContext>()
					.UseInMemoryDatabase("HiparDbTest" + DateTime.Now.Ticks.ToString())
					.Options;


				return new RastafarContext(options, false);	
			}
		}
    }
}
