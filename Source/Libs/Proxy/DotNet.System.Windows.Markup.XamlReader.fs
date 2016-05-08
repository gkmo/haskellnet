
namespace DotNet.System.Windows.Markup

module XamlReader =     
    
    open Data.Typeable
        
    open DotNet.System.Object
    open DotNet.System.Xml.XmlReader
    
    type XamlReader = System.Windows.Markup.XamlReader    
    
    type ZCTSubXamlReader<'aayD> = ZCDSubXamlReader of 'aayD
    
    let zdf1 : Lazy<ZCTTypeable<XamlReader>> = lazy (fun _ -> typeof<XamlReader>)
    let zdf2 : Lazy<ZCTSubObject<XamlReader>>= lazy ZCDSubObject (null)
    let zdf3 : Lazy<ZCTSubXamlReader<XamlReader>> = lazy ZCDSubXamlReader (null)
    
    let load : Lazy<XmlReader> -> GHC.IOBase.IO<Object> = 
        fun reader ->
            GHC.Base.hreturn GHC.Base.zdfMonadIO (lazy (XamlReader.Load(reader.Force())))