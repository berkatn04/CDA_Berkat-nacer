using Microsoft.EntityFrameworkCore;
using System;

namespace WebApplication1

{

	public class MyDbContext : DbContext
	{
		public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
		{

		}
	}
}