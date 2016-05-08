namespace Data

module Typeable = 
    
    //type TyCon = TyCon of GHC.Prim.Intzh * Lazy<GHC.Types.ZMZN<GHC.Types.Char>>
    
    //type TypeRep = TypeRep of GHC.Prim.Intzh * Lazy<TyCon> * Lazy<GHC.Types.ZMZN<TypeRep>>
    
    type TypeRep = System.Type
    
    type ZCCoZCTTypeable<'aaHr> = Lazy<'aaHr> -> TypeRep
    
    type ZCTTypeable<'aaHr> = ZCCoZCTTypeable<'aaHr>
    
    let cast<'aaHN, 'baHO> : Lazy<ZCTTypeable<'aaHN>> -> Lazy<ZCTTypeable<'baHO>> -> Lazy<'aaHN> -> Data.Maybe.Maybe<'baHO> = 
        fun zddTypeablea1s4 zddTypeable1a1s5 xaLg ->
            match box (xaLg.Force()) with
            | :? 'baHO as x -> Data.Maybe.Just (lazy x)
            | _ -> Data.Maybe.Nothing