
namespace DotNet.System.Windows.Forms

module Control = 

    open System.Windows.Forms
    open Data.Typeable
    open DotNet.System.Object
    
    // Type definition
    type Control = System.Windows.Forms.Control    
    type ZCTSubControl<'aayD> = ZCDSubControl of 'aayD    
    let zdf1 : Lazy<ZCTTypeable<Control>> = lazy (fun _ -> typeof<Control>)
    let zdf2 : Lazy<ZCTSubObject<Control>> = lazy ZCDSubObject (null)
    let zdf3 : Lazy<ZCTSubControl<Control>> = lazy ZCDSubControl (null)
    
    // Methods
    let newControl : (unit -> GHC.IOBase.IO<Control>) = 
        fun _ ->
            GHC.Base.hreturn GHC.Base.zdfMonadIO (lazy (new Control()))
            
    let getText<'cayy when 'cayy :> Control> : Lazy<ZCTSubControl<'cayy>> -> Lazy<'cayy> -> GHC.IOBase.IO<GHC.Types.ZMZN<GHC.Types.Char>> = 
        fun _ control ->
            GHC.Base.hreturn GHC.Base.zdfMonadIO (lazy GHC.Base.unpackCStringzh (control.Force()).Text)

    let setText<'cayy when 'cayy :> Control> : Lazy<ZCTSubControl<'cayy>> -> Lazy<GHC.Types.ZMZN<GHC.Types.Char>> -> Lazy<'cayy> -> GHC.IOBase.IO<unit> = 
        fun _ text control ->
            GHC.Base.hreturn GHC.Base.zdfMonadIO (lazy (control.Force()).Text <- GHC.Base.packCStringzh (text.Force()))