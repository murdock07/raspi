using System;

namespace Raspi
{
	public class MessagingClass
	{
		public MessagingClass ()
		{
		}

		public static void SendMessage(string text)
		{
			Console.WriteLine("Debug: message sent");
		}

		public static void ClearHistory()
		{
			Console.WriteLine ("Debug: history cleared");
		}
	}
}

