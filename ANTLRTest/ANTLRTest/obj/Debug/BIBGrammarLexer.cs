//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from D:\Git\IwSK\ANTLRTest\ANTLRTest\BIBGrammar.g4 by ANTLR 4.3

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591

namespace ANTLRTest {
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.3")]
[System.CLSCompliant(false)]
public partial class BIBGrammarLexer : Lexer {
	public const int
		Assign=1, Concat=2, Comma=3, CloseBrace=4, QuotedContent=5, BracedContent=6, 
		StringType=7, PreambleType=8, CommentType=9, Type=10, Number=11, Name=12, 
		Spaces=13;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] tokenNames = {
		"'\\u0000'", "'\\u0001'", "'\\u0002'", "'\\u0003'", "'\\u0004'", "'\\u0005'", 
		"'\\u0006'", "'\\u0007'", "'\b'", "'\t'", "'\n'", "'\\u000B'", "'\f'", 
		"'\r'"
	};
	public static readonly string[] ruleNames = {
		"Assign", "Concat", "Comma", "CloseBrace", "QuotedContent", "BracedContent", 
		"StringType", "PreambleType", "CommentType", "Type", "Number", "Name", 
		"Spaces", "Letter", "Digit", "SP"
	};


	public BIBGrammarLexer(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

	public override string GrammarFileName { get { return "BIBGrammar.g4"; } }

	public override string[] TokenNames { get { return tokenNames; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public override void Action(RuleContext _localctx, int ruleIndex, int actionIndex) {
		switch (ruleIndex) {
		case 12 : Spaces_action(_localctx, actionIndex); break;
		}
	}
	private void Spaces_action(RuleContext _localctx, int actionIndex) {
		switch (actionIndex) {
		case 0: break;
		}
	}

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2\xF\x97\b\x1\x4"+
		"\x2\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b"+
		"\x4\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4"+
		"\x10\t\x10\x4\x11\t\x11\x3\x2\x3\x2\x3\x3\x3\x3\x3\x4\x3\x4\x3\x5\x3\x5"+
		"\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\a\x6\x31\n\x6\f\x6\xE\x6\x34\v\x6\x3\x6"+
		"\x3\x6\x3\a\x3\a\x3\a\x3\a\x3\a\a\a=\n\a\f\a\xE\a@\v\a\x3\a\x3\a\x3\b"+
		"\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x5\bL\n\b\x3\b\x3\b\x3\t\x3\t\x3\t"+
		"\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x5\tZ\n\t\x3\t\x3\t\x3\n\x3\n\x3\n"+
		"\x3\n\x3\n\x3\n\x3\n\x3\n\x3\n\x5\ng\n\n\x3\n\x3\n\x3\n\a\nl\n\n\f\n\xE"+
		"\no\v\n\x5\nq\n\n\x3\v\x3\v\x6\vu\n\v\r\v\xE\vv\x3\v\x5\vz\n\v\x3\v\x3"+
		"\v\x3\f\x6\f\x7F\n\f\r\f\xE\f\x80\x3\r\x3\r\x3\r\x3\r\a\r\x87\n\r\f\r"+
		"\xE\r\x8A\v\r\x3\xE\x3\xE\x3\xE\x3\xF\x3\xF\x3\x10\x3\x10\x3\x11\x6\x11"+
		"\x94\n\x11\r\x11\xE\x11\x95\x2\x2\x2\x12\x3\x2\x3\x5\x2\x4\a\x2\x5\t\x2"+
		"\x6\v\x2\a\r\x2\b\xF\x2\t\x11\x2\n\x13\x2\v\x15\x2\f\x17\x2\r\x19\x2\xE"+
		"\x1B\x2\xF\x1D\x2\x2\x1F\x2\x2!\x2\x2\x3\x2\x16\x6\x2$$^^}}\x7F\x7F\x5"+
		"\x2^^}}\x7F\x7F\x4\x2UUuu\x4\x2VVvv\x4\x2TTtt\x4\x2KKkk\x4\x2PPpp\x4\x2"+
		"IIii\x4\x2RRrr\x4\x2GGgg\x4\x2\x43\x43\x63\x63\x4\x2OOoo\x4\x2\x44\x44"+
		"\x64\x64\x4\x2NNnn\x4\x2\x45\x45\x65\x65\x4\x2QQqq\x4\x2\f\f\xF\xF\x4"+
		"\x2//<<\x4\x2\x43\\\x63|\x5\x2\v\f\xE\xF\"\"\xA5\x2\x3\x3\x2\x2\x2\x2"+
		"\x5\x3\x2\x2\x2\x2\a\x3\x2\x2\x2\x2\t\x3\x2\x2\x2\x2\v\x3\x2\x2\x2\x2"+
		"\r\x3\x2\x2\x2\x2\xF\x3\x2\x2\x2\x2\x11\x3\x2\x2\x2\x2\x13\x3\x2\x2\x2"+
		"\x2\x15\x3\x2\x2\x2\x2\x17\x3\x2\x2\x2\x2\x19\x3\x2\x2\x2\x2\x1B\x3\x2"+
		"\x2\x2\x3#\x3\x2\x2\x2\x5%\x3\x2\x2\x2\a\'\x3\x2\x2\x2\t)\x3\x2\x2\x2"+
		"\v+\x3\x2\x2\x2\r\x37\x3\x2\x2\x2\xF\x43\x3\x2\x2\x2\x11O\x3\x2\x2\x2"+
		"\x13p\x3\x2\x2\x2\x15r\x3\x2\x2\x2\x17~\x3\x2\x2\x2\x19\x82\x3\x2\x2\x2"+
		"\x1B\x8B\x3\x2\x2\x2\x1D\x8E\x3\x2\x2\x2\x1F\x90\x3\x2\x2\x2!\x93\x3\x2"+
		"\x2\x2#$\a?\x2\x2$\x4\x3\x2\x2\x2%&\a%\x2\x2&\x6\x3\x2\x2\x2\'(\a.\x2"+
		"\x2(\b\x3\x2\x2\x2)*\a\x7F\x2\x2*\n\x3\x2\x2\x2+\x32\a$\x2\x2,\x31\n\x2"+
		"\x2\x2-.\a^\x2\x2.\x31\v\x2\x2\x2/\x31\x5\r\a\x2\x30,\x3\x2\x2\x2\x30"+
		"-\x3\x2\x2\x2\x30/\x3\x2\x2\x2\x31\x34\x3\x2\x2\x2\x32\x30\x3\x2\x2\x2"+
		"\x32\x33\x3\x2\x2\x2\x33\x35\x3\x2\x2\x2\x34\x32\x3\x2\x2\x2\x35\x36\a"+
		"$\x2\x2\x36\f\x3\x2\x2\x2\x37>\a}\x2\x2\x38=\n\x3\x2\x2\x39:\a^\x2\x2"+
		":=\v\x2\x2\x2;=\x5\r\a\x2<\x38\x3\x2\x2\x2<\x39\x3\x2\x2\x2<;\x3\x2\x2"+
		"\x2=@\x3\x2\x2\x2><\x3\x2\x2\x2>?\x3\x2\x2\x2?\x41\x3\x2\x2\x2@>\x3\x2"+
		"\x2\x2\x41\x42\a\x7F\x2\x2\x42\xE\x3\x2\x2\x2\x43\x44\a\x42\x2\x2\x44"+
		"\x45\t\x4\x2\x2\x45\x46\t\x5\x2\x2\x46G\t\x6\x2\x2GH\t\a\x2\x2HI\t\b\x2"+
		"\x2IK\t\t\x2\x2JL\x5!\x11\x2KJ\x3\x2\x2\x2KL\x3\x2\x2\x2LM\x3\x2\x2\x2"+
		"MN\a}\x2\x2N\x10\x3\x2\x2\x2OP\a\x42\x2\x2PQ\t\n\x2\x2QR\t\x6\x2\x2RS"+
		"\t\v\x2\x2ST\t\f\x2\x2TU\t\r\x2\x2UV\t\xE\x2\x2VW\t\xF\x2\x2WY\t\v\x2"+
		"\x2XZ\x5!\x11\x2YX\x3\x2\x2\x2YZ\x3\x2\x2\x2Z[\x3\x2\x2\x2[\\\a}\x2\x2"+
		"\\\x12\x3\x2\x2\x2]^\a\x42\x2\x2^_\t\x10\x2\x2_`\t\x11\x2\x2`\x61\t\r"+
		"\x2\x2\x61\x62\t\r\x2\x2\x62\x63\t\v\x2\x2\x63\x64\t\b\x2\x2\x64\x66\t"+
		"\x5\x2\x2\x65g\x5!\x11\x2\x66\x65\x3\x2\x2\x2\x66g\x3\x2\x2\x2gh\x3\x2"+
		"\x2\x2hq\x5\r\a\x2im\a\'\x2\x2jl\n\x12\x2\x2kj\x3\x2\x2\x2lo\x3\x2\x2"+
		"\x2mk\x3\x2\x2\x2mn\x3\x2\x2\x2nq\x3\x2\x2\x2om\x3\x2\x2\x2p]\x3\x2\x2"+
		"\x2pi\x3\x2\x2\x2q\x14\x3\x2\x2\x2rt\a\x42\x2\x2su\x5\x1D\xF\x2ts\x3\x2"+
		"\x2\x2uv\x3\x2\x2\x2vt\x3\x2\x2\x2vw\x3\x2\x2\x2wy\x3\x2\x2\x2xz\x5!\x11"+
		"\x2yx\x3\x2\x2\x2yz\x3\x2\x2\x2z{\x3\x2\x2\x2{|\a}\x2\x2|\x16\x3\x2\x2"+
		"\x2}\x7F\x5\x1F\x10\x2~}\x3\x2\x2\x2\x7F\x80\x3\x2\x2\x2\x80~\x3\x2\x2"+
		"\x2\x80\x81\x3\x2\x2\x2\x81\x18\x3\x2\x2\x2\x82\x88\x5\x1D\xF\x2\x83\x87"+
		"\x5\x1D\xF\x2\x84\x87\x5\x1F\x10\x2\x85\x87\t\x13\x2\x2\x86\x83\x3\x2"+
		"\x2\x2\x86\x84\x3\x2\x2\x2\x86\x85\x3\x2\x2\x2\x87\x8A\x3\x2\x2\x2\x88"+
		"\x86\x3\x2\x2\x2\x88\x89\x3\x2\x2\x2\x89\x1A\x3\x2\x2\x2\x8A\x88\x3\x2"+
		"\x2\x2\x8B\x8C\x5!\x11\x2\x8C\x8D\b\xE\x2\x2\x8D\x1C\x3\x2\x2\x2\x8E\x8F"+
		"\t\x14\x2\x2\x8F\x1E\x3\x2\x2\x2\x90\x91\x4\x32;\x2\x91 \x3\x2\x2\x2\x92"+
		"\x94\t\x15\x2\x2\x93\x92\x3\x2\x2\x2\x94\x95\x3\x2\x2\x2\x95\x93\x3\x2"+
		"\x2\x2\x95\x96\x3\x2\x2\x2\x96\"\x3\x2\x2\x2\x12\x2\x30\x32<>KY\x66mp"+
		"vy\x80\x86\x88\x95\x3\x3\xE\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace ANTLRTest