
namespace DotNet

module HaskellSystem = 

    let inline zh<'a, 'b> (o : Lazy<'a>) (f : Lazy<'a> -> 'b) = f o