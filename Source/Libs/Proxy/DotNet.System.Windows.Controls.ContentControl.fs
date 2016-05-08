
namespace DotNet.System.Windows.Controls

module ContentControl =                
              
    open Data.Typeable
    open DotNet.System.Object
    open DotNet.System.Windows.FrameworkElement
    open DotNet.System.Uri    
    
    // Type definition
    type ContentControl = System.Windows.Controls.ContentControl  
    type ZCTSubContentControl<'aayD> = ZCDSubContentControl of 'aayD    
    let zdfTypeableContentControl : Lazy<ZCTTypeable<ContentControl>> = lazy (fun _ -> typeof<ContentControl>)
    let zdfSubFrameworkElementContentControl : Lazy<ZCTSubFrameworkElement<ContentControl>>= lazy ZCDSubFrameworkElement (null)    
    let zdfSubObjectContentControl : Lazy<ZCTSubObject<ContentControl>>= lazy ZCDSubObject (null)
    let zdfSubContentControlContentControl : Lazy<ZCTSubContentControl<ContentControl>> = lazy ZCDSubContentControl (null)

    // Methods    
    let getContent<'cayy when 'cayy :> ContentControl> : Lazy<ZCTSubContentControl<'cayy>> -> Lazy<'cayy> -> GHC.IOBase.IO<Object> = 
        fun _ control ->
            GHC.Base.hreturn GHC.Base.zdfMonadIO (lazy (control.Force()).Content)

    let setContent<'cayy when 'cayy :> ContentControl> : Lazy<ZCTSubContentControl<'cayy>> -> Lazy<GHC.Types.ZMZN<GHC.Types.Char>> -> Lazy<'cayy> -> GHC.IOBase.IO<unit> = 
        fun _ content control ->
            GHC.Base.hreturn GHC.Base.zdfMonadIO (lazy (control.Force()).Content <- (GHC.Base.packCStringzh (content.Force())))

