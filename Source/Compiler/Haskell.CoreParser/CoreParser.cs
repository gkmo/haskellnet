// $ANTLR 3.2 Sep 23, 2009 12:02:23 Core.g 2013-07-18 15:04:28

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;

using IDictionary	= System.Collections.IDictionary;
using Hashtable 	= System.Collections.Hashtable;

using Antlr.Runtime.Tree;

namespace  Haskell.CoreParser 
{
public partial class CoreParser : Parser
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"TK_MODULE", 
		"TK_VALUE_DEF", 
		"TK_REC_VALUE_DEF", 
		"TK_ALGEBRIC_TYPE", 
		"TK_NEW_TYPE", 
		"TK_CONSTRUCTOR_DEF", 
		"TK_APPLICATION", 
		"TK_ABSTRACTION", 
		"TK_TYPE_BINDER", 
		"TK_VALUE_BINDER", 
		"TK_LIT_INTEGER", 
		"TK_LIT_RATIONAL", 
		"TK_LIT_STRING", 
		"TK_LIT_CHAR", 
		"TK_MODULE_IDENTIFIER", 
		"TK_VARIABLE", 
		"TK_ATOMIC_TYPE", 
		"TK_TYPE_ABSTRACTION", 
		"TK_ARROW_TYPE_CONSTRUCTION", 
		"TK_TYPE_APPLICATION", 
		"TK_NESTED_TYPE", 
		"TK_TRANSITIVE_COERCION", 
		"TK_SYMMETRIC_COERCION", 
		"TK_UNSAFE_COERCION", 
		"TK_LEFT_COERCION", 
		"TK_RIGHT_COERCION", 
		"TK_INSTANTIATION_COERCION", 
		"TK_CASE_EXPRESSION", 
		"TK_NESTED_EXPRESSION", 
		"TK_DEFAULT_ALTERNATIVE", 
		"TK_LITERAL_ALTERNATIVE", 
		"TK_CONSTRUCTOR_ALTERNATIVE", 
		"TK_TYPE_ARG", 
		"TK_VALUE_ARG", 
		"TK_LOCAL_DEFINITION", 
		"TK_NOTE", 
		"TK_DATA_CONSTRUCTOR", 
		"TK_CAST", 
		"MODULE", 
		"SEMICOLON", 
		"REC", 
		"LB", 
		"DCOLON", 
		"EQ", 
		"RB", 
		"DATA", 
		"NEWTYPE", 
		"AT", 
		"LP", 
		"RP", 
		"DSLASH", 
		"ARROW", 
		"LET", 
		"IN", 
		"CASE", 
		"OF", 
		"CAST", 
		"NOTE", 
		"STRINGLITERAL", 
		"ECALL", 
		"DECALL", 
		"LABEL", 
		"STAR", 
		"SHARP", 
		"QUESTION", 
		"DCOLONEQ", 
		"PERCENT_ARROW", 
		"INTLITERAL", 
		"PERCENT", 
		"CHARLITERAL", 
		"TRANS", 
		"SYM", 
		"UNSAFE", 
		"LEFT", 
		"RIGHT", 
		"INST", 
		"FORALL", 
		"DOT", 
		"COLON", 
		"UNAME", 
		"LNAME", 
		"MINUS", 
		"IntegerNumber", 
		"LowLetter", 
		"UpperLetter", 
		"HexPrefix", 
		"HexDigit", 
		"EscapeSequence", 
		"NEWLINE", 
		"WS"
    };

    public const int CAST = 60;
    public const int UpperLetter = 88;
    public const int TK_LITERAL_ALTERNATIVE = 34;
    public const int STAR = 66;
    public const int TK_VALUE_BINDER = 13;
    public const int TK_UNSAFE_COERCION = 27;
    public const int LP = 52;
    public const int CASE = 58;
    public const int TK_TYPE_BINDER = 12;
    public const int EOF = -1;
    public const int SYM = 75;
    public const int INST = 79;
    public const int DCOLON = 46;
    public const int TK_ABSTRACTION = 11;
    public const int TK_LIT_INTEGER = 14;
    public const int ECALL = 63;
    public const int EQ = 47;
    public const int UNSAFE = 76;
    public const int HexPrefix = 89;
    public const int SHARP = 67;
    public const int TK_INSTANTIATION_COERCION = 30;
    public const int TK_TYPE_ARG = 36;
    public const int TK_ARROW_TYPE_CONSTRUCTION = 22;
    public const int PERCENT_ARROW = 70;
    public const int SEMICOLON = 43;
    public const int TK_TRANSITIVE_COERCION = 25;
    public const int INTLITERAL = 71;
    public const int OF = 59;
    public const int TK_CONSTRUCTOR_DEF = 9;
    public const int WS = 93;
    public const int TK_NEW_TYPE = 8;
    public const int TK_REC_VALUE_DEF = 6;
    public const int TK_LEFT_COERCION = 28;
    public const int TK_LOCAL_DEFINITION = 38;
    public const int LNAME = 84;
    public const int TK_DEFAULT_ALTERNATIVE = 33;
    public const int TK_LIT_STRING = 16;
    public const int CHARLITERAL = 73;
    public const int TK_CAST = 41;
    public const int DSLASH = 54;
    public const int EscapeSequence = 91;
    public const int DECALL = 64;
    public const int RB = 48;
    public const int IntegerNumber = 86;
    public const int RP = 53;
    public const int NEWTYPE = 50;
    public const int TK_ALGEBRIC_TYPE = 7;
    public const int TK_VALUE_ARG = 37;
    public const int HexDigit = 90;
    public const int TK_APPLICATION = 10;
    public const int TRANS = 74;
    public const int AT = 51;
    public const int IN = 57;
    public const int TK_SYMMETRIC_COERCION = 26;
    public const int NOTE = 61;
    public const int TK_RIGHT_COERCION = 29;
    public const int LEFT = 77;
    public const int TK_TYPE_APPLICATION = 23;
    public const int TK_TYPE_ABSTRACTION = 21;
    public const int DOT = 81;
    public const int UNAME = 83;
    public const int TK_DATA_CONSTRUCTOR = 40;
    public const int TK_VARIABLE = 19;
    public const int PERCENT = 72;
    public const int TK_CASE_EXPRESSION = 31;
    public const int TK_NOTE = 39;
    public const int TK_NESTED_TYPE = 24;
    public const int TK_VALUE_DEF = 5;
    public const int FORALL = 80;
    public const int TK_NESTED_EXPRESSION = 32;
    public const int TK_LIT_RATIONAL = 15;
    public const int TK_MODULE_IDENTIFIER = 18;
    public const int RIGHT = 78;
    public const int MINUS = 85;
    public const int MODULE = 42;
    public const int REC = 44;
    public const int COLON = 82;
    public const int NEWLINE = 92;
    public const int QUESTION = 68;
    public const int LABEL = 65;
    public const int STRINGLITERAL = 62;
    public const int TK_CONSTRUCTOR_ALTERNATIVE = 35;
    public const int TK_ATOMIC_TYPE = 20;
    public const int ARROW = 55;
    public const int LB = 45;
    public const int TK_LIT_CHAR = 17;
    public const int TK_MODULE = 4;
    public const int LowLetter = 87;
    public const int DATA = 49;
    public const int LET = 56;
    public const int DCOLONEQ = 69;

    // delegates
    // delegators



        public CoreParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public CoreParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();

             
        }
        
    protected ITreeAdaptor adaptor = new CommonTreeAdaptor();

    public ITreeAdaptor TreeAdaptor
    {
        get { return this.adaptor; }
        set {
    	this.adaptor = value;
    	}
    }

    override public string[] TokenNames {
		get { return CoreParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "Core.g"; }
    }


    public class module_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "module"
    // Core.g:58:1: module : MODULE mident ( tdef SEMICOLON )* ( vdefg SEMICOLON )* -> ^( TK_MODULE mident ( tdef )* ( vdefg )* ) ;
    public CoreParser.module_return module() // throws RecognitionException [1]
    {   
        CoreParser.module_return retval = new CoreParser.module_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken MODULE1 = null;
        IToken SEMICOLON4 = null;
        IToken SEMICOLON6 = null;
        CoreParser.mident_return mident2 = default(CoreParser.mident_return);

        CoreParser.tdef_return tdef3 = default(CoreParser.tdef_return);

        CoreParser.vdefg_return vdefg5 = default(CoreParser.vdefg_return);


        CommonTree MODULE1_tree=null;
        CommonTree SEMICOLON4_tree=null;
        CommonTree SEMICOLON6_tree=null;
        RewriteRuleTokenStream stream_SEMICOLON = new RewriteRuleTokenStream(adaptor,"token SEMICOLON");
        RewriteRuleTokenStream stream_MODULE = new RewriteRuleTokenStream(adaptor,"token MODULE");
        RewriteRuleSubtreeStream stream_mident = new RewriteRuleSubtreeStream(adaptor,"rule mident");
        RewriteRuleSubtreeStream stream_vdefg = new RewriteRuleSubtreeStream(adaptor,"rule vdefg");
        RewriteRuleSubtreeStream stream_tdef = new RewriteRuleSubtreeStream(adaptor,"rule tdef");
        try 
    	{
            // Core.g:59:2: ( MODULE mident ( tdef SEMICOLON )* ( vdefg SEMICOLON )* -> ^( TK_MODULE mident ( tdef )* ( vdefg )* ) )
            // Core.g:59:4: MODULE mident ( tdef SEMICOLON )* ( vdefg SEMICOLON )*
            {
            	MODULE1=(IToken)Match(input,MODULE,FOLLOW_MODULE_in_module219); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_MODULE.Add(MODULE1);

            	PushFollow(FOLLOW_mident_in_module221);
            	mident2 = mident();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_mident.Add(mident2.Tree);
            	// Core.g:59:18: ( tdef SEMICOLON )*
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( ((LA1_0 >= DATA && LA1_0 <= NEWTYPE)) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // Core.g:59:19: tdef SEMICOLON
            			    {
            			    	PushFollow(FOLLOW_tdef_in_module224);
            			    	tdef3 = tdef();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_tdef.Add(tdef3.Tree);
            			    	SEMICOLON4=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_module226); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_SEMICOLON.Add(SEMICOLON4);


            			    }
            			    break;

            			default:
            			    goto loop1;
            	    }
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements

            	// Core.g:59:36: ( vdefg SEMICOLON )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( (LA2_0 == REC || (LA2_0 >= UNAME && LA2_0 <= LNAME)) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // Core.g:59:38: vdefg SEMICOLON
            			    {
            			    	PushFollow(FOLLOW_vdefg_in_module232);
            			    	vdefg5 = vdefg();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_vdefg.Add(vdefg5.Tree);
            			    	SEMICOLON6=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_module234); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_SEMICOLON.Add(SEMICOLON6);


            			    }
            			    break;

            			default:
            			    goto loop2;
            	    }
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whining that label 'loop2' has no statements



            	// AST REWRITE
            	// elements:          tdef, mident, vdefg
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 59:56: -> ^( TK_MODULE mident ( tdef )* ( vdefg )* )
            	{
            	    // Core.g:59:59: ^( TK_MODULE mident ( tdef )* ( vdefg )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TK_MODULE, "TK_MODULE"), root_1);

            	    adaptor.AddChild(root_1, stream_mident.NextTree());
            	    // Core.g:59:78: ( tdef )*
            	    while ( stream_tdef.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tdef.NextTree());

            	    }
            	    stream_tdef.Reset();
            	    // Core.g:59:84: ( vdefg )*
            	    while ( stream_vdefg.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_vdefg.NextTree());

            	    }
            	    stream_vdefg.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "module"

    public class vdefg_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "vdefg"
    // Core.g:61:1: vdefg : ( REC LB ( qvar DCOLON ty EQ exp ( SEMICOLON )? )* RB -> ( ^( TK_REC_VALUE_DEF qvar ty exp ) )* | qvar DCOLON ty EQ exp -> ^( TK_VALUE_DEF qvar ty exp ) );
    public CoreParser.vdefg_return vdefg() // throws RecognitionException [1]
    {   
        CoreParser.vdefg_return retval = new CoreParser.vdefg_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken REC7 = null;
        IToken LB8 = null;
        IToken DCOLON10 = null;
        IToken EQ12 = null;
        IToken SEMICOLON14 = null;
        IToken RB15 = null;
        IToken DCOLON17 = null;
        IToken EQ19 = null;
        CoreParser.qvar_return qvar9 = default(CoreParser.qvar_return);

        CoreParser.ty_return ty11 = default(CoreParser.ty_return);

        CoreParser.exp_return exp13 = default(CoreParser.exp_return);

        CoreParser.qvar_return qvar16 = default(CoreParser.qvar_return);

        CoreParser.ty_return ty18 = default(CoreParser.ty_return);

        CoreParser.exp_return exp20 = default(CoreParser.exp_return);


        CommonTree REC7_tree=null;
        CommonTree LB8_tree=null;
        CommonTree DCOLON10_tree=null;
        CommonTree EQ12_tree=null;
        CommonTree SEMICOLON14_tree=null;
        CommonTree RB15_tree=null;
        CommonTree DCOLON17_tree=null;
        CommonTree EQ19_tree=null;
        RewriteRuleTokenStream stream_LB = new RewriteRuleTokenStream(adaptor,"token LB");
        RewriteRuleTokenStream stream_DCOLON = new RewriteRuleTokenStream(adaptor,"token DCOLON");
        RewriteRuleTokenStream stream_SEMICOLON = new RewriteRuleTokenStream(adaptor,"token SEMICOLON");
        RewriteRuleTokenStream stream_EQ = new RewriteRuleTokenStream(adaptor,"token EQ");
        RewriteRuleTokenStream stream_RB = new RewriteRuleTokenStream(adaptor,"token RB");
        RewriteRuleTokenStream stream_REC = new RewriteRuleTokenStream(adaptor,"token REC");
        RewriteRuleSubtreeStream stream_ty = new RewriteRuleSubtreeStream(adaptor,"rule ty");
        RewriteRuleSubtreeStream stream_exp = new RewriteRuleSubtreeStream(adaptor,"rule exp");
        RewriteRuleSubtreeStream stream_qvar = new RewriteRuleSubtreeStream(adaptor,"rule qvar");
        try 
    	{
            // Core.g:62:2: ( REC LB ( qvar DCOLON ty EQ exp ( SEMICOLON )? )* RB -> ( ^( TK_REC_VALUE_DEF qvar ty exp ) )* | qvar DCOLON ty EQ exp -> ^( TK_VALUE_DEF qvar ty exp ) )
            int alt5 = 2;
            int LA5_0 = input.LA(1);

            if ( (LA5_0 == REC) )
            {
                alt5 = 1;
            }
            else if ( ((LA5_0 >= UNAME && LA5_0 <= LNAME)) )
            {
                alt5 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d5s0 =
                    new NoViableAltException("", 5, 0, input);

                throw nvae_d5s0;
            }
            switch (alt5) 
            {
                case 1 :
                    // Core.g:62:4: REC LB ( qvar DCOLON ty EQ exp ( SEMICOLON )? )* RB
                    {
                    	REC7=(IToken)Match(input,REC,FOLLOW_REC_in_vdefg260); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_REC.Add(REC7);

                    	LB8=(IToken)Match(input,LB,FOLLOW_LB_in_vdefg262); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_LB.Add(LB8);

                    	// Core.g:62:11: ( qvar DCOLON ty EQ exp ( SEMICOLON )? )*
                    	do 
                    	{
                    	    int alt4 = 2;
                    	    int LA4_0 = input.LA(1);

                    	    if ( ((LA4_0 >= UNAME && LA4_0 <= LNAME)) )
                    	    {
                    	        alt4 = 1;
                    	    }


                    	    switch (alt4) 
                    		{
                    			case 1 :
                    			    // Core.g:62:12: qvar DCOLON ty EQ exp ( SEMICOLON )?
                    			    {
                    			    	PushFollow(FOLLOW_qvar_in_vdefg265);
                    			    	qvar9 = qvar();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( (state.backtracking==0) ) stream_qvar.Add(qvar9.Tree);
                    			    	DCOLON10=(IToken)Match(input,DCOLON,FOLLOW_DCOLON_in_vdefg267); if (state.failed) return retval; 
                    			    	if ( (state.backtracking==0) ) stream_DCOLON.Add(DCOLON10);

                    			    	PushFollow(FOLLOW_ty_in_vdefg269);
                    			    	ty11 = ty();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( (state.backtracking==0) ) stream_ty.Add(ty11.Tree);
                    			    	EQ12=(IToken)Match(input,EQ,FOLLOW_EQ_in_vdefg271); if (state.failed) return retval; 
                    			    	if ( (state.backtracking==0) ) stream_EQ.Add(EQ12);

                    			    	PushFollow(FOLLOW_exp_in_vdefg273);
                    			    	exp13 = exp();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( (state.backtracking==0) ) stream_exp.Add(exp13.Tree);
                    			    	// Core.g:62:34: ( SEMICOLON )?
                    			    	int alt3 = 2;
                    			    	int LA3_0 = input.LA(1);

                    			    	if ( (LA3_0 == SEMICOLON) )
                    			    	{
                    			    	    alt3 = 1;
                    			    	}
                    			    	switch (alt3) 
                    			    	{
                    			    	    case 1 :
                    			    	        // Core.g:0:0: SEMICOLON
                    			    	        {
                    			    	        	SEMICOLON14=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_vdefg275); if (state.failed) return retval; 
                    			    	        	if ( (state.backtracking==0) ) stream_SEMICOLON.Add(SEMICOLON14);


                    			    	        }
                    			    	        break;

                    			    	}


                    			    }
                    			    break;

                    			default:
                    			    goto loop4;
                    	    }
                    	} while (true);

                    	loop4:
                    		;	// Stops C# compiler whining that label 'loop4' has no statements

                    	RB15=(IToken)Match(input,RB,FOLLOW_RB_in_vdefg280); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_RB.Add(RB15);



                    	// AST REWRITE
                    	// elements:          qvar, exp, ty
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 62:50: -> ( ^( TK_REC_VALUE_DEF qvar ty exp ) )*
                    	{
                    	    // Core.g:62:53: ( ^( TK_REC_VALUE_DEF qvar ty exp ) )*
                    	    while ( stream_qvar.HasNext() || stream_exp.HasNext() || stream_ty.HasNext() )
                    	    {
                    	        // Core.g:62:54: ^( TK_REC_VALUE_DEF qvar ty exp )
                    	        {
                    	        CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	        root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TK_REC_VALUE_DEF, "TK_REC_VALUE_DEF"), root_1);

                    	        adaptor.AddChild(root_1, stream_qvar.NextTree());
                    	        adaptor.AddChild(root_1, stream_ty.NextTree());
                    	        adaptor.AddChild(root_1, stream_exp.NextTree());

                    	        adaptor.AddChild(root_0, root_1);
                    	        }

                    	    }
                    	    stream_qvar.Reset();
                    	    stream_exp.Reset();
                    	    stream_ty.Reset();

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 2 :
                    // Core.g:63:4: qvar DCOLON ty EQ exp
                    {
                    	PushFollow(FOLLOW_qvar_in_vdefg300);
                    	qvar16 = qvar();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_qvar.Add(qvar16.Tree);
                    	DCOLON17=(IToken)Match(input,DCOLON,FOLLOW_DCOLON_in_vdefg302); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_DCOLON.Add(DCOLON17);

                    	PushFollow(FOLLOW_ty_in_vdefg304);
                    	ty18 = ty();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_ty.Add(ty18.Tree);
                    	EQ19=(IToken)Match(input,EQ,FOLLOW_EQ_in_vdefg306); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_EQ.Add(EQ19);

                    	PushFollow(FOLLOW_exp_in_vdefg308);
                    	exp20 = exp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_exp.Add(exp20.Tree);


                    	// AST REWRITE
                    	// elements:          exp, qvar, ty
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 63:26: -> ^( TK_VALUE_DEF qvar ty exp )
                    	{
                    	    // Core.g:63:29: ^( TK_VALUE_DEF qvar ty exp )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TK_VALUE_DEF, "TK_VALUE_DEF"), root_1);

                    	    adaptor.AddChild(root_1, stream_qvar.NextTree());
                    	    adaptor.AddChild(root_1, stream_ty.NextTree());
                    	    adaptor.AddChild(root_1, stream_exp.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "vdefg"

    public class tdef_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "tdef"
    // Core.g:65:1: tdef : ( DATA qtycon ( tbind )* EQ LB ( cdef ( SEMICOLON )? )* RB -> ^( TK_ALGEBRIC_TYPE qtycon ( tbind )* ( cdef )* ) | NEWTYPE qtycon qtycon ( tbind )* EQ ty -> ^( TK_NEW_TYPE qtycon qtycon ( tbind )* ) );
    public CoreParser.tdef_return tdef() // throws RecognitionException [1]
    {   
        CoreParser.tdef_return retval = new CoreParser.tdef_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken DATA21 = null;
        IToken EQ24 = null;
        IToken LB25 = null;
        IToken SEMICOLON27 = null;
        IToken RB28 = null;
        IToken NEWTYPE29 = null;
        IToken EQ33 = null;
        CoreParser.qtycon_return qtycon22 = default(CoreParser.qtycon_return);

        CoreParser.tbind_return tbind23 = default(CoreParser.tbind_return);

        CoreParser.cdef_return cdef26 = default(CoreParser.cdef_return);

        CoreParser.qtycon_return qtycon30 = default(CoreParser.qtycon_return);

        CoreParser.qtycon_return qtycon31 = default(CoreParser.qtycon_return);

        CoreParser.tbind_return tbind32 = default(CoreParser.tbind_return);

        CoreParser.ty_return ty34 = default(CoreParser.ty_return);


        CommonTree DATA21_tree=null;
        CommonTree EQ24_tree=null;
        CommonTree LB25_tree=null;
        CommonTree SEMICOLON27_tree=null;
        CommonTree RB28_tree=null;
        CommonTree NEWTYPE29_tree=null;
        CommonTree EQ33_tree=null;
        RewriteRuleTokenStream stream_LB = new RewriteRuleTokenStream(adaptor,"token LB");
        RewriteRuleTokenStream stream_SEMICOLON = new RewriteRuleTokenStream(adaptor,"token SEMICOLON");
        RewriteRuleTokenStream stream_EQ = new RewriteRuleTokenStream(adaptor,"token EQ");
        RewriteRuleTokenStream stream_RB = new RewriteRuleTokenStream(adaptor,"token RB");
        RewriteRuleTokenStream stream_DATA = new RewriteRuleTokenStream(adaptor,"token DATA");
        RewriteRuleTokenStream stream_NEWTYPE = new RewriteRuleTokenStream(adaptor,"token NEWTYPE");
        RewriteRuleSubtreeStream stream_ty = new RewriteRuleSubtreeStream(adaptor,"rule ty");
        RewriteRuleSubtreeStream stream_qtycon = new RewriteRuleSubtreeStream(adaptor,"rule qtycon");
        RewriteRuleSubtreeStream stream_cdef = new RewriteRuleSubtreeStream(adaptor,"rule cdef");
        RewriteRuleSubtreeStream stream_tbind = new RewriteRuleSubtreeStream(adaptor,"rule tbind");
        try 
    	{
            // Core.g:66:2: ( DATA qtycon ( tbind )* EQ LB ( cdef ( SEMICOLON )? )* RB -> ^( TK_ALGEBRIC_TYPE qtycon ( tbind )* ( cdef )* ) | NEWTYPE qtycon qtycon ( tbind )* EQ ty -> ^( TK_NEW_TYPE qtycon qtycon ( tbind )* ) )
            int alt10 = 2;
            int LA10_0 = input.LA(1);

            if ( (LA10_0 == DATA) )
            {
                alt10 = 1;
            }
            else if ( (LA10_0 == NEWTYPE) )
            {
                alt10 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d10s0 =
                    new NoViableAltException("", 10, 0, input);

                throw nvae_d10s0;
            }
            switch (alt10) 
            {
                case 1 :
                    // Core.g:66:4: DATA qtycon ( tbind )* EQ LB ( cdef ( SEMICOLON )? )* RB
                    {
                    	DATA21=(IToken)Match(input,DATA,FOLLOW_DATA_in_tdef330); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_DATA.Add(DATA21);

                    	PushFollow(FOLLOW_qtycon_in_tdef332);
                    	qtycon22 = qtycon();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_qtycon.Add(qtycon22.Tree);
                    	// Core.g:66:16: ( tbind )*
                    	do 
                    	{
                    	    int alt6 = 2;
                    	    int LA6_0 = input.LA(1);

                    	    if ( (LA6_0 == LP || LA6_0 == LNAME) )
                    	    {
                    	        alt6 = 1;
                    	    }


                    	    switch (alt6) 
                    		{
                    			case 1 :
                    			    // Core.g:66:17: tbind
                    			    {
                    			    	PushFollow(FOLLOW_tbind_in_tdef335);
                    			    	tbind23 = tbind();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( (state.backtracking==0) ) stream_tbind.Add(tbind23.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop6;
                    	    }
                    	} while (true);

                    	loop6:
                    		;	// Stops C# compiler whining that label 'loop6' has no statements

                    	EQ24=(IToken)Match(input,EQ,FOLLOW_EQ_in_tdef339); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_EQ.Add(EQ24);

                    	LB25=(IToken)Match(input,LB,FOLLOW_LB_in_tdef341); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_LB.Add(LB25);

                    	// Core.g:66:31: ( cdef ( SEMICOLON )? )*
                    	do 
                    	{
                    	    int alt8 = 2;
                    	    int LA8_0 = input.LA(1);

                    	    if ( ((LA8_0 >= UNAME && LA8_0 <= LNAME)) )
                    	    {
                    	        alt8 = 1;
                    	    }


                    	    switch (alt8) 
                    		{
                    			case 1 :
                    			    // Core.g:66:32: cdef ( SEMICOLON )?
                    			    {
                    			    	PushFollow(FOLLOW_cdef_in_tdef344);
                    			    	cdef26 = cdef();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( (state.backtracking==0) ) stream_cdef.Add(cdef26.Tree);
                    			    	// Core.g:66:37: ( SEMICOLON )?
                    			    	int alt7 = 2;
                    			    	int LA7_0 = input.LA(1);

                    			    	if ( (LA7_0 == SEMICOLON) )
                    			    	{
                    			    	    alt7 = 1;
                    			    	}
                    			    	switch (alt7) 
                    			    	{
                    			    	    case 1 :
                    			    	        // Core.g:0:0: SEMICOLON
                    			    	        {
                    			    	        	SEMICOLON27=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_tdef346); if (state.failed) return retval; 
                    			    	        	if ( (state.backtracking==0) ) stream_SEMICOLON.Add(SEMICOLON27);


                    			    	        }
                    			    	        break;

                    			    	}


                    			    }
                    			    break;

                    			default:
                    			    goto loop8;
                    	    }
                    	} while (true);

                    	loop8:
                    		;	// Stops C# compiler whining that label 'loop8' has no statements

                    	RB28=(IToken)Match(input,RB,FOLLOW_RB_in_tdef351); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_RB.Add(RB28);



                    	// AST REWRITE
                    	// elements:          tbind, cdef, qtycon
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 66:53: -> ^( TK_ALGEBRIC_TYPE qtycon ( tbind )* ( cdef )* )
                    	{
                    	    // Core.g:66:56: ^( TK_ALGEBRIC_TYPE qtycon ( tbind )* ( cdef )* )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TK_ALGEBRIC_TYPE, "TK_ALGEBRIC_TYPE"), root_1);

                    	    adaptor.AddChild(root_1, stream_qtycon.NextTree());
                    	    // Core.g:66:82: ( tbind )*
                    	    while ( stream_tbind.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_tbind.NextTree());

                    	    }
                    	    stream_tbind.Reset();
                    	    // Core.g:66:89: ( cdef )*
                    	    while ( stream_cdef.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_cdef.NextTree());

                    	    }
                    	    stream_cdef.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 2 :
                    // Core.g:67:4: NEWTYPE qtycon qtycon ( tbind )* EQ ty
                    {
                    	NEWTYPE29=(IToken)Match(input,NEWTYPE,FOLLOW_NEWTYPE_in_tdef370); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_NEWTYPE.Add(NEWTYPE29);

                    	PushFollow(FOLLOW_qtycon_in_tdef372);
                    	qtycon30 = qtycon();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_qtycon.Add(qtycon30.Tree);
                    	PushFollow(FOLLOW_qtycon_in_tdef374);
                    	qtycon31 = qtycon();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_qtycon.Add(qtycon31.Tree);
                    	// Core.g:67:26: ( tbind )*
                    	do 
                    	{
                    	    int alt9 = 2;
                    	    int LA9_0 = input.LA(1);

                    	    if ( (LA9_0 == LP || LA9_0 == LNAME) )
                    	    {
                    	        alt9 = 1;
                    	    }


                    	    switch (alt9) 
                    		{
                    			case 1 :
                    			    // Core.g:67:27: tbind
                    			    {
                    			    	PushFollow(FOLLOW_tbind_in_tdef377);
                    			    	tbind32 = tbind();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( (state.backtracking==0) ) stream_tbind.Add(tbind32.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop9;
                    	    }
                    	} while (true);

                    	loop9:
                    		;	// Stops C# compiler whining that label 'loop9' has no statements

                    	EQ33=(IToken)Match(input,EQ,FOLLOW_EQ_in_tdef381); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_EQ.Add(EQ33);

                    	PushFollow(FOLLOW_ty_in_tdef383);
                    	ty34 = ty();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_ty.Add(ty34.Tree);


                    	// AST REWRITE
                    	// elements:          qtycon, tbind, qtycon
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 67:41: -> ^( TK_NEW_TYPE qtycon qtycon ( tbind )* )
                    	{
                    	    // Core.g:67:44: ^( TK_NEW_TYPE qtycon qtycon ( tbind )* )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TK_NEW_TYPE, "TK_NEW_TYPE"), root_1);

                    	    adaptor.AddChild(root_1, stream_qtycon.NextTree());
                    	    adaptor.AddChild(root_1, stream_qtycon.NextTree());
                    	    // Core.g:67:72: ( tbind )*
                    	    while ( stream_tbind.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_tbind.NextTree());

                    	    }
                    	    stream_tbind.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "tdef"

    public class cdef_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "cdef"
    // Core.g:70:1: cdef : qdcon ( AT tbind )* ( aty )* -> ^( TK_CONSTRUCTOR_DEF qdcon ( tbind )* ( aty )* ) ;
    public CoreParser.cdef_return cdef() // throws RecognitionException [1]
    {   
        CoreParser.cdef_return retval = new CoreParser.cdef_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken AT36 = null;
        CoreParser.qdcon_return qdcon35 = default(CoreParser.qdcon_return);

        CoreParser.tbind_return tbind37 = default(CoreParser.tbind_return);

        CoreParser.aty_return aty38 = default(CoreParser.aty_return);


        CommonTree AT36_tree=null;
        RewriteRuleTokenStream stream_AT = new RewriteRuleTokenStream(adaptor,"token AT");
        RewriteRuleSubtreeStream stream_qdcon = new RewriteRuleSubtreeStream(adaptor,"rule qdcon");
        RewriteRuleSubtreeStream stream_tbind = new RewriteRuleSubtreeStream(adaptor,"rule tbind");
        RewriteRuleSubtreeStream stream_aty = new RewriteRuleSubtreeStream(adaptor,"rule aty");
        try 
    	{
            // Core.g:71:2: ( qdcon ( AT tbind )* ( aty )* -> ^( TK_CONSTRUCTOR_DEF qdcon ( tbind )* ( aty )* ) )
            // Core.g:71:4: qdcon ( AT tbind )* ( aty )*
            {
            	PushFollow(FOLLOW_qdcon_in_cdef407);
            	qdcon35 = qdcon();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_qdcon.Add(qdcon35.Tree);
            	// Core.g:71:10: ( AT tbind )*
            	do 
            	{
            	    int alt11 = 2;
            	    int LA11_0 = input.LA(1);

            	    if ( (LA11_0 == AT) )
            	    {
            	        alt11 = 1;
            	    }


            	    switch (alt11) 
            		{
            			case 1 :
            			    // Core.g:71:11: AT tbind
            			    {
            			    	AT36=(IToken)Match(input,AT,FOLLOW_AT_in_cdef410); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_AT.Add(AT36);

            			    	PushFollow(FOLLOW_tbind_in_cdef412);
            			    	tbind37 = tbind();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_tbind.Add(tbind37.Tree);

            			    }
            			    break;

            			default:
            			    goto loop11;
            	    }
            	} while (true);

            	loop11:
            		;	// Stops C# compiler whining that label 'loop11' has no statements

            	// Core.g:71:23: ( aty )*
            	do 
            	{
            	    int alt12 = 2;
            	    switch ( input.LA(1) ) 
            	    {
            	    case LNAME:
            	    	{
            	        int LA12_2 = input.LA(2);

            	        if ( (LA12_2 == COLON) )
            	        {
            	            int LA12_5 = input.LA(3);

            	            if ( (LA12_5 == UNAME) )
            	            {
            	                int LA12_6 = input.LA(4);

            	                if ( (LA12_6 == DOT) )
            	                {
            	                    int LA12_7 = input.LA(5);

            	                    if ( (LA12_7 == UNAME) )
            	                    {
            	                        int LA12_8 = input.LA(6);

            	                        if ( (synpred12_Core()) )
            	                        {
            	                            alt12 = 1;
            	                        }


            	                    }


            	                }


            	            }


            	        }
            	        else if ( (LA12_2 == EOF || LA12_2 == SEMICOLON || LA12_2 == RB || LA12_2 == LP || (LA12_2 >= UNAME && LA12_2 <= LNAME)) )
            	        {
            	            alt12 = 1;
            	        }


            	        }
            	        break;
            	    case UNAME:
            	    	{
            	        int LA12_3 = input.LA(2);

            	        if ( (LA12_3 == COLON) )
            	        {
            	            int LA12_5 = input.LA(3);

            	            if ( (LA12_5 == UNAME) )
            	            {
            	                int LA12_6 = input.LA(4);

            	                if ( (LA12_6 == DOT) )
            	                {
            	                    int LA12_7 = input.LA(5);

            	                    if ( (LA12_7 == UNAME) )
            	                    {
            	                        int LA12_8 = input.LA(6);

            	                        if ( (synpred12_Core()) )
            	                        {
            	                            alt12 = 1;
            	                        }


            	                    }


            	                }


            	            }


            	        }


            	        }
            	        break;
            	    case LP:
            	    	{
            	        alt12 = 1;
            	        }
            	        break;

            	    }

            	    switch (alt12) 
            		{
            			case 1 :
            			    // Core.g:71:25: aty
            			    {
            			    	PushFollow(FOLLOW_aty_in_cdef419);
            			    	aty38 = aty();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_aty.Add(aty38.Tree);

            			    }
            			    break;

            			default:
            			    goto loop12;
            	    }
            	} while (true);

            	loop12:
            		;	// Stops C# compiler whining that label 'loop12' has no statements



            	// AST REWRITE
            	// elements:          aty, tbind, qdcon
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 71:32: -> ^( TK_CONSTRUCTOR_DEF qdcon ( tbind )* ( aty )* )
            	{
            	    // Core.g:71:35: ^( TK_CONSTRUCTOR_DEF qdcon ( tbind )* ( aty )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TK_CONSTRUCTOR_DEF, "TK_CONSTRUCTOR_DEF"), root_1);

            	    adaptor.AddChild(root_1, stream_qdcon.NextTree());
            	    // Core.g:71:62: ( tbind )*
            	    while ( stream_tbind.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_tbind.NextTree());

            	    }
            	    stream_tbind.Reset();
            	    // Core.g:71:69: ( aty )*
            	    while ( stream_aty.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_aty.NextTree());

            	    }
            	    stream_aty.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "cdef"

    public class aexp_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "aexp"
    // Core.g:77:1: aexp : ( qvar | qdcon | literal | LP exp RP -> ^( TK_NESTED_EXPRESSION exp ) );
    public CoreParser.aexp_return aexp() // throws RecognitionException [1]
    {   
        CoreParser.aexp_return retval = new CoreParser.aexp_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken LP42 = null;
        IToken RP44 = null;
        CoreParser.qvar_return qvar39 = default(CoreParser.qvar_return);

        CoreParser.qdcon_return qdcon40 = default(CoreParser.qdcon_return);

        CoreParser.literal_return literal41 = default(CoreParser.literal_return);

        CoreParser.exp_return exp43 = default(CoreParser.exp_return);


        CommonTree LP42_tree=null;
        CommonTree RP44_tree=null;
        RewriteRuleTokenStream stream_RP = new RewriteRuleTokenStream(adaptor,"token RP");
        RewriteRuleTokenStream stream_LP = new RewriteRuleTokenStream(adaptor,"token LP");
        RewriteRuleSubtreeStream stream_exp = new RewriteRuleSubtreeStream(adaptor,"rule exp");
        try 
    	{
            // Core.g:78:2: ( qvar | qdcon | literal | LP exp RP -> ^( TK_NESTED_EXPRESSION exp ) )
            int alt13 = 4;
            alt13 = dfa13.Predict(input);
            switch (alt13) 
            {
                case 1 :
                    // Core.g:78:4: qvar
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_qvar_in_aexp450);
                    	qvar39 = qvar();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, qvar39.Tree);

                    }
                    break;
                case 2 :
                    // Core.g:79:4: qdcon
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_qdcon_in_aexp455);
                    	qdcon40 = qdcon();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, qdcon40.Tree);

                    }
                    break;
                case 3 :
                    // Core.g:80:4: literal
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_literal_in_aexp460);
                    	literal41 = literal();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, literal41.Tree);

                    }
                    break;
                case 4 :
                    // Core.g:81:4: LP exp RP
                    {
                    	LP42=(IToken)Match(input,LP,FOLLOW_LP_in_aexp465); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_LP.Add(LP42);

                    	PushFollow(FOLLOW_exp_in_aexp467);
                    	exp43 = exp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_exp.Add(exp43.Tree);
                    	RP44=(IToken)Match(input,RP,FOLLOW_RP_in_aexp469); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_RP.Add(RP44);



                    	// AST REWRITE
                    	// elements:          exp
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 81:14: -> ^( TK_NESTED_EXPRESSION exp )
                    	{
                    	    // Core.g:81:17: ^( TK_NESTED_EXPRESSION exp )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TK_NESTED_EXPRESSION, "TK_NESTED_EXPRESSION"), root_1);

                    	    adaptor.AddChild(root_1, stream_exp.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "aexp"

    public class exp_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "exp"
    // Core.g:84:1: exp : ( aexp ( arg )+ -> ^( TK_APPLICATION aexp ( arg )+ ) | DSLASH ( binder )+ ARROW exp -> ^( TK_ABSTRACTION exp ( binder )+ ) | LET vdefg IN exp -> ^( TK_LOCAL_DEFINITION vdefg exp ) | CASE aty exp OF vbind LB alt ( SEMICOLON alt )* RB -> ^( TK_CASE_EXPRESSION aty exp vbind ( alt )+ ) | CAST LP exp RP aty -> ^( TK_CAST exp aty ) | NOTE STRINGLITERAL exp -> ^( TK_NOTE STRINGLITERAL exp ) | ECALL STRINGLITERAL aty | DECALL aty | LABEL STRINGLITERAL | aexp );
    public CoreParser.exp_return exp() // throws RecognitionException [1]
    {   
        CoreParser.exp_return retval = new CoreParser.exp_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken DSLASH47 = null;
        IToken ARROW49 = null;
        IToken LET51 = null;
        IToken IN53 = null;
        IToken CASE55 = null;
        IToken OF58 = null;
        IToken LB60 = null;
        IToken SEMICOLON62 = null;
        IToken RB64 = null;
        IToken CAST65 = null;
        IToken LP66 = null;
        IToken RP68 = null;
        IToken NOTE70 = null;
        IToken STRINGLITERAL71 = null;
        IToken ECALL73 = null;
        IToken STRINGLITERAL74 = null;
        IToken DECALL76 = null;
        IToken LABEL78 = null;
        IToken STRINGLITERAL79 = null;
        CoreParser.aexp_return aexp45 = default(CoreParser.aexp_return);

        CoreParser.arg_return arg46 = default(CoreParser.arg_return);

        CoreParser.binder_return binder48 = default(CoreParser.binder_return);

        CoreParser.exp_return exp50 = default(CoreParser.exp_return);

        CoreParser.vdefg_return vdefg52 = default(CoreParser.vdefg_return);

        CoreParser.exp_return exp54 = default(CoreParser.exp_return);

        CoreParser.aty_return aty56 = default(CoreParser.aty_return);

        CoreParser.exp_return exp57 = default(CoreParser.exp_return);

        CoreParser.vbind_return vbind59 = default(CoreParser.vbind_return);

        CoreParser.alt_return alt61 = default(CoreParser.alt_return);

        CoreParser.alt_return alt63 = default(CoreParser.alt_return);

        CoreParser.exp_return exp67 = default(CoreParser.exp_return);

        CoreParser.aty_return aty69 = default(CoreParser.aty_return);

        CoreParser.exp_return exp72 = default(CoreParser.exp_return);

        CoreParser.aty_return aty75 = default(CoreParser.aty_return);

        CoreParser.aty_return aty77 = default(CoreParser.aty_return);

        CoreParser.aexp_return aexp80 = default(CoreParser.aexp_return);


        CommonTree DSLASH47_tree=null;
        CommonTree ARROW49_tree=null;
        CommonTree LET51_tree=null;
        CommonTree IN53_tree=null;
        CommonTree CASE55_tree=null;
        CommonTree OF58_tree=null;
        CommonTree LB60_tree=null;
        CommonTree SEMICOLON62_tree=null;
        CommonTree RB64_tree=null;
        CommonTree CAST65_tree=null;
        CommonTree LP66_tree=null;
        CommonTree RP68_tree=null;
        CommonTree NOTE70_tree=null;
        CommonTree STRINGLITERAL71_tree=null;
        CommonTree ECALL73_tree=null;
        CommonTree STRINGLITERAL74_tree=null;
        CommonTree DECALL76_tree=null;
        CommonTree LABEL78_tree=null;
        CommonTree STRINGLITERAL79_tree=null;
        RewriteRuleTokenStream stream_CAST = new RewriteRuleTokenStream(adaptor,"token CAST");
        RewriteRuleTokenStream stream_ARROW = new RewriteRuleTokenStream(adaptor,"token ARROW");
        RewriteRuleTokenStream stream_LB = new RewriteRuleTokenStream(adaptor,"token LB");
        RewriteRuleTokenStream stream_SEMICOLON = new RewriteRuleTokenStream(adaptor,"token SEMICOLON");
        RewriteRuleTokenStream stream_IN = new RewriteRuleTokenStream(adaptor,"token IN");
        RewriteRuleTokenStream stream_RB = new RewriteRuleTokenStream(adaptor,"token RB");
        RewriteRuleTokenStream stream_RP = new RewriteRuleTokenStream(adaptor,"token RP");
        RewriteRuleTokenStream stream_OF = new RewriteRuleTokenStream(adaptor,"token OF");
        RewriteRuleTokenStream stream_DSLASH = new RewriteRuleTokenStream(adaptor,"token DSLASH");
        RewriteRuleTokenStream stream_NOTE = new RewriteRuleTokenStream(adaptor,"token NOTE");
        RewriteRuleTokenStream stream_STRINGLITERAL = new RewriteRuleTokenStream(adaptor,"token STRINGLITERAL");
        RewriteRuleTokenStream stream_LET = new RewriteRuleTokenStream(adaptor,"token LET");
        RewriteRuleTokenStream stream_LP = new RewriteRuleTokenStream(adaptor,"token LP");
        RewriteRuleTokenStream stream_CASE = new RewriteRuleTokenStream(adaptor,"token CASE");
        RewriteRuleSubtreeStream stream_vbind = new RewriteRuleSubtreeStream(adaptor,"rule vbind");
        RewriteRuleSubtreeStream stream_binder = new RewriteRuleSubtreeStream(adaptor,"rule binder");
        RewriteRuleSubtreeStream stream_exp = new RewriteRuleSubtreeStream(adaptor,"rule exp");
        RewriteRuleSubtreeStream stream_arg = new RewriteRuleSubtreeStream(adaptor,"rule arg");
        RewriteRuleSubtreeStream stream_vdefg = new RewriteRuleSubtreeStream(adaptor,"rule vdefg");
        RewriteRuleSubtreeStream stream_alt = new RewriteRuleSubtreeStream(adaptor,"rule alt");
        RewriteRuleSubtreeStream stream_aexp = new RewriteRuleSubtreeStream(adaptor,"rule aexp");
        RewriteRuleSubtreeStream stream_aty = new RewriteRuleSubtreeStream(adaptor,"rule aty");
        try 
    	{
            // Core.g:85:2: ( aexp ( arg )+ -> ^( TK_APPLICATION aexp ( arg )+ ) | DSLASH ( binder )+ ARROW exp -> ^( TK_ABSTRACTION exp ( binder )+ ) | LET vdefg IN exp -> ^( TK_LOCAL_DEFINITION vdefg exp ) | CASE aty exp OF vbind LB alt ( SEMICOLON alt )* RB -> ^( TK_CASE_EXPRESSION aty exp vbind ( alt )+ ) | CAST LP exp RP aty -> ^( TK_CAST exp aty ) | NOTE STRINGLITERAL exp -> ^( TK_NOTE STRINGLITERAL exp ) | ECALL STRINGLITERAL aty | DECALL aty | LABEL STRINGLITERAL | aexp )
            int alt17 = 10;
            alt17 = dfa17.Predict(input);
            switch (alt17) 
            {
                case 1 :
                    // Core.g:85:4: aexp ( arg )+
                    {
                    	PushFollow(FOLLOW_aexp_in_exp491);
                    	aexp45 = aexp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_aexp.Add(aexp45.Tree);
                    	// Core.g:85:9: ( arg )+
                    	int cnt14 = 0;
                    	do 
                    	{
                    	    int alt14 = 2;
                    	    switch ( input.LA(1) ) 
                    	    {
                    	    case LNAME:
                    	    	{
                    	        int LA14_2 = input.LA(2);

                    	        if ( (LA14_2 == EOF || LA14_2 == SEMICOLON || LA14_2 == RB || (LA14_2 >= AT && LA14_2 <= RP) || LA14_2 == IN || LA14_2 == OF || (LA14_2 >= UNAME && LA14_2 <= LNAME)) )
                    	        {
                    	            alt14 = 1;
                    	        }
                    	        else if ( (LA14_2 == COLON) )
                    	        {
                    	            int LA14_5 = input.LA(3);

                    	            if ( (LA14_5 == UNAME) )
                    	            {
                    	                int LA14_6 = input.LA(4);

                    	                if ( (LA14_6 == DOT) )
                    	                {
                    	                    int LA14_7 = input.LA(5);

                    	                    if ( (LA14_7 == UNAME) )
                    	                    {
                    	                        alt14 = 1;
                    	                    }
                    	                    else if ( (LA14_7 == LNAME) )
                    	                    {
                    	                        int LA14_8 = input.LA(6);

                    	                        if ( (LA14_8 == EOF || LA14_8 == SEMICOLON || LA14_8 == RB || (LA14_8 >= AT && LA14_8 <= RP) || LA14_8 == IN || LA14_8 == OF || (LA14_8 >= UNAME && LA14_8 <= LNAME)) )
                    	                        {
                    	                            alt14 = 1;
                    	                        }


                    	                    }


                    	                }


                    	            }


                    	        }


                    	        }
                    	        break;
                    	    case UNAME:
                    	    	{
                    	        int LA14_3 = input.LA(2);

                    	        if ( (LA14_3 == COLON) )
                    	        {
                    	            int LA14_5 = input.LA(3);

                    	            if ( (LA14_5 == UNAME) )
                    	            {
                    	                int LA14_6 = input.LA(4);

                    	                if ( (LA14_6 == DOT) )
                    	                {
                    	                    int LA14_7 = input.LA(5);

                    	                    if ( (LA14_7 == UNAME) )
                    	                    {
                    	                        alt14 = 1;
                    	                    }
                    	                    else if ( (LA14_7 == LNAME) )
                    	                    {
                    	                        int LA14_8 = input.LA(6);

                    	                        if ( (LA14_8 == EOF || LA14_8 == SEMICOLON || LA14_8 == RB || (LA14_8 >= AT && LA14_8 <= RP) || LA14_8 == IN || LA14_8 == OF || (LA14_8 >= UNAME && LA14_8 <= LNAME)) )
                    	                        {
                    	                            alt14 = 1;
                    	                        }


                    	                    }


                    	                }


                    	            }


                    	        }


                    	        }
                    	        break;
                    	    case AT:
                    	    case LP:
                    	    	{
                    	        alt14 = 1;
                    	        }
                    	        break;

                    	    }

                    	    switch (alt14) 
                    		{
                    			case 1 :
                    			    // Core.g:85:10: arg
                    			    {
                    			    	PushFollow(FOLLOW_arg_in_exp494);
                    			    	arg46 = arg();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( (state.backtracking==0) ) stream_arg.Add(arg46.Tree);

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt14 >= 1 ) goto loop14;
                    			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    		            EarlyExitException eee14 =
                    		                new EarlyExitException(14, input);
                    		            throw eee14;
                    	    }
                    	    cnt14++;
                    	} while (true);

                    	loop14:
                    		;	// Stops C# compiler whining that label 'loop14' has no statements



                    	// AST REWRITE
                    	// elements:          arg, aexp
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 85:16: -> ^( TK_APPLICATION aexp ( arg )+ )
                    	{
                    	    // Core.g:85:19: ^( TK_APPLICATION aexp ( arg )+ )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TK_APPLICATION, "TK_APPLICATION"), root_1);

                    	    adaptor.AddChild(root_1, stream_aexp.NextTree());
                    	    if ( !(stream_arg.HasNext()) ) {
                    	        throw new RewriteEarlyExitException();
                    	    }
                    	    while ( stream_arg.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_arg.NextTree());

                    	    }
                    	    stream_arg.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 2 :
                    // Core.g:86:4: DSLASH ( binder )+ ARROW exp
                    {
                    	DSLASH47=(IToken)Match(input,DSLASH,FOLLOW_DSLASH_in_exp515); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_DSLASH.Add(DSLASH47);

                    	// Core.g:86:11: ( binder )+
                    	int cnt15 = 0;
                    	do 
                    	{
                    	    int alt15 = 2;
                    	    int LA15_0 = input.LA(1);

                    	    if ( ((LA15_0 >= AT && LA15_0 <= LP)) )
                    	    {
                    	        alt15 = 1;
                    	    }


                    	    switch (alt15) 
                    		{
                    			case 1 :
                    			    // Core.g:86:12: binder
                    			    {
                    			    	PushFollow(FOLLOW_binder_in_exp518);
                    			    	binder48 = binder();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( (state.backtracking==0) ) stream_binder.Add(binder48.Tree);

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt15 >= 1 ) goto loop15;
                    			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    		            EarlyExitException eee15 =
                    		                new EarlyExitException(15, input);
                    		            throw eee15;
                    	    }
                    	    cnt15++;
                    	} while (true);

                    	loop15:
                    		;	// Stops C# compiler whining that label 'loop15' has no statements

                    	ARROW49=(IToken)Match(input,ARROW,FOLLOW_ARROW_in_exp522); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_ARROW.Add(ARROW49);

                    	PushFollow(FOLLOW_exp_in_exp524);
                    	exp50 = exp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_exp.Add(exp50.Tree);


                    	// AST REWRITE
                    	// elements:          exp, binder
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 86:31: -> ^( TK_ABSTRACTION exp ( binder )+ )
                    	{
                    	    // Core.g:86:34: ^( TK_ABSTRACTION exp ( binder )+ )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TK_ABSTRACTION, "TK_ABSTRACTION"), root_1);

                    	    adaptor.AddChild(root_1, stream_exp.NextTree());
                    	    if ( !(stream_binder.HasNext()) ) {
                    	        throw new RewriteEarlyExitException();
                    	    }
                    	    while ( stream_binder.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_binder.NextTree());

                    	    }
                    	    stream_binder.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 3 :
                    // Core.g:87:4: LET vdefg IN exp
                    {
                    	LET51=(IToken)Match(input,LET,FOLLOW_LET_in_exp542); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_LET.Add(LET51);

                    	PushFollow(FOLLOW_vdefg_in_exp544);
                    	vdefg52 = vdefg();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_vdefg.Add(vdefg52.Tree);
                    	IN53=(IToken)Match(input,IN,FOLLOW_IN_in_exp546); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_IN.Add(IN53);

                    	PushFollow(FOLLOW_exp_in_exp548);
                    	exp54 = exp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_exp.Add(exp54.Tree);


                    	// AST REWRITE
                    	// elements:          exp, vdefg
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 87:21: -> ^( TK_LOCAL_DEFINITION vdefg exp )
                    	{
                    	    // Core.g:87:24: ^( TK_LOCAL_DEFINITION vdefg exp )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TK_LOCAL_DEFINITION, "TK_LOCAL_DEFINITION"), root_1);

                    	    adaptor.AddChild(root_1, stream_vdefg.NextTree());
                    	    adaptor.AddChild(root_1, stream_exp.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 4 :
                    // Core.g:88:4: CASE aty exp OF vbind LB alt ( SEMICOLON alt )* RB
                    {
                    	CASE55=(IToken)Match(input,CASE,FOLLOW_CASE_in_exp563); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_CASE.Add(CASE55);

                    	PushFollow(FOLLOW_aty_in_exp565);
                    	aty56 = aty();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_aty.Add(aty56.Tree);
                    	PushFollow(FOLLOW_exp_in_exp567);
                    	exp57 = exp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_exp.Add(exp57.Tree);
                    	OF58=(IToken)Match(input,OF,FOLLOW_OF_in_exp569); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_OF.Add(OF58);

                    	PushFollow(FOLLOW_vbind_in_exp571);
                    	vbind59 = vbind();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_vbind.Add(vbind59.Tree);
                    	LB60=(IToken)Match(input,LB,FOLLOW_LB_in_exp573); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_LB.Add(LB60);

                    	PushFollow(FOLLOW_alt_in_exp575);
                    	alt61 = alt();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_alt.Add(alt61.Tree);
                    	// Core.g:88:33: ( SEMICOLON alt )*
                    	do 
                    	{
                    	    int alt16 = 2;
                    	    int LA16_0 = input.LA(1);

                    	    if ( (LA16_0 == SEMICOLON) )
                    	    {
                    	        alt16 = 1;
                    	    }


                    	    switch (alt16) 
                    		{
                    			case 1 :
                    			    // Core.g:88:34: SEMICOLON alt
                    			    {
                    			    	SEMICOLON62=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_exp578); if (state.failed) return retval; 
                    			    	if ( (state.backtracking==0) ) stream_SEMICOLON.Add(SEMICOLON62);

                    			    	PushFollow(FOLLOW_alt_in_exp580);
                    			    	alt63 = alt();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( (state.backtracking==0) ) stream_alt.Add(alt63.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop16;
                    	    }
                    	} while (true);

                    	loop16:
                    		;	// Stops C# compiler whining that label 'loop16' has no statements

                    	RB64=(IToken)Match(input,RB,FOLLOW_RB_in_exp584); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_RB.Add(RB64);



                    	// AST REWRITE
                    	// elements:          vbind, alt, aty, exp
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 88:53: -> ^( TK_CASE_EXPRESSION aty exp vbind ( alt )+ )
                    	{
                    	    // Core.g:88:56: ^( TK_CASE_EXPRESSION aty exp vbind ( alt )+ )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TK_CASE_EXPRESSION, "TK_CASE_EXPRESSION"), root_1);

                    	    adaptor.AddChild(root_1, stream_aty.NextTree());
                    	    adaptor.AddChild(root_1, stream_exp.NextTree());
                    	    adaptor.AddChild(root_1, stream_vbind.NextTree());
                    	    if ( !(stream_alt.HasNext()) ) {
                    	        throw new RewriteEarlyExitException();
                    	    }
                    	    while ( stream_alt.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_alt.NextTree());

                    	    }
                    	    stream_alt.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 5 :
                    // Core.g:89:4: CAST LP exp RP aty
                    {
                    	CAST65=(IToken)Match(input,CAST,FOLLOW_CAST_in_exp604); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_CAST.Add(CAST65);

                    	LP66=(IToken)Match(input,LP,FOLLOW_LP_in_exp606); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_LP.Add(LP66);

                    	PushFollow(FOLLOW_exp_in_exp608);
                    	exp67 = exp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_exp.Add(exp67.Tree);
                    	RP68=(IToken)Match(input,RP,FOLLOW_RP_in_exp610); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_RP.Add(RP68);

                    	PushFollow(FOLLOW_aty_in_exp612);
                    	aty69 = aty();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_aty.Add(aty69.Tree);


                    	// AST REWRITE
                    	// elements:          exp, aty
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 89:23: -> ^( TK_CAST exp aty )
                    	{
                    	    // Core.g:89:26: ^( TK_CAST exp aty )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TK_CAST, "TK_CAST"), root_1);

                    	    adaptor.AddChild(root_1, stream_exp.NextTree());
                    	    adaptor.AddChild(root_1, stream_aty.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 6 :
                    // Core.g:90:4: NOTE STRINGLITERAL exp
                    {
                    	NOTE70=(IToken)Match(input,NOTE,FOLLOW_NOTE_in_exp628); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_NOTE.Add(NOTE70);

                    	STRINGLITERAL71=(IToken)Match(input,STRINGLITERAL,FOLLOW_STRINGLITERAL_in_exp630); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_STRINGLITERAL.Add(STRINGLITERAL71);

                    	PushFollow(FOLLOW_exp_in_exp632);
                    	exp72 = exp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_exp.Add(exp72.Tree);


                    	// AST REWRITE
                    	// elements:          exp, STRINGLITERAL
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 90:27: -> ^( TK_NOTE STRINGLITERAL exp )
                    	{
                    	    // Core.g:90:30: ^( TK_NOTE STRINGLITERAL exp )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TK_NOTE, "TK_NOTE"), root_1);

                    	    adaptor.AddChild(root_1, stream_STRINGLITERAL.NextNode());
                    	    adaptor.AddChild(root_1, stream_exp.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 7 :
                    // Core.g:91:4: ECALL STRINGLITERAL aty
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	ECALL73=(IToken)Match(input,ECALL,FOLLOW_ECALL_in_exp647); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{ECALL73_tree = (CommonTree)adaptor.Create(ECALL73);
                    		adaptor.AddChild(root_0, ECALL73_tree);
                    	}
                    	STRINGLITERAL74=(IToken)Match(input,STRINGLITERAL,FOLLOW_STRINGLITERAL_in_exp649); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{STRINGLITERAL74_tree = (CommonTree)adaptor.Create(STRINGLITERAL74);
                    		adaptor.AddChild(root_0, STRINGLITERAL74_tree);
                    	}
                    	PushFollow(FOLLOW_aty_in_exp651);
                    	aty75 = aty();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, aty75.Tree);

                    }
                    break;
                case 8 :
                    // Core.g:92:4: DECALL aty
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	DECALL76=(IToken)Match(input,DECALL,FOLLOW_DECALL_in_exp656); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{DECALL76_tree = (CommonTree)adaptor.Create(DECALL76);
                    		adaptor.AddChild(root_0, DECALL76_tree);
                    	}
                    	PushFollow(FOLLOW_aty_in_exp658);
                    	aty77 = aty();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, aty77.Tree);

                    }
                    break;
                case 9 :
                    // Core.g:93:4: LABEL STRINGLITERAL
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	LABEL78=(IToken)Match(input,LABEL,FOLLOW_LABEL_in_exp663); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{LABEL78_tree = (CommonTree)adaptor.Create(LABEL78);
                    		adaptor.AddChild(root_0, LABEL78_tree);
                    	}
                    	STRINGLITERAL79=(IToken)Match(input,STRINGLITERAL,FOLLOW_STRINGLITERAL_in_exp665); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{STRINGLITERAL79_tree = (CommonTree)adaptor.Create(STRINGLITERAL79);
                    		adaptor.AddChild(root_0, STRINGLITERAL79_tree);
                    	}

                    }
                    break;
                case 10 :
                    // Core.g:94:4: aexp
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_aexp_in_exp670);
                    	aexp80 = aexp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, aexp80.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "exp"

    public class akind_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "akind"
    // Core.g:97:1: akind : ( STAR | SHARP | QUESTION | bty DCOLONEQ bty | LP kind RP );
    public CoreParser.akind_return akind() // throws RecognitionException [1]
    {   
        CoreParser.akind_return retval = new CoreParser.akind_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken STAR81 = null;
        IToken SHARP82 = null;
        IToken QUESTION83 = null;
        IToken DCOLONEQ85 = null;
        IToken LP87 = null;
        IToken RP89 = null;
        CoreParser.bty_return bty84 = default(CoreParser.bty_return);

        CoreParser.bty_return bty86 = default(CoreParser.bty_return);

        CoreParser.kind_return kind88 = default(CoreParser.kind_return);


        CommonTree STAR81_tree=null;
        CommonTree SHARP82_tree=null;
        CommonTree QUESTION83_tree=null;
        CommonTree DCOLONEQ85_tree=null;
        CommonTree LP87_tree=null;
        CommonTree RP89_tree=null;

        try 
    	{
            // Core.g:98:2: ( STAR | SHARP | QUESTION | bty DCOLONEQ bty | LP kind RP )
            int alt18 = 5;
            alt18 = dfa18.Predict(input);
            switch (alt18) 
            {
                case 1 :
                    // Core.g:98:4: STAR
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	STAR81=(IToken)Match(input,STAR,FOLLOW_STAR_in_akind683); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{STAR81_tree = (CommonTree)adaptor.Create(STAR81);
                    		adaptor.AddChild(root_0, STAR81_tree);
                    	}

                    }
                    break;
                case 2 :
                    // Core.g:99:4: SHARP
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	SHARP82=(IToken)Match(input,SHARP,FOLLOW_SHARP_in_akind688); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{SHARP82_tree = (CommonTree)adaptor.Create(SHARP82);
                    		adaptor.AddChild(root_0, SHARP82_tree);
                    	}

                    }
                    break;
                case 3 :
                    // Core.g:100:4: QUESTION
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	QUESTION83=(IToken)Match(input,QUESTION,FOLLOW_QUESTION_in_akind693); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{QUESTION83_tree = (CommonTree)adaptor.Create(QUESTION83);
                    		adaptor.AddChild(root_0, QUESTION83_tree);
                    	}

                    }
                    break;
                case 4 :
                    // Core.g:101:4: bty DCOLONEQ bty
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_bty_in_akind698);
                    	bty84 = bty();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, bty84.Tree);
                    	DCOLONEQ85=(IToken)Match(input,DCOLONEQ,FOLLOW_DCOLONEQ_in_akind700); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{DCOLONEQ85_tree = (CommonTree)adaptor.Create(DCOLONEQ85);
                    		adaptor.AddChild(root_0, DCOLONEQ85_tree);
                    	}
                    	PushFollow(FOLLOW_bty_in_akind702);
                    	bty86 = bty();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, bty86.Tree);

                    }
                    break;
                case 5 :
                    // Core.g:102:4: LP kind RP
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	LP87=(IToken)Match(input,LP,FOLLOW_LP_in_akind707); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{LP87_tree = (CommonTree)adaptor.Create(LP87);
                    		adaptor.AddChild(root_0, LP87_tree);
                    	}
                    	PushFollow(FOLLOW_kind_in_akind709);
                    	kind88 = kind();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, kind88.Tree);
                    	RP89=(IToken)Match(input,RP,FOLLOW_RP_in_akind711); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{RP89_tree = (CommonTree)adaptor.Create(RP89);
                    		adaptor.AddChild(root_0, RP89_tree);
                    	}

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "akind"

    public class kind_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "kind"
    // Core.g:105:1: kind : ( akind | akind ARROW kind );
    public CoreParser.kind_return kind() // throws RecognitionException [1]
    {   
        CoreParser.kind_return retval = new CoreParser.kind_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken ARROW92 = null;
        CoreParser.akind_return akind90 = default(CoreParser.akind_return);

        CoreParser.akind_return akind91 = default(CoreParser.akind_return);

        CoreParser.kind_return kind93 = default(CoreParser.kind_return);


        CommonTree ARROW92_tree=null;

        try 
    	{
            // Core.g:106:2: ( akind | akind ARROW kind )
            int alt19 = 2;
            alt19 = dfa19.Predict(input);
            switch (alt19) 
            {
                case 1 :
                    // Core.g:106:4: akind
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_akind_in_kind723);
                    	akind90 = akind();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, akind90.Tree);

                    }
                    break;
                case 2 :
                    // Core.g:107:4: akind ARROW kind
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_akind_in_kind728);
                    	akind91 = akind();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, akind91.Tree);
                    	ARROW92=(IToken)Match(input,ARROW,FOLLOW_ARROW_in_kind730); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{ARROW92_tree = (CommonTree)adaptor.Create(ARROW92);
                    		adaptor.AddChild(root_0, ARROW92_tree);
                    	}
                    	PushFollow(FOLLOW_kind_in_kind732);
                    	kind93 = kind();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, kind93.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "kind"

    public class arg_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "arg"
    // Core.g:110:1: arg : ( AT aty -> ^( TK_TYPE_ARG aty ) | aexp -> ^( TK_VALUE_ARG aexp ) );
    public CoreParser.arg_return arg() // throws RecognitionException [1]
    {   
        CoreParser.arg_return retval = new CoreParser.arg_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken AT94 = null;
        CoreParser.aty_return aty95 = default(CoreParser.aty_return);

        CoreParser.aexp_return aexp96 = default(CoreParser.aexp_return);


        CommonTree AT94_tree=null;
        RewriteRuleTokenStream stream_AT = new RewriteRuleTokenStream(adaptor,"token AT");
        RewriteRuleSubtreeStream stream_aexp = new RewriteRuleSubtreeStream(adaptor,"rule aexp");
        RewriteRuleSubtreeStream stream_aty = new RewriteRuleSubtreeStream(adaptor,"rule aty");
        try 
    	{
            // Core.g:111:2: ( AT aty -> ^( TK_TYPE_ARG aty ) | aexp -> ^( TK_VALUE_ARG aexp ) )
            int alt20 = 2;
            int LA20_0 = input.LA(1);

            if ( (LA20_0 == AT) )
            {
                alt20 = 1;
            }
            else if ( (LA20_0 == LP || (LA20_0 >= UNAME && LA20_0 <= LNAME)) )
            {
                alt20 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d20s0 =
                    new NoViableAltException("", 20, 0, input);

                throw nvae_d20s0;
            }
            switch (alt20) 
            {
                case 1 :
                    // Core.g:111:4: AT aty
                    {
                    	AT94=(IToken)Match(input,AT,FOLLOW_AT_in_arg743); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_AT.Add(AT94);

                    	PushFollow(FOLLOW_aty_in_arg745);
                    	aty95 = aty();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_aty.Add(aty95.Tree);


                    	// AST REWRITE
                    	// elements:          aty
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 111:11: -> ^( TK_TYPE_ARG aty )
                    	{
                    	    // Core.g:111:14: ^( TK_TYPE_ARG aty )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TK_TYPE_ARG, "TK_TYPE_ARG"), root_1);

                    	    adaptor.AddChild(root_1, stream_aty.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 2 :
                    // Core.g:112:4: aexp
                    {
                    	PushFollow(FOLLOW_aexp_in_arg759);
                    	aexp96 = aexp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_aexp.Add(aexp96.Tree);


                    	// AST REWRITE
                    	// elements:          aexp
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 112:9: -> ^( TK_VALUE_ARG aexp )
                    	{
                    	    // Core.g:112:12: ^( TK_VALUE_ARG aexp )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TK_VALUE_ARG, "TK_VALUE_ARG"), root_1);

                    	    adaptor.AddChild(root_1, stream_aexp.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "arg"

    public class alt_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "alt"
    // Core.g:115:1: alt : ( qdcon ( AT tbind )* ( vbind )* ARROW exp -> ^( TK_CONSTRUCTOR_ALTERNATIVE qdcon exp ( tbind )* ( vbind )* ) | literal ARROW exp -> ^( TK_LITERAL_ALTERNATIVE literal exp ) | PERCENT_ARROW exp -> ^( TK_DEFAULT_ALTERNATIVE exp ) );
    public CoreParser.alt_return alt() // throws RecognitionException [1]
    {   
        CoreParser.alt_return retval = new CoreParser.alt_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken AT98 = null;
        IToken ARROW101 = null;
        IToken ARROW104 = null;
        IToken PERCENT_ARROW106 = null;
        CoreParser.qdcon_return qdcon97 = default(CoreParser.qdcon_return);

        CoreParser.tbind_return tbind99 = default(CoreParser.tbind_return);

        CoreParser.vbind_return vbind100 = default(CoreParser.vbind_return);

        CoreParser.exp_return exp102 = default(CoreParser.exp_return);

        CoreParser.literal_return literal103 = default(CoreParser.literal_return);

        CoreParser.exp_return exp105 = default(CoreParser.exp_return);

        CoreParser.exp_return exp107 = default(CoreParser.exp_return);


        CommonTree AT98_tree=null;
        CommonTree ARROW101_tree=null;
        CommonTree ARROW104_tree=null;
        CommonTree PERCENT_ARROW106_tree=null;
        RewriteRuleTokenStream stream_PERCENT_ARROW = new RewriteRuleTokenStream(adaptor,"token PERCENT_ARROW");
        RewriteRuleTokenStream stream_AT = new RewriteRuleTokenStream(adaptor,"token AT");
        RewriteRuleTokenStream stream_ARROW = new RewriteRuleTokenStream(adaptor,"token ARROW");
        RewriteRuleSubtreeStream stream_vbind = new RewriteRuleSubtreeStream(adaptor,"rule vbind");
        RewriteRuleSubtreeStream stream_exp = new RewriteRuleSubtreeStream(adaptor,"rule exp");
        RewriteRuleSubtreeStream stream_qdcon = new RewriteRuleSubtreeStream(adaptor,"rule qdcon");
        RewriteRuleSubtreeStream stream_tbind = new RewriteRuleSubtreeStream(adaptor,"rule tbind");
        RewriteRuleSubtreeStream stream_literal = new RewriteRuleSubtreeStream(adaptor,"rule literal");
        try 
    	{
            // Core.g:116:2: ( qdcon ( AT tbind )* ( vbind )* ARROW exp -> ^( TK_CONSTRUCTOR_ALTERNATIVE qdcon exp ( tbind )* ( vbind )* ) | literal ARROW exp -> ^( TK_LITERAL_ALTERNATIVE literal exp ) | PERCENT_ARROW exp -> ^( TK_DEFAULT_ALTERNATIVE exp ) )
            int alt23 = 3;
            switch ( input.LA(1) ) 
            {
            case UNAME:
            case LNAME:
            	{
                alt23 = 1;
                }
                break;
            case LP:
            	{
                alt23 = 2;
                }
                break;
            case PERCENT_ARROW:
            	{
                alt23 = 3;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d23s0 =
            	        new NoViableAltException("", 23, 0, input);

            	    throw nvae_d23s0;
            }

            switch (alt23) 
            {
                case 1 :
                    // Core.g:116:4: qdcon ( AT tbind )* ( vbind )* ARROW exp
                    {
                    	PushFollow(FOLLOW_qdcon_in_alt782);
                    	qdcon97 = qdcon();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_qdcon.Add(qdcon97.Tree);
                    	// Core.g:116:10: ( AT tbind )*
                    	do 
                    	{
                    	    int alt21 = 2;
                    	    int LA21_0 = input.LA(1);

                    	    if ( (LA21_0 == AT) )
                    	    {
                    	        alt21 = 1;
                    	    }


                    	    switch (alt21) 
                    		{
                    			case 1 :
                    			    // Core.g:116:12: AT tbind
                    			    {
                    			    	AT98=(IToken)Match(input,AT,FOLLOW_AT_in_alt786); if (state.failed) return retval; 
                    			    	if ( (state.backtracking==0) ) stream_AT.Add(AT98);

                    			    	PushFollow(FOLLOW_tbind_in_alt788);
                    			    	tbind99 = tbind();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( (state.backtracking==0) ) stream_tbind.Add(tbind99.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop21;
                    	    }
                    	} while (true);

                    	loop21:
                    		;	// Stops C# compiler whining that label 'loop21' has no statements

                    	// Core.g:116:24: ( vbind )*
                    	do 
                    	{
                    	    int alt22 = 2;
                    	    int LA22_0 = input.LA(1);

                    	    if ( (LA22_0 == LP) )
                    	    {
                    	        alt22 = 1;
                    	    }


                    	    switch (alt22) 
                    		{
                    			case 1 :
                    			    // Core.g:116:26: vbind
                    			    {
                    			    	PushFollow(FOLLOW_vbind_in_alt795);
                    			    	vbind100 = vbind();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( (state.backtracking==0) ) stream_vbind.Add(vbind100.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop22;
                    	    }
                    	} while (true);

                    	loop22:
                    		;	// Stops C# compiler whining that label 'loop22' has no statements

                    	ARROW101=(IToken)Match(input,ARROW,FOLLOW_ARROW_in_alt800); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_ARROW.Add(ARROW101);

                    	PushFollow(FOLLOW_exp_in_alt802);
                    	exp102 = exp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_exp.Add(exp102.Tree);


                    	// AST REWRITE
                    	// elements:          exp, qdcon, vbind, tbind
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 116:45: -> ^( TK_CONSTRUCTOR_ALTERNATIVE qdcon exp ( tbind )* ( vbind )* )
                    	{
                    	    // Core.g:116:49: ^( TK_CONSTRUCTOR_ALTERNATIVE qdcon exp ( tbind )* ( vbind )* )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TK_CONSTRUCTOR_ALTERNATIVE, "TK_CONSTRUCTOR_ALTERNATIVE"), root_1);

                    	    adaptor.AddChild(root_1, stream_qdcon.NextTree());
                    	    adaptor.AddChild(root_1, stream_exp.NextTree());
                    	    // Core.g:116:88: ( tbind )*
                    	    while ( stream_tbind.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_tbind.NextTree());

                    	    }
                    	    stream_tbind.Reset();
                    	    // Core.g:116:95: ( vbind )*
                    	    while ( stream_vbind.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_vbind.NextTree());

                    	    }
                    	    stream_vbind.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 2 :
                    // Core.g:117:4: literal ARROW exp
                    {
                    	PushFollow(FOLLOW_literal_in_alt825);
                    	literal103 = literal();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_literal.Add(literal103.Tree);
                    	ARROW104=(IToken)Match(input,ARROW,FOLLOW_ARROW_in_alt827); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_ARROW.Add(ARROW104);

                    	PushFollow(FOLLOW_exp_in_alt829);
                    	exp105 = exp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_exp.Add(exp105.Tree);


                    	// AST REWRITE
                    	// elements:          literal, exp
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 117:22: -> ^( TK_LITERAL_ALTERNATIVE literal exp )
                    	{
                    	    // Core.g:117:25: ^( TK_LITERAL_ALTERNATIVE literal exp )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TK_LITERAL_ALTERNATIVE, "TK_LITERAL_ALTERNATIVE"), root_1);

                    	    adaptor.AddChild(root_1, stream_literal.NextTree());
                    	    adaptor.AddChild(root_1, stream_exp.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 3 :
                    // Core.g:118:4: PERCENT_ARROW exp
                    {
                    	PERCENT_ARROW106=(IToken)Match(input,PERCENT_ARROW,FOLLOW_PERCENT_ARROW_in_alt844); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_PERCENT_ARROW.Add(PERCENT_ARROW106);

                    	PushFollow(FOLLOW_exp_in_alt846);
                    	exp107 = exp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_exp.Add(exp107.Tree);


                    	// AST REWRITE
                    	// elements:          exp
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 118:22: -> ^( TK_DEFAULT_ALTERNATIVE exp )
                    	{
                    	    // Core.g:118:25: ^( TK_DEFAULT_ALTERNATIVE exp )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TK_DEFAULT_ALTERNATIVE, "TK_DEFAULT_ALTERNATIVE"), root_1);

                    	    adaptor.AddChild(root_1, stream_exp.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "alt"

    public class binder_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "binder"
    // Core.g:121:1: binder : ( AT tbind -> tbind | vbind -> vbind );
    public CoreParser.binder_return binder() // throws RecognitionException [1]
    {   
        CoreParser.binder_return retval = new CoreParser.binder_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken AT108 = null;
        CoreParser.tbind_return tbind109 = default(CoreParser.tbind_return);

        CoreParser.vbind_return vbind110 = default(CoreParser.vbind_return);


        CommonTree AT108_tree=null;
        RewriteRuleTokenStream stream_AT = new RewriteRuleTokenStream(adaptor,"token AT");
        RewriteRuleSubtreeStream stream_vbind = new RewriteRuleSubtreeStream(adaptor,"rule vbind");
        RewriteRuleSubtreeStream stream_tbind = new RewriteRuleSubtreeStream(adaptor,"rule tbind");
        try 
    	{
            // Core.g:122:2: ( AT tbind -> tbind | vbind -> vbind )
            int alt24 = 2;
            int LA24_0 = input.LA(1);

            if ( (LA24_0 == AT) )
            {
                alt24 = 1;
            }
            else if ( (LA24_0 == LP) )
            {
                alt24 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d24s0 =
                    new NoViableAltException("", 24, 0, input);

                throw nvae_d24s0;
            }
            switch (alt24) 
            {
                case 1 :
                    // Core.g:122:4: AT tbind
                    {
                    	AT108=(IToken)Match(input,AT,FOLLOW_AT_in_binder866); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_AT.Add(AT108);

                    	PushFollow(FOLLOW_tbind_in_binder868);
                    	tbind109 = tbind();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_tbind.Add(tbind109.Tree);


                    	// AST REWRITE
                    	// elements:          tbind
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 122:13: -> tbind
                    	{
                    	    adaptor.AddChild(root_0, stream_tbind.NextTree());

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 2 :
                    // Core.g:123:4: vbind
                    {
                    	PushFollow(FOLLOW_vbind_in_binder877);
                    	vbind110 = vbind();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_vbind.Add(vbind110.Tree);


                    	// AST REWRITE
                    	// elements:          vbind
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 123:10: -> vbind
                    	{
                    	    adaptor.AddChild(root_0, stream_vbind.NextTree());

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "binder"

    public class tbind_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "tbind"
    // Core.g:126:1: tbind : ( tyvar -> ^( TK_TYPE_BINDER tyvar ) | LP tyvar DCOLON kind RP -> ^( TK_TYPE_BINDER tyvar kind ) );
    public CoreParser.tbind_return tbind() // throws RecognitionException [1]
    {   
        CoreParser.tbind_return retval = new CoreParser.tbind_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken LP112 = null;
        IToken DCOLON114 = null;
        IToken RP116 = null;
        CoreParser.tyvar_return tyvar111 = default(CoreParser.tyvar_return);

        CoreParser.tyvar_return tyvar113 = default(CoreParser.tyvar_return);

        CoreParser.kind_return kind115 = default(CoreParser.kind_return);


        CommonTree LP112_tree=null;
        CommonTree DCOLON114_tree=null;
        CommonTree RP116_tree=null;
        RewriteRuleTokenStream stream_DCOLON = new RewriteRuleTokenStream(adaptor,"token DCOLON");
        RewriteRuleTokenStream stream_RP = new RewriteRuleTokenStream(adaptor,"token RP");
        RewriteRuleTokenStream stream_LP = new RewriteRuleTokenStream(adaptor,"token LP");
        RewriteRuleSubtreeStream stream_tyvar = new RewriteRuleSubtreeStream(adaptor,"rule tyvar");
        RewriteRuleSubtreeStream stream_kind = new RewriteRuleSubtreeStream(adaptor,"rule kind");
        try 
    	{
            // Core.g:127:2: ( tyvar -> ^( TK_TYPE_BINDER tyvar ) | LP tyvar DCOLON kind RP -> ^( TK_TYPE_BINDER tyvar kind ) )
            int alt25 = 2;
            int LA25_0 = input.LA(1);

            if ( (LA25_0 == LNAME) )
            {
                alt25 = 1;
            }
            else if ( (LA25_0 == LP) )
            {
                alt25 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d25s0 =
                    new NoViableAltException("", 25, 0, input);

                throw nvae_d25s0;
            }
            switch (alt25) 
            {
                case 1 :
                    // Core.g:127:4: tyvar
                    {
                    	PushFollow(FOLLOW_tyvar_in_tbind892);
                    	tyvar111 = tyvar();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_tyvar.Add(tyvar111.Tree);


                    	// AST REWRITE
                    	// elements:          tyvar
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 127:10: -> ^( TK_TYPE_BINDER tyvar )
                    	{
                    	    // Core.g:127:13: ^( TK_TYPE_BINDER tyvar )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TK_TYPE_BINDER, "TK_TYPE_BINDER"), root_1);

                    	    adaptor.AddChild(root_1, stream_tyvar.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 2 :
                    // Core.g:128:4: LP tyvar DCOLON kind RP
                    {
                    	LP112=(IToken)Match(input,LP,FOLLOW_LP_in_tbind905); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_LP.Add(LP112);

                    	PushFollow(FOLLOW_tyvar_in_tbind907);
                    	tyvar113 = tyvar();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_tyvar.Add(tyvar113.Tree);
                    	DCOLON114=(IToken)Match(input,DCOLON,FOLLOW_DCOLON_in_tbind909); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_DCOLON.Add(DCOLON114);

                    	PushFollow(FOLLOW_kind_in_tbind911);
                    	kind115 = kind();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_kind.Add(kind115.Tree);
                    	RP116=(IToken)Match(input,RP,FOLLOW_RP_in_tbind913); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_RP.Add(RP116);



                    	// AST REWRITE
                    	// elements:          tyvar, kind
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 128:28: -> ^( TK_TYPE_BINDER tyvar kind )
                    	{
                    	    // Core.g:128:31: ^( TK_TYPE_BINDER tyvar kind )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TK_TYPE_BINDER, "TK_TYPE_BINDER"), root_1);

                    	    adaptor.AddChild(root_1, stream_tyvar.NextTree());
                    	    adaptor.AddChild(root_1, stream_kind.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "tbind"

    public class vbind_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "vbind"
    // Core.g:131:1: vbind : LP var DCOLON ty RP -> ^( TK_VALUE_BINDER var ty ) ;
    public CoreParser.vbind_return vbind() // throws RecognitionException [1]
    {   
        CoreParser.vbind_return retval = new CoreParser.vbind_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken LP117 = null;
        IToken DCOLON119 = null;
        IToken RP121 = null;
        CoreParser.var_return var118 = default(CoreParser.var_return);

        CoreParser.ty_return ty120 = default(CoreParser.ty_return);


        CommonTree LP117_tree=null;
        CommonTree DCOLON119_tree=null;
        CommonTree RP121_tree=null;
        RewriteRuleTokenStream stream_DCOLON = new RewriteRuleTokenStream(adaptor,"token DCOLON");
        RewriteRuleTokenStream stream_RP = new RewriteRuleTokenStream(adaptor,"token RP");
        RewriteRuleTokenStream stream_LP = new RewriteRuleTokenStream(adaptor,"token LP");
        RewriteRuleSubtreeStream stream_ty = new RewriteRuleSubtreeStream(adaptor,"rule ty");
        RewriteRuleSubtreeStream stream_var = new RewriteRuleSubtreeStream(adaptor,"rule var");
        try 
    	{
            // Core.g:131:8: ( LP var DCOLON ty RP -> ^( TK_VALUE_BINDER var ty ) )
            // Core.g:131:10: LP var DCOLON ty RP
            {
            	LP117=(IToken)Match(input,LP,FOLLOW_LP_in_vbind933); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_LP.Add(LP117);

            	PushFollow(FOLLOW_var_in_vbind935);
            	var118 = var();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_var.Add(var118.Tree);
            	DCOLON119=(IToken)Match(input,DCOLON,FOLLOW_DCOLON_in_vbind937); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_DCOLON.Add(DCOLON119);

            	PushFollow(FOLLOW_ty_in_vbind939);
            	ty120 = ty();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_ty.Add(ty120.Tree);
            	RP121=(IToken)Match(input,RP,FOLLOW_RP_in_vbind941); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_RP.Add(RP121);



            	// AST REWRITE
            	// elements:          ty, var
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 131:30: -> ^( TK_VALUE_BINDER var ty )
            	{
            	    // Core.g:131:33: ^( TK_VALUE_BINDER var ty )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TK_VALUE_BINDER, "TK_VALUE_BINDER"), root_1);

            	    adaptor.AddChild(root_1, stream_var.NextTree());
            	    adaptor.AddChild(root_1, stream_ty.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "vbind"

    public class literal_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "literal"
    // Core.g:134:1: literal : ( LP INTLITERAL DCOLON ty RP -> ^( TK_LIT_INTEGER ty INTLITERAL ) | LP INTLITERAL PERCENT INTLITERAL DCOLON ty RP -> ^( TK_LIT_RATIONAL ty INTLITERAL INTLITERAL ) | LP CHARLITERAL DCOLON ty RP -> ^( TK_LIT_CHAR ty CHARLITERAL ) | LP STRINGLITERAL DCOLON ty RP -> ^( TK_LIT_STRING ty STRINGLITERAL ) );
    public CoreParser.literal_return literal() // throws RecognitionException [1]
    {   
        CoreParser.literal_return retval = new CoreParser.literal_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken LP122 = null;
        IToken INTLITERAL123 = null;
        IToken DCOLON124 = null;
        IToken RP126 = null;
        IToken LP127 = null;
        IToken INTLITERAL128 = null;
        IToken PERCENT129 = null;
        IToken INTLITERAL130 = null;
        IToken DCOLON131 = null;
        IToken RP133 = null;
        IToken LP134 = null;
        IToken CHARLITERAL135 = null;
        IToken DCOLON136 = null;
        IToken RP138 = null;
        IToken LP139 = null;
        IToken STRINGLITERAL140 = null;
        IToken DCOLON141 = null;
        IToken RP143 = null;
        CoreParser.ty_return ty125 = default(CoreParser.ty_return);

        CoreParser.ty_return ty132 = default(CoreParser.ty_return);

        CoreParser.ty_return ty137 = default(CoreParser.ty_return);

        CoreParser.ty_return ty142 = default(CoreParser.ty_return);


        CommonTree LP122_tree=null;
        CommonTree INTLITERAL123_tree=null;
        CommonTree DCOLON124_tree=null;
        CommonTree RP126_tree=null;
        CommonTree LP127_tree=null;
        CommonTree INTLITERAL128_tree=null;
        CommonTree PERCENT129_tree=null;
        CommonTree INTLITERAL130_tree=null;
        CommonTree DCOLON131_tree=null;
        CommonTree RP133_tree=null;
        CommonTree LP134_tree=null;
        CommonTree CHARLITERAL135_tree=null;
        CommonTree DCOLON136_tree=null;
        CommonTree RP138_tree=null;
        CommonTree LP139_tree=null;
        CommonTree STRINGLITERAL140_tree=null;
        CommonTree DCOLON141_tree=null;
        CommonTree RP143_tree=null;
        RewriteRuleTokenStream stream_DCOLON = new RewriteRuleTokenStream(adaptor,"token DCOLON");
        RewriteRuleTokenStream stream_PERCENT = new RewriteRuleTokenStream(adaptor,"token PERCENT");
        RewriteRuleTokenStream stream_INTLITERAL = new RewriteRuleTokenStream(adaptor,"token INTLITERAL");
        RewriteRuleTokenStream stream_RP = new RewriteRuleTokenStream(adaptor,"token RP");
        RewriteRuleTokenStream stream_STRINGLITERAL = new RewriteRuleTokenStream(adaptor,"token STRINGLITERAL");
        RewriteRuleTokenStream stream_CHARLITERAL = new RewriteRuleTokenStream(adaptor,"token CHARLITERAL");
        RewriteRuleTokenStream stream_LP = new RewriteRuleTokenStream(adaptor,"token LP");
        RewriteRuleSubtreeStream stream_ty = new RewriteRuleSubtreeStream(adaptor,"rule ty");
        try 
    	{
            // Core.g:135:5: ( LP INTLITERAL DCOLON ty RP -> ^( TK_LIT_INTEGER ty INTLITERAL ) | LP INTLITERAL PERCENT INTLITERAL DCOLON ty RP -> ^( TK_LIT_RATIONAL ty INTLITERAL INTLITERAL ) | LP CHARLITERAL DCOLON ty RP -> ^( TK_LIT_CHAR ty CHARLITERAL ) | LP STRINGLITERAL DCOLON ty RP -> ^( TK_LIT_STRING ty STRINGLITERAL ) )
            int alt26 = 4;
            int LA26_0 = input.LA(1);

            if ( (LA26_0 == LP) )
            {
                switch ( input.LA(2) ) 
                {
                case INTLITERAL:
                	{
                    int LA26_2 = input.LA(3);

                    if ( (LA26_2 == DCOLON) )
                    {
                        alt26 = 1;
                    }
                    else if ( (LA26_2 == PERCENT) )
                    {
                        alt26 = 2;
                    }
                    else 
                    {
                        if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                        NoViableAltException nvae_d26s2 =
                            new NoViableAltException("", 26, 2, input);

                        throw nvae_d26s2;
                    }
                    }
                    break;
                case CHARLITERAL:
                	{
                    alt26 = 3;
                    }
                    break;
                case STRINGLITERAL:
                	{
                    alt26 = 4;
                    }
                    break;
                	default:
                	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                	    NoViableAltException nvae_d26s1 =
                	        new NoViableAltException("", 26, 1, input);

                	    throw nvae_d26s1;
                }

            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d26s0 =
                    new NoViableAltException("", 26, 0, input);

                throw nvae_d26s0;
            }
            switch (alt26) 
            {
                case 1 :
                    // Core.g:135:9: LP INTLITERAL DCOLON ty RP
                    {
                    	LP122=(IToken)Match(input,LP,FOLLOW_LP_in_literal967); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_LP.Add(LP122);

                    	INTLITERAL123=(IToken)Match(input,INTLITERAL,FOLLOW_INTLITERAL_in_literal969); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_INTLITERAL.Add(INTLITERAL123);

                    	DCOLON124=(IToken)Match(input,DCOLON,FOLLOW_DCOLON_in_literal971); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_DCOLON.Add(DCOLON124);

                    	PushFollow(FOLLOW_ty_in_literal973);
                    	ty125 = ty();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_ty.Add(ty125.Tree);
                    	RP126=(IToken)Match(input,RP,FOLLOW_RP_in_literal975); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_RP.Add(RP126);



                    	// AST REWRITE
                    	// elements:          INTLITERAL, ty
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 135:36: -> ^( TK_LIT_INTEGER ty INTLITERAL )
                    	{
                    	    // Core.g:135:39: ^( TK_LIT_INTEGER ty INTLITERAL )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TK_LIT_INTEGER, "TK_LIT_INTEGER"), root_1);

                    	    adaptor.AddChild(root_1, stream_ty.NextTree());
                    	    adaptor.AddChild(root_1, stream_INTLITERAL.NextNode());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 2 :
                    // Core.g:136:9: LP INTLITERAL PERCENT INTLITERAL DCOLON ty RP
                    {
                    	LP127=(IToken)Match(input,LP,FOLLOW_LP_in_literal995); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_LP.Add(LP127);

                    	INTLITERAL128=(IToken)Match(input,INTLITERAL,FOLLOW_INTLITERAL_in_literal997); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_INTLITERAL.Add(INTLITERAL128);

                    	PERCENT129=(IToken)Match(input,PERCENT,FOLLOW_PERCENT_in_literal999); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_PERCENT.Add(PERCENT129);

                    	INTLITERAL130=(IToken)Match(input,INTLITERAL,FOLLOW_INTLITERAL_in_literal1001); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_INTLITERAL.Add(INTLITERAL130);

                    	DCOLON131=(IToken)Match(input,DCOLON,FOLLOW_DCOLON_in_literal1003); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_DCOLON.Add(DCOLON131);

                    	PushFollow(FOLLOW_ty_in_literal1005);
                    	ty132 = ty();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_ty.Add(ty132.Tree);
                    	RP133=(IToken)Match(input,RP,FOLLOW_RP_in_literal1007); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_RP.Add(RP133);



                    	// AST REWRITE
                    	// elements:          ty, INTLITERAL, INTLITERAL
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 136:55: -> ^( TK_LIT_RATIONAL ty INTLITERAL INTLITERAL )
                    	{
                    	    // Core.g:136:58: ^( TK_LIT_RATIONAL ty INTLITERAL INTLITERAL )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TK_LIT_RATIONAL, "TK_LIT_RATIONAL"), root_1);

                    	    adaptor.AddChild(root_1, stream_ty.NextTree());
                    	    adaptor.AddChild(root_1, stream_INTLITERAL.NextNode());
                    	    adaptor.AddChild(root_1, stream_INTLITERAL.NextNode());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 3 :
                    // Core.g:137:9: LP CHARLITERAL DCOLON ty RP
                    {
                    	LP134=(IToken)Match(input,LP,FOLLOW_LP_in_literal1029); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_LP.Add(LP134);

                    	CHARLITERAL135=(IToken)Match(input,CHARLITERAL,FOLLOW_CHARLITERAL_in_literal1031); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_CHARLITERAL.Add(CHARLITERAL135);

                    	DCOLON136=(IToken)Match(input,DCOLON,FOLLOW_DCOLON_in_literal1033); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_DCOLON.Add(DCOLON136);

                    	PushFollow(FOLLOW_ty_in_literal1035);
                    	ty137 = ty();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_ty.Add(ty137.Tree);
                    	RP138=(IToken)Match(input,RP,FOLLOW_RP_in_literal1037); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_RP.Add(RP138);



                    	// AST REWRITE
                    	// elements:          ty, CHARLITERAL
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 137:37: -> ^( TK_LIT_CHAR ty CHARLITERAL )
                    	{
                    	    // Core.g:137:40: ^( TK_LIT_CHAR ty CHARLITERAL )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TK_LIT_CHAR, "TK_LIT_CHAR"), root_1);

                    	    adaptor.AddChild(root_1, stream_ty.NextTree());
                    	    adaptor.AddChild(root_1, stream_CHARLITERAL.NextNode());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 4 :
                    // Core.g:138:9: LP STRINGLITERAL DCOLON ty RP
                    {
                    	LP139=(IToken)Match(input,LP,FOLLOW_LP_in_literal1057); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_LP.Add(LP139);

                    	STRINGLITERAL140=(IToken)Match(input,STRINGLITERAL,FOLLOW_STRINGLITERAL_in_literal1059); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_STRINGLITERAL.Add(STRINGLITERAL140);

                    	DCOLON141=(IToken)Match(input,DCOLON,FOLLOW_DCOLON_in_literal1061); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_DCOLON.Add(DCOLON141);

                    	PushFollow(FOLLOW_ty_in_literal1063);
                    	ty142 = ty();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_ty.Add(ty142.Tree);
                    	RP143=(IToken)Match(input,RP,FOLLOW_RP_in_literal1065); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_RP.Add(RP143);



                    	// AST REWRITE
                    	// elements:          STRINGLITERAL, ty
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 138:39: -> ^( TK_LIT_STRING ty STRINGLITERAL )
                    	{
                    	    // Core.g:138:42: ^( TK_LIT_STRING ty STRINGLITERAL )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TK_LIT_STRING, "TK_LIT_STRING"), root_1);

                    	    adaptor.AddChild(root_1, stream_ty.NextTree());
                    	    adaptor.AddChild(root_1, stream_STRINGLITERAL.NextNode());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "literal"

    public class aty_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "aty"
    // Core.g:142:1: aty : ( qtycon -> ^( TK_ATOMIC_TYPE qtycon ) | tyvar -> ^( TK_ATOMIC_TYPE tyvar ) | LP ty RP -> ^( TK_NESTED_TYPE ty ) );
    public CoreParser.aty_return aty() // throws RecognitionException [1]
    {   
        CoreParser.aty_return retval = new CoreParser.aty_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken LP146 = null;
        IToken RP148 = null;
        CoreParser.qtycon_return qtycon144 = default(CoreParser.qtycon_return);

        CoreParser.tyvar_return tyvar145 = default(CoreParser.tyvar_return);

        CoreParser.ty_return ty147 = default(CoreParser.ty_return);


        CommonTree LP146_tree=null;
        CommonTree RP148_tree=null;
        RewriteRuleTokenStream stream_RP = new RewriteRuleTokenStream(adaptor,"token RP");
        RewriteRuleTokenStream stream_LP = new RewriteRuleTokenStream(adaptor,"token LP");
        RewriteRuleSubtreeStream stream_ty = new RewriteRuleSubtreeStream(adaptor,"rule ty");
        RewriteRuleSubtreeStream stream_qtycon = new RewriteRuleSubtreeStream(adaptor,"rule qtycon");
        RewriteRuleSubtreeStream stream_tyvar = new RewriteRuleSubtreeStream(adaptor,"rule tyvar");
        try 
    	{
            // Core.g:143:2: ( qtycon -> ^( TK_ATOMIC_TYPE qtycon ) | tyvar -> ^( TK_ATOMIC_TYPE tyvar ) | LP ty RP -> ^( TK_NESTED_TYPE ty ) )
            int alt27 = 3;
            switch ( input.LA(1) ) 
            {
            case LNAME:
            	{
                int LA27_1 = input.LA(2);

                if ( (LA27_1 == COLON) )
                {
                    alt27 = 1;
                }
                else if ( (LA27_1 == EOF || LA27_1 == SEMICOLON || (LA27_1 >= EQ && LA27_1 <= RB) || (LA27_1 >= AT && LA27_1 <= NOTE) || (LA27_1 >= ECALL && LA27_1 <= LABEL) || LA27_1 == DCOLONEQ || (LA27_1 >= UNAME && LA27_1 <= LNAME)) )
                {
                    alt27 = 2;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d27s1 =
                        new NoViableAltException("", 27, 1, input);

                    throw nvae_d27s1;
                }
                }
                break;
            case UNAME:
            	{
                alt27 = 1;
                }
                break;
            case LP:
            	{
                alt27 = 3;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d27s0 =
            	        new NoViableAltException("", 27, 0, input);

            	    throw nvae_d27s0;
            }

            switch (alt27) 
            {
                case 1 :
                    // Core.g:143:4: qtycon
                    {
                    	PushFollow(FOLLOW_qtycon_in_aty1092);
                    	qtycon144 = qtycon();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_qtycon.Add(qtycon144.Tree);


                    	// AST REWRITE
                    	// elements:          qtycon
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 143:11: -> ^( TK_ATOMIC_TYPE qtycon )
                    	{
                    	    // Core.g:143:14: ^( TK_ATOMIC_TYPE qtycon )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TK_ATOMIC_TYPE, "TK_ATOMIC_TYPE"), root_1);

                    	    adaptor.AddChild(root_1, stream_qtycon.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 2 :
                    // Core.g:144:4: tyvar
                    {
                    	PushFollow(FOLLOW_tyvar_in_aty1105);
                    	tyvar145 = tyvar();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_tyvar.Add(tyvar145.Tree);


                    	// AST REWRITE
                    	// elements:          tyvar
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 144:10: -> ^( TK_ATOMIC_TYPE tyvar )
                    	{
                    	    // Core.g:144:13: ^( TK_ATOMIC_TYPE tyvar )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TK_ATOMIC_TYPE, "TK_ATOMIC_TYPE"), root_1);

                    	    adaptor.AddChild(root_1, stream_tyvar.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 3 :
                    // Core.g:145:4: LP ty RP
                    {
                    	LP146=(IToken)Match(input,LP,FOLLOW_LP_in_aty1118); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_LP.Add(LP146);

                    	PushFollow(FOLLOW_ty_in_aty1120);
                    	ty147 = ty();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_ty.Add(ty147.Tree);
                    	RP148=(IToken)Match(input,RP,FOLLOW_RP_in_aty1122); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_RP.Add(RP148);



                    	// AST REWRITE
                    	// elements:          ty
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 145:13: -> ^( TK_NESTED_TYPE ty )
                    	{
                    	    // Core.g:145:16: ^( TK_NESTED_TYPE ty )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TK_NESTED_TYPE, "TK_NESTED_TYPE"), root_1);

                    	    adaptor.AddChild(root_1, stream_ty.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "aty"

    public class bty_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "bty"
    // Core.g:148:1: bty : ( aty ( aty )+ -> ^( TK_TYPE_APPLICATION ( aty )* ) | aty | TRANS aty aty aty -> ^( TK_TYPE_APPLICATION ^( TK_TRANSITIVE_COERCION aty aty ) aty ) | TRANS aty aty -> ^( TK_TRANSITIVE_COERCION aty aty ) | SYM aty aty -> ^( TK_TYPE_APPLICATION ^( TK_SYMMETRIC_COERCION aty ) aty ) | SYM aty -> ^( TK_SYMMETRIC_COERCION aty ) | UNSAFE aty aty aty -> ^( TK_TYPE_APPLICATION ^( TK_UNSAFE_COERCION aty aty ) aty ) | UNSAFE aty aty -> ^( TK_UNSAFE_COERCION aty aty ) | LEFT aty aty -> ^( TK_TYPE_APPLICATION ^( TK_LEFT_COERCION aty ) aty ) | LEFT aty -> ^( TK_LEFT_COERCION aty ) | RIGHT aty aty -> ^( TK_TYPE_APPLICATION ^( TK_RIGHT_COERCION aty ) aty ) | RIGHT aty -> ^( TK_RIGHT_COERCION aty ) | INST aty aty aty -> ^( TK_TYPE_APPLICATION ^( TK_INSTANTIATION_COERCION aty aty ) aty ) | INST aty aty -> ^( TK_INSTANTIATION_COERCION aty aty ) );
    public CoreParser.bty_return bty() // throws RecognitionException [1]
    {   
        CoreParser.bty_return retval = new CoreParser.bty_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken TRANS152 = null;
        IToken TRANS156 = null;
        IToken SYM159 = null;
        IToken SYM162 = null;
        IToken UNSAFE164 = null;
        IToken UNSAFE168 = null;
        IToken LEFT171 = null;
        IToken LEFT174 = null;
        IToken RIGHT176 = null;
        IToken RIGHT179 = null;
        IToken INST181 = null;
        IToken INST185 = null;
        CoreParser.aty_return aty149 = default(CoreParser.aty_return);

        CoreParser.aty_return aty150 = default(CoreParser.aty_return);

        CoreParser.aty_return aty151 = default(CoreParser.aty_return);

        CoreParser.aty_return aty153 = default(CoreParser.aty_return);

        CoreParser.aty_return aty154 = default(CoreParser.aty_return);

        CoreParser.aty_return aty155 = default(CoreParser.aty_return);

        CoreParser.aty_return aty157 = default(CoreParser.aty_return);

        CoreParser.aty_return aty158 = default(CoreParser.aty_return);

        CoreParser.aty_return aty160 = default(CoreParser.aty_return);

        CoreParser.aty_return aty161 = default(CoreParser.aty_return);

        CoreParser.aty_return aty163 = default(CoreParser.aty_return);

        CoreParser.aty_return aty165 = default(CoreParser.aty_return);

        CoreParser.aty_return aty166 = default(CoreParser.aty_return);

        CoreParser.aty_return aty167 = default(CoreParser.aty_return);

        CoreParser.aty_return aty169 = default(CoreParser.aty_return);

        CoreParser.aty_return aty170 = default(CoreParser.aty_return);

        CoreParser.aty_return aty172 = default(CoreParser.aty_return);

        CoreParser.aty_return aty173 = default(CoreParser.aty_return);

        CoreParser.aty_return aty175 = default(CoreParser.aty_return);

        CoreParser.aty_return aty177 = default(CoreParser.aty_return);

        CoreParser.aty_return aty178 = default(CoreParser.aty_return);

        CoreParser.aty_return aty180 = default(CoreParser.aty_return);

        CoreParser.aty_return aty182 = default(CoreParser.aty_return);

        CoreParser.aty_return aty183 = default(CoreParser.aty_return);

        CoreParser.aty_return aty184 = default(CoreParser.aty_return);

        CoreParser.aty_return aty186 = default(CoreParser.aty_return);

        CoreParser.aty_return aty187 = default(CoreParser.aty_return);


        CommonTree TRANS152_tree=null;
        CommonTree TRANS156_tree=null;
        CommonTree SYM159_tree=null;
        CommonTree SYM162_tree=null;
        CommonTree UNSAFE164_tree=null;
        CommonTree UNSAFE168_tree=null;
        CommonTree LEFT171_tree=null;
        CommonTree LEFT174_tree=null;
        CommonTree RIGHT176_tree=null;
        CommonTree RIGHT179_tree=null;
        CommonTree INST181_tree=null;
        CommonTree INST185_tree=null;
        RewriteRuleTokenStream stream_RIGHT = new RewriteRuleTokenStream(adaptor,"token RIGHT");
        RewriteRuleTokenStream stream_UNSAFE = new RewriteRuleTokenStream(adaptor,"token UNSAFE");
        RewriteRuleTokenStream stream_LEFT = new RewriteRuleTokenStream(adaptor,"token LEFT");
        RewriteRuleTokenStream stream_SYM = new RewriteRuleTokenStream(adaptor,"token SYM");
        RewriteRuleTokenStream stream_INST = new RewriteRuleTokenStream(adaptor,"token INST");
        RewriteRuleTokenStream stream_TRANS = new RewriteRuleTokenStream(adaptor,"token TRANS");
        RewriteRuleSubtreeStream stream_aty = new RewriteRuleSubtreeStream(adaptor,"rule aty");
        try 
    	{
            // Core.g:149:2: ( aty ( aty )+ -> ^( TK_TYPE_APPLICATION ( aty )* ) | aty | TRANS aty aty aty -> ^( TK_TYPE_APPLICATION ^( TK_TRANSITIVE_COERCION aty aty ) aty ) | TRANS aty aty -> ^( TK_TRANSITIVE_COERCION aty aty ) | SYM aty aty -> ^( TK_TYPE_APPLICATION ^( TK_SYMMETRIC_COERCION aty ) aty ) | SYM aty -> ^( TK_SYMMETRIC_COERCION aty ) | UNSAFE aty aty aty -> ^( TK_TYPE_APPLICATION ^( TK_UNSAFE_COERCION aty aty ) aty ) | UNSAFE aty aty -> ^( TK_UNSAFE_COERCION aty aty ) | LEFT aty aty -> ^( TK_TYPE_APPLICATION ^( TK_LEFT_COERCION aty ) aty ) | LEFT aty -> ^( TK_LEFT_COERCION aty ) | RIGHT aty aty -> ^( TK_TYPE_APPLICATION ^( TK_RIGHT_COERCION aty ) aty ) | RIGHT aty -> ^( TK_RIGHT_COERCION aty ) | INST aty aty aty -> ^( TK_TYPE_APPLICATION ^( TK_INSTANTIATION_COERCION aty aty ) aty ) | INST aty aty -> ^( TK_INSTANTIATION_COERCION aty aty ) )
            int alt29 = 14;
            alt29 = dfa29.Predict(input);
            switch (alt29) 
            {
                case 1 :
                    // Core.g:149:4: aty ( aty )+
                    {
                    	PushFollow(FOLLOW_aty_in_bty1142);
                    	aty149 = aty();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_aty.Add(aty149.Tree);
                    	// Core.g:149:8: ( aty )+
                    	int cnt28 = 0;
                    	do 
                    	{
                    	    int alt28 = 2;
                    	    int LA28_0 = input.LA(1);

                    	    if ( (LA28_0 == LP || (LA28_0 >= UNAME && LA28_0 <= LNAME)) )
                    	    {
                    	        alt28 = 1;
                    	    }


                    	    switch (alt28) 
                    		{
                    			case 1 :
                    			    // Core.g:0:0: aty
                    			    {
                    			    	PushFollow(FOLLOW_aty_in_bty1144);
                    			    	aty150 = aty();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( (state.backtracking==0) ) stream_aty.Add(aty150.Tree);

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt28 >= 1 ) goto loop28;
                    			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    		            EarlyExitException eee28 =
                    		                new EarlyExitException(28, input);
                    		            throw eee28;
                    	    }
                    	    cnt28++;
                    	} while (true);

                    	loop28:
                    		;	// Stops C# compiler whining that label 'loop28' has no statements



                    	// AST REWRITE
                    	// elements:          aty
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 149:13: -> ^( TK_TYPE_APPLICATION ( aty )* )
                    	{
                    	    // Core.g:149:16: ^( TK_TYPE_APPLICATION ( aty )* )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TK_TYPE_APPLICATION, "TK_TYPE_APPLICATION"), root_1);

                    	    // Core.g:149:38: ( aty )*
                    	    while ( stream_aty.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_aty.NextTree());

                    	    }
                    	    stream_aty.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 2 :
                    // Core.g:150:4: aty
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_aty_in_bty1159);
                    	aty151 = aty();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, aty151.Tree);

                    }
                    break;
                case 3 :
                    // Core.g:151:4: TRANS aty aty aty
                    {
                    	TRANS152=(IToken)Match(input,TRANS,FOLLOW_TRANS_in_bty1165); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_TRANS.Add(TRANS152);

                    	PushFollow(FOLLOW_aty_in_bty1167);
                    	aty153 = aty();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_aty.Add(aty153.Tree);
                    	PushFollow(FOLLOW_aty_in_bty1169);
                    	aty154 = aty();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_aty.Add(aty154.Tree);
                    	PushFollow(FOLLOW_aty_in_bty1171);
                    	aty155 = aty();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_aty.Add(aty155.Tree);


                    	// AST REWRITE
                    	// elements:          aty, aty, aty
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 151:22: -> ^( TK_TYPE_APPLICATION ^( TK_TRANSITIVE_COERCION aty aty ) aty )
                    	{
                    	    // Core.g:151:25: ^( TK_TYPE_APPLICATION ^( TK_TRANSITIVE_COERCION aty aty ) aty )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TK_TYPE_APPLICATION, "TK_TYPE_APPLICATION"), root_1);

                    	    // Core.g:151:47: ^( TK_TRANSITIVE_COERCION aty aty )
                    	    {
                    	    CommonTree root_2 = (CommonTree)adaptor.GetNilNode();
                    	    root_2 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TK_TRANSITIVE_COERCION, "TK_TRANSITIVE_COERCION"), root_2);

                    	    adaptor.AddChild(root_2, stream_aty.NextTree());
                    	    adaptor.AddChild(root_2, stream_aty.NextTree());

                    	    adaptor.AddChild(root_1, root_2);
                    	    }
                    	    adaptor.AddChild(root_1, stream_aty.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 4 :
                    // Core.g:152:4: TRANS aty aty
                    {
                    	TRANS156=(IToken)Match(input,TRANS,FOLLOW_TRANS_in_bty1192); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_TRANS.Add(TRANS156);

                    	PushFollow(FOLLOW_aty_in_bty1194);
                    	aty157 = aty();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_aty.Add(aty157.Tree);
                    	PushFollow(FOLLOW_aty_in_bty1196);
                    	aty158 = aty();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_aty.Add(aty158.Tree);


                    	// AST REWRITE
                    	// elements:          aty, aty
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 152:18: -> ^( TK_TRANSITIVE_COERCION aty aty )
                    	{
                    	    // Core.g:152:21: ^( TK_TRANSITIVE_COERCION aty aty )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TK_TRANSITIVE_COERCION, "TK_TRANSITIVE_COERCION"), root_1);

                    	    adaptor.AddChild(root_1, stream_aty.NextTree());
                    	    adaptor.AddChild(root_1, stream_aty.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 5 :
                    // Core.g:153:4: SYM aty aty
                    {
                    	SYM159=(IToken)Match(input,SYM,FOLLOW_SYM_in_bty1212); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_SYM.Add(SYM159);

                    	PushFollow(FOLLOW_aty_in_bty1214);
                    	aty160 = aty();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_aty.Add(aty160.Tree);
                    	PushFollow(FOLLOW_aty_in_bty1216);
                    	aty161 = aty();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_aty.Add(aty161.Tree);


                    	// AST REWRITE
                    	// elements:          aty, aty
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 153:16: -> ^( TK_TYPE_APPLICATION ^( TK_SYMMETRIC_COERCION aty ) aty )
                    	{
                    	    // Core.g:153:19: ^( TK_TYPE_APPLICATION ^( TK_SYMMETRIC_COERCION aty ) aty )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TK_TYPE_APPLICATION, "TK_TYPE_APPLICATION"), root_1);

                    	    // Core.g:153:41: ^( TK_SYMMETRIC_COERCION aty )
                    	    {
                    	    CommonTree root_2 = (CommonTree)adaptor.GetNilNode();
                    	    root_2 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TK_SYMMETRIC_COERCION, "TK_SYMMETRIC_COERCION"), root_2);

                    	    adaptor.AddChild(root_2, stream_aty.NextTree());

                    	    adaptor.AddChild(root_1, root_2);
                    	    }
                    	    adaptor.AddChild(root_1, stream_aty.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 6 :
                    // Core.g:154:4: SYM aty
                    {
                    	SYM162=(IToken)Match(input,SYM,FOLLOW_SYM_in_bty1235); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_SYM.Add(SYM162);

                    	PushFollow(FOLLOW_aty_in_bty1237);
                    	aty163 = aty();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_aty.Add(aty163.Tree);


                    	// AST REWRITE
                    	// elements:          aty
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 154:12: -> ^( TK_SYMMETRIC_COERCION aty )
                    	{
                    	    // Core.g:154:15: ^( TK_SYMMETRIC_COERCION aty )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TK_SYMMETRIC_COERCION, "TK_SYMMETRIC_COERCION"), root_1);

                    	    adaptor.AddChild(root_1, stream_aty.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 7 :
                    // Core.g:155:4: UNSAFE aty aty aty
                    {
                    	UNSAFE164=(IToken)Match(input,UNSAFE,FOLLOW_UNSAFE_in_bty1251); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_UNSAFE.Add(UNSAFE164);

                    	PushFollow(FOLLOW_aty_in_bty1253);
                    	aty165 = aty();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_aty.Add(aty165.Tree);
                    	PushFollow(FOLLOW_aty_in_bty1255);
                    	aty166 = aty();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_aty.Add(aty166.Tree);
                    	PushFollow(FOLLOW_aty_in_bty1257);
                    	aty167 = aty();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_aty.Add(aty167.Tree);


                    	// AST REWRITE
                    	// elements:          aty, aty, aty
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 155:23: -> ^( TK_TYPE_APPLICATION ^( TK_UNSAFE_COERCION aty aty ) aty )
                    	{
                    	    // Core.g:155:26: ^( TK_TYPE_APPLICATION ^( TK_UNSAFE_COERCION aty aty ) aty )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TK_TYPE_APPLICATION, "TK_TYPE_APPLICATION"), root_1);

                    	    // Core.g:155:48: ^( TK_UNSAFE_COERCION aty aty )
                    	    {
                    	    CommonTree root_2 = (CommonTree)adaptor.GetNilNode();
                    	    root_2 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TK_UNSAFE_COERCION, "TK_UNSAFE_COERCION"), root_2);

                    	    adaptor.AddChild(root_2, stream_aty.NextTree());
                    	    adaptor.AddChild(root_2, stream_aty.NextTree());

                    	    adaptor.AddChild(root_1, root_2);
                    	    }
                    	    adaptor.AddChild(root_1, stream_aty.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 8 :
                    // Core.g:156:4: UNSAFE aty aty
                    {
                    	UNSAFE168=(IToken)Match(input,UNSAFE,FOLLOW_UNSAFE_in_bty1278); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_UNSAFE.Add(UNSAFE168);

                    	PushFollow(FOLLOW_aty_in_bty1280);
                    	aty169 = aty();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_aty.Add(aty169.Tree);
                    	PushFollow(FOLLOW_aty_in_bty1282);
                    	aty170 = aty();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_aty.Add(aty170.Tree);


                    	// AST REWRITE
                    	// elements:          aty, aty
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 156:19: -> ^( TK_UNSAFE_COERCION aty aty )
                    	{
                    	    // Core.g:156:22: ^( TK_UNSAFE_COERCION aty aty )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TK_UNSAFE_COERCION, "TK_UNSAFE_COERCION"), root_1);

                    	    adaptor.AddChild(root_1, stream_aty.NextTree());
                    	    adaptor.AddChild(root_1, stream_aty.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 9 :
                    // Core.g:157:4: LEFT aty aty
                    {
                    	LEFT171=(IToken)Match(input,LEFT,FOLLOW_LEFT_in_bty1298); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_LEFT.Add(LEFT171);

                    	PushFollow(FOLLOW_aty_in_bty1300);
                    	aty172 = aty();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_aty.Add(aty172.Tree);
                    	PushFollow(FOLLOW_aty_in_bty1302);
                    	aty173 = aty();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_aty.Add(aty173.Tree);


                    	// AST REWRITE
                    	// elements:          aty, aty
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 157:17: -> ^( TK_TYPE_APPLICATION ^( TK_LEFT_COERCION aty ) aty )
                    	{
                    	    // Core.g:157:20: ^( TK_TYPE_APPLICATION ^( TK_LEFT_COERCION aty ) aty )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TK_TYPE_APPLICATION, "TK_TYPE_APPLICATION"), root_1);

                    	    // Core.g:157:42: ^( TK_LEFT_COERCION aty )
                    	    {
                    	    CommonTree root_2 = (CommonTree)adaptor.GetNilNode();
                    	    root_2 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TK_LEFT_COERCION, "TK_LEFT_COERCION"), root_2);

                    	    adaptor.AddChild(root_2, stream_aty.NextTree());

                    	    adaptor.AddChild(root_1, root_2);
                    	    }
                    	    adaptor.AddChild(root_1, stream_aty.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 10 :
                    // Core.g:158:4: LEFT aty
                    {
                    	LEFT174=(IToken)Match(input,LEFT,FOLLOW_LEFT_in_bty1321); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_LEFT.Add(LEFT174);

                    	PushFollow(FOLLOW_aty_in_bty1323);
                    	aty175 = aty();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_aty.Add(aty175.Tree);


                    	// AST REWRITE
                    	// elements:          aty
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 158:13: -> ^( TK_LEFT_COERCION aty )
                    	{
                    	    // Core.g:158:16: ^( TK_LEFT_COERCION aty )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TK_LEFT_COERCION, "TK_LEFT_COERCION"), root_1);

                    	    adaptor.AddChild(root_1, stream_aty.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 11 :
                    // Core.g:159:4: RIGHT aty aty
                    {
                    	RIGHT176=(IToken)Match(input,RIGHT,FOLLOW_RIGHT_in_bty1337); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_RIGHT.Add(RIGHT176);

                    	PushFollow(FOLLOW_aty_in_bty1339);
                    	aty177 = aty();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_aty.Add(aty177.Tree);
                    	PushFollow(FOLLOW_aty_in_bty1341);
                    	aty178 = aty();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_aty.Add(aty178.Tree);


                    	// AST REWRITE
                    	// elements:          aty, aty
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 159:18: -> ^( TK_TYPE_APPLICATION ^( TK_RIGHT_COERCION aty ) aty )
                    	{
                    	    // Core.g:159:21: ^( TK_TYPE_APPLICATION ^( TK_RIGHT_COERCION aty ) aty )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TK_TYPE_APPLICATION, "TK_TYPE_APPLICATION"), root_1);

                    	    // Core.g:159:43: ^( TK_RIGHT_COERCION aty )
                    	    {
                    	    CommonTree root_2 = (CommonTree)adaptor.GetNilNode();
                    	    root_2 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TK_RIGHT_COERCION, "TK_RIGHT_COERCION"), root_2);

                    	    adaptor.AddChild(root_2, stream_aty.NextTree());

                    	    adaptor.AddChild(root_1, root_2);
                    	    }
                    	    adaptor.AddChild(root_1, stream_aty.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 12 :
                    // Core.g:160:4: RIGHT aty
                    {
                    	RIGHT179=(IToken)Match(input,RIGHT,FOLLOW_RIGHT_in_bty1360); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_RIGHT.Add(RIGHT179);

                    	PushFollow(FOLLOW_aty_in_bty1362);
                    	aty180 = aty();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_aty.Add(aty180.Tree);


                    	// AST REWRITE
                    	// elements:          aty
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 160:14: -> ^( TK_RIGHT_COERCION aty )
                    	{
                    	    // Core.g:160:17: ^( TK_RIGHT_COERCION aty )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TK_RIGHT_COERCION, "TK_RIGHT_COERCION"), root_1);

                    	    adaptor.AddChild(root_1, stream_aty.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 13 :
                    // Core.g:161:4: INST aty aty aty
                    {
                    	INST181=(IToken)Match(input,INST,FOLLOW_INST_in_bty1376); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_INST.Add(INST181);

                    	PushFollow(FOLLOW_aty_in_bty1378);
                    	aty182 = aty();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_aty.Add(aty182.Tree);
                    	PushFollow(FOLLOW_aty_in_bty1380);
                    	aty183 = aty();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_aty.Add(aty183.Tree);
                    	PushFollow(FOLLOW_aty_in_bty1382);
                    	aty184 = aty();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_aty.Add(aty184.Tree);


                    	// AST REWRITE
                    	// elements:          aty, aty, aty
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 161:21: -> ^( TK_TYPE_APPLICATION ^( TK_INSTANTIATION_COERCION aty aty ) aty )
                    	{
                    	    // Core.g:161:24: ^( TK_TYPE_APPLICATION ^( TK_INSTANTIATION_COERCION aty aty ) aty )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TK_TYPE_APPLICATION, "TK_TYPE_APPLICATION"), root_1);

                    	    // Core.g:161:46: ^( TK_INSTANTIATION_COERCION aty aty )
                    	    {
                    	    CommonTree root_2 = (CommonTree)adaptor.GetNilNode();
                    	    root_2 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TK_INSTANTIATION_COERCION, "TK_INSTANTIATION_COERCION"), root_2);

                    	    adaptor.AddChild(root_2, stream_aty.NextTree());
                    	    adaptor.AddChild(root_2, stream_aty.NextTree());

                    	    adaptor.AddChild(root_1, root_2);
                    	    }
                    	    adaptor.AddChild(root_1, stream_aty.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 14 :
                    // Core.g:162:4: INST aty aty
                    {
                    	INST185=(IToken)Match(input,INST,FOLLOW_INST_in_bty1403); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_INST.Add(INST185);

                    	PushFollow(FOLLOW_aty_in_bty1405);
                    	aty186 = aty();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_aty.Add(aty186.Tree);
                    	PushFollow(FOLLOW_aty_in_bty1407);
                    	aty187 = aty();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_aty.Add(aty187.Tree);


                    	// AST REWRITE
                    	// elements:          aty, aty
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 162:17: -> ^( TK_INSTANTIATION_COERCION aty aty )
                    	{
                    	    // Core.g:162:20: ^( TK_INSTANTIATION_COERCION aty aty )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TK_INSTANTIATION_COERCION, "TK_INSTANTIATION_COERCION"), root_1);

                    	    adaptor.AddChild(root_1, stream_aty.NextTree());
                    	    adaptor.AddChild(root_1, stream_aty.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "bty"

    public class ty_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "ty"
    // Core.g:166:1: ty : ( bty ARROW ty -> ^( TK_ARROW_TYPE_CONSTRUCTION bty ty ) | FORALL ( tbind )+ DOT ty -> ^( TK_TYPE_ABSTRACTION ty ( tbind )* ) | bty );
    public CoreParser.ty_return ty() // throws RecognitionException [1]
    {   
        CoreParser.ty_return retval = new CoreParser.ty_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken ARROW189 = null;
        IToken FORALL191 = null;
        IToken DOT193 = null;
        CoreParser.bty_return bty188 = default(CoreParser.bty_return);

        CoreParser.ty_return ty190 = default(CoreParser.ty_return);

        CoreParser.tbind_return tbind192 = default(CoreParser.tbind_return);

        CoreParser.ty_return ty194 = default(CoreParser.ty_return);

        CoreParser.bty_return bty195 = default(CoreParser.bty_return);


        CommonTree ARROW189_tree=null;
        CommonTree FORALL191_tree=null;
        CommonTree DOT193_tree=null;
        RewriteRuleTokenStream stream_FORALL = new RewriteRuleTokenStream(adaptor,"token FORALL");
        RewriteRuleTokenStream stream_ARROW = new RewriteRuleTokenStream(adaptor,"token ARROW");
        RewriteRuleTokenStream stream_DOT = new RewriteRuleTokenStream(adaptor,"token DOT");
        RewriteRuleSubtreeStream stream_ty = new RewriteRuleSubtreeStream(adaptor,"rule ty");
        RewriteRuleSubtreeStream stream_bty = new RewriteRuleSubtreeStream(adaptor,"rule bty");
        RewriteRuleSubtreeStream stream_tbind = new RewriteRuleSubtreeStream(adaptor,"rule tbind");
        try 
    	{
            // Core.g:167:2: ( bty ARROW ty -> ^( TK_ARROW_TYPE_CONSTRUCTION bty ty ) | FORALL ( tbind )+ DOT ty -> ^( TK_TYPE_ABSTRACTION ty ( tbind )* ) | bty )
            int alt31 = 3;
            alt31 = dfa31.Predict(input);
            switch (alt31) 
            {
                case 1 :
                    // Core.g:167:4: bty ARROW ty
                    {
                    	PushFollow(FOLLOW_bty_in_ty1429);
                    	bty188 = bty();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_bty.Add(bty188.Tree);
                    	ARROW189=(IToken)Match(input,ARROW,FOLLOW_ARROW_in_ty1431); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_ARROW.Add(ARROW189);

                    	PushFollow(FOLLOW_ty_in_ty1433);
                    	ty190 = ty();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_ty.Add(ty190.Tree);


                    	// AST REWRITE
                    	// elements:          bty, ty
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 167:17: -> ^( TK_ARROW_TYPE_CONSTRUCTION bty ty )
                    	{
                    	    // Core.g:167:20: ^( TK_ARROW_TYPE_CONSTRUCTION bty ty )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TK_ARROW_TYPE_CONSTRUCTION, "TK_ARROW_TYPE_CONSTRUCTION"), root_1);

                    	    adaptor.AddChild(root_1, stream_bty.NextTree());
                    	    adaptor.AddChild(root_1, stream_ty.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 2 :
                    // Core.g:168:4: FORALL ( tbind )+ DOT ty
                    {
                    	FORALL191=(IToken)Match(input,FORALL,FOLLOW_FORALL_in_ty1448); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_FORALL.Add(FORALL191);

                    	// Core.g:168:11: ( tbind )+
                    	int cnt30 = 0;
                    	do 
                    	{
                    	    int alt30 = 2;
                    	    int LA30_0 = input.LA(1);

                    	    if ( (LA30_0 == LP || LA30_0 == LNAME) )
                    	    {
                    	        alt30 = 1;
                    	    }


                    	    switch (alt30) 
                    		{
                    			case 1 :
                    			    // Core.g:168:12: tbind
                    			    {
                    			    	PushFollow(FOLLOW_tbind_in_ty1451);
                    			    	tbind192 = tbind();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( (state.backtracking==0) ) stream_tbind.Add(tbind192.Tree);

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt30 >= 1 ) goto loop30;
                    			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    		            EarlyExitException eee30 =
                    		                new EarlyExitException(30, input);
                    		            throw eee30;
                    	    }
                    	    cnt30++;
                    	} while (true);

                    	loop30:
                    		;	// Stops C# compiler whining that label 'loop30' has no statements

                    	DOT193=(IToken)Match(input,DOT,FOLLOW_DOT_in_ty1455); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_DOT.Add(DOT193);

                    	PushFollow(FOLLOW_ty_in_ty1457);
                    	ty194 = ty();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_ty.Add(ty194.Tree);


                    	// AST REWRITE
                    	// elements:          ty, tbind
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 168:27: -> ^( TK_TYPE_ABSTRACTION ty ( tbind )* )
                    	{
                    	    // Core.g:168:30: ^( TK_TYPE_ABSTRACTION ty ( tbind )* )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TK_TYPE_ABSTRACTION, "TK_TYPE_ABSTRACTION"), root_1);

                    	    adaptor.AddChild(root_1, stream_ty.NextTree());
                    	    // Core.g:168:55: ( tbind )*
                    	    while ( stream_tbind.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_tbind.NextTree());

                    	    }
                    	    stream_tbind.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 3 :
                    // Core.g:169:4: bty
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_bty_in_ty1473);
                    	bty195 = bty();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, bty195.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "ty"

    public class mident_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "mident"
    // Core.g:173:1: mident : pname COLON UNAME -> ^( TK_MODULE_IDENTIFIER pname UNAME ) ;
    public CoreParser.mident_return mident() // throws RecognitionException [1]
    {   
        CoreParser.mident_return retval = new CoreParser.mident_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken COLON197 = null;
        IToken UNAME198 = null;
        CoreParser.pname_return pname196 = default(CoreParser.pname_return);


        CommonTree COLON197_tree=null;
        CommonTree UNAME198_tree=null;
        RewriteRuleTokenStream stream_COLON = new RewriteRuleTokenStream(adaptor,"token COLON");
        RewriteRuleTokenStream stream_UNAME = new RewriteRuleTokenStream(adaptor,"token UNAME");
        RewriteRuleSubtreeStream stream_pname = new RewriteRuleSubtreeStream(adaptor,"rule pname");
        try 
    	{
            // Core.g:173:8: ( pname COLON UNAME -> ^( TK_MODULE_IDENTIFIER pname UNAME ) )
            // Core.g:173:10: pname COLON UNAME
            {
            	PushFollow(FOLLOW_pname_in_mident1483);
            	pname196 = pname();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_pname.Add(pname196.Tree);
            	COLON197=(IToken)Match(input,COLON,FOLLOW_COLON_in_mident1485); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_COLON.Add(COLON197);

            	UNAME198=(IToken)Match(input,UNAME,FOLLOW_UNAME_in_mident1487); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_UNAME.Add(UNAME198);



            	// AST REWRITE
            	// elements:          pname, UNAME
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 173:28: -> ^( TK_MODULE_IDENTIFIER pname UNAME )
            	{
            	    // Core.g:173:31: ^( TK_MODULE_IDENTIFIER pname UNAME )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TK_MODULE_IDENTIFIER, "TK_MODULE_IDENTIFIER"), root_1);

            	    adaptor.AddChild(root_1, stream_pname.NextTree());
            	    adaptor.AddChild(root_1, stream_UNAME.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "mident"

    public class tycon_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "tycon"
    // Core.g:174:1: tycon : UNAME ;
    public CoreParser.tycon_return tycon() // throws RecognitionException [1]
    {   
        CoreParser.tycon_return retval = new CoreParser.tycon_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken UNAME199 = null;

        CommonTree UNAME199_tree=null;

        try 
    	{
            // Core.g:174:8: ( UNAME )
            // Core.g:174:10: UNAME
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	UNAME199=(IToken)Match(input,UNAME,FOLLOW_UNAME_in_tycon1505); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{UNAME199_tree = (CommonTree)adaptor.Create(UNAME199);
            		adaptor.AddChild(root_0, UNAME199_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "tycon"

    public class qtycon_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "qtycon"
    // Core.g:175:1: qtycon : mident DOT tycon -> tycon mident ;
    public CoreParser.qtycon_return qtycon() // throws RecognitionException [1]
    {   
        CoreParser.qtycon_return retval = new CoreParser.qtycon_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken DOT201 = null;
        CoreParser.mident_return mident200 = default(CoreParser.mident_return);

        CoreParser.tycon_return tycon202 = default(CoreParser.tycon_return);


        CommonTree DOT201_tree=null;
        RewriteRuleTokenStream stream_DOT = new RewriteRuleTokenStream(adaptor,"token DOT");
        RewriteRuleSubtreeStream stream_mident = new RewriteRuleSubtreeStream(adaptor,"rule mident");
        RewriteRuleSubtreeStream stream_tycon = new RewriteRuleSubtreeStream(adaptor,"rule tycon");
        try 
    	{
            // Core.g:175:9: ( mident DOT tycon -> tycon mident )
            // Core.g:175:11: mident DOT tycon
            {
            	PushFollow(FOLLOW_mident_in_qtycon1513);
            	mident200 = mident();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_mident.Add(mident200.Tree);
            	DOT201=(IToken)Match(input,DOT,FOLLOW_DOT_in_qtycon1515); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_DOT.Add(DOT201);

            	PushFollow(FOLLOW_tycon_in_qtycon1517);
            	tycon202 = tycon();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_tycon.Add(tycon202.Tree);


            	// AST REWRITE
            	// elements:          mident, tycon
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 175:28: -> tycon mident
            	{
            	    adaptor.AddChild(root_0, stream_tycon.NextTree());
            	    adaptor.AddChild(root_0, stream_mident.NextTree());

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "qtycon"

    public class tyvar_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "tyvar"
    // Core.g:176:1: tyvar : LNAME ;
    public CoreParser.tyvar_return tyvar() // throws RecognitionException [1]
    {   
        CoreParser.tyvar_return retval = new CoreParser.tyvar_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken LNAME203 = null;

        CommonTree LNAME203_tree=null;

        try 
    	{
            // Core.g:176:8: ( LNAME )
            // Core.g:176:10: LNAME
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	LNAME203=(IToken)Match(input,LNAME,FOLLOW_LNAME_in_tyvar1531); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{LNAME203_tree = (CommonTree)adaptor.Create(LNAME203);
            		adaptor.AddChild(root_0, LNAME203_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "tyvar"

    public class var_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "var"
    // Core.g:177:1: var : LNAME -> ^( TK_VARIABLE LNAME ) ;
    public CoreParser.var_return var() // throws RecognitionException [1]
    {   
        CoreParser.var_return retval = new CoreParser.var_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken LNAME204 = null;

        CommonTree LNAME204_tree=null;
        RewriteRuleTokenStream stream_LNAME = new RewriteRuleTokenStream(adaptor,"token LNAME");

        try 
    	{
            // Core.g:177:6: ( LNAME -> ^( TK_VARIABLE LNAME ) )
            // Core.g:177:8: LNAME
            {
            	LNAME204=(IToken)Match(input,LNAME,FOLLOW_LNAME_in_var1539); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_LNAME.Add(LNAME204);



            	// AST REWRITE
            	// elements:          LNAME
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 177:14: -> ^( TK_VARIABLE LNAME )
            	{
            	    // Core.g:177:17: ^( TK_VARIABLE LNAME )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TK_VARIABLE, "TK_VARIABLE"), root_1);

            	    adaptor.AddChild(root_1, stream_LNAME.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "var"

    public class qvar_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "qvar"
    // Core.g:178:1: qvar : ( mident DOT )? LNAME -> ^( TK_VARIABLE LNAME ( mident )? ) ;
    public CoreParser.qvar_return qvar() // throws RecognitionException [1]
    {   
        CoreParser.qvar_return retval = new CoreParser.qvar_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken DOT206 = null;
        IToken LNAME207 = null;
        CoreParser.mident_return mident205 = default(CoreParser.mident_return);


        CommonTree DOT206_tree=null;
        CommonTree LNAME207_tree=null;
        RewriteRuleTokenStream stream_DOT = new RewriteRuleTokenStream(adaptor,"token DOT");
        RewriteRuleTokenStream stream_LNAME = new RewriteRuleTokenStream(adaptor,"token LNAME");
        RewriteRuleSubtreeStream stream_mident = new RewriteRuleSubtreeStream(adaptor,"rule mident");
        try 
    	{
            // Core.g:178:7: ( ( mident DOT )? LNAME -> ^( TK_VARIABLE LNAME ( mident )? ) )
            // Core.g:178:9: ( mident DOT )? LNAME
            {
            	// Core.g:178:9: ( mident DOT )?
            	int alt32 = 2;
            	int LA32_0 = input.LA(1);

            	if ( (LA32_0 == LNAME) )
            	{
            	    int LA32_1 = input.LA(2);

            	    if ( (LA32_1 == COLON) )
            	    {
            	        alt32 = 1;
            	    }
            	}
            	else if ( (LA32_0 == UNAME) )
            	{
            	    alt32 = 1;
            	}
            	switch (alt32) 
            	{
            	    case 1 :
            	        // Core.g:178:10: mident DOT
            	        {
            	        	PushFollow(FOLLOW_mident_in_qvar1556);
            	        	mident205 = mident();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_mident.Add(mident205.Tree);
            	        	DOT206=(IToken)Match(input,DOT,FOLLOW_DOT_in_qvar1558); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_DOT.Add(DOT206);


            	        }
            	        break;

            	}

            	LNAME207=(IToken)Match(input,LNAME,FOLLOW_LNAME_in_qvar1562); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_LNAME.Add(LNAME207);



            	// AST REWRITE
            	// elements:          mident, LNAME
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 178:29: -> ^( TK_VARIABLE LNAME ( mident )? )
            	{
            	    // Core.g:178:32: ^( TK_VARIABLE LNAME ( mident )? )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TK_VARIABLE, "TK_VARIABLE"), root_1);

            	    adaptor.AddChild(root_1, stream_LNAME.NextNode());
            	    // Core.g:178:52: ( mident )?
            	    if ( stream_mident.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_mident.NextTree());

            	    }
            	    stream_mident.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "qvar"

    public class dcon_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "dcon"
    // Core.g:179:1: dcon : UNAME -> ^( TK_DATA_CONSTRUCTOR UNAME ) ;
    public CoreParser.dcon_return dcon() // throws RecognitionException [1]
    {   
        CoreParser.dcon_return retval = new CoreParser.dcon_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken UNAME208 = null;

        CommonTree UNAME208_tree=null;
        RewriteRuleTokenStream stream_UNAME = new RewriteRuleTokenStream(adaptor,"token UNAME");

        try 
    	{
            // Core.g:179:7: ( UNAME -> ^( TK_DATA_CONSTRUCTOR UNAME ) )
            // Core.g:179:9: UNAME
            {
            	UNAME208=(IToken)Match(input,UNAME,FOLLOW_UNAME_in_dcon1581); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_UNAME.Add(UNAME208);



            	// AST REWRITE
            	// elements:          UNAME
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 179:15: -> ^( TK_DATA_CONSTRUCTOR UNAME )
            	{
            	    // Core.g:179:18: ^( TK_DATA_CONSTRUCTOR UNAME )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TK_DATA_CONSTRUCTOR, "TK_DATA_CONSTRUCTOR"), root_1);

            	    adaptor.AddChild(root_1, stream_UNAME.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "dcon"

    public class qdcon_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "qdcon"
    // Core.g:180:1: qdcon : mident DOT UNAME -> ^( TK_DATA_CONSTRUCTOR UNAME mident ) ;
    public CoreParser.qdcon_return qdcon() // throws RecognitionException [1]
    {   
        CoreParser.qdcon_return retval = new CoreParser.qdcon_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken DOT210 = null;
        IToken UNAME211 = null;
        CoreParser.mident_return mident209 = default(CoreParser.mident_return);


        CommonTree DOT210_tree=null;
        CommonTree UNAME211_tree=null;
        RewriteRuleTokenStream stream_UNAME = new RewriteRuleTokenStream(adaptor,"token UNAME");
        RewriteRuleTokenStream stream_DOT = new RewriteRuleTokenStream(adaptor,"token DOT");
        RewriteRuleSubtreeStream stream_mident = new RewriteRuleSubtreeStream(adaptor,"rule mident");
        try 
    	{
            // Core.g:180:9: ( mident DOT UNAME -> ^( TK_DATA_CONSTRUCTOR UNAME mident ) )
            // Core.g:180:11: mident DOT UNAME
            {
            	PushFollow(FOLLOW_mident_in_qdcon1598);
            	mident209 = mident();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_mident.Add(mident209.Tree);
            	DOT210=(IToken)Match(input,DOT,FOLLOW_DOT_in_qdcon1600); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_DOT.Add(DOT210);

            	UNAME211=(IToken)Match(input,UNAME,FOLLOW_UNAME_in_qdcon1602); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_UNAME.Add(UNAME211);



            	// AST REWRITE
            	// elements:          mident, UNAME
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 180:28: -> ^( TK_DATA_CONSTRUCTOR UNAME mident )
            	{
            	    // Core.g:180:31: ^( TK_DATA_CONSTRUCTOR UNAME mident )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TK_DATA_CONSTRUCTOR, "TK_DATA_CONSTRUCTOR"), root_1);

            	    adaptor.AddChild(root_1, stream_UNAME.NextNode());
            	    adaptor.AddChild(root_1, stream_mident.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "qdcon"

    public class pname_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "pname"
    // Core.g:182:1: pname : ( LNAME | UNAME );
    public CoreParser.pname_return pname() // throws RecognitionException [1]
    {   
        CoreParser.pname_return retval = new CoreParser.pname_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken set212 = null;

        CommonTree set212_tree=null;

        try 
    	{
            // Core.g:182:9: ( LNAME | UNAME )
            // Core.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set212 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= UNAME && input.LA(1) <= LNAME) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set212));
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "pname"

    // $ANTLR start "synpred12_Core"
    public void synpred12_Core_fragment() {
        // Core.g:71:25: ( aty )
        // Core.g:71:25: aty
        {
        	PushFollow(FOLLOW_aty_in_synpred12_Core419);
        	aty();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred12_Core"

    // $ANTLR start "synpred17_Core"
    public void synpred17_Core_fragment() {
        // Core.g:85:4: ( aexp ( arg )+ )
        // Core.g:85:4: aexp ( arg )+
        {
        	PushFollow(FOLLOW_aexp_in_synpred17_Core491);
        	aexp();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	// Core.g:85:9: ( arg )+
        	int cnt40 = 0;
        	do 
        	{
        	    int alt40 = 2;
        	    int LA40_0 = input.LA(1);

        	    if ( ((LA40_0 >= AT && LA40_0 <= LP) || (LA40_0 >= UNAME && LA40_0 <= LNAME)) )
        	    {
        	        alt40 = 1;
        	    }


        	    switch (alt40) 
        		{
        			case 1 :
        			    // Core.g:85:10: arg
        			    {
        			    	PushFollow(FOLLOW_arg_in_synpred17_Core494);
        			    	arg();
        			    	state.followingStackPointer--;
        			    	if (state.failed) return ;

        			    }
        			    break;

        			default:
        			    if ( cnt40 >= 1 ) goto loop40;
        			    if ( state.backtracking > 0 ) {state.failed = true; return ;}
        		            EarlyExitException eee40 =
        		                new EarlyExitException(40, input);
        		            throw eee40;
        	    }
        	    cnt40++;
        	} while (true);

        	loop40:
        		;	// Stops C# compiler whining that label 'loop40' has no statements


        }
    }
    // $ANTLR end "synpred17_Core"

    // $ANTLR start "synpred31_Core"
    public void synpred31_Core_fragment() {
        // Core.g:101:4: ( bty DCOLONEQ bty )
        // Core.g:101:4: bty DCOLONEQ bty
        {
        	PushFollow(FOLLOW_bty_in_synpred31_Core698);
        	bty();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	Match(input,DCOLONEQ,FOLLOW_DCOLONEQ_in_synpred31_Core700); if (state.failed) return ;
        	PushFollow(FOLLOW_bty_in_synpred31_Core702);
        	bty();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred31_Core"

    // $ANTLR start "synpred32_Core"
    public void synpred32_Core_fragment() {
        // Core.g:106:4: ( akind )
        // Core.g:106:4: akind
        {
        	PushFollow(FOLLOW_akind_in_synpred32_Core723);
        	akind();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred32_Core"

    // $ANTLR start "synpred46_Core"
    public void synpred46_Core_fragment() {
        // Core.g:149:4: ( aty ( aty )+ )
        // Core.g:149:4: aty ( aty )+
        {
        	PushFollow(FOLLOW_aty_in_synpred46_Core1142);
        	aty();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	// Core.g:149:8: ( aty )+
        	int cnt45 = 0;
        	do 
        	{
        	    int alt45 = 2;
        	    int LA45_0 = input.LA(1);

        	    if ( (LA45_0 == LP || (LA45_0 >= UNAME && LA45_0 <= LNAME)) )
        	    {
        	        alt45 = 1;
        	    }


        	    switch (alt45) 
        		{
        			case 1 :
        			    // Core.g:0:0: aty
        			    {
        			    	PushFollow(FOLLOW_aty_in_synpred46_Core1144);
        			    	aty();
        			    	state.followingStackPointer--;
        			    	if (state.failed) return ;

        			    }
        			    break;

        			default:
        			    if ( cnt45 >= 1 ) goto loop45;
        			    if ( state.backtracking > 0 ) {state.failed = true; return ;}
        		            EarlyExitException eee45 =
        		                new EarlyExitException(45, input);
        		            throw eee45;
        	    }
        	    cnt45++;
        	} while (true);

        	loop45:
        		;	// Stops C# compiler whining that label 'loop45' has no statements


        }
    }
    // $ANTLR end "synpred46_Core"

    // $ANTLR start "synpred47_Core"
    public void synpred47_Core_fragment() {
        // Core.g:150:4: ( aty )
        // Core.g:150:4: aty
        {
        	PushFollow(FOLLOW_aty_in_synpred47_Core1159);
        	aty();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred47_Core"

    // $ANTLR start "synpred48_Core"
    public void synpred48_Core_fragment() {
        // Core.g:151:4: ( TRANS aty aty aty )
        // Core.g:151:4: TRANS aty aty aty
        {
        	Match(input,TRANS,FOLLOW_TRANS_in_synpred48_Core1165); if (state.failed) return ;
        	PushFollow(FOLLOW_aty_in_synpred48_Core1167);
        	aty();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	PushFollow(FOLLOW_aty_in_synpred48_Core1169);
        	aty();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	PushFollow(FOLLOW_aty_in_synpred48_Core1171);
        	aty();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred48_Core"

    // $ANTLR start "synpred49_Core"
    public void synpred49_Core_fragment() {
        // Core.g:152:4: ( TRANS aty aty )
        // Core.g:152:4: TRANS aty aty
        {
        	Match(input,TRANS,FOLLOW_TRANS_in_synpred49_Core1192); if (state.failed) return ;
        	PushFollow(FOLLOW_aty_in_synpred49_Core1194);
        	aty();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	PushFollow(FOLLOW_aty_in_synpred49_Core1196);
        	aty();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred49_Core"

    // $ANTLR start "synpred50_Core"
    public void synpred50_Core_fragment() {
        // Core.g:153:4: ( SYM aty aty )
        // Core.g:153:4: SYM aty aty
        {
        	Match(input,SYM,FOLLOW_SYM_in_synpred50_Core1212); if (state.failed) return ;
        	PushFollow(FOLLOW_aty_in_synpred50_Core1214);
        	aty();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	PushFollow(FOLLOW_aty_in_synpred50_Core1216);
        	aty();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred50_Core"

    // $ANTLR start "synpred51_Core"
    public void synpred51_Core_fragment() {
        // Core.g:154:4: ( SYM aty )
        // Core.g:154:4: SYM aty
        {
        	Match(input,SYM,FOLLOW_SYM_in_synpred51_Core1235); if (state.failed) return ;
        	PushFollow(FOLLOW_aty_in_synpred51_Core1237);
        	aty();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred51_Core"

    // $ANTLR start "synpred52_Core"
    public void synpred52_Core_fragment() {
        // Core.g:155:4: ( UNSAFE aty aty aty )
        // Core.g:155:4: UNSAFE aty aty aty
        {
        	Match(input,UNSAFE,FOLLOW_UNSAFE_in_synpred52_Core1251); if (state.failed) return ;
        	PushFollow(FOLLOW_aty_in_synpred52_Core1253);
        	aty();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	PushFollow(FOLLOW_aty_in_synpred52_Core1255);
        	aty();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	PushFollow(FOLLOW_aty_in_synpred52_Core1257);
        	aty();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred52_Core"

    // $ANTLR start "synpred53_Core"
    public void synpred53_Core_fragment() {
        // Core.g:156:4: ( UNSAFE aty aty )
        // Core.g:156:4: UNSAFE aty aty
        {
        	Match(input,UNSAFE,FOLLOW_UNSAFE_in_synpred53_Core1278); if (state.failed) return ;
        	PushFollow(FOLLOW_aty_in_synpred53_Core1280);
        	aty();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	PushFollow(FOLLOW_aty_in_synpred53_Core1282);
        	aty();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred53_Core"

    // $ANTLR start "synpred54_Core"
    public void synpred54_Core_fragment() {
        // Core.g:157:4: ( LEFT aty aty )
        // Core.g:157:4: LEFT aty aty
        {
        	Match(input,LEFT,FOLLOW_LEFT_in_synpred54_Core1298); if (state.failed) return ;
        	PushFollow(FOLLOW_aty_in_synpred54_Core1300);
        	aty();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	PushFollow(FOLLOW_aty_in_synpred54_Core1302);
        	aty();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred54_Core"

    // $ANTLR start "synpred55_Core"
    public void synpred55_Core_fragment() {
        // Core.g:158:4: ( LEFT aty )
        // Core.g:158:4: LEFT aty
        {
        	Match(input,LEFT,FOLLOW_LEFT_in_synpred55_Core1321); if (state.failed) return ;
        	PushFollow(FOLLOW_aty_in_synpred55_Core1323);
        	aty();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred55_Core"

    // $ANTLR start "synpred56_Core"
    public void synpred56_Core_fragment() {
        // Core.g:159:4: ( RIGHT aty aty )
        // Core.g:159:4: RIGHT aty aty
        {
        	Match(input,RIGHT,FOLLOW_RIGHT_in_synpred56_Core1337); if (state.failed) return ;
        	PushFollow(FOLLOW_aty_in_synpred56_Core1339);
        	aty();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	PushFollow(FOLLOW_aty_in_synpred56_Core1341);
        	aty();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred56_Core"

    // $ANTLR start "synpred57_Core"
    public void synpred57_Core_fragment() {
        // Core.g:160:4: ( RIGHT aty )
        // Core.g:160:4: RIGHT aty
        {
        	Match(input,RIGHT,FOLLOW_RIGHT_in_synpred57_Core1360); if (state.failed) return ;
        	PushFollow(FOLLOW_aty_in_synpred57_Core1362);
        	aty();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred57_Core"

    // $ANTLR start "synpred58_Core"
    public void synpred58_Core_fragment() {
        // Core.g:161:4: ( INST aty aty aty )
        // Core.g:161:4: INST aty aty aty
        {
        	Match(input,INST,FOLLOW_INST_in_synpred58_Core1376); if (state.failed) return ;
        	PushFollow(FOLLOW_aty_in_synpred58_Core1378);
        	aty();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	PushFollow(FOLLOW_aty_in_synpred58_Core1380);
        	aty();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	PushFollow(FOLLOW_aty_in_synpred58_Core1382);
        	aty();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred58_Core"

    // $ANTLR start "synpred59_Core"
    public void synpred59_Core_fragment() {
        // Core.g:167:4: ( bty ARROW ty )
        // Core.g:167:4: bty ARROW ty
        {
        	PushFollow(FOLLOW_bty_in_synpred59_Core1429);
        	bty();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	Match(input,ARROW,FOLLOW_ARROW_in_synpred59_Core1431); if (state.failed) return ;
        	PushFollow(FOLLOW_ty_in_synpred59_Core1433);
        	ty();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred59_Core"

    // Delegated rules

   	public bool synpred50_Core() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred50_Core_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred59_Core() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred59_Core_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred55_Core() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred55_Core_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred46_Core() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred46_Core_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred54_Core() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred54_Core_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred56_Core() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred56_Core_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred52_Core() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred52_Core_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred31_Core() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred31_Core_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred57_Core() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred57_Core_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred47_Core() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred47_Core_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred58_Core() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred58_Core_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred48_Core() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred48_Core_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred51_Core() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred51_Core_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred32_Core() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred32_Core_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred17_Core() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred17_Core_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred53_Core() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred53_Core_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred12_Core() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred12_Core_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred49_Core() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred49_Core_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}


   	protected DFA13 dfa13;
   	protected DFA17 dfa17;
   	protected DFA18 dfa18;
   	protected DFA19 dfa19;
   	protected DFA29 dfa29;
   	protected DFA31 dfa31;
	private void InitializeCyclicDFAs()
	{
    	this.dfa13 = new DFA13(this);
    	this.dfa17 = new DFA17(this);
    	this.dfa18 = new DFA18(this);
    	this.dfa19 = new DFA19(this);
    	this.dfa29 = new DFA29(this);
    	this.dfa31 = new DFA31(this);
	    this.dfa17.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA17_SpecialStateTransition);
	    this.dfa18.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA18_SpecialStateTransition);
	    this.dfa19.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA19_SpecialStateTransition);
	    this.dfa29.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA29_SpecialStateTransition);
	    this.dfa31.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA31_SpecialStateTransition);
	}

    const string DFA13_eotS =
        "\x0b\uffff";
    const string DFA13_eofS =
        "\x01\uffff\x01\x05\x09\uffff";
    const string DFA13_minS =
        "\x01\x34\x01\x2b\x01\x52\x01\x34\x01\x53\x03\uffff\x01\x51\x01"+
        "\x53\x01\uffff";
    const string DFA13_maxS =
        "\x02\x54\x01\x52\x01\x54\x01\x53\x03\uffff\x01\x51\x01\x54\x01"+
        "\uffff";
    const string DFA13_acceptS =
        "\x05\uffff\x01\x01\x01\x03\x01\x04\x02\uffff\x01\x02";
    const string DFA13_specialS =
        "\x0b\uffff}>";
    static readonly string[] DFA13_transitionS = {
            "\x01\x03\x1e\uffff\x01\x02\x01\x01",
            "\x01\x05\x04\uffff\x01\x05\x02\uffff\x03\x05\x03\uffff\x01"+
            "\x05\x01\uffff\x01\x05\x16\uffff\x01\x04\x02\x05",
            "\x01\x04",
            "\x01\x07\x01\uffff\x01\x07\x01\uffff\x01\x07\x01\uffff\x01"+
            "\x07\x01\uffff\x02\x07\x01\x06\x03\x07\x05\uffff\x01\x06\x01"+
            "\uffff\x01\x06\x09\uffff\x02\x07",
            "\x01\x08",
            "",
            "",
            "",
            "\x01\x09",
            "\x01\x0a\x01\x05",
            ""
    };

    static readonly short[] DFA13_eot = DFA.UnpackEncodedString(DFA13_eotS);
    static readonly short[] DFA13_eof = DFA.UnpackEncodedString(DFA13_eofS);
    static readonly char[] DFA13_min = DFA.UnpackEncodedStringToUnsignedChars(DFA13_minS);
    static readonly char[] DFA13_max = DFA.UnpackEncodedStringToUnsignedChars(DFA13_maxS);
    static readonly short[] DFA13_accept = DFA.UnpackEncodedString(DFA13_acceptS);
    static readonly short[] DFA13_special = DFA.UnpackEncodedString(DFA13_specialS);
    static readonly short[][] DFA13_transition = DFA.UnpackEncodedStringArray(DFA13_transitionS);

    protected class DFA13 : DFA
    {
        public DFA13(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 13;
            this.eot = DFA13_eot;
            this.eof = DFA13_eof;
            this.min = DFA13_min;
            this.max = DFA13_max;
            this.accept = DFA13_accept;
            this.special = DFA13_special;
            this.transition = DFA13_transition;

        }

        override public string Description
        {
            get { return "77:1: aexp : ( qvar | qdcon | literal | LP exp RP -> ^( TK_NESTED_EXPRESSION exp ) );"; }
        }

    }

    const string DFA17_eotS =
        "\x0e\uffff";
    const string DFA17_eofS =
        "\x0e\uffff";
    const string DFA17_minS =
        "\x01\x34\x03\x00\x0a\uffff";
    const string DFA17_maxS =
        "\x01\x54\x03\x00\x0a\uffff";
    const string DFA17_acceptS =
        "\x04\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01\x07\x01"+
        "\x08\x01\x09\x01\x01\x01\x0a";
    const string DFA17_specialS =
        "\x01\uffff\x01\x00\x01\x01\x01\x02\x0a\uffff}>";
    static readonly string[] DFA17_transitionS = {
            "\x01\x03\x01\uffff\x01\x04\x01\uffff\x01\x05\x01\uffff\x01"+
            "\x06\x01\uffff\x01\x07\x01\x08\x01\uffff\x01\x09\x01\x0a\x01"+
            "\x0b\x11\uffff\x01\x02\x01\x01",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA17_eot = DFA.UnpackEncodedString(DFA17_eotS);
    static readonly short[] DFA17_eof = DFA.UnpackEncodedString(DFA17_eofS);
    static readonly char[] DFA17_min = DFA.UnpackEncodedStringToUnsignedChars(DFA17_minS);
    static readonly char[] DFA17_max = DFA.UnpackEncodedStringToUnsignedChars(DFA17_maxS);
    static readonly short[] DFA17_accept = DFA.UnpackEncodedString(DFA17_acceptS);
    static readonly short[] DFA17_special = DFA.UnpackEncodedString(DFA17_specialS);
    static readonly short[][] DFA17_transition = DFA.UnpackEncodedStringArray(DFA17_transitionS);

    protected class DFA17 : DFA
    {
        public DFA17(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 17;
            this.eot = DFA17_eot;
            this.eof = DFA17_eof;
            this.min = DFA17_min;
            this.max = DFA17_max;
            this.accept = DFA17_accept;
            this.special = DFA17_special;
            this.transition = DFA17_transition;

        }

        override public string Description
        {
            get { return "84:1: exp : ( aexp ( arg )+ -> ^( TK_APPLICATION aexp ( arg )+ ) | DSLASH ( binder )+ ARROW exp -> ^( TK_ABSTRACTION exp ( binder )+ ) | LET vdefg IN exp -> ^( TK_LOCAL_DEFINITION vdefg exp ) | CASE aty exp OF vbind LB alt ( SEMICOLON alt )* RB -> ^( TK_CASE_EXPRESSION aty exp vbind ( alt )+ ) | CAST LP exp RP aty -> ^( TK_CAST exp aty ) | NOTE STRINGLITERAL exp -> ^( TK_NOTE STRINGLITERAL exp ) | ECALL STRINGLITERAL aty | DECALL aty | LABEL STRINGLITERAL | aexp );"; }
        }

    }


    protected internal int DFA17_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA17_1 = input.LA(1);

                   	 
                   	int index17_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred17_Core()) ) { s = 12; }

                   	else if ( (true) ) { s = 13; }

                   	 
                   	input.Seek(index17_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA17_2 = input.LA(1);

                   	 
                   	int index17_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred17_Core()) ) { s = 12; }

                   	else if ( (true) ) { s = 13; }

                   	 
                   	input.Seek(index17_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA17_3 = input.LA(1);

                   	 
                   	int index17_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred17_Core()) ) { s = 12; }

                   	else if ( (true) ) { s = 13; }

                   	 
                   	input.Seek(index17_3);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae17 =
            new NoViableAltException(dfa.Description, 17, _s, input);
        dfa.Error(nvae17);
        throw nvae17;
    }
    const string DFA18_eotS =
        "\x0e\uffff";
    const string DFA18_eofS =
        "\x0e\uffff";
    const string DFA18_minS =
        "\x01\x34\x05\uffff\x01\x00\x07\uffff";
    const string DFA18_maxS =
        "\x01\x54\x05\uffff\x01\x00\x07\uffff";
    const string DFA18_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\x03\x01\x04\x08\uffff\x01\x05";
    const string DFA18_specialS =
        "\x06\uffff\x01\x00\x07\uffff}>";
    static readonly string[] DFA18_transitionS = {
            "\x01\x06\x0d\uffff\x01\x01\x01\x02\x01\x03\x05\uffff\x06\x04"+
            "\x03\uffff\x02\x04",
            "",
            "",
            "",
            "",
            "",
            "\x01\uffff",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA18_eot = DFA.UnpackEncodedString(DFA18_eotS);
    static readonly short[] DFA18_eof = DFA.UnpackEncodedString(DFA18_eofS);
    static readonly char[] DFA18_min = DFA.UnpackEncodedStringToUnsignedChars(DFA18_minS);
    static readonly char[] DFA18_max = DFA.UnpackEncodedStringToUnsignedChars(DFA18_maxS);
    static readonly short[] DFA18_accept = DFA.UnpackEncodedString(DFA18_acceptS);
    static readonly short[] DFA18_special = DFA.UnpackEncodedString(DFA18_specialS);
    static readonly short[][] DFA18_transition = DFA.UnpackEncodedStringArray(DFA18_transitionS);

    protected class DFA18 : DFA
    {
        public DFA18(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 18;
            this.eot = DFA18_eot;
            this.eof = DFA18_eof;
            this.min = DFA18_min;
            this.max = DFA18_max;
            this.accept = DFA18_accept;
            this.special = DFA18_special;
            this.transition = DFA18_transition;

        }

        override public string Description
        {
            get { return "97:1: akind : ( STAR | SHARP | QUESTION | bty DCOLONEQ bty | LP kind RP );"; }
        }

    }


    protected internal int DFA18_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA18_6 = input.LA(1);

                   	 
                   	int index18_6 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred31_Core()) ) { s = 4; }

                   	else if ( (true) ) { s = 13; }

                   	 
                   	input.Seek(index18_6);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae18 =
            new NoViableAltException(dfa.Description, 18, _s, input);
        dfa.Error(nvae18);
        throw nvae18;
    }
    const string DFA19_eotS =
        "\x0f\uffff";
    const string DFA19_eofS =
        "\x0f\uffff";
    const string DFA19_minS =
        "\x01\x34\x0c\x00\x02\uffff";
    const string DFA19_maxS =
        "\x01\x54\x0c\x00\x02\uffff";
    const string DFA19_acceptS =
        "\x0d\uffff\x01\x01\x01\x02";
    const string DFA19_specialS =
        "\x01\uffff\x01\x00\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x01"+
        "\x06\x01\x07\x01\x08\x01\x09\x01\x0a\x01\x0b\x02\uffff}>";
    static readonly string[] DFA19_transitionS = {
            "\x01\x06\x0d\uffff\x01\x01\x01\x02\x01\x03\x05\uffff\x01\x07"+
            "\x01\x08\x01\x09\x01\x0a\x01\x0b\x01\x0c\x03\uffff\x01\x05\x01"+
            "\x04",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "",
            ""
    };

    static readonly short[] DFA19_eot = DFA.UnpackEncodedString(DFA19_eotS);
    static readonly short[] DFA19_eof = DFA.UnpackEncodedString(DFA19_eofS);
    static readonly char[] DFA19_min = DFA.UnpackEncodedStringToUnsignedChars(DFA19_minS);
    static readonly char[] DFA19_max = DFA.UnpackEncodedStringToUnsignedChars(DFA19_maxS);
    static readonly short[] DFA19_accept = DFA.UnpackEncodedString(DFA19_acceptS);
    static readonly short[] DFA19_special = DFA.UnpackEncodedString(DFA19_specialS);
    static readonly short[][] DFA19_transition = DFA.UnpackEncodedStringArray(DFA19_transitionS);

    protected class DFA19 : DFA
    {
        public DFA19(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 19;
            this.eot = DFA19_eot;
            this.eof = DFA19_eof;
            this.min = DFA19_min;
            this.max = DFA19_max;
            this.accept = DFA19_accept;
            this.special = DFA19_special;
            this.transition = DFA19_transition;

        }

        override public string Description
        {
            get { return "105:1: kind : ( akind | akind ARROW kind );"; }
        }

    }


    protected internal int DFA19_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA19_1 = input.LA(1);

                   	 
                   	int index19_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred32_Core()) ) { s = 13; }

                   	else if ( (true) ) { s = 14; }

                   	 
                   	input.Seek(index19_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA19_2 = input.LA(1);

                   	 
                   	int index19_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred32_Core()) ) { s = 13; }

                   	else if ( (true) ) { s = 14; }

                   	 
                   	input.Seek(index19_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA19_3 = input.LA(1);

                   	 
                   	int index19_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred32_Core()) ) { s = 13; }

                   	else if ( (true) ) { s = 14; }

                   	 
                   	input.Seek(index19_3);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA19_4 = input.LA(1);

                   	 
                   	int index19_4 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred32_Core()) ) { s = 13; }

                   	else if ( (true) ) { s = 14; }

                   	 
                   	input.Seek(index19_4);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA19_5 = input.LA(1);

                   	 
                   	int index19_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred32_Core()) ) { s = 13; }

                   	else if ( (true) ) { s = 14; }

                   	 
                   	input.Seek(index19_5);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 5 : 
                   	int LA19_6 = input.LA(1);

                   	 
                   	int index19_6 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred32_Core()) ) { s = 13; }

                   	else if ( (true) ) { s = 14; }

                   	 
                   	input.Seek(index19_6);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 6 : 
                   	int LA19_7 = input.LA(1);

                   	 
                   	int index19_7 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred32_Core()) ) { s = 13; }

                   	else if ( (true) ) { s = 14; }

                   	 
                   	input.Seek(index19_7);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 7 : 
                   	int LA19_8 = input.LA(1);

                   	 
                   	int index19_8 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred32_Core()) ) { s = 13; }

                   	else if ( (true) ) { s = 14; }

                   	 
                   	input.Seek(index19_8);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 8 : 
                   	int LA19_9 = input.LA(1);

                   	 
                   	int index19_9 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred32_Core()) ) { s = 13; }

                   	else if ( (true) ) { s = 14; }

                   	 
                   	input.Seek(index19_9);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 9 : 
                   	int LA19_10 = input.LA(1);

                   	 
                   	int index19_10 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred32_Core()) ) { s = 13; }

                   	else if ( (true) ) { s = 14; }

                   	 
                   	input.Seek(index19_10);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 10 : 
                   	int LA19_11 = input.LA(1);

                   	 
                   	int index19_11 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred32_Core()) ) { s = 13; }

                   	else if ( (true) ) { s = 14; }

                   	 
                   	input.Seek(index19_11);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 11 : 
                   	int LA19_12 = input.LA(1);

                   	 
                   	int index19_12 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred32_Core()) ) { s = 13; }

                   	else if ( (true) ) { s = 14; }

                   	 
                   	input.Seek(index19_12);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae19 =
            new NoViableAltException(dfa.Description, 19, _s, input);
        dfa.Error(nvae19);
        throw nvae19;
    }
    const string DFA29_eotS =
        "\x18\uffff";
    const string DFA29_eofS =
        "\x18\uffff";
    const string DFA29_minS =
        "\x01\x34\x09\x00\x0e\uffff";
    const string DFA29_maxS =
        "\x01\x54\x09\x00\x0e\uffff";
    const string DFA29_acceptS =
        "\x0a\uffff\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01"+
        "\x07\x01\x08\x01\x09\x01\x0a\x01\x0b\x01\x0c\x01\x0d\x01\x0e";
    const string DFA29_specialS =
        "\x01\uffff\x01\x00\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x01"+
        "\x06\x01\x07\x01\x08\x0e\uffff}>";
    static readonly string[] DFA29_transitionS = {
            "\x01\x03\x15\uffff\x01\x04\x01\x05\x01\x06\x01\x07\x01\x08"+
            "\x01\x09\x03\uffff\x01\x02\x01\x01",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA29_eot = DFA.UnpackEncodedString(DFA29_eotS);
    static readonly short[] DFA29_eof = DFA.UnpackEncodedString(DFA29_eofS);
    static readonly char[] DFA29_min = DFA.UnpackEncodedStringToUnsignedChars(DFA29_minS);
    static readonly char[] DFA29_max = DFA.UnpackEncodedStringToUnsignedChars(DFA29_maxS);
    static readonly short[] DFA29_accept = DFA.UnpackEncodedString(DFA29_acceptS);
    static readonly short[] DFA29_special = DFA.UnpackEncodedString(DFA29_specialS);
    static readonly short[][] DFA29_transition = DFA.UnpackEncodedStringArray(DFA29_transitionS);

    protected class DFA29 : DFA
    {
        public DFA29(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 29;
            this.eot = DFA29_eot;
            this.eof = DFA29_eof;
            this.min = DFA29_min;
            this.max = DFA29_max;
            this.accept = DFA29_accept;
            this.special = DFA29_special;
            this.transition = DFA29_transition;

        }

        override public string Description
        {
            get { return "148:1: bty : ( aty ( aty )+ -> ^( TK_TYPE_APPLICATION ( aty )* ) | aty | TRANS aty aty aty -> ^( TK_TYPE_APPLICATION ^( TK_TRANSITIVE_COERCION aty aty ) aty ) | TRANS aty aty -> ^( TK_TRANSITIVE_COERCION aty aty ) | SYM aty aty -> ^( TK_TYPE_APPLICATION ^( TK_SYMMETRIC_COERCION aty ) aty ) | SYM aty -> ^( TK_SYMMETRIC_COERCION aty ) | UNSAFE aty aty aty -> ^( TK_TYPE_APPLICATION ^( TK_UNSAFE_COERCION aty aty ) aty ) | UNSAFE aty aty -> ^( TK_UNSAFE_COERCION aty aty ) | LEFT aty aty -> ^( TK_TYPE_APPLICATION ^( TK_LEFT_COERCION aty ) aty ) | LEFT aty -> ^( TK_LEFT_COERCION aty ) | RIGHT aty aty -> ^( TK_TYPE_APPLICATION ^( TK_RIGHT_COERCION aty ) aty ) | RIGHT aty -> ^( TK_RIGHT_COERCION aty ) | INST aty aty aty -> ^( TK_TYPE_APPLICATION ^( TK_INSTANTIATION_COERCION aty aty ) aty ) | INST aty aty -> ^( TK_INSTANTIATION_COERCION aty aty ) );"; }
        }

    }


    protected internal int DFA29_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA29_1 = input.LA(1);

                   	 
                   	int index29_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred46_Core()) ) { s = 10; }

                   	else if ( (synpred47_Core()) ) { s = 11; }

                   	 
                   	input.Seek(index29_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA29_2 = input.LA(1);

                   	 
                   	int index29_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred46_Core()) ) { s = 10; }

                   	else if ( (synpred47_Core()) ) { s = 11; }

                   	 
                   	input.Seek(index29_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA29_3 = input.LA(1);

                   	 
                   	int index29_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred46_Core()) ) { s = 10; }

                   	else if ( (synpred47_Core()) ) { s = 11; }

                   	 
                   	input.Seek(index29_3);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA29_4 = input.LA(1);

                   	 
                   	int index29_4 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred48_Core()) ) { s = 12; }

                   	else if ( (synpred49_Core()) ) { s = 13; }

                   	 
                   	input.Seek(index29_4);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA29_5 = input.LA(1);

                   	 
                   	int index29_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred50_Core()) ) { s = 14; }

                   	else if ( (synpred51_Core()) ) { s = 15; }

                   	 
                   	input.Seek(index29_5);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 5 : 
                   	int LA29_6 = input.LA(1);

                   	 
                   	int index29_6 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred52_Core()) ) { s = 16; }

                   	else if ( (synpred53_Core()) ) { s = 17; }

                   	 
                   	input.Seek(index29_6);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 6 : 
                   	int LA29_7 = input.LA(1);

                   	 
                   	int index29_7 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred54_Core()) ) { s = 18; }

                   	else if ( (synpred55_Core()) ) { s = 19; }

                   	 
                   	input.Seek(index29_7);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 7 : 
                   	int LA29_8 = input.LA(1);

                   	 
                   	int index29_8 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred56_Core()) ) { s = 20; }

                   	else if ( (synpred57_Core()) ) { s = 21; }

                   	 
                   	input.Seek(index29_8);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 8 : 
                   	int LA29_9 = input.LA(1);

                   	 
                   	int index29_9 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred58_Core()) ) { s = 22; }

                   	else if ( (true) ) { s = 23; }

                   	 
                   	input.Seek(index29_9);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae29 =
            new NoViableAltException(dfa.Description, 29, _s, input);
        dfa.Error(nvae29);
        throw nvae29;
    }
    const string DFA31_eotS =
        "\x0d\uffff";
    const string DFA31_eofS =
        "\x0d\uffff";
    const string DFA31_minS =
        "\x01\x34\x09\x00\x03\uffff";
    const string DFA31_maxS =
        "\x01\x54\x09\x00\x03\uffff";
    const string DFA31_acceptS =
        "\x0a\uffff\x01\x02\x01\x01\x01\x03";
    const string DFA31_specialS =
        "\x01\uffff\x01\x00\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x01"+
        "\x06\x01\x07\x01\x08\x03\uffff}>";
    static readonly string[] DFA31_transitionS = {
            "\x01\x03\x15\uffff\x01\x04\x01\x05\x01\x06\x01\x07\x01\x08"+
            "\x01\x09\x01\x0a\x02\uffff\x01\x02\x01\x01",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "",
            "",
            ""
    };

    static readonly short[] DFA31_eot = DFA.UnpackEncodedString(DFA31_eotS);
    static readonly short[] DFA31_eof = DFA.UnpackEncodedString(DFA31_eofS);
    static readonly char[] DFA31_min = DFA.UnpackEncodedStringToUnsignedChars(DFA31_minS);
    static readonly char[] DFA31_max = DFA.UnpackEncodedStringToUnsignedChars(DFA31_maxS);
    static readonly short[] DFA31_accept = DFA.UnpackEncodedString(DFA31_acceptS);
    static readonly short[] DFA31_special = DFA.UnpackEncodedString(DFA31_specialS);
    static readonly short[][] DFA31_transition = DFA.UnpackEncodedStringArray(DFA31_transitionS);

    protected class DFA31 : DFA
    {
        public DFA31(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 31;
            this.eot = DFA31_eot;
            this.eof = DFA31_eof;
            this.min = DFA31_min;
            this.max = DFA31_max;
            this.accept = DFA31_accept;
            this.special = DFA31_special;
            this.transition = DFA31_transition;

        }

        override public string Description
        {
            get { return "166:1: ty : ( bty ARROW ty -> ^( TK_ARROW_TYPE_CONSTRUCTION bty ty ) | FORALL ( tbind )+ DOT ty -> ^( TK_TYPE_ABSTRACTION ty ( tbind )* ) | bty );"; }
        }

    }


    protected internal int DFA31_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA31_1 = input.LA(1);

                   	 
                   	int index31_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred59_Core()) ) { s = 11; }

                   	else if ( (true) ) { s = 12; }

                   	 
                   	input.Seek(index31_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA31_2 = input.LA(1);

                   	 
                   	int index31_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred59_Core()) ) { s = 11; }

                   	else if ( (true) ) { s = 12; }

                   	 
                   	input.Seek(index31_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA31_3 = input.LA(1);

                   	 
                   	int index31_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred59_Core()) ) { s = 11; }

                   	else if ( (true) ) { s = 12; }

                   	 
                   	input.Seek(index31_3);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA31_4 = input.LA(1);

                   	 
                   	int index31_4 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred59_Core()) ) { s = 11; }

                   	else if ( (true) ) { s = 12; }

                   	 
                   	input.Seek(index31_4);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA31_5 = input.LA(1);

                   	 
                   	int index31_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred59_Core()) ) { s = 11; }

                   	else if ( (true) ) { s = 12; }

                   	 
                   	input.Seek(index31_5);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 5 : 
                   	int LA31_6 = input.LA(1);

                   	 
                   	int index31_6 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred59_Core()) ) { s = 11; }

                   	else if ( (true) ) { s = 12; }

                   	 
                   	input.Seek(index31_6);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 6 : 
                   	int LA31_7 = input.LA(1);

                   	 
                   	int index31_7 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred59_Core()) ) { s = 11; }

                   	else if ( (true) ) { s = 12; }

                   	 
                   	input.Seek(index31_7);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 7 : 
                   	int LA31_8 = input.LA(1);

                   	 
                   	int index31_8 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred59_Core()) ) { s = 11; }

                   	else if ( (true) ) { s = 12; }

                   	 
                   	input.Seek(index31_8);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 8 : 
                   	int LA31_9 = input.LA(1);

                   	 
                   	int index31_9 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred59_Core()) ) { s = 11; }

                   	else if ( (true) ) { s = 12; }

                   	 
                   	input.Seek(index31_9);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae31 =
            new NoViableAltException(dfa.Description, 31, _s, input);
        dfa.Error(nvae31);
        throw nvae31;
    }
 

    public static readonly BitSet FOLLOW_MODULE_in_module219 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_mident_in_module221 = new BitSet(new ulong[]{0x0006100000000002UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_tdef_in_module224 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_module226 = new BitSet(new ulong[]{0x0006100000000002UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_vdefg_in_module232 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_module234 = new BitSet(new ulong[]{0x0000100000000002UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_REC_in_vdefg260 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_LB_in_vdefg262 = new BitSet(new ulong[]{0x0001100000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_qvar_in_vdefg265 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_DCOLON_in_vdefg267 = new BitSet(new ulong[]{0x0010000000000000UL,0x000000000019FC00UL});
    public static readonly BitSet FOLLOW_ty_in_vdefg269 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_EQ_in_vdefg271 = new BitSet(new ulong[]{0xB550100000000000UL,0x0000000000180003UL});
    public static readonly BitSet FOLLOW_exp_in_vdefg273 = new BitSet(new ulong[]{0x0001180000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_vdefg275 = new BitSet(new ulong[]{0x0001100000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_RB_in_vdefg280 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_qvar_in_vdefg300 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_DCOLON_in_vdefg302 = new BitSet(new ulong[]{0x0010000000000000UL,0x000000000019FC00UL});
    public static readonly BitSet FOLLOW_ty_in_vdefg304 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_EQ_in_vdefg306 = new BitSet(new ulong[]{0xB550100000000000UL,0x0000000000180003UL});
    public static readonly BitSet FOLLOW_exp_in_vdefg308 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DATA_in_tdef330 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_qtycon_in_tdef332 = new BitSet(new ulong[]{0x0010800000000000UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_tbind_in_tdef335 = new BitSet(new ulong[]{0x0010800000000000UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_EQ_in_tdef339 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_LB_in_tdef341 = new BitSet(new ulong[]{0x0001000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_cdef_in_tdef344 = new BitSet(new ulong[]{0x0001080000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_tdef346 = new BitSet(new ulong[]{0x0001000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_RB_in_tdef351 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NEWTYPE_in_tdef370 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_qtycon_in_tdef372 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_qtycon_in_tdef374 = new BitSet(new ulong[]{0x0010800000000000UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_tbind_in_tdef377 = new BitSet(new ulong[]{0x0010800000000000UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_EQ_in_tdef381 = new BitSet(new ulong[]{0x0010000000000000UL,0x000000000019FC00UL});
    public static readonly BitSet FOLLOW_ty_in_tdef383 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_qdcon_in_cdef407 = new BitSet(new ulong[]{0x0018000000000002UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_AT_in_cdef410 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_tbind_in_cdef412 = new BitSet(new ulong[]{0x0018000000000002UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_aty_in_cdef419 = new BitSet(new ulong[]{0x0010000000000002UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_qvar_in_aexp450 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_qdcon_in_aexp455 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_literal_in_aexp460 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_aexp465 = new BitSet(new ulong[]{0xB550100000000000UL,0x0000000000180003UL});
    public static readonly BitSet FOLLOW_exp_in_aexp467 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_RP_in_aexp469 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_aexp_in_exp491 = new BitSet(new ulong[]{0x0018100000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_arg_in_exp494 = new BitSet(new ulong[]{0x0018100000000002UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_DSLASH_in_exp515 = new BitSet(new ulong[]{0x0018000000000000UL});
    public static readonly BitSet FOLLOW_binder_in_exp518 = new BitSet(new ulong[]{0x0098000000000000UL});
    public static readonly BitSet FOLLOW_ARROW_in_exp522 = new BitSet(new ulong[]{0xB550100000000000UL,0x0000000000180003UL});
    public static readonly BitSet FOLLOW_exp_in_exp524 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LET_in_exp542 = new BitSet(new ulong[]{0x0000100000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_vdefg_in_exp544 = new BitSet(new ulong[]{0x0200000000000000UL});
    public static readonly BitSet FOLLOW_IN_in_exp546 = new BitSet(new ulong[]{0xB550100000000000UL,0x0000000000180003UL});
    public static readonly BitSet FOLLOW_exp_in_exp548 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CASE_in_exp563 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_aty_in_exp565 = new BitSet(new ulong[]{0xB550100000000000UL,0x0000000000180003UL});
    public static readonly BitSet FOLLOW_exp_in_exp567 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_OF_in_exp569 = new BitSet(new ulong[]{0x0018000000000000UL});
    public static readonly BitSet FOLLOW_vbind_in_exp571 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_LB_in_exp573 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000180040UL});
    public static readonly BitSet FOLLOW_alt_in_exp575 = new BitSet(new ulong[]{0x0001080000000000UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_exp578 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000180040UL});
    public static readonly BitSet FOLLOW_alt_in_exp580 = new BitSet(new ulong[]{0x0001080000000000UL});
    public static readonly BitSet FOLLOW_RB_in_exp584 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CAST_in_exp604 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_LP_in_exp606 = new BitSet(new ulong[]{0xB550100000000000UL,0x0000000000180003UL});
    public static readonly BitSet FOLLOW_exp_in_exp608 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_RP_in_exp610 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_aty_in_exp612 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NOTE_in_exp628 = new BitSet(new ulong[]{0x4000000000000000UL});
    public static readonly BitSet FOLLOW_STRINGLITERAL_in_exp630 = new BitSet(new ulong[]{0xB550100000000000UL,0x0000000000180003UL});
    public static readonly BitSet FOLLOW_exp_in_exp632 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ECALL_in_exp647 = new BitSet(new ulong[]{0x4000000000000000UL});
    public static readonly BitSet FOLLOW_STRINGLITERAL_in_exp649 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_aty_in_exp651 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DECALL_in_exp656 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_aty_in_exp658 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LABEL_in_exp663 = new BitSet(new ulong[]{0x4000000000000000UL});
    public static readonly BitSet FOLLOW_STRINGLITERAL_in_exp665 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_aexp_in_exp670 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_STAR_in_akind683 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SHARP_in_akind688 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_QUESTION_in_akind693 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_bty_in_akind698 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_DCOLONEQ_in_akind700 = new BitSet(new ulong[]{0x0010000000000000UL,0x000000000018FC00UL});
    public static readonly BitSet FOLLOW_bty_in_akind702 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_akind707 = new BitSet(new ulong[]{0x0010000000000000UL,0x000000000018FC1CUL});
    public static readonly BitSet FOLLOW_kind_in_akind709 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_RP_in_akind711 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_akind_in_kind723 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_akind_in_kind728 = new BitSet(new ulong[]{0x0080000000000000UL});
    public static readonly BitSet FOLLOW_ARROW_in_kind730 = new BitSet(new ulong[]{0x0010000000000000UL,0x000000000018FC1CUL});
    public static readonly BitSet FOLLOW_kind_in_kind732 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_AT_in_arg743 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_aty_in_arg745 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_aexp_in_arg759 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_qdcon_in_alt782 = new BitSet(new ulong[]{0x0098000000000000UL});
    public static readonly BitSet FOLLOW_AT_in_alt786 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_tbind_in_alt788 = new BitSet(new ulong[]{0x0098000000000000UL});
    public static readonly BitSet FOLLOW_vbind_in_alt795 = new BitSet(new ulong[]{0x0098000000000000UL});
    public static readonly BitSet FOLLOW_ARROW_in_alt800 = new BitSet(new ulong[]{0xB550100000000000UL,0x0000000000180003UL});
    public static readonly BitSet FOLLOW_exp_in_alt802 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_literal_in_alt825 = new BitSet(new ulong[]{0x0080000000000000UL});
    public static readonly BitSet FOLLOW_ARROW_in_alt827 = new BitSet(new ulong[]{0xB550100000000000UL,0x0000000000180003UL});
    public static readonly BitSet FOLLOW_exp_in_alt829 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PERCENT_ARROW_in_alt844 = new BitSet(new ulong[]{0xB550100000000000UL,0x0000000000180003UL});
    public static readonly BitSet FOLLOW_exp_in_alt846 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_AT_in_binder866 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_tbind_in_binder868 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_vbind_in_binder877 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tyvar_in_tbind892 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_tbind905 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_tyvar_in_tbind907 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_DCOLON_in_tbind909 = new BitSet(new ulong[]{0x0010000000000000UL,0x000000000018FC1CUL});
    public static readonly BitSet FOLLOW_kind_in_tbind911 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_RP_in_tbind913 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_vbind933 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_var_in_vbind935 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_DCOLON_in_vbind937 = new BitSet(new ulong[]{0x0010000000000000UL,0x000000000019FC00UL});
    public static readonly BitSet FOLLOW_ty_in_vbind939 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_RP_in_vbind941 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_literal967 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_INTLITERAL_in_literal969 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_DCOLON_in_literal971 = new BitSet(new ulong[]{0x0010000000000000UL,0x000000000019FC00UL});
    public static readonly BitSet FOLLOW_ty_in_literal973 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_RP_in_literal975 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_literal995 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_INTLITERAL_in_literal997 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_PERCENT_in_literal999 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_INTLITERAL_in_literal1001 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_DCOLON_in_literal1003 = new BitSet(new ulong[]{0x0010000000000000UL,0x000000000019FC00UL});
    public static readonly BitSet FOLLOW_ty_in_literal1005 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_RP_in_literal1007 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_literal1029 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_CHARLITERAL_in_literal1031 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_DCOLON_in_literal1033 = new BitSet(new ulong[]{0x0010000000000000UL,0x000000000019FC00UL});
    public static readonly BitSet FOLLOW_ty_in_literal1035 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_RP_in_literal1037 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_literal1057 = new BitSet(new ulong[]{0x4000000000000000UL});
    public static readonly BitSet FOLLOW_STRINGLITERAL_in_literal1059 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_DCOLON_in_literal1061 = new BitSet(new ulong[]{0x0010000000000000UL,0x000000000019FC00UL});
    public static readonly BitSet FOLLOW_ty_in_literal1063 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_RP_in_literal1065 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_qtycon_in_aty1092 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tyvar_in_aty1105 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_aty1118 = new BitSet(new ulong[]{0x0010000000000000UL,0x000000000019FC00UL});
    public static readonly BitSet FOLLOW_ty_in_aty1120 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_RP_in_aty1122 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_aty_in_bty1142 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_aty_in_bty1144 = new BitSet(new ulong[]{0x0010000000000002UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_aty_in_bty1159 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRANS_in_bty1165 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_aty_in_bty1167 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_aty_in_bty1169 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_aty_in_bty1171 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRANS_in_bty1192 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_aty_in_bty1194 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_aty_in_bty1196 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SYM_in_bty1212 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_aty_in_bty1214 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_aty_in_bty1216 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SYM_in_bty1235 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_aty_in_bty1237 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UNSAFE_in_bty1251 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_aty_in_bty1253 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_aty_in_bty1255 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_aty_in_bty1257 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UNSAFE_in_bty1278 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_aty_in_bty1280 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_aty_in_bty1282 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LEFT_in_bty1298 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_aty_in_bty1300 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_aty_in_bty1302 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LEFT_in_bty1321 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_aty_in_bty1323 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_RIGHT_in_bty1337 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_aty_in_bty1339 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_aty_in_bty1341 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_RIGHT_in_bty1360 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_aty_in_bty1362 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INST_in_bty1376 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_aty_in_bty1378 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_aty_in_bty1380 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_aty_in_bty1382 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INST_in_bty1403 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_aty_in_bty1405 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_aty_in_bty1407 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_bty_in_ty1429 = new BitSet(new ulong[]{0x0080000000000000UL});
    public static readonly BitSet FOLLOW_ARROW_in_ty1431 = new BitSet(new ulong[]{0x0010000000000000UL,0x000000000019FC00UL});
    public static readonly BitSet FOLLOW_ty_in_ty1433 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FORALL_in_ty1448 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_tbind_in_ty1451 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000120000UL});
    public static readonly BitSet FOLLOW_DOT_in_ty1455 = new BitSet(new ulong[]{0x0010000000000000UL,0x000000000019FC00UL});
    public static readonly BitSet FOLLOW_ty_in_ty1457 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_bty_in_ty1473 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_pname_in_mident1483 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_COLON_in_mident1485 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000080000UL});
    public static readonly BitSet FOLLOW_UNAME_in_mident1487 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UNAME_in_tycon1505 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_mident_in_qtycon1513 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_DOT_in_qtycon1515 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000080000UL});
    public static readonly BitSet FOLLOW_tycon_in_qtycon1517 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LNAME_in_tyvar1531 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LNAME_in_var1539 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_mident_in_qvar1556 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_DOT_in_qvar1558 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_LNAME_in_qvar1562 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UNAME_in_dcon1581 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_mident_in_qdcon1598 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_DOT_in_qdcon1600 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000080000UL});
    public static readonly BitSet FOLLOW_UNAME_in_qdcon1602 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_pname0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_aty_in_synpred12_Core419 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_aexp_in_synpred17_Core491 = new BitSet(new ulong[]{0x0018100000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_arg_in_synpred17_Core494 = new BitSet(new ulong[]{0x0018100000000002UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_bty_in_synpred31_Core698 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_DCOLONEQ_in_synpred31_Core700 = new BitSet(new ulong[]{0x0010000000000000UL,0x000000000018FC00UL});
    public static readonly BitSet FOLLOW_bty_in_synpred31_Core702 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_akind_in_synpred32_Core723 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_aty_in_synpred46_Core1142 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_aty_in_synpred46_Core1144 = new BitSet(new ulong[]{0x0010000000000002UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_aty_in_synpred47_Core1159 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRANS_in_synpred48_Core1165 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_aty_in_synpred48_Core1167 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_aty_in_synpred48_Core1169 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_aty_in_synpred48_Core1171 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRANS_in_synpred49_Core1192 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_aty_in_synpred49_Core1194 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_aty_in_synpred49_Core1196 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SYM_in_synpred50_Core1212 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_aty_in_synpred50_Core1214 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_aty_in_synpred50_Core1216 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SYM_in_synpred51_Core1235 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_aty_in_synpred51_Core1237 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UNSAFE_in_synpred52_Core1251 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_aty_in_synpred52_Core1253 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_aty_in_synpred52_Core1255 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_aty_in_synpred52_Core1257 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UNSAFE_in_synpred53_Core1278 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_aty_in_synpred53_Core1280 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_aty_in_synpred53_Core1282 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LEFT_in_synpred54_Core1298 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_aty_in_synpred54_Core1300 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_aty_in_synpred54_Core1302 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LEFT_in_synpred55_Core1321 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_aty_in_synpred55_Core1323 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_RIGHT_in_synpred56_Core1337 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_aty_in_synpred56_Core1339 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_aty_in_synpred56_Core1341 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_RIGHT_in_synpred57_Core1360 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_aty_in_synpred57_Core1362 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INST_in_synpred58_Core1376 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_aty_in_synpred58_Core1378 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_aty_in_synpred58_Core1380 = new BitSet(new ulong[]{0x0010000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_aty_in_synpred58_Core1382 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_bty_in_synpred59_Core1429 = new BitSet(new ulong[]{0x0080000000000000UL});
    public static readonly BitSet FOLLOW_ARROW_in_synpred59_Core1431 = new BitSet(new ulong[]{0x0010000000000000UL,0x000000000019FC00UL});
    public static readonly BitSet FOLLOW_ty_in_synpred59_Core1433 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}