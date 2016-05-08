
namespace DotNet.System

module EventArgs = 

    open Data.Typeable
    open DotNet.System.Object
    
    // Type definition
    type EventArgs = System.EventArgs  
    type ZCTSubEventArgs<'aayD> = ZCDSubEventArgs of 'aayD    
    let zdfTypeableEventArgs : Lazy<ZCTTypeable<EventArgs>> = lazy (fun _ -> typeof<EventArgs>)
    let zdfSubObjectEventArgs : Lazy<ZCTSubObject<EventArgs>>= lazy ZCDSubObject (null)
    let zdfSubEventArgsEventArgs : Lazy<ZCTSubEventArgs<EventArgs>> = lazy ZCDSubEventArgs (null)
    
    // Methods
    let newEventArgs : unit -> GHC.IOBase.IO<EventArgs> = 
        fun _ ->
            GHC.Base.hreturn GHC.Base.zdfMonadIO (lazy (new EventArgs()))            
            