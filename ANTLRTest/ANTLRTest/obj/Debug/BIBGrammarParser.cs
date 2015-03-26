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
using Antlr4.Runtime.Tree;
using System.Collections.Generic;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.3")]
[System.CLSCompliant(false)]
public partial class BIBGrammarParser : Parser {
	public const int
		Assign=1, Concat=2, Comma=3, CloseBrace=4, QuotedContent=5, BracedContent=6, 
		StringType=7, PreambleType=8, CommentType=9, Type=10, Number=11, Name=12, 
		Spaces=13;
	public static readonly string[] tokenNames = {
		"<INVALID>", "'='", "'#'", "','", "'}'", "QuotedContent", "BracedContent", 
		"StringType", "PreambleType", "CommentType", "Type", "Number", "Name", 
		"Spaces"
	};
	public const int
		RULE_parse = 0, RULE_entry = 1, RULE_tags = 2, RULE_tag = 3, RULE_content = 4, 
		RULE_concatable = 5;
	public static readonly string[] ruleNames = {
		"parse", "entry", "tags", "tag", "content", "concatable"
	};

	public override string GrammarFileName { get { return "BIBGrammar.g4"; } }

	public override string[] TokenNames { get { return tokenNames; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public BIBGrammarParser(ITokenStream input)
		: base(input)
	{
		_interp = new ParserATNSimulator(this,_ATN);
	}
	public partial class ParseContext : ParserRuleContext {
		public EntryContext entry(int i) {
			return GetRuleContext<EntryContext>(i);
		}
		public ITerminalNode Comma(int i) {
			return GetToken(BIBGrammarParser.Comma, i);
		}
		public ITerminalNode Eof() { return GetToken(BIBGrammarParser.Eof, 0); }
		public IReadOnlyList<EntryContext> entry() {
			return GetRuleContexts<EntryContext>();
		}
		public IReadOnlyList<ITerminalNode> Comma() { return GetTokens(BIBGrammarParser.Comma); }
		public ParseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_parse; } }
		public override void EnterRule(IParseTreeListener listener) {
			IBIBGrammarListener typedListener = listener as IBIBGrammarListener;
			if (typedListener != null) typedListener.EnterParse(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IBIBGrammarListener typedListener = listener as IBIBGrammarListener;
			if (typedListener != null) typedListener.ExitParse(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IBIBGrammarVisitor<TResult> typedVisitor = visitor as IBIBGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitParse(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ParseContext parse() {
		ParseContext _localctx = new ParseContext(_ctx, State);
		EnterRule(_localctx, 0, RULE_parse);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 25;
			_la = _input.La(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << StringType) | (1L << PreambleType) | (1L << CommentType) | (1L << Type))) != 0)) {
				{
				State = 12; entry();
				State = 19;
				_errHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(_input,1,_ctx);
				while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.InvalidAltNumber ) {
					if ( _alt==1 ) {
						{
						{
						State = 14;
						_la = _input.La(1);
						if (_la==Comma) {
							{
							State = 13; Match(Comma);
							}
						}

						State = 16; entry();
						}
						} 
					}
					State = 21;
					_errHandler.Sync(this);
					_alt = Interpreter.AdaptivePredict(_input,1,_ctx);
				}
				State = 23;
				_la = _input.La(1);
				if (_la==Comma) {
					{
					State = 22; Match(Comma);
					}
				}

				}
			}

			State = 27; Match(Eof);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class EntryContext : ParserRuleContext {
		public ITerminalNode CommentType() { return GetToken(BIBGrammarParser.CommentType, 0); }
		public ITerminalNode StringType() { return GetToken(BIBGrammarParser.StringType, 0); }
		public ITerminalNode Assign() { return GetToken(BIBGrammarParser.Assign, 0); }
		public ITerminalNode QuotedContent() { return GetToken(BIBGrammarParser.QuotedContent, 0); }
		public ITerminalNode CloseBrace() { return GetToken(BIBGrammarParser.CloseBrace, 0); }
		public ITerminalNode PreambleType() { return GetToken(BIBGrammarParser.PreambleType, 0); }
		public ContentContext content() {
			return GetRuleContext<ContentContext>(0);
		}
		public TagsContext tags() {
			return GetRuleContext<TagsContext>(0);
		}
		public ITerminalNode Name() { return GetToken(BIBGrammarParser.Name, 0); }
		public ITerminalNode Comma() { return GetToken(BIBGrammarParser.Comma, 0); }
		public ITerminalNode Type() { return GetToken(BIBGrammarParser.Type, 0); }
		public EntryContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_entry; } }
		public override void EnterRule(IParseTreeListener listener) {
			IBIBGrammarListener typedListener = listener as IBIBGrammarListener;
			if (typedListener != null) typedListener.EnterEntry(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IBIBGrammarListener typedListener = listener as IBIBGrammarListener;
			if (typedListener != null) typedListener.ExitEntry(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IBIBGrammarVisitor<TResult> typedVisitor = visitor as IBIBGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitEntry(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public EntryContext entry() {
		EntryContext _localctx = new EntryContext(_ctx, State);
		EnterRule(_localctx, 2, RULE_entry);
		try {
			State = 45;
			switch (_input.La(1)) {
			case Type:
				EnterOuterAlt(_localctx, 1);
				{
				State = 29; Match(Type);
				State = 30; Match(Name);
				State = 31; Match(Comma);
				State = 32; tags();
				State = 33; Match(CloseBrace);
				}
				break;
			case StringType:
				EnterOuterAlt(_localctx, 2);
				{
				State = 35; Match(StringType);
				State = 36; Match(Name);
				State = 37; Match(Assign);
				State = 38; Match(QuotedContent);
				State = 39; Match(CloseBrace);
				}
				break;
			case PreambleType:
				EnterOuterAlt(_localctx, 3);
				{
				State = 40; Match(PreambleType);
				State = 41; content();
				State = 42; Match(CloseBrace);
				}
				break;
			case CommentType:
				EnterOuterAlt(_localctx, 4);
				{
				State = 44; Match(CommentType);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TagsContext : ParserRuleContext {
		public ITerminalNode Comma(int i) {
			return GetToken(BIBGrammarParser.Comma, i);
		}
		public IReadOnlyList<TagContext> tag() {
			return GetRuleContexts<TagContext>();
		}
		public TagContext tag(int i) {
			return GetRuleContext<TagContext>(i);
		}
		public IReadOnlyList<ITerminalNode> Comma() { return GetTokens(BIBGrammarParser.Comma); }
		public TagsContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_tags; } }
		public override void EnterRule(IParseTreeListener listener) {
			IBIBGrammarListener typedListener = listener as IBIBGrammarListener;
			if (typedListener != null) typedListener.EnterTags(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IBIBGrammarListener typedListener = listener as IBIBGrammarListener;
			if (typedListener != null) typedListener.ExitTags(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IBIBGrammarVisitor<TResult> typedVisitor = visitor as IBIBGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTags(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public TagsContext tags() {
		TagsContext _localctx = new TagsContext(_ctx, State);
		EnterRule(_localctx, 4, RULE_tags);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 58;
			_la = _input.La(1);
			if (_la==Name) {
				{
				State = 47; tag();
				State = 52;
				_errHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(_input,5,_ctx);
				while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.InvalidAltNumber ) {
					if ( _alt==1 ) {
						{
						{
						State = 48; Match(Comma);
						State = 49; tag();
						}
						} 
					}
					State = 54;
					_errHandler.Sync(this);
					_alt = Interpreter.AdaptivePredict(_input,5,_ctx);
				}
				State = 56;
				_la = _input.La(1);
				if (_la==Comma) {
					{
					State = 55; Match(Comma);
					}
				}

				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TagContext : ParserRuleContext {
		public ITerminalNode Assign() { return GetToken(BIBGrammarParser.Assign, 0); }
		public ContentContext content() {
			return GetRuleContext<ContentContext>(0);
		}
		public ITerminalNode Name() { return GetToken(BIBGrammarParser.Name, 0); }
		public TagContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_tag; } }
		public override void EnterRule(IParseTreeListener listener) {
			IBIBGrammarListener typedListener = listener as IBIBGrammarListener;
			if (typedListener != null) typedListener.EnterTag(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IBIBGrammarListener typedListener = listener as IBIBGrammarListener;
			if (typedListener != null) typedListener.ExitTag(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IBIBGrammarVisitor<TResult> typedVisitor = visitor as IBIBGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTag(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public TagContext tag() {
		TagContext _localctx = new TagContext(_ctx, State);
		EnterRule(_localctx, 6, RULE_tag);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 60; Match(Name);
			State = 61; Match(Assign);
			State = 62; content();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ContentContext : ParserRuleContext {
		public IReadOnlyList<ITerminalNode> Concat() { return GetTokens(BIBGrammarParser.Concat); }
		public IReadOnlyList<ConcatableContext> concatable() {
			return GetRuleContexts<ConcatableContext>();
		}
		public ITerminalNode BracedContent() { return GetToken(BIBGrammarParser.BracedContent, 0); }
		public ITerminalNode Number() { return GetToken(BIBGrammarParser.Number, 0); }
		public ITerminalNode Concat(int i) {
			return GetToken(BIBGrammarParser.Concat, i);
		}
		public ConcatableContext concatable(int i) {
			return GetRuleContext<ConcatableContext>(i);
		}
		public ContentContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_content; } }
		public override void EnterRule(IParseTreeListener listener) {
			IBIBGrammarListener typedListener = listener as IBIBGrammarListener;
			if (typedListener != null) typedListener.EnterContent(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IBIBGrammarListener typedListener = listener as IBIBGrammarListener;
			if (typedListener != null) typedListener.ExitContent(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IBIBGrammarVisitor<TResult> typedVisitor = visitor as IBIBGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitContent(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ContentContext content() {
		ContentContext _localctx = new ContentContext(_ctx, State);
		EnterRule(_localctx, 8, RULE_content);
		int _la;
		try {
			State = 74;
			switch (_input.La(1)) {
			case QuotedContent:
			case Name:
				EnterOuterAlt(_localctx, 1);
				{
				State = 64; concatable();
				State = 69;
				_errHandler.Sync(this);
				_la = _input.La(1);
				while (_la==Concat) {
					{
					{
					State = 65; Match(Concat);
					State = 66; concatable();
					}
					}
					State = 71;
					_errHandler.Sync(this);
					_la = _input.La(1);
				}
				}
				break;
			case Number:
				EnterOuterAlt(_localctx, 2);
				{
				State = 72; Match(Number);
				}
				break;
			case BracedContent:
				EnterOuterAlt(_localctx, 3);
				{
				State = 73; Match(BracedContent);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ConcatableContext : ParserRuleContext {
		public ITerminalNode QuotedContent() { return GetToken(BIBGrammarParser.QuotedContent, 0); }
		public ITerminalNode Name() { return GetToken(BIBGrammarParser.Name, 0); }
		public ConcatableContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_concatable; } }
		public override void EnterRule(IParseTreeListener listener) {
			IBIBGrammarListener typedListener = listener as IBIBGrammarListener;
			if (typedListener != null) typedListener.EnterConcatable(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IBIBGrammarListener typedListener = listener as IBIBGrammarListener;
			if (typedListener != null) typedListener.ExitConcatable(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IBIBGrammarVisitor<TResult> typedVisitor = visitor as IBIBGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitConcatable(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ConcatableContext concatable() {
		ConcatableContext _localctx = new ConcatableContext(_ctx, State);
		EnterRule(_localctx, 10, RULE_concatable);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 76;
			_la = _input.La(1);
			if ( !(_la==QuotedContent || _la==Name) ) {
			_errHandler.RecoverInline(this);
			}
			Consume();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x3\xFQ\x4\x2\t\x2"+
		"\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x3\x2\x3\x2\x5\x2"+
		"\x11\n\x2\x3\x2\a\x2\x14\n\x2\f\x2\xE\x2\x17\v\x2\x3\x2\x5\x2\x1A\n\x2"+
		"\x5\x2\x1C\n\x2\x3\x2\x3\x2\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3"+
		"\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x5\x3\x30\n\x3"+
		"\x3\x4\x3\x4\x3\x4\a\x4\x35\n\x4\f\x4\xE\x4\x38\v\x4\x3\x4\x5\x4;\n\x4"+
		"\x5\x4=\n\x4\x3\x5\x3\x5\x3\x5\x3\x5\x3\x6\x3\x6\x3\x6\a\x6\x46\n\x6\f"+
		"\x6\xE\x6I\v\x6\x3\x6\x3\x6\x5\x6M\n\x6\x3\a\x3\a\x3\a\x2\x2\x2\b\x2\x2"+
		"\x4\x2\x6\x2\b\x2\n\x2\f\x2\x2\x3\x4\x2\a\a\xE\xEW\x2\x1B\x3\x2\x2\x2"+
		"\x4/\x3\x2\x2\x2\x6<\x3\x2\x2\x2\b>\x3\x2\x2\x2\nL\x3\x2\x2\x2\fN\x3\x2"+
		"\x2\x2\xE\x15\x5\x4\x3\x2\xF\x11\a\x5\x2\x2\x10\xF\x3\x2\x2\x2\x10\x11"+
		"\x3\x2\x2\x2\x11\x12\x3\x2\x2\x2\x12\x14\x5\x4\x3\x2\x13\x10\x3\x2\x2"+
		"\x2\x14\x17\x3\x2\x2\x2\x15\x13\x3\x2\x2\x2\x15\x16\x3\x2\x2\x2\x16\x19"+
		"\x3\x2\x2\x2\x17\x15\x3\x2\x2\x2\x18\x1A\a\x5\x2\x2\x19\x18\x3\x2\x2\x2"+
		"\x19\x1A\x3\x2\x2\x2\x1A\x1C\x3\x2\x2\x2\x1B\xE\x3\x2\x2\x2\x1B\x1C\x3"+
		"\x2\x2\x2\x1C\x1D\x3\x2\x2\x2\x1D\x1E\a\x2\x2\x3\x1E\x3\x3\x2\x2\x2\x1F"+
		" \a\f\x2\x2 !\a\xE\x2\x2!\"\a\x5\x2\x2\"#\x5\x6\x4\x2#$\a\x6\x2\x2$\x30"+
		"\x3\x2\x2\x2%&\a\t\x2\x2&\'\a\xE\x2\x2\'(\a\x3\x2\x2()\a\a\x2\x2)\x30"+
		"\a\x6\x2\x2*+\a\n\x2\x2+,\x5\n\x6\x2,-\a\x6\x2\x2-\x30\x3\x2\x2\x2.\x30"+
		"\a\v\x2\x2/\x1F\x3\x2\x2\x2/%\x3\x2\x2\x2/*\x3\x2\x2\x2/.\x3\x2\x2\x2"+
		"\x30\x5\x3\x2\x2\x2\x31\x36\x5\b\x5\x2\x32\x33\a\x5\x2\x2\x33\x35\x5\b"+
		"\x5\x2\x34\x32\x3\x2\x2\x2\x35\x38\x3\x2\x2\x2\x36\x34\x3\x2\x2\x2\x36"+
		"\x37\x3\x2\x2\x2\x37:\x3\x2\x2\x2\x38\x36\x3\x2\x2\x2\x39;\a\x5\x2\x2"+
		":\x39\x3\x2\x2\x2:;\x3\x2\x2\x2;=\x3\x2\x2\x2<\x31\x3\x2\x2\x2<=\x3\x2"+
		"\x2\x2=\a\x3\x2\x2\x2>?\a\xE\x2\x2?@\a\x3\x2\x2@\x41\x5\n\x6\x2\x41\t"+
		"\x3\x2\x2\x2\x42G\x5\f\a\x2\x43\x44\a\x4\x2\x2\x44\x46\x5\f\a\x2\x45\x43"+
		"\x3\x2\x2\x2\x46I\x3\x2\x2\x2G\x45\x3\x2\x2\x2GH\x3\x2\x2\x2HM\x3\x2\x2"+
		"\x2IG\x3\x2\x2\x2JM\a\r\x2\x2KM\a\b\x2\x2L\x42\x3\x2\x2\x2LJ\x3\x2\x2"+
		"\x2LK\x3\x2\x2\x2M\v\x3\x2\x2\x2NO\t\x2\x2\x2O\r\x3\x2\x2\x2\f\x10\x15"+
		"\x19\x1B/\x36:<GL";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace ANTLRTest