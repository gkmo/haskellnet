
namespace DotNet.System.Windows.Forms

module Application = 

    open System
    open System.Windows.Forms    
    open DotNet.System.Windows.Forms.Form       
            
    let run<'cayy when 'cayy :> Form> : Lazy<ZCTSubForm<'cayy>> -> Lazy<'cayy> -> GHC.IOBase.IO<unit> = 
        fun _ form ->
            GHC.Base.hreturn GHC.Base.zdfMonadIO (lazy Application.Run(form.Force()))            