
namespace DotNet.System.Windows

module RoutedEventArgs = 
    
    open Data.Typeable
    open DotNet.System.Object
    open DotNet.System.EventArgs
    
    // Type definition
    type RoutedEventArgs = System.Windows.RoutedEventArgs  
    type ZCTSubRoutedEventArgs<'aayD> = ZCDSubRoutedEventArgs of 'aayD    
    let zdfTypeableRoutedEventArgs : Lazy<ZCTTypeable<RoutedEventArgs>> = lazy (fun _ -> typeof<RoutedEventArgs>)
    let zdfSubObjectRoutedEventArgs : Lazy<ZCTSubObject<RoutedEventArgs>>= lazy ZCDSubObject (null)
    let zdfSubEventArgsRoutedEventArgs : Lazy<ZCTSubEventArgs<RoutedEventArgs>> = lazy ZCDSubEventArgs (null)
    let zdfSubRoutedEventArgsRoutedEventArgs : Lazy<ZCTSubRoutedEventArgs<RoutedEventArgs>> = lazy ZCDSubRoutedEventArgs (null)
    