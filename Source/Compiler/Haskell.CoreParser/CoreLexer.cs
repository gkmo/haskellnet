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


namespace  Haskell.CoreParser 
{
public partial class CoreLexer : Lexer {
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
    public const int CHARLITERAL = 73;
    public const int TK_LIT_STRING = 16;
    public const int TK_DEFAULT_ALTERNATIVE = 33;
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
    public const int LET = 56;
    public const int DATA = 49;
    public const int DCOLONEQ = 69;

    // delegates
    // delegators

    public CoreLexer() 
    {
		InitializeCyclicDFAs();
    }
    public CoreLexer(ICharStream input)
		: this(input, null) {
    }
    public CoreLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state) {
		InitializeCyclicDFAs(); 

    }
    
    override public string GrammarFileName
    {
    	get { return "Core.g";} 
    }

    // $ANTLR start "MODULE"
    public void mMODULE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MODULE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Core.g:185:2: ( '%module' )
            // Core.g:185:4: '%module'
            {
            	Match("%module"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MODULE"

    // $ANTLR start "REC"
    public void mREC() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = REC;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Core.g:187:2: ( '%rec' )
            // Core.g:187:4: '%rec'
            {
            	Match("%rec"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "REC"

    // $ANTLR start "DATA"
    public void mDATA() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DATA;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Core.g:189:2: ( '%data' )
            // Core.g:189:4: '%data'
            {
            	Match("%data"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DATA"

    // $ANTLR start "NEWTYPE"
    public void mNEWTYPE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NEWTYPE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Core.g:191:2: ( '%newtype' )
            // Core.g:191:4: '%newtype'
            {
            	Match("%newtype"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NEWTYPE"

    // $ANTLR start "PERCENT_ARROW"
    public void mPERCENT_ARROW() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = PERCENT_ARROW;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Core.g:193:2: ( '%_ ->' )
            // Core.g:193:4: '%_ ->'
            {
            	Match("%_ ->"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "PERCENT_ARROW"

    // $ANTLR start "DSLASH"
    public void mDSLASH() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DSLASH;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Core.g:195:2: ( '\\\\' )
            // Core.g:195:4: '\\\\'
            {
            	Match('\\'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DSLASH"

    // $ANTLR start "LET"
    public void mLET() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LET;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Core.g:197:2: ( '%let' )
            // Core.g:197:4: '%let'
            {
            	Match("%let"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LET"

    // $ANTLR start "IN"
    public void mIN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = IN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Core.g:199:2: ( '%in' )
            // Core.g:199:4: '%in'
            {
            	Match("%in"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "IN"

    // $ANTLR start "OF"
    public void mOF() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = OF;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Core.g:201:2: ( '%of' )
            // Core.g:201:4: '%of'
            {
            	Match("%of"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "OF"

    // $ANTLR start "CASE"
    public void mCASE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = CASE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Core.g:203:2: ( '%case' )
            // Core.g:203:4: '%case'
            {
            	Match("%case"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "CASE"

    // $ANTLR start "CAST"
    public void mCAST() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = CAST;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Core.g:205:2: ( '%cast' )
            // Core.g:205:4: '%cast'
            {
            	Match("%cast"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "CAST"

    // $ANTLR start "NOTE"
    public void mNOTE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NOTE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Core.g:207:2: ( '%note' )
            // Core.g:207:4: '%note'
            {
            	Match("%note"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NOTE"

    // $ANTLR start "ECALL"
    public void mECALL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ECALL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Core.g:209:2: ( '%external ccall' )
            // Core.g:209:4: '%external ccall'
            {
            	Match("%external ccall"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ECALL"

    // $ANTLR start "DECALL"
    public void mDECALL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DECALL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Core.g:211:2: ( '%dynexternal ccall' )
            // Core.g:211:4: '%dynexternal ccall'
            {
            	Match("%dynexternal ccall"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DECALL"

    // $ANTLR start "LABEL"
    public void mLABEL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LABEL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Core.g:213:2: ( '%label' )
            // Core.g:213:4: '%label'
            {
            	Match("%label"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LABEL"

    // $ANTLR start "SYM"
    public void mSYM() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SYM;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Core.g:215:2: ( '%sym' )
            // Core.g:215:4: '%sym'
            {
            	Match("%sym"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SYM"

    // $ANTLR start "FORALL"
    public void mFORALL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = FORALL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Core.g:217:2: ( '%forall' )
            // Core.g:217:4: '%forall'
            {
            	Match("%forall"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "FORALL"

    // $ANTLR start "LEFT"
    public void mLEFT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LEFT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Core.g:219:2: ( '%left' )
            // Core.g:219:4: '%left'
            {
            	Match("%left"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LEFT"

    // $ANTLR start "RIGHT"
    public void mRIGHT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = RIGHT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Core.g:221:2: ( '%right' )
            // Core.g:221:4: '%right'
            {
            	Match("%right"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "RIGHT"

    // $ANTLR start "INST"
    public void mINST() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = INST;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Core.g:223:2: ( '%inst' )
            // Core.g:223:4: '%inst'
            {
            	Match("%inst"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "INST"

    // $ANTLR start "TRANS"
    public void mTRANS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = TRANS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Core.g:225:2: ( '%trans' )
            // Core.g:225:4: '%trans'
            {
            	Match("%trans"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "TRANS"

    // $ANTLR start "UNSAFE"
    public void mUNSAFE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = UNSAFE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Core.g:227:2: ( '%unsafe' )
            // Core.g:227:4: '%unsafe'
            {
            	Match("%unsafe"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "UNSAFE"

    // $ANTLR start "STAR"
    public void mSTAR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = STAR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Core.g:229:2: ( '*' )
            // Core.g:229:4: '*'
            {
            	Match('*'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "STAR"

    // $ANTLR start "SHARP"
    public void mSHARP() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SHARP;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Core.g:231:2: ( '#' )
            // Core.g:231:4: '#'
            {
            	Match('#'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SHARP"

    // $ANTLR start "QUESTION"
    public void mQUESTION() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = QUESTION;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Core.g:233:2: ( '?' )
            // Core.g:233:4: '?'
            {
            	Match('?'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "QUESTION"

    // $ANTLR start "DCOLONEQ"
    public void mDCOLONEQ() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DCOLONEQ;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Core.g:235:2: ( ':=:' )
            // Core.g:235:4: ':=:'
            {
            	Match(":=:"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DCOLONEQ"

    // $ANTLR start "SEMICOLON"
    public void mSEMICOLON() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SEMICOLON;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Core.g:238:2: ( ';' )
            // Core.g:238:4: ';'
            {
            	Match(';'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SEMICOLON"

    // $ANTLR start "PERCENT"
    public void mPERCENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = PERCENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Core.g:240:2: ( '%' )
            // Core.g:240:4: '%'
            {
            	Match('%'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "PERCENT"

    // $ANTLR start "COLON"
    public void mCOLON() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = COLON;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Core.g:242:2: ( ':' )
            // Core.g:242:4: ':'
            {
            	Match(':'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "COLON"

    // $ANTLR start "DOT"
    public void mDOT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DOT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Core.g:244:2: ( '.' )
            // Core.g:244:4: '.'
            {
            	Match('.'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DOT"

    // $ANTLR start "LP"
    public void mLP() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LP;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Core.g:246:2: ( '(' )
            // Core.g:246:4: '('
            {
            	Match('('); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LP"

    // $ANTLR start "RP"
    public void mRP() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = RP;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Core.g:248:2: ( ')' )
            // Core.g:248:4: ')'
            {
            	Match(')'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "RP"

    // $ANTLR start "LB"
    public void mLB() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LB;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Core.g:250:2: ( '{' )
            // Core.g:250:4: '{'
            {
            	Match('{'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LB"

    // $ANTLR start "RB"
    public void mRB() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = RB;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Core.g:252:2: ( '}' )
            // Core.g:252:4: '}'
            {
            	Match('}'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "RB"

    // $ANTLR start "DCOLON"
    public void mDCOLON() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DCOLON;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Core.g:254:2: ( '::' )
            // Core.g:254:4: '::'
            {
            	Match("::"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DCOLON"

    // $ANTLR start "ARROW"
    public void mARROW() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ARROW;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Core.g:256:2: ( '->' )
            // Core.g:256:4: '->'
            {
            	Match("->"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ARROW"

    // $ANTLR start "EQ"
    public void mEQ() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = EQ;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Core.g:258:2: ( '=' )
            // Core.g:258:4: '='
            {
            	Match('='); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "EQ"

    // $ANTLR start "AT"
    public void mAT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = AT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Core.g:260:2: ( '@' )
            // Core.g:260:4: '@'
            {
            	Match('@'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "AT"

    // $ANTLR start "MINUS"
    public void mMINUS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MINUS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Core.g:262:2: ( '-' )
            // Core.g:262:4: '-'
            {
            	Match('-'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MINUS"

    // $ANTLR start "INTLITERAL"
    public void mINTLITERAL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = INTLITERAL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Core.g:265:5: ( ( MINUS )? IntegerNumber )
            // Core.g:265:9: ( MINUS )? IntegerNumber
            {
            	// Core.g:265:9: ( MINUS )?
            	int alt1 = 2;
            	int LA1_0 = input.LA(1);

            	if ( (LA1_0 == '-') )
            	{
            	    alt1 = 1;
            	}
            	switch (alt1) 
            	{
            	    case 1 :
            	        // Core.g:265:9: MINUS
            	        {
            	        	mMINUS(); 

            	        }
            	        break;

            	}

            	mIntegerNumber(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "INTLITERAL"

    // $ANTLR start "LNAME"
    public void mLNAME() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LNAME;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Core.g:269:5: ( LowLetter ( '0' .. '9' | LowLetter | UpperLetter | '_' )* )
            // Core.g:269:7: LowLetter ( '0' .. '9' | LowLetter | UpperLetter | '_' )*
            {
            	mLowLetter(); 
            	// Core.g:269:17: ( '0' .. '9' | LowLetter | UpperLetter | '_' )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( ((LA2_0 >= '0' && LA2_0 <= '9') || (LA2_0 >= 'A' && LA2_0 <= 'Z') || LA2_0 == '_' || (LA2_0 >= 'a' && LA2_0 <= 'z')) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // Core.g:
            			    {
            			    	if ( (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop2;
            	    }
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whining that label 'loop2' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LNAME"

    // $ANTLR start "UNAME"
    public void mUNAME() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = UNAME;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Core.g:272:5: ( UpperLetter ( '0' .. '9' | LowLetter | UpperLetter | '_' )* )
            // Core.g:272:7: UpperLetter ( '0' .. '9' | LowLetter | UpperLetter | '_' )*
            {
            	mUpperLetter(); 
            	// Core.g:272:19: ( '0' .. '9' | LowLetter | UpperLetter | '_' )*
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( ((LA3_0 >= '0' && LA3_0 <= '9') || (LA3_0 >= 'A' && LA3_0 <= 'Z') || LA3_0 == '_' || (LA3_0 >= 'a' && LA3_0 <= 'z')) )
            	    {
            	        alt3 = 1;
            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // Core.g:
            			    {
            			    	if ( (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop3;
            	    }
            	} while (true);

            	loop3:
            		;	// Stops C# compiler whining that label 'loop3' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "UNAME"

    // $ANTLR start "LowLetter"
    public void mLowLetter() // throws RecognitionException [2]
    {
    		try
    		{
            // Core.g:276:5: ( 'a' .. 'z' )
            // Core.g:276:8: 'a' .. 'z'
            {
            	MatchRange('a','z'); 

            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "LowLetter"

    // $ANTLR start "UpperLetter"
    public void mUpperLetter() // throws RecognitionException [2]
    {
    		try
    		{
            // Core.g:280:5: ( 'A' .. 'Z' )
            // Core.g:280:8: 'A' .. 'Z'
            {
            	MatchRange('A','Z'); 

            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "UpperLetter"

    // $ANTLR start "IntegerNumber"
    public void mIntegerNumber() // throws RecognitionException [2]
    {
    		try
    		{
            // Core.g:284:5: ( '0' | '1' .. '9' ( '0' .. '9' )* | '0' ( '0' .. '7' )+ | HexPrefix ( HexDigit )+ )
            int alt7 = 4;
            int LA7_0 = input.LA(1);

            if ( (LA7_0 == '0') )
            {
                switch ( input.LA(2) ) 
                {
                case 'X':
                case 'x':
                	{
                    alt7 = 4;
                    }
                    break;
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                	{
                    alt7 = 3;
                    }
                    break;
                	default:
                    	alt7 = 1;
                    	break;}

            }
            else if ( ((LA7_0 >= '1' && LA7_0 <= '9')) )
            {
                alt7 = 2;
            }
            else 
            {
                NoViableAltException nvae_d7s0 =
                    new NoViableAltException("", 7, 0, input);

                throw nvae_d7s0;
            }
            switch (alt7) 
            {
                case 1 :
                    // Core.g:284:9: '0'
                    {
                    	Match('0'); 

                    }
                    break;
                case 2 :
                    // Core.g:285:9: '1' .. '9' ( '0' .. '9' )*
                    {
                    	MatchRange('1','9'); 
                    	// Core.g:285:18: ( '0' .. '9' )*
                    	do 
                    	{
                    	    int alt4 = 2;
                    	    int LA4_0 = input.LA(1);

                    	    if ( ((LA4_0 >= '0' && LA4_0 <= '9')) )
                    	    {
                    	        alt4 = 1;
                    	    }


                    	    switch (alt4) 
                    		{
                    			case 1 :
                    			    // Core.g:285:19: '0' .. '9'
                    			    {
                    			    	MatchRange('0','9'); 

                    			    }
                    			    break;

                    			default:
                    			    goto loop4;
                    	    }
                    	} while (true);

                    	loop4:
                    		;	// Stops C# compiler whining that label 'loop4' has no statements


                    }
                    break;
                case 3 :
                    // Core.g:286:9: '0' ( '0' .. '7' )+
                    {
                    	Match('0'); 
                    	// Core.g:286:13: ( '0' .. '7' )+
                    	int cnt5 = 0;
                    	do 
                    	{
                    	    int alt5 = 2;
                    	    int LA5_0 = input.LA(1);

                    	    if ( ((LA5_0 >= '0' && LA5_0 <= '7')) )
                    	    {
                    	        alt5 = 1;
                    	    }


                    	    switch (alt5) 
                    		{
                    			case 1 :
                    			    // Core.g:286:14: '0' .. '7'
                    			    {
                    			    	MatchRange('0','7'); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt5 >= 1 ) goto loop5;
                    		            EarlyExitException eee5 =
                    		                new EarlyExitException(5, input);
                    		            throw eee5;
                    	    }
                    	    cnt5++;
                    	} while (true);

                    	loop5:
                    		;	// Stops C# compiler whining that label 'loop5' has no statements


                    }
                    break;
                case 4 :
                    // Core.g:287:9: HexPrefix ( HexDigit )+
                    {
                    	mHexPrefix(); 
                    	// Core.g:287:19: ( HexDigit )+
                    	int cnt6 = 0;
                    	do 
                    	{
                    	    int alt6 = 2;
                    	    int LA6_0 = input.LA(1);

                    	    if ( ((LA6_0 >= '0' && LA6_0 <= '9') || (LA6_0 >= 'A' && LA6_0 <= 'F') || (LA6_0 >= 'a' && LA6_0 <= 'f')) )
                    	    {
                    	        alt6 = 1;
                    	    }


                    	    switch (alt6) 
                    		{
                    			case 1 :
                    			    // Core.g:287:19: HexDigit
                    			    {
                    			    	mHexDigit(); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt6 >= 1 ) goto loop6;
                    		            EarlyExitException eee6 =
                    		                new EarlyExitException(6, input);
                    		            throw eee6;
                    	    }
                    	    cnt6++;
                    	} while (true);

                    	loop6:
                    		;	// Stops C# compiler whining that label 'loop6' has no statements


                    }
                    break;

            }
        }
        finally 
    	{
        }
    }
    // $ANTLR end "IntegerNumber"

    // $ANTLR start "CHARLITERAL"
    public void mCHARLITERAL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = CHARLITERAL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Core.g:291:5: ( '\\'' ( EscapeSequence | ~ ( '\\'' | '\\\\' | '\\r' | '\\n' ) | '\\\\x' HexDigit HexDigit ) '\\'' )
            // Core.g:291:9: '\\'' ( EscapeSequence | ~ ( '\\'' | '\\\\' | '\\r' | '\\n' ) | '\\\\x' HexDigit HexDigit ) '\\''
            {
            	Match('\''); 
            	// Core.g:292:9: ( EscapeSequence | ~ ( '\\'' | '\\\\' | '\\r' | '\\n' ) | '\\\\x' HexDigit HexDigit )
            	int alt8 = 3;
            	int LA8_0 = input.LA(1);

            	if ( (LA8_0 == '\\') )
            	{
            	    int LA8_1 = input.LA(2);

            	    if ( (LA8_1 == 'x') )
            	    {
            	        alt8 = 3;
            	    }
            	    else if ( (LA8_1 == '\"' || LA8_1 == '\'' || (LA8_1 >= '0' && LA8_1 <= '7') || LA8_1 == '\\' || LA8_1 == 'b' || LA8_1 == 'f' || LA8_1 == 'n' || LA8_1 == 'r' || LA8_1 == 't') )
            	    {
            	        alt8 = 1;
            	    }
            	    else 
            	    {
            	        NoViableAltException nvae_d8s1 =
            	            new NoViableAltException("", 8, 1, input);

            	        throw nvae_d8s1;
            	    }
            	}
            	else if ( ((LA8_0 >= '\u0000' && LA8_0 <= '\t') || (LA8_0 >= '\u000B' && LA8_0 <= '\f') || (LA8_0 >= '\u000E' && LA8_0 <= '&') || (LA8_0 >= '(' && LA8_0 <= '[') || (LA8_0 >= ']' && LA8_0 <= '\uFFFF')) )
            	{
            	    alt8 = 2;
            	}
            	else 
            	{
            	    NoViableAltException nvae_d8s0 =
            	        new NoViableAltException("", 8, 0, input);

            	    throw nvae_d8s0;
            	}
            	switch (alt8) 
            	{
            	    case 1 :
            	        // Core.g:292:13: EscapeSequence
            	        {
            	        	mEscapeSequence(); 

            	        }
            	        break;
            	    case 2 :
            	        // Core.g:293:13: ~ ( '\\'' | '\\\\' | '\\r' | '\\n' )
            	        {
            	        	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '\t') || (input.LA(1) >= '\u000B' && input.LA(1) <= '\f') || (input.LA(1) >= '\u000E' && input.LA(1) <= '&') || (input.LA(1) >= '(' && input.LA(1) <= '[') || (input.LA(1) >= ']' && input.LA(1) <= '\uFFFF') ) 
            	        	{
            	        	    input.Consume();

            	        	}
            	        	else 
            	        	{
            	        	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	        	    Recover(mse);
            	        	    throw mse;}


            	        }
            	        break;
            	    case 3 :
            	        // Core.g:294:12: '\\\\x' HexDigit HexDigit
            	        {
            	        	Match("\\x"); 

            	        	mHexDigit(); 
            	        	mHexDigit(); 

            	        }
            	        break;

            	}

            	Match('\''); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "CHARLITERAL"

    // $ANTLR start "STRINGLITERAL"
    public void mSTRINGLITERAL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = STRINGLITERAL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Core.g:300:5: ( '\"' ( EscapeSequence | ~ ( '\\\\' | '\"' | '\\r' | '\\n' ) | '\\\\x' HexDigit HexDigit )* '\"' )
            // Core.g:300:9: '\"' ( EscapeSequence | ~ ( '\\\\' | '\"' | '\\r' | '\\n' ) | '\\\\x' HexDigit HexDigit )* '\"'
            {
            	Match('\"'); 
            	// Core.g:301:9: ( EscapeSequence | ~ ( '\\\\' | '\"' | '\\r' | '\\n' ) | '\\\\x' HexDigit HexDigit )*
            	do 
            	{
            	    int alt9 = 4;
            	    int LA9_0 = input.LA(1);

            	    if ( (LA9_0 == '\\') )
            	    {
            	        int LA9_2 = input.LA(2);

            	        if ( (LA9_2 == 'x') )
            	        {
            	            alt9 = 3;
            	        }
            	        else if ( (LA9_2 == '\"' || LA9_2 == '\'' || (LA9_2 >= '0' && LA9_2 <= '7') || LA9_2 == '\\' || LA9_2 == 'b' || LA9_2 == 'f' || LA9_2 == 'n' || LA9_2 == 'r' || LA9_2 == 't') )
            	        {
            	            alt9 = 1;
            	        }


            	    }
            	    else if ( ((LA9_0 >= '\u0000' && LA9_0 <= '\t') || (LA9_0 >= '\u000B' && LA9_0 <= '\f') || (LA9_0 >= '\u000E' && LA9_0 <= '!') || (LA9_0 >= '#' && LA9_0 <= '[') || (LA9_0 >= ']' && LA9_0 <= '\uFFFF')) )
            	    {
            	        alt9 = 2;
            	    }


            	    switch (alt9) 
            		{
            			case 1 :
            			    // Core.g:301:13: EscapeSequence
            			    {
            			    	mEscapeSequence(); 

            			    }
            			    break;
            			case 2 :
            			    // Core.g:302:13: ~ ( '\\\\' | '\"' | '\\r' | '\\n' )
            			    {
            			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '\t') || (input.LA(1) >= '\u000B' && input.LA(1) <= '\f') || (input.LA(1) >= '\u000E' && input.LA(1) <= '!') || (input.LA(1) >= '#' && input.LA(1) <= '[') || (input.LA(1) >= ']' && input.LA(1) <= '\uFFFF') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;
            			case 3 :
            			    // Core.g:303:13: '\\\\x' HexDigit HexDigit
            			    {
            			    	Match("\\x"); 

            			    	mHexDigit(); 
            			    	mHexDigit(); 

            			    }
            			    break;

            			default:
            			    goto loop9;
            	    }
            	} while (true);

            	loop9:
            		;	// Stops C# compiler whining that label 'loop9' has no statements

            	Match('\"'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "STRINGLITERAL"

    // $ANTLR start "HexPrefix"
    public void mHexPrefix() // throws RecognitionException [2]
    {
    		try
    		{
            // Core.g:310:5: ( '0x' | '0X' )
            int alt10 = 2;
            int LA10_0 = input.LA(1);

            if ( (LA10_0 == '0') )
            {
                int LA10_1 = input.LA(2);

                if ( (LA10_1 == 'x') )
                {
                    alt10 = 1;
                }
                else if ( (LA10_1 == 'X') )
                {
                    alt10 = 2;
                }
                else 
                {
                    NoViableAltException nvae_d10s1 =
                        new NoViableAltException("", 10, 1, input);

                    throw nvae_d10s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d10s0 =
                    new NoViableAltException("", 10, 0, input);

                throw nvae_d10s0;
            }
            switch (alt10) 
            {
                case 1 :
                    // Core.g:310:9: '0x'
                    {
                    	Match("0x"); 


                    }
                    break;
                case 2 :
                    // Core.g:310:16: '0X'
                    {
                    	Match("0X"); 


                    }
                    break;

            }
        }
        finally 
    	{
        }
    }
    // $ANTLR end "HexPrefix"

    // $ANTLR start "HexDigit"
    public void mHexDigit() // throws RecognitionException [2]
    {
    		try
    		{
            // Core.g:315:5: ( ( '0' .. '9' | 'a' .. 'f' | 'A' .. 'F' ) )
            // Core.g:315:9: ( '0' .. '9' | 'a' .. 'f' | 'A' .. 'F' )
            {
            	if ( (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'F') || (input.LA(1) >= 'a' && input.LA(1) <= 'f') ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "HexDigit"

    // $ANTLR start "NEWLINE"
    public void mNEWLINE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NEWLINE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Core.g:318:9: ( ( '\\r' )? '\\n' )
            // Core.g:318:10: ( '\\r' )? '\\n'
            {
            	// Core.g:318:10: ( '\\r' )?
            	int alt11 = 2;
            	int LA11_0 = input.LA(1);

            	if ( (LA11_0 == '\r') )
            	{
            	    alt11 = 1;
            	}
            	switch (alt11) 
            	{
            	    case 1 :
            	        // Core.g:318:10: '\\r'
            	        {
            	        	Match('\r'); 

            	        }
            	        break;

            	}

            	Match('\n'); 
            	Skip();

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NEWLINE"

    // $ANTLR start "EscapeSequence"
    public void mEscapeSequence() // throws RecognitionException [2]
    {
    		try
    		{
            // Core.g:322:5: ( '\\\\' ( 'b' | 't' | 'n' | 'f' | 'r' | '\\\"' | '\\'' | '\\\\' | ( '0' .. '3' ) ( '0' .. '7' ) ( '0' .. '7' ) | ( '0' .. '7' ) ( '0' .. '7' ) | ( '0' .. '7' ) ) )
            // Core.g:322:9: '\\\\' ( 'b' | 't' | 'n' | 'f' | 'r' | '\\\"' | '\\'' | '\\\\' | ( '0' .. '3' ) ( '0' .. '7' ) ( '0' .. '7' ) | ( '0' .. '7' ) ( '0' .. '7' ) | ( '0' .. '7' ) )
            {
            	Match('\\'); 
            	// Core.g:322:14: ( 'b' | 't' | 'n' | 'f' | 'r' | '\\\"' | '\\'' | '\\\\' | ( '0' .. '3' ) ( '0' .. '7' ) ( '0' .. '7' ) | ( '0' .. '7' ) ( '0' .. '7' ) | ( '0' .. '7' ) )
            	int alt12 = 11;
            	alt12 = dfa12.Predict(input);
            	switch (alt12) 
            	{
            	    case 1 :
            	        // Core.g:323:18: 'b'
            	        {
            	        	Match('b'); 

            	        }
            	        break;
            	    case 2 :
            	        // Core.g:324:18: 't'
            	        {
            	        	Match('t'); 

            	        }
            	        break;
            	    case 3 :
            	        // Core.g:325:18: 'n'
            	        {
            	        	Match('n'); 

            	        }
            	        break;
            	    case 4 :
            	        // Core.g:326:18: 'f'
            	        {
            	        	Match('f'); 

            	        }
            	        break;
            	    case 5 :
            	        // Core.g:327:18: 'r'
            	        {
            	        	Match('r'); 

            	        }
            	        break;
            	    case 6 :
            	        // Core.g:328:18: '\\\"'
            	        {
            	        	Match('\"'); 

            	        }
            	        break;
            	    case 7 :
            	        // Core.g:329:18: '\\''
            	        {
            	        	Match('\''); 

            	        }
            	        break;
            	    case 8 :
            	        // Core.g:330:18: '\\\\'
            	        {
            	        	Match('\\'); 

            	        }
            	        break;
            	    case 9 :
            	        // Core.g:332:18: ( '0' .. '3' ) ( '0' .. '7' ) ( '0' .. '7' )
            	        {
            	        	// Core.g:332:18: ( '0' .. '3' )
            	        	// Core.g:332:19: '0' .. '3'
            	        	{
            	        		MatchRange('0','3'); 

            	        	}

            	        	// Core.g:332:29: ( '0' .. '7' )
            	        	// Core.g:332:30: '0' .. '7'
            	        	{
            	        		MatchRange('0','7'); 

            	        	}

            	        	// Core.g:332:40: ( '0' .. '7' )
            	        	// Core.g:332:41: '0' .. '7'
            	        	{
            	        		MatchRange('0','7'); 

            	        	}


            	        }
            	        break;
            	    case 10 :
            	        // Core.g:334:18: ( '0' .. '7' ) ( '0' .. '7' )
            	        {
            	        	// Core.g:334:18: ( '0' .. '7' )
            	        	// Core.g:334:19: '0' .. '7'
            	        	{
            	        		MatchRange('0','7'); 

            	        	}

            	        	// Core.g:334:29: ( '0' .. '7' )
            	        	// Core.g:334:30: '0' .. '7'
            	        	{
            	        		MatchRange('0','7'); 

            	        	}


            	        }
            	        break;
            	    case 11 :
            	        // Core.g:336:18: ( '0' .. '7' )
            	        {
            	        	// Core.g:336:18: ( '0' .. '7' )
            	        	// Core.g:336:19: '0' .. '7'
            	        	{
            	        		MatchRange('0','7'); 

            	        	}


            	        }
            	        break;

            	}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "EscapeSequence"

    // $ANTLR start "WS"
    public void mWS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Core.g:341:5: ( ( ' ' | '\\r' | '\\t' | '\\u000C' | '\\n' ) )
            // Core.g:341:9: ( ' ' | '\\r' | '\\t' | '\\u000C' | '\\n' )
            {
            	if ( (input.LA(1) >= '\t' && input.LA(1) <= '\n') || (input.LA(1) >= '\f' && input.LA(1) <= '\r') || input.LA(1) == ' ' ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            	                Skip();
            	            

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "WS"

    override public void mTokens() // throws RecognitionException 
    {
        // Core.g:1:8: ( MODULE | REC | DATA | NEWTYPE | PERCENT_ARROW | DSLASH | LET | IN | OF | CASE | CAST | NOTE | ECALL | DECALL | LABEL | SYM | FORALL | LEFT | RIGHT | INST | TRANS | UNSAFE | STAR | SHARP | QUESTION | DCOLONEQ | SEMICOLON | PERCENT | COLON | DOT | LP | RP | LB | RB | DCOLON | ARROW | EQ | AT | MINUS | INTLITERAL | LNAME | UNAME | CHARLITERAL | STRINGLITERAL | NEWLINE | WS )
        int alt13 = 46;
        alt13 = dfa13.Predict(input);
        switch (alt13) 
        {
            case 1 :
                // Core.g:1:10: MODULE
                {
                	mMODULE(); 

                }
                break;
            case 2 :
                // Core.g:1:17: REC
                {
                	mREC(); 

                }
                break;
            case 3 :
                // Core.g:1:21: DATA
                {
                	mDATA(); 

                }
                break;
            case 4 :
                // Core.g:1:26: NEWTYPE
                {
                	mNEWTYPE(); 

                }
                break;
            case 5 :
                // Core.g:1:34: PERCENT_ARROW
                {
                	mPERCENT_ARROW(); 

                }
                break;
            case 6 :
                // Core.g:1:48: DSLASH
                {
                	mDSLASH(); 

                }
                break;
            case 7 :
                // Core.g:1:55: LET
                {
                	mLET(); 

                }
                break;
            case 8 :
                // Core.g:1:59: IN
                {
                	mIN(); 

                }
                break;
            case 9 :
                // Core.g:1:62: OF
                {
                	mOF(); 

                }
                break;
            case 10 :
                // Core.g:1:65: CASE
                {
                	mCASE(); 

                }
                break;
            case 11 :
                // Core.g:1:70: CAST
                {
                	mCAST(); 

                }
                break;
            case 12 :
                // Core.g:1:75: NOTE
                {
                	mNOTE(); 

                }
                break;
            case 13 :
                // Core.g:1:80: ECALL
                {
                	mECALL(); 

                }
                break;
            case 14 :
                // Core.g:1:86: DECALL
                {
                	mDECALL(); 

                }
                break;
            case 15 :
                // Core.g:1:93: LABEL
                {
                	mLABEL(); 

                }
                break;
            case 16 :
                // Core.g:1:99: SYM
                {
                	mSYM(); 

                }
                break;
            case 17 :
                // Core.g:1:103: FORALL
                {
                	mFORALL(); 

                }
                break;
            case 18 :
                // Core.g:1:110: LEFT
                {
                	mLEFT(); 

                }
                break;
            case 19 :
                // Core.g:1:115: RIGHT
                {
                	mRIGHT(); 

                }
                break;
            case 20 :
                // Core.g:1:121: INST
                {
                	mINST(); 

                }
                break;
            case 21 :
                // Core.g:1:126: TRANS
                {
                	mTRANS(); 

                }
                break;
            case 22 :
                // Core.g:1:132: UNSAFE
                {
                	mUNSAFE(); 

                }
                break;
            case 23 :
                // Core.g:1:139: STAR
                {
                	mSTAR(); 

                }
                break;
            case 24 :
                // Core.g:1:144: SHARP
                {
                	mSHARP(); 

                }
                break;
            case 25 :
                // Core.g:1:150: QUESTION
                {
                	mQUESTION(); 

                }
                break;
            case 26 :
                // Core.g:1:159: DCOLONEQ
                {
                	mDCOLONEQ(); 

                }
                break;
            case 27 :
                // Core.g:1:168: SEMICOLON
                {
                	mSEMICOLON(); 

                }
                break;
            case 28 :
                // Core.g:1:178: PERCENT
                {
                	mPERCENT(); 

                }
                break;
            case 29 :
                // Core.g:1:186: COLON
                {
                	mCOLON(); 

                }
                break;
            case 30 :
                // Core.g:1:192: DOT
                {
                	mDOT(); 

                }
                break;
            case 31 :
                // Core.g:1:196: LP
                {
                	mLP(); 

                }
                break;
            case 32 :
                // Core.g:1:199: RP
                {
                	mRP(); 

                }
                break;
            case 33 :
                // Core.g:1:202: LB
                {
                	mLB(); 

                }
                break;
            case 34 :
                // Core.g:1:205: RB
                {
                	mRB(); 

                }
                break;
            case 35 :
                // Core.g:1:208: DCOLON
                {
                	mDCOLON(); 

                }
                break;
            case 36 :
                // Core.g:1:215: ARROW
                {
                	mARROW(); 

                }
                break;
            case 37 :
                // Core.g:1:221: EQ
                {
                	mEQ(); 

                }
                break;
            case 38 :
                // Core.g:1:224: AT
                {
                	mAT(); 

                }
                break;
            case 39 :
                // Core.g:1:227: MINUS
                {
                	mMINUS(); 

                }
                break;
            case 40 :
                // Core.g:1:233: INTLITERAL
                {
                	mINTLITERAL(); 

                }
                break;
            case 41 :
                // Core.g:1:244: LNAME
                {
                	mLNAME(); 

                }
                break;
            case 42 :
                // Core.g:1:250: UNAME
                {
                	mUNAME(); 

                }
                break;
            case 43 :
                // Core.g:1:256: CHARLITERAL
                {
                	mCHARLITERAL(); 

                }
                break;
            case 44 :
                // Core.g:1:268: STRINGLITERAL
                {
                	mSTRINGLITERAL(); 

                }
                break;
            case 45 :
                // Core.g:1:282: NEWLINE
                {
                	mNEWLINE(); 

                }
                break;
            case 46 :
                // Core.g:1:290: WS
                {
                	mWS(); 

                }
                break;

        }

    }


    protected DFA12 dfa12;
    protected DFA13 dfa13;
	private void InitializeCyclicDFAs()
	{
	    this.dfa12 = new DFA12(this);
	    this.dfa13 = new DFA13(this);
	}

    const string DFA12_eotS =
        "\x09\uffff\x02\x0b\x01\uffff\x01\x0d\x02\uffff";
    const string DFA12_eofS =
        "\x0f\uffff";
    const string DFA12_minS =
        "\x01\x22\x08\uffff\x02\x30\x01\uffff\x01\x30\x02\uffff";
    const string DFA12_maxS =
        "\x01\x74\x08\uffff\x02\x37\x01\uffff\x01\x37\x02\uffff";
    const string DFA12_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01"+
        "\x07\x01\x08\x02\uffff\x01\x0b\x01\uffff\x01\x0a\x01\x09";
    const string DFA12_specialS =
        "\x0f\uffff}>";
    static readonly string[] DFA12_transitionS = {
            "\x01\x06\x04\uffff\x01\x07\x08\uffff\x04\x09\x04\x0a\x24\uffff"+
            "\x01\x08\x05\uffff\x01\x01\x03\uffff\x01\x04\x07\uffff\x01\x03"+
            "\x03\uffff\x01\x05\x01\uffff\x01\x02",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x08\x0c",
            "\x08\x0d",
            "",
            "\x08\x0e",
            "",
            ""
    };

    static readonly short[] DFA12_eot = DFA.UnpackEncodedString(DFA12_eotS);
    static readonly short[] DFA12_eof = DFA.UnpackEncodedString(DFA12_eofS);
    static readonly char[] DFA12_min = DFA.UnpackEncodedStringToUnsignedChars(DFA12_minS);
    static readonly char[] DFA12_max = DFA.UnpackEncodedStringToUnsignedChars(DFA12_maxS);
    static readonly short[] DFA12_accept = DFA.UnpackEncodedString(DFA12_acceptS);
    static readonly short[] DFA12_special = DFA.UnpackEncodedString(DFA12_specialS);
    static readonly short[][] DFA12_transition = DFA.UnpackEncodedStringArray(DFA12_transitionS);

    protected class DFA12 : DFA
    {
        public DFA12(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 12;
            this.eot = DFA12_eot;
            this.eof = DFA12_eof;
            this.min = DFA12_min;
            this.max = DFA12_max;
            this.accept = DFA12_accept;
            this.special = DFA12_special;
            this.transition = DFA12_transition;

        }

        override public string Description
        {
            get { return "322:14: ( 'b' | 't' | 'n' | 'f' | 'r' | '\\\"' | '\\'' | '\\\\' | ( '0' .. '3' ) ( '0' .. '7' ) ( '0' .. '7' ) | ( '0' .. '7' ) ( '0' .. '7' ) | ( '0' .. '7' ) )"; }
        }

    }

    const string DFA13_eotS =
        "\x01\uffff\x01\x26\x04\uffff\x01\x29\x06\uffff\x01\x2b\x07\uffff"+
        "\x01\x17\x1f\uffff\x01\x3a\x08\uffff";
    const string DFA13_eofS =
        "\x3e\uffff";
    const string DFA13_minS =
        "\x01\x09\x01\x5f\x04\uffff\x01\x3a\x06\uffff\x01\x30\x07\uffff"+
        "\x01\x0a\x03\uffff\x01\x65\x01\x61\x01\x65\x01\uffff\x01\x61\x01"+
        "\x6e\x01\uffff\x01\x61\x12\uffff\x01\x66\x01\uffff\x02\x73\x04\uffff"+
        "\x01\x65\x02\uffff";
    const string DFA13_maxS =
        "\x01\x7d\x01\x75\x04\uffff\x01\x3d\x06\uffff\x01\x3e\x07\uffff"+
        "\x01\x0a\x03\uffff\x01\x69\x01\x79\x01\x6f\x01\uffff\x01\x65\x01"+
        "\x6e\x01\uffff\x01\x61\x12\uffff\x01\x74\x01\uffff\x02\x73\x04\uffff"+
        "\x01\x74\x02\uffff";
    const string DFA13_acceptS =
        "\x02\uffff\x01\x06\x01\x17\x01\x18\x01\x19\x01\uffff\x01\x1b\x01"+
        "\x1e\x01\x1f\x01\x20\x01\x21\x01\x22\x01\uffff\x01\x25\x01\x26\x01"+
        "\x28\x01\x29\x01\x2a\x01\x2b\x01\x2c\x01\uffff\x01\x2d\x01\x2e\x01"+
        "\x01\x03\uffff\x01\x05\x02\uffff\x01\x09\x01\uffff\x01\x0d\x01\x10"+
        "\x01\x11\x01\x15\x01\x16\x01\x1c\x01\x1a\x01\x23\x01\x1d\x01\x24"+
        "\x01\x27\x01\x2d\x01\x02\x01\x13\x01\x03\x01\x0e\x01\x04\x01\x0c"+
        "\x01\uffff\x01\x0f\x02\uffff\x01\x07\x01\x12\x01\x14\x01\x08\x01"+
        "\uffff\x01\x0a\x01\x0b";
    const string DFA13_specialS =
        "\x3e\uffff}>";
    static readonly string[] DFA13_transitionS = {
            "\x01\x17\x01\x16\x01\uffff\x01\x17\x01\x15\x12\uffff\x01\x17"+
            "\x01\uffff\x01\x14\x01\x04\x01\uffff\x01\x01\x01\uffff\x01\x13"+
            "\x01\x09\x01\x0a\x01\x03\x02\uffff\x01\x0d\x01\x08\x01\uffff"+
            "\x0a\x10\x01\x06\x01\x07\x01\uffff\x01\x0e\x01\uffff\x01\x05"+
            "\x01\x0f\x1a\x12\x01\uffff\x01\x02\x04\uffff\x1a\x11\x01\x0b"+
            "\x01\uffff\x01\x0c",
            "\x01\x1c\x03\uffff\x01\x20\x01\x1a\x01\x21\x01\x23\x02\uffff"+
            "\x01\x1e\x02\uffff\x01\x1d\x01\x18\x01\x1b\x01\x1f\x02\uffff"+
            "\x01\x19\x01\x22\x01\x24\x01\x25",
            "",
            "",
            "",
            "",
            "\x01\x28\x02\uffff\x01\x27",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x0a\x10\x04\uffff\x01\x2a",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x2c",
            "",
            "",
            "",
            "\x01\x2d\x03\uffff\x01\x2e",
            "\x01\x2f\x17\uffff\x01\x30",
            "\x01\x31\x09\uffff\x01\x32",
            "",
            "\x01\x34\x03\uffff\x01\x33",
            "\x01\x35",
            "",
            "\x01\x36",
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
            "",
            "",
            "",
            "",
            "",
            "\x01\x38\x0d\uffff\x01\x37",
            "",
            "\x01\x39",
            "\x01\x3b",
            "",
            "",
            "",
            "",
            "\x01\x3c\x0e\uffff\x01\x3d",
            "",
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
            get { return "1:1: Tokens : ( MODULE | REC | DATA | NEWTYPE | PERCENT_ARROW | DSLASH | LET | IN | OF | CASE | CAST | NOTE | ECALL | DECALL | LABEL | SYM | FORALL | LEFT | RIGHT | INST | TRANS | UNSAFE | STAR | SHARP | QUESTION | DCOLONEQ | SEMICOLON | PERCENT | COLON | DOT | LP | RP | LB | RB | DCOLON | ARROW | EQ | AT | MINUS | INTLITERAL | LNAME | UNAME | CHARLITERAL | STRINGLITERAL | NEWLINE | WS );"; }
        }

    }

 
    
}
}