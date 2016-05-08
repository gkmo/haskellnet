namespace FormTest

module Main = 
    let private runrA7 : Lazy<DotNet.System.Windows.Forms.Form.Form> -> GHC.IOBase.IO<GHC.Unit.Z0T> = 
        (DotNet.System.Windows.Forms.Application.run<DotNet.System.Windows.Forms.Form.Form> (DotNet.System.Windows.Forms.Form.zdf4))
    
    let private addLoadrA9 : Lazy<DotNet.System.EventHandler.EventHandler> -> Lazy<DotNet.System.Windows.Forms.Form.Form> -> GHC.IOBase.IO<GHC.Unit.Z0T> = 
        (DotNet.System.Windows.Forms.Form.addLoad<DotNet.System.Windows.Forms.Form.Form> (DotNet.System.Windows.Forms.Form.zdf4))
    
    let private setTextrAb : Lazy<GHC.Types.ZMZN<GHC.Types.Char>> -> Lazy<DotNet.System.Windows.Forms.Form.Form> -> GHC.IOBase.IO<GHC.Unit.Z0T> = 
        (DotNet.System.Windows.Forms.Control.setText<DotNet.System.Windows.Forms.Form.Form> (DotNet.System.Windows.Forms.Form.zdf3))
    
    let private setText1rAd : Lazy<GHC.Types.ZMZN<GHC.Types.Char>> -> Lazy<DotNet.System.Windows.Forms.Form.Form> -> GHC.IOBase.IO<GHC.Unit.Z0T> = 
        (DotNet.System.Windows.Forms.Control.setText<DotNet.System.Windows.Forms.Form.Form> (DotNet.System.Windows.Forms.Form.zdf3))
    
    let private onLoadrxI : Lazy<DotNet.System.Object.Object> -> Lazy<DotNet.System.EventArgs.EventArgs> -> GHC.IOBase.IO<GHC.Unit.Z0T> = 
        fun faxM argaxO ->
            let 
                wildB1 : Data.Maybe.Maybe<DotNet.System.Windows.Forms.Form.Form> = (Data.Typeable.cast<DotNet.System.Object.Object, DotNet.System.Windows.Forms.Form.Form> (DotNet.System.Object.zdfTypeableObject) (DotNet.System.Windows.Forms.Form.zdf1) (faxM))
            in
                match wildB1 with
                | Data.Maybe.Just (xaxQ) -> 
                    (DotNet.HaskellSystem.zh<DotNet.System.Windows.Forms.Form.Form, GHC.IOBase.IO<GHC.Unit.Z0T>> (xaxQ) ((setText1rAd (lazy (GHC.Base.unpackCStringzh ("Loaded"))))))
                | Data.Maybe.Nothing -> 
                    (GHC.Base.hreturn (GHC.Base.zdfMonadIO) (lazy () ))
    
    
    let private mainrxK : Lazy<GHC.IOBase.IO<GHC.Unit.Z0T>> = 
        lazy
        (
            (GHC.Base.zgzgze (GHC.Base.zdfMonadIO) (lazy (DotNet.System.EventHandler.newEventHandler (onLoadrxI))) (fun handleraxS ->
                (GHC.Base.zgzgze (GHC.Base.zdfMonadIO) (lazy (DotNet.System.Windows.Forms.Form.newForm (() ))) (fun faxU ->
                    (GHC.Base.zgzg (GHC.Base.zdfMonadIO) (lazy (DotNet.HaskellSystem.zh<DotNet.System.Windows.Forms.Form.Form, GHC.IOBase.IO<GHC.Unit.Z0T>> (faxU) ((setTextrAb (lazy (GHC.Base.unpackCStringzh ("Haskell.NET"))))))) (lazy (GHC.Base.zgzg (GHC.Base.zdfMonadIO) (lazy (DotNet.HaskellSystem.zh<DotNet.System.Windows.Forms.Form.Form, GHC.IOBase.IO<GHC.Unit.Z0T>> (faxU) ((addLoadrA9 (handleraxS))))) (lazy (runrA7 (faxU))))))))))
        )
    
    let zcmain : GHC.IOBase.IO<GHC.Unit.Z0T> = 
        (GHC.TopHandler.runMainIO<GHC.Unit.Z0T> (mainrxK))
    
    zcmain (GHC.Prim.State (())) |> ignore

                
//%module main:FormTestziMain
//  %rec
//  {runrA7 :: DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziFormsziForm.Form
//             -> (base:GHCziIOBase.IO ghczmprim:GHCziUnit.Z0T) =
//     DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziFormsziApplication.run
//     @ DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziFormsziForm.Form
//     DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziFormsziForm.zdf4;
//   addLoadrA9 :: DotNetProxyzm0zi0zi1:DotNetziSystemziEventHandler.EventHandler
//                 ->
//                 DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziFormsziForm.Form ->
//                 (base:GHCziIOBase.IO ghczmprim:GHCziUnit.Z0T) =
//     DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziFormsziForm.addLoad
//     @ DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziFormsziForm.Form
//     DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziFormsziForm.zdf4;
//   setTextrAb :: (ghczmprim:GHCziTypes.ZMZN ghczmprim:GHCziTypes.Char)
//                 ->
//                 DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziFormsziForm.Form ->
//                 (base:GHCziIOBase.IO ghczmprim:GHCziUnit.Z0T) =
//     DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziFormsziControl.setText
//     @ DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziFormsziForm.Form
//     DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziFormsziForm.zdf3;
//   setText1rAd :: (ghczmprim:GHCziTypes.ZMZN
//                   ghczmprim:GHCziTypes.Char)
//                  ->
//                  DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziFormsziForm.Form ->
//                  (base:GHCziIOBase.IO ghczmprim:GHCziUnit.Z0T) =
//     DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziFormsziControl.setText
//     @ DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziFormsziForm.Form
//     DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziFormsziForm.zdf3;
//   onLoadrxI :: DotNetProxyzm0zi0zi1:DotNetziSystemziObject.Object ->
//                DotNetProxyzm0zi0zi1:DotNetziSystemziEventArgs.EventArgs ->
//                (base:GHCziIOBase.IO ghczmprim:GHCziUnit.Z0T) =
//     \ (faxM::DotNetProxyzm0zi0zi1:DotNetziSystemziObject.Object)
//       (argaxO::DotNetProxyzm0zi0zi1:DotNetziSystemziEventArgs.EventArgs) ->
//         %case ((base:GHCziIOBase.IO
//                 ghczmprim:GHCziUnit.Z0T)) (base:DataziTypeable.cast
//                                            @ DotNetProxyzm0zi0zi1:DotNetziSystemziObject.Object
//                                            @ DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziFormsziForm.Form
//                                            DotNetProxyzm0zi0zi1:DotNetziSystemziObject.zdf1
//                                            DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziFormsziForm.zdf1
//                                            faxM)
//         %of (wildB1::(base:DataziMaybe.Maybe
//                       DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziFormsziForm.Form))
//           {base:DataziMaybe.Nothing ->
//              base:GHCziBase.return @ base:GHCziIOBase.IO base:GHCziIOBase.zdf25
//              @ ghczmprim:GHCziUnit.Z0T ghczmprim:GHCziUnit.Z0T;
//            base:DataziMaybe.Just
//            (xaxQ::DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziFormsziForm.Form) ->
//              DotNetProxyzm0zi0zi1:DotNetziSystem.zh
//              @ DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziFormsziForm.Form
//              @ ((base:GHCziIOBase.IO ghczmprim:GHCziUnit.Z0T)) xaxQ
//              (setText1rAd
//               (base:GHCziBase.unpackCStringzh
//                ("Loaded"::ghczmprim:GHCziPrim.Addrzh)))};
//   mainrxK :: (base:GHCziIOBase.IO ghczmprim:GHCziUnit.Z0T) =
//     base:GHCziBase.zgzgze @ base:GHCziIOBase.IO base:GHCziIOBase.zdf25
//     @ DotNetProxyzm0zi0zi1:DotNetziSystemziEventHandler.EventHandler
//     @ ghczmprim:GHCziUnit.Z0T
//     (DotNetProxyzm0zi0zi1:DotNetziSystemziEventHandler.newEventHandler
//      onLoadrxI)
//     (\ (handleraxS::DotNetProxyzm0zi0zi1:DotNetziSystemziEventHandler.EventHandler) ->
//          base:GHCziBase.zgzgze @ base:GHCziIOBase.IO base:GHCziIOBase.zdf25
//          @ DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziFormsziForm.Form
//          @ ghczmprim:GHCziUnit.Z0T
//          (DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziFormsziForm.newForm
//           ghczmprim:GHCziUnit.Z0T)
//          (\ (faxU::DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziFormsziForm.Form) ->
//               base:GHCziBase.zgzg @ base:GHCziIOBase.IO base:GHCziIOBase.zdf25
//               @ ghczmprim:GHCziUnit.Z0T @ ghczmprim:GHCziUnit.Z0T
//               (DotNetProxyzm0zi0zi1:DotNetziSystem.zh
//                @ DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziFormsziForm.Form
//                @ ((base:GHCziIOBase.IO ghczmprim:GHCziUnit.Z0T)) faxU
//                (setTextrAb
//                 (base:GHCziBase.unpackCStringzh
//                  ("Haskell.NET"::ghczmprim:GHCziPrim.Addrzh))))
//               (base:GHCziBase.zgzg @ base:GHCziIOBase.IO base:GHCziIOBase.zdf25
//                @ ghczmprim:GHCziUnit.Z0T @ ghczmprim:GHCziUnit.Z0T
//                (DotNetProxyzm0zi0zi1:DotNetziSystem.zh
//                 @ DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziFormsziForm.Form
//                 @ ((base:GHCziIOBase.IO ghczmprim:GHCziUnit.Z0T)) faxU
//                 (addLoadrA9 handleraxS))
//                (runrA7 faxU))));
//   main:ZCMain.main :: (base:GHCziIOBase.IO ghczmprim:GHCziUnit.Z0T) =
//     base:GHCziTopHandler.runMainIO @ ghczmprim:GHCziUnit.Z0T mainrxK};


    
    
    
    
    