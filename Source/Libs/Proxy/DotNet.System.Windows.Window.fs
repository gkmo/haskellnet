
namespace DotNet.System.Windows

module Window =                
              
    open Data.Typeable
    open DotNet.System.Object
    open DotNet.System.Uri    
    open DotNet.System.Windows.FrameworkElement
    
    // Type definition
    type Window = System.Windows.Window  
    type ZCTSubWindow<'aayD> = ZCDSubWindow of 'aayD    
    let zdfTypeableWindow : Lazy<ZCTTypeable<Window>> = lazy (fun _ -> typeof<Window>)
    let zdfSubFrameworkElementWindow : Lazy<ZCTSubFrameworkElement<Window>> = lazy ZCDSubFrameworkElement (null)
    let zdfSubObjectWindow : Lazy<ZCTSubObject<Window>>= lazy ZCDSubObject (null)
    let zdfSubWindowWindow : Lazy<ZCTSubWindow<Window>> = lazy ZCDSubWindow (null)

    // Methods    
    let newWindow : unit -> GHC.IOBase.IO<Window> = 
        fun handler ->
            GHC.Base.hreturn GHC.Base.zdfMonadIO (lazy (new Window())) 

    let show : Lazy<Window> -> GHC.IOBase.IO<unit> = 
        fun window ->
            GHC.Base.hreturn GHC.Base.zdfMonadIO (lazy (window.Force()).Show())
                     
    let activate : Lazy<Window> -> GHC.IOBase.IO<GHC.Bool.Bool> = 
        fun window ->
            GHC.Base.hreturn GHC.Base.zdfMonadIO (lazy (window.Force()).Activate())
                                                            
    let close : Lazy<Window> -> GHC.IOBase.IO<unit> = 
        fun window ->
            GHC.Base.hreturn GHC.Base.zdfMonadIO (lazy (window.Force()).Close())
            
    let getTitle : Lazy<Window> -> GHC.IOBase.IO<GHC.Types.ZMZN<GHC.Types.Char>> = 
        fun window ->
            GHC.Base.hreturn GHC.Base.zdfMonadIO (lazy (GHC.Base.unpackCStringzh (window.Force()).Title))
                        
    let setTitle : Lazy<GHC.Types.ZMZN<GHC.Types.Char>> -> Lazy<Window> -> GHC.IOBase.IO<unit> = 
        fun title window ->
            GHC.Base.hreturn GHC.Base.zdfMonadIO (lazy (window.Force()).Title <- (GHC.Base.packCStringzh (title.Force())))               