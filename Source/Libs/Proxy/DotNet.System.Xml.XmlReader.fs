
namespace DotNet.System.Xml

module XmlReader =     
    
    open Data.Typeable
    open DotNet.System.Object
    
    type XmlReader = System.Xml.XmlReader    
    
    type ZCTSubXmlReader<'aayD> = ZCDSubXmlReader of 'aayD
    
    let zdf1 : Lazy<ZCTTypeable<XmlReader>> = lazy (fun _ -> typeof<XmlReader>)
    let zdf2 : Lazy<ZCTSubObject<XmlReader>>= lazy ZCDSubObject (null)
    let zdf3 : Lazy<ZCTSubXmlReader<XmlReader>> = lazy ZCDSubXmlReader (null)
    
    let create : Lazy<GHC.Types.ZMZN<GHC.Types.Char>> -> GHC.IOBase.IO<XmlReader> = 
        fun path ->
            GHC.Base.hreturn GHC.Base.zdfMonadIO (lazy (XmlReader.Create(GHC.Base.packCStringzh (path.Force()))))
            
    let close : Lazy<XmlReader> -> GHC.IOBase.IO<unit> = 
        fun reader ->
            GHC.Base.hreturn GHC.Base.zdfMonadIO (lazy (reader.Force().Close()))