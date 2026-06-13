using System.IO;
using System.Text;

namespace LitJson
{
	internal class Lexer
	{
		private delegate bool StateHandler(FsmContext ctx);

		private static int[] fsm_return_table;

		private static StateHandler[] fsm_handler_table;

		private bool allow_comments;

		private bool allow_single_quoted_strings;

		private bool end_of_input;

		private FsmContext fsm_context;

		private int input_buffer;

		private int input_char;

		private TextReader reader;

		private int state;

		private StringBuilder string_buffer;

		private string string_value;

		private int token;

		private int unichar;

		public bool AllowComments
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
			set
			{
			}
		}

		public bool AllowSingleQuotedStrings
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
			set
			{
			}
		}

		public bool EndOfInput
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		public int Token
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		public string StringValue
		{
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		public Lexer(TextReader reader)
		{
		}

		static Lexer()
		{
		}

		private static int HexValue(int digit)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static void PopulateFsmTables()
		{
		}

		private static char ProcessEscChar(int esc_char)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static bool State1(FsmContext ctx)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static bool State2(FsmContext ctx)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static bool State3(FsmContext ctx)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static bool State4(FsmContext ctx)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static bool State5(FsmContext ctx)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static bool State6(FsmContext ctx)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static bool State7(FsmContext ctx)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static bool State8(FsmContext ctx)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static bool State9(FsmContext ctx)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static bool State10(FsmContext ctx)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static bool State11(FsmContext ctx)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static bool State12(FsmContext ctx)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static bool State13(FsmContext ctx)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static bool State14(FsmContext ctx)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static bool State15(FsmContext ctx)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static bool State16(FsmContext ctx)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static bool State17(FsmContext ctx)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static bool State18(FsmContext ctx)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static bool State19(FsmContext ctx)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static bool State20(FsmContext ctx)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static bool State21(FsmContext ctx)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static bool State22(FsmContext ctx)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static bool State23(FsmContext ctx)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static bool State24(FsmContext ctx)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static bool State25(FsmContext ctx)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static bool State26(FsmContext ctx)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static bool State27(FsmContext ctx)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private static bool State28(FsmContext ctx)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private bool GetChar()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private int NextChar()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		public bool NextToken()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		private void UngetChar()
		{
		}
	}
}
