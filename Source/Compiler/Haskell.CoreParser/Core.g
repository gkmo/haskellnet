grammar Core;

options
{
	language=CSharp2;
	//language=Java;
	output=AST;
	ASTLabelType=CommonTree;
	backtrack=true;
}

tokens 
{
	TK_MODULE;
	TK_VALUE_DEF;
	TK_REC_VALUE_DEF;
	TK_ALGEBRIC_TYPE;
	TK_NEW_TYPE;
	TK_CONSTRUCTOR_DEF;
	TK_APPLICATION;
	TK_ABSTRACTION;
	TK_TYPE_BINDER;
	TK_VALUE_BINDER;
	TK_LIT_INTEGER;
	TK_LIT_RATIONAL;
	TK_LIT_STRING;
	TK_LIT_CHAR;
	TK_MODULE_IDENTIFIER;
	TK_VARIABLE;
	TK_ATOMIC_TYPE;
	TK_TYPE_ABSTRACTION;
	TK_ARROW_TYPE_CONSTRUCTION;
	TK_TYPE_APPLICATION;
	TK_NESTED_TYPE;
	TK_TRANSITIVE_COERCION;
	TK_SYMMETRIC_COERCION;
	TK_UNSAFE_COERCION;
	TK_LEFT_COERCION;
	TK_RIGHT_COERCION;
	TK_INSTANTIATION_COERCION;
	TK_CASE_EXPRESSION;
	TK_NESTED_EXPRESSION;	
	TK_DEFAULT_ALTERNATIVE;
	TK_LITERAL_ALTERNATIVE;
	TK_CONSTRUCTOR_ALTERNATIVE;
	TK_TYPE_ARG;
	TK_VALUE_ARG;
	TK_LOCAL_DEFINITION;
	TK_NOTE;
	TK_DATA_CONSTRUCTOR;
	TK_CAST;
}


@lexer::namespace { Haskell.CoreParser }
@parser::namespace { Haskell.CoreParser }

module	
	: MODULE mident (tdef SEMICOLON)* ( vdefg SEMICOLON)* -> ^(TK_MODULE mident tdef* vdefg*);

vdefg 
	: REC LB (qvar DCOLON ty EQ exp SEMICOLON?)* RB -> (^(TK_REC_VALUE_DEF qvar ty exp))*
	| qvar DCOLON ty EQ exp -> ^(TK_VALUE_DEF qvar ty exp);

tdef 
	: DATA qtycon (tbind)* EQ LB (cdef SEMICOLON?)* RB -> ^(TK_ALGEBRIC_TYPE qtycon tbind* cdef*)
	| NEWTYPE qtycon qtycon (tbind)* EQ ty -> ^(TK_NEW_TYPE qtycon qtycon tbind*);

// Constr. defn. 
cdef 
	: qdcon (AT tbind )* ( aty )* -> ^(TK_CONSTRUCTOR_DEF qdcon tbind* aty*);

//vdef
//	: qvar DCOLON ty EQ exp -> ^(TK_VALUE_DEF qvar ty exp);

// Atomic Expression
aexp 
	: qvar
	| qdcon
	| literal
	| LP exp RP -> ^(TK_NESTED_EXPRESSION exp);
	
	
exp 	
	: aexp (arg)+ -> ^(TK_APPLICATION aexp (arg)+)	
	| DSLASH (binder)+ ARROW exp -> ^(TK_ABSTRACTION exp (binder)+)
	| LET vdefg IN exp -> ^(TK_LOCAL_DEFINITION vdefg exp)
	| CASE aty exp OF vbind LB alt (SEMICOLON alt)* RB -> ^(TK_CASE_EXPRESSION aty exp vbind alt+)
	| CAST LP exp RP aty -> ^(TK_CAST exp aty) // Ignore cast expressions (%cast has no operational meaning and is only used in typechecking. [Core - 6.10.pdf])
	| NOTE STRINGLITERAL exp -> ^(TK_NOTE STRINGLITERAL exp)
	| ECALL STRINGLITERAL aty
	| DECALL aty
	| LABEL STRINGLITERAL
	| aexp;
		
// Atomic Kind
akind 
	: STAR
	| SHARP
	| QUESTION
	| bty DCOLONEQ bty
	| LP kind RP;
	
// Kind
kind 
	: akind
	| akind ARROW kind;

// Argument 
arg 
	: AT aty -> ^(TK_TYPE_ARG aty) // type argument
	| aexp -> ^(TK_VALUE_ARG aexp);  //value argument
	
// Case alt. 
alt 	
	: qdcon ( AT tbind )* ( vbind )* ARROW exp ->  ^(TK_CONSTRUCTOR_ALTERNATIVE qdcon exp tbind* vbind*) // constructor alternative
	| literal ARROW exp -> ^(TK_LITERAL_ALTERNATIVE literal exp)// literal alternative
	| PERCENT_ARROW exp -> ^(TK_DEFAULT_ALTERNATIVE exp); //default alternative

// Binder 
binder 
	: AT tbind -> tbind
	| vbind -> vbind;

// Type Binder
tbind 
	: tyvar -> ^(TK_TYPE_BINDER tyvar)
	| LP tyvar DCOLON kind RP -> ^(TK_TYPE_BINDER tyvar kind);

// Value binder 
vbind 	: LP var DCOLON ty RP -> ^(TK_VALUE_BINDER var ty);

// Literal 
literal 
    :   LP INTLITERAL DCOLON ty RP -> ^(TK_LIT_INTEGER ty INTLITERAL)// integer
    |   LP INTLITERAL PERCENT INTLITERAL DCOLON ty RP -> ^(TK_LIT_RATIONAL ty INTLITERAL INTLITERAL)//rational
    |   LP CHARLITERAL DCOLON ty RP -> ^(TK_LIT_CHAR ty CHARLITERAL)//character
    |   LP STRINGLITERAL DCOLON ty RP -> ^(TK_LIT_STRING ty STRINGLITERAL) //string
    ;

// Atomic Type
aty 
	: qtycon -> ^(TK_ATOMIC_TYPE qtycon)
	| tyvar -> ^(TK_ATOMIC_TYPE tyvar)
	| LP ty RP -> ^(TK_NESTED_TYPE ty);

// Basic Type
bty 	
	: aty aty+ -> ^(TK_TYPE_APPLICATION aty*)
	| aty	
	| TRANS aty aty aty -> ^(TK_TYPE_APPLICATION ^(TK_TRANSITIVE_COERCION aty aty) aty)
	| TRANS aty aty -> ^(TK_TRANSITIVE_COERCION aty aty)	
	| SYM aty aty -> ^(TK_TYPE_APPLICATION ^(TK_SYMMETRIC_COERCION aty) aty)
	| SYM aty -> ^(TK_SYMMETRIC_COERCION aty)	
	| UNSAFE aty aty aty -> ^(TK_TYPE_APPLICATION ^(TK_UNSAFE_COERCION aty aty) aty)
	| UNSAFE aty aty -> ^(TK_UNSAFE_COERCION aty aty)	
	| LEFT aty aty -> ^(TK_TYPE_APPLICATION ^(TK_LEFT_COERCION aty) aty)
	| LEFT aty -> ^(TK_LEFT_COERCION aty)	
	| RIGHT aty aty -> ^(TK_TYPE_APPLICATION ^(TK_RIGHT_COERCION aty) aty)
	| RIGHT aty -> ^(TK_RIGHT_COERCION aty)	
	| INST aty aty aty -> ^(TK_TYPE_APPLICATION ^(TK_INSTANTIATION_COERCION aty aty) aty)
	| INST aty aty -> ^(TK_INSTANTIATION_COERCION aty aty);


// Type 	
ty 
	: bty ARROW ty -> ^(TK_ARROW_TYPE_CONSTRUCTION bty ty)
	| FORALL (tbind)+ DOT ty -> ^(TK_TYPE_ABSTRACTION ty tbind*)
	| bty;

// Identifiers

mident	: pname COLON UNAME -> ^(TK_MODULE_IDENTIFIER pname UNAME);
tycon 	: UNAME;
qtycon 	: mident DOT tycon -> tycon mident;
tyvar 	: LNAME;
var 	: LNAME -> ^(TK_VARIABLE LNAME);
qvar 	: (mident DOT)? LNAME -> ^(TK_VARIABLE LNAME mident?);
dcon 	: UNAME -> ^(TK_DATA_CONSTRUCTOR UNAME);
qdcon   : mident DOT UNAME -> ^(TK_DATA_CONSTRUCTOR UNAME mident);
	
pname   : LNAME | UNAME;

MODULE	
	: '%module';
REC
	: '%rec';
DATA
	: '%data';	
NEWTYPE
	: '%newtype';
PERCENT_ARROW
	: '%_ ->';	
DSLASH
	: '\\';
LET
	: '%let';
IN	
	: '%in';
OF	
	: '%of';		
CASE
	: '%case';	
CAST
	: '%cast';
NOTE
	: '%note';	
ECALL
	: '%external ccall';	
DECALL
	: '%dynexternal ccall';	
LABEL
	: '%label';	
SYM
	: '%sym';	
FORALL	
	: '%forall';
LEFT	
	: '%left';
RIGHT	
	: '%right';
INST
	: '%inst';
TRANS
	: '%trans';	
UNSAFE
	: '%unsafe';	
STAR
	: '*';
SHARP
	: '#';
QUESTION
	: '?';
DCOLONEQ 
	: ':=:';
	
SEMICOLON
	: ';';
PERCENT
	: '%';
COLON	
	: ':';
DOT	
	: '.';
LP	
	: '(';
RP	
	: ')';
LB
	: '{';
RB
	: '}';
DCOLON
	: '::';
ARROW
	: '->';	
EQ
	: '=';
AT
	: '@';
MINUS
	: '-';	
		
INTLITERAL
    :   MINUS? IntegerNumber 
    ;    	   
    
LNAME
    : LowLetter ('0'..'9' | LowLetter | UpperLetter | '_')*;
    
UNAME
    : UpperLetter ('0'..'9' | LowLetter | UpperLetter | '_')*;

fragment
LowLetter
    :  'a'..'z';
    
fragment
UpperLetter
    :  'A'..'Z';
    
fragment
IntegerNumber
    :   '0' 
    |   '1'..'9' ('0'..'9')*    
    |   '0' ('0'..'7')+         
    |   HexPrefix HexDigit+        
    ;

CHARLITERAL
    :   '\'' 
        (   EscapeSequence 
        |   ~( '\'' | '\\' | '\r' | '\n' )
        |  '\\x' HexDigit HexDigit
        ) 
        '\''
    ; 

STRINGLITERAL
    :   '"' 
        (   EscapeSequence
        |   ~( '\\' | '"' | '\r' | '\n' )
        |   '\\x' HexDigit HexDigit        
        )* 
        '"' 
    ;

fragment
HexPrefix
    :   '0x' | '0X'
    ;

fragment
HexDigit
    :   ('0'..'9'|'a'..'f'|'A'..'F')
    ;

NEWLINE	:'\r' ? '\n' {Skip();};

fragment
EscapeSequence 
    :   '\\' (
                 'b' 
             |   't' 
             |   'n' 
             |   'f' 
             |   'r' 
             |   '\"' 
             |   '\'' 
             |   '\\' 
             |       
                 ('0'..'3') ('0'..'7') ('0'..'7')
             |       
                 ('0'..'7') ('0'..'7') 
             |       
                 ('0'..'7')
             )          
;     

WS  
    :   (
             ' '
        |    '\r'
        |    '\t'
        |    '\u000C'
        |    '\n'
        ) 
            {
                Skip();
            }          
    ;

