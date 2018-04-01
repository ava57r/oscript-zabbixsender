using System;
using Newtonsoft.Json;

namespace OneScript.Zabbix
{
	public class Message
	{
		[JsonProperty(PropertyName = "request")]
		private readonly string request = "sender data"; 

		[JsonProperty(PropertyName = "data")] 
		private readonly SendValue[] data;

		public Message(SendValue sendvalue)
		{
			data = new [] { sendvalue };
		}
	}
}
