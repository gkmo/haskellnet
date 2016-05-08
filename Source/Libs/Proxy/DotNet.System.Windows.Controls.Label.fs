
namespace DotNet.System.Windows.Controls

module Label =                
              
    open Data.Typeable
    open DotNet.System.Object    
    open DotNet.System.Windows.FrameworkElement
    open DotNet.System.Windows.Controls.ContentControl
    
    // Type definition
    type Label = System.Windows.Controls.Label  
    type ZCTSubLabel<'aayD> = ZCDSubLabel of 'aayD    
    let zdfTypeableLabel : Lazy<ZCTTypeable<Label>> = lazy (fun _ -> typeof<Label>)
    let zdfSubFrameworkElementLabel : Lazy<ZCTSubFrameworkElement<Label>>= lazy ZCDSubFrameworkElement (null)    
    let zdfSubContentControlLabel : Lazy<ZCTSubContentControl<Label>>= lazy ZCDSubContentControl (null)
    let zdfSubObjectLabel : Lazy<ZCTSubObject<Label>>= lazy ZCDSubObject (null)
    let zdfSubLabelLabel : Lazy<ZCTSubLabel<Label>> = lazy ZCDSubLabel (null)

    // Methods    
    let newLabel : unit -> GHC.IOBase.IO<Label> = 
        fun handler ->
            GHC.Base.hreturn GHC.Base.zdfMonadIO (lazy (new Label())) 

