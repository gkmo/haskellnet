
namespace DotNet.System.Windows.Controls

module TextBox =                
              
    open Data.Typeable
    open DotNet.System.Object    
    open DotNet.System.Windows.FrameworkElement
    open DotNet.System.Windows.Controls.ContentControl
    
    // Type definition
    type TextBox = System.Windows.Controls.TextBox  
    type ZCTSubTextBox<'aayD> = ZCDSubTextBox of 'aayD    
    let zdfTypeableTextBox : Lazy<ZCTTypeable<TextBox>> = lazy (fun _ -> typeof<TextBox>)
    let zdfSubFrameworkElementTextBox : Lazy<ZCTSubFrameworkElement<TextBox>>= lazy ZCDSubFrameworkElement (null)    
    let zdfSubObjectTextBox : Lazy<ZCTSubObject<TextBox>>= lazy ZCDSubObject (null)
    let zdfSubTextBoxTextBox : Lazy<ZCTSubTextBox<TextBox>> = lazy ZCDSubTextBox (null)

    // Methods    
    let newTextBox : unit -> GHC.IOBase.IO<TextBox> = 
        fun handler ->
            GHC.Base.hreturn GHC.Base.zdfMonadIO (lazy (new TextBox())) 

    let getText<'cayy when 'cayy :> TextBox> : Lazy<ZCTSubTextBox<'cayy>> -> Lazy<'cayy> -> GHC.IOBase.IO<GHC.Types.ZMZN<GHC.Types.Char>> = 
        fun _ control ->
            GHC.Base.hreturn GHC.Base.zdfMonadIO (lazy GHC.Base.unpackCStringzh (control.Force()).Text)

    let setText<'cayy when 'cayy :> TextBox> : Lazy<ZCTSubTextBox<'cayy>> -> Lazy<GHC.Types.ZMZN<GHC.Types.Char>> -> Lazy<'cayy> -> GHC.IOBase.IO<unit> = 
        fun _ content control ->
            GHC.Base.hreturn GHC.Base.zdfMonadIO (lazy (control.Force()).Text <- (GHC.Base.packCStringzh (content.Force())))
