using System;
using ETicaretAPI.Domain.Entities;
using System.Collections.Generic;

namespace ETicaretAPI.Application.Abstractions
{
	public interface IProductService
	{

		List<Product> GetProducts();

	}
}

