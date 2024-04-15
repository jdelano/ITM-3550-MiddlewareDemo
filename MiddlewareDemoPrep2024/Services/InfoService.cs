using System;
using MiddlewareDemoPrep2024.Repositories;

namespace MiddlewareDemoPrep2024.Services;

public class InfoService
{
	private readonly InfoRepository _repository1;
	private readonly InfoRepository _repository2;
	public InfoService(InfoRepository repository1, InfoRepository repository2)
	{
		_repository1 = repository1;
		_repository2 = repository2;
	}

	public string GetInformation()
	{
		return $"{_repository1.Information} {_repository2.Information}";
	}
}

