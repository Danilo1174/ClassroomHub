using System;
using System.Runtime.Serialization;

namespace ClassroomHub.Web.Controllers
{
	[Serializable]
	internal class InvalidDateExeception : Exception
	{
		public InvalidDateExeception()
		{
		}

		public InvalidDateExeception(string message) : base(message)
		{
		}

		public InvalidDateExeception(string message, Exception innerException) : base(message, innerException)
		{
		}

		protected InvalidDateExeception(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}