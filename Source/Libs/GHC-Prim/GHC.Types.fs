// Learn more about F# at http://fsharp.net

namespace GHC  
    
module Types = 
    open Prim
    open Generics
    
    type Int = Izh of Intzh
        with        
        override this.ToString() = 
            match this with
            | Izh (x) -> (x).ToString()
                
    type Char = Czh of Charzh
        with        
        override this.ToString() = 
            match this with
            | Czh x -> (x).ToString()
            
    type Float = Fzh of Floatzh
        with        
            override this.ToString() = 
                match this with
                | Fzh (x) -> (x).ToString()
                
    type Double = Dzh of Doublezh
        with        
            override this.ToString() = 
                match this with
                | Dzh (x) -> (x).ToString()
     
    type ZMZN<'a> = 
        | ZMZN
        | ZC of Lazy<'a> * Lazy<ZMZN<'a>>
    
    let inline lvl<'a> = 
        lazy(ZCzpZC<Unit, ZCztZC<'a, ZMZN<'a>>>.Inl (lazy(Unit)))
    
    let zdgtoZMZN<'a> (x : Lazy<ZCzpZC<Unit, ZCztZC<'a, ZMZN<'a>>>>) = 
        lazy
        (
            match x.Force() with
            | Inl (Lazy(Unit)) -> ZMZN
            | Inr g4aV -> 
                match g4aV.Force() with
                | ZCztZC (g2aY, g3a10) -> ZC (g2aY, g3a10)
        )
        
    let zdgfromZMZN<'a> (x : Lazy<ZMZN<'a>>) = 
        lazy
        (
            match x.Force() with        
            | ZMZN -> lvl<'a>.Force()
            | ZC (g2aA, g3aC) -> ZCzpZC<Unit, ZCztZC<'a, ZMZN<'a>>>.Inr (lazy(ZCztZC (g2aA, g3aC)))
        )