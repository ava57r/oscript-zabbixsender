using Newtonsoft.Json;
using System;
using ScriptEngine.Machine.Contexts;
using ScriptEngine.Machine;

namespace OneScript.Zabbix
{
	[ContextClass("ПолученныйОтвет", "SenderResponse")]
	public class SenderResponse: AutoContext<SenderResponse>
	{
		public SenderResponse()
		{

		}

		[ContextProperty("Ответ", "Response")]
		[JsonProperty(PropertyName = "response")]
		public string Response { get; set; } = "";

		[ContextProperty("Инфо", "Info")]
		[JsonProperty(PropertyName = "info")]
		public string Info { get; set; } = "";

		[ContextProperty("Успех", "Success")]
		public bool Success { get { return Response == "success"; }}

		[ScriptConstructor]
		public static IRuntimeContextInstance Constructor()
		{
			return new SenderResponse();
		}
	}
}
