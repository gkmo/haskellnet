
namespace DotNet.System.Windows

module Application =                
          
    open System              
    open Data.Typeable
    open DotNet.System.Object
    open DotNet.System.Uri    
    open DotNet.System.Windows.Window
    
    // Type definition
    type Application = System.Windows.Application  
    type ZCTSubApplication<'aayD> = ZCDSubApplication of 'aayD    
    let zdfTypeableApplication : Lazy<ZCTTypeable<Application>> = lazy (fun _ -> typeof<Application>)
    let zdfSubObjectApplication : Lazy<ZCTSubObject<Application>>= lazy ZCDSubObject (null)
    let zdfSubApplicationApplication : Lazy<ZCTSubApplication<Application>> = lazy ZCDSubApplication (null)

    // Methods    
    let newApplication : unit -> GHC.IOBase.IO<Application> = 
        fun handler ->
            GHC.Base.hreturn GHC.Base.zdfMonadIO (lazy (new Application())) 

    let run<'b, 'a when 'a :> Application and 'b :> Window> : Lazy<ZCTSubWindow<'b>> -> Lazy<ZCTSubApplication<'a>> -> Lazy<'b> -> Lazy<'a> -> GHC.IOBase.IO<unit> = 
        fun _ _ window app ->
            GHC.Base.hreturn GHC.Base.zdfMonadIO (lazy ((app.Force()).Run(window.Force()) |> ignore))
                                    
    let findResource<'a when 'a :> Application> : Lazy<ZCTSubApplication<'a>> -> Lazy<Object> -> Lazy<'a> -> GHC.IOBase.IO<Object> = 
        fun _ key app ->
            GHC.Base.hreturn GHC.Base.zdfMonadIO (lazy (app.Force()).FindResource key)
                
    let getStartupUri<'a when 'a :> Application> : Lazy<ZCTSubApplication<'a>> -> Lazy<'a> -> GHC.IOBase.IO<Uri> = 
        fun _ app ->
            GHC.Base.hreturn GHC.Base.zdfMonadIO (lazy ((app.Force()).StartupUri))
                        
    let setStartupUri<'a when 'a :> Application> : Lazy<ZCTSubApplication<'a>> -> Lazy<Uri> -> Lazy<'a> -> GHC.IOBase.IO<unit> = 
        fun _ uri app ->
            GHC.Base.hreturn GHC.Base.zdfMonadIO (lazy (app.Force()).StartupUri <- (uri.Force()))
                                                            
    let loadComponent : Lazy<Uri> -> GHC.IOBase.IO<Object> = 
        fun path ->
            GHC.Base.hreturn GHC.Base.zdfMonadIO (lazy System.Windows.Application.LoadComponent(path.Force()))            