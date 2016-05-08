namespace GHC

module Prim =    

    type ImportantGenericArguments = 
        class
            inherit System.Attribute
            
            val mutable Positions : string
            new (str : string) = { Positions = str }
        end
        
    type Intzh = System.Int32
    type Charzh = System.Char
    type Floatzh = System.Single
    type Doublezh = System.Double
    type Addrzh = System.String
    type ByteArrayzh = System.Byte[]
    
    // @State\#@ is the primitive, unlifted type of states.  It has
    // one type parameter, thus @State\# RealWorld@, or @State\# s@,
    // where s is a type variable. The only purpose of the type parameter
    // is to keep different state threads separate.  It is represented by
    // nothing at all. 
    type Statezh<'s> = 
        | State of 's
        
    // @RealWorld@ is deeply magical.  It is /primitive/, but it is not
    // /unlifted/ (hence @ptrArg@).  We never manipulate values of type
    // @RealWorld@; it\'s only used in the type system, to parameterise @State\#@.        
    type RealWorld = unit
         
    let realWorldzh : Statezh<RealWorld> = State ()
             
    type Z2H<'a, 'b> =
        | Z2H of 'a * 'b
        
    type Z4H<'a, 'b, 'c, 'd> =
        | Z4H of 'a * 'b * 'c * 'd
                
    let inline zezezh (a : Intzh) (b : Intzh) = a = b
    let inline zszezh (a : Intzh) (b : Intzh) = a <> b
    let inline zlzezh (a : Intzh) (b : Intzh) = a <= b
    let inline zgzezh (a : Intzh) (b : Intzh) = a >= b
    let inline zlzh   (a : Intzh) (b : Intzh) = a < b
    let inline zgzh   (a : Intzh) (b : Intzh) = a > b
    let inline zpzh   (a : Intzh) (b : Intzh) = a + b
    let inline zmzh   (a : Intzh) (b : Intzh) = a - b
    let inline ztzh   (a : Intzh) (b : Intzh) = a * b
    let inline quotIntzh   (a : Intzh) (b : Intzh) = a / b
    let inline remIntzh    (a : Intzh) (b : Intzh) = a % b
    let inline negateIntzh (a : Intzh) = -a
    let inline chrzh (a : Intzh) = System.Convert.ToChar(a)
    let inline gtCharzh (a : Charzh) (b : Charzh) = a > b
    let inline geCharzh (a : Charzh) (b : Charzh) = a >= b
    let inline ltCharzh (a : Charzh) (b : Charzh) = a < b
    let inline leCharzh (a : Charzh) (b : Charzh) = a <= b
    let inline eqCharzh (a : Charzh) (b : Charzh) = a = b
    
    let inline ordzh (a : Charzh) = System.Convert.ToInt32(a)
    
    // TODO: implement BigInteger to Int32
    let integer2Intzh : Intzh -> ByteArrayzh -> Intzh = 
        fun i b -> i
        
    // TODO: implement BigInteger to Int32        
    let int2Integerzh : Intzh -> Z2H<Intzh, ByteArrayzh> = 
        fun i -> Z2H (i, null)
    
    // TODO: implement BigInteger to Int32            
    let addIntCzh : Intzh -> Intzh -> Z2H<Intzh, ByteArrayzh> = 
        fun x y -> Z2H (x + y, null)

    // TODO: implement BigInteger to Int32                    
    let mulIntMayOflozh : Intzh -> Intzh -> Intzh =
        fun x y -> x * y
    
    // TODO: implement BigInteger to Int32                
    let cmpIntegerIntzh : Intzh -> ByteArrayzh -> Intzh -> Intzh =
        fun i b a -> (i).CompareTo(a)
        
    let timesIntegerzh : Intzh -> ByteArrayzh -> Intzh -> ByteArrayzh -> Z2H<Intzh, ByteArrayzh> = 
        fun ai ab bi bb ->
            Z2H (ai * bi, null)
        
    // TODO: implement BigInteger to Int32                        
    let quotRemIntegerzh : Intzh -> ByteArrayzh -> Intzh -> ByteArrayzh -> Z4H<Intzh, ByteArrayzh, Intzh, ByteArrayzh> =
        fun ai ab bi bb ->
            let result = System.Math.DivRem(ai, bi) in
                match result with
                | (d, r) -> Z4H (d, null, r, null)