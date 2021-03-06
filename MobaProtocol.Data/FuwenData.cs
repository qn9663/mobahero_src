using ProtoBuf;
using System;

namespace MobaProtocol.Data
{
	[ProtoContract]
	public class FuwenData
	{
		[ProtoMember(1)]
		public int SummonerId
		{
			get;
			set;
		}

		[ProtoMember(2)]
		public int Power
		{
			get;
			set;
		}

		[ProtoMember(3)]
		public int Intelligence
		{
			get;
			set;
		}

		[ProtoMember(4)]
		public int Agile
		{
			get;
			set;
		}
	}
}
