using System;
using FazBem.Models;

namespace FazBem.Interfaces
{
	public interface IProductRepository
	{
		Product GetProductByBarCode(string barCode);
	}
}

