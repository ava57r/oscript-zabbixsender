using System;
using Newtonsoft.Json;

namespace OneScript.Zabbix
{
		public struct SendValue
		{
		[JsonProperty(PropertyName = "host")]
		public string Host { get; set; }

		[JsonProperty(PropertyName = "key")]
		public string Key { get; set; }

		[JsonProperty(PropertyName = "value")]
		public string Value { get; set; }
		}
}
