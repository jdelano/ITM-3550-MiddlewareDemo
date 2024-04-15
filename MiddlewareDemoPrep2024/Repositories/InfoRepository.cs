using System;
namespace MiddlewareDemoPrep2024.Repositories;

public class InfoRepository
{
	public string Information { get; set; }

	public InfoRepository()
	{
		Random random = new Random();
		Information = $"Hello World! {random.Next()}";
	}
}

