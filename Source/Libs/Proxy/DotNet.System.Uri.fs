
namespace DotNet.System

module Uri =     
    
    open Data.Typeable
    open DotNet.System.Object
    
    type Uri = System.Uri
    type UriKind = System.UriKind
    
    type ZCTSubUri<'aayD> = ZCDSubUri of 'aayD
    
    let zdfTypeableUri : Lazy<ZCTTypeable<Uri>> = lazy (fun _ -> typeof<Uri>)
    let zdfSubObjectUri : Lazy<ZCTSubObject<Uri>>= lazy ZCDSubObject (null)
    let zdfSubUriUri : Lazy<ZCTSubUri<Uri>> = lazy ZCDSubUri (null)
    
    let newUri : Lazy<GHC.Types.ZMZN<GHC.Types.Char>> -> Lazy<UriKind> -> GHC.IOBase.IO<Uri> = 
        fun path kind ->
            GHC.Base.hreturn GHC.Base.zdfMonadIO (lazy (new Uri(GHC.Base.packCStringzh (path.Force()), kind.Force())))