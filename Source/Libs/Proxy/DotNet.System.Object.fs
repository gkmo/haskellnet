
namespace DotNet.System

module Object =     
    
    open Data.Typeable
    
    type Object = System.Object
    
    type ZCTSubObject<'aayD> = ZCDSubObject of 'aayD
    
    let zdfTypeableObject : Lazy<ZCTTypeable<Object>> = lazy (fun _ -> typeof<Object>)
    let zdfSubObjectObject : ZCTSubObject<Object> = ZCDSubObject (null)
    
    let newObject : (unit -> GHC.IOBase.IO<Object>) = 
        fun _ ->
            GHC.Base.hreturn GHC.Base.zdfMonadIO (lazy (new Object()))