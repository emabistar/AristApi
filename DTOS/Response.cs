using System;
namespace MusicalApp.DTOS
{
	public class Response<T>
	{
		public T? Data { get; set; }
		public bool Success { get; set; }
		public string Message { get; set; } = string.Empty;
	}
}

