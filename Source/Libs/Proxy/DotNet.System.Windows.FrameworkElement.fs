
namespace DotNet.System.Windows

module FrameworkElement =                
              
    open Data.Typeable
    open DotNet.System.Object
    
    // Type definition
    type FrameworkElement = System.Windows.FrameworkElement  
    type ZCTSubFrameworkElement<'aayD> = ZCDSubFrameworkElement of 'aayD    
    let zdf1 : Lazy<ZCTTypeable<FrameworkElement>> = lazy (fun _ -> typeof<FrameworkElement>)
    let zdf2 : Lazy<ZCTSubObject<FrameworkElement>>= lazy ZCDSubObject (null)
    let zdf3 : Lazy<ZCTSubFrameworkElement<FrameworkElement>> = lazy ZCDSubFrameworkElement (null)

    // Methods    
    let findName<'e when 'e :> FrameworkElement> : Lazy<ZCTSubFrameworkElement<'e>> -> Lazy<GHC.Types.ZMZN<GHC.Types.Char>> -> Lazy<'e> -> GHC.IOBase.IO<Object> =
        fun _ name element ->
            GHC.Base.hreturn GHC.Base.zdfMonadIO (lazy (element.Force()).FindName(GHC.Base.packCStringzh (name.Force())))