// Learn more about F# at http://fsharp.net

namespace Program

module Main = 
    let private qsortrmC<'aaAL> : Lazy<GHC.Classes.ZCTOrd<'aaAL>> -> Lazy<GHC.Types.ZMZN<'aaAL>> -> GHC.Types.ZMZN<'aaAL> = 
        fun zddOrdaAS etasJ5 ->
            let rec 
                qsort1azzP : Lazy<GHC.Types.ZMZN<'aaAL>> -> GHC.Types.ZMZN<'aaAL> = fun dsdI1 ->
                    let 
                        wildB1 : Lazy<GHC.Types.ZMZN<'aaAL>> = dsdI1
                    in
                        match wildB1.Force() with
                        | GHC.Types.ZC (xan8, xsana) -> 
                            (GHC.Base.zpzp<'aaAL> (lazy (qsort1azzP (lazy (GHC.List.filter<'aaAL> (fun ds1dHX ->
                                (GHC.Classes.zl<'aaAL> (zddOrdaAS) (ds1dHX) (xan8))) (xsana))))) (lazy (GHC.Base.zpzp<'aaAL> (lazy (GHC.Types.ZC  ((xan8), (lazy (GHC.Types.ZMZN ))))) (lazy (qsort1azzP (lazy (GHC.List.filter<'aaAL> (fun ds1dHZZ ->
                                (GHC.Classes.zgze<'aaAL> (zddOrdaAS) (ds1dHZZ) (xan8))) (xsana))))))))
                        | GHC.Types.ZMZN -> 
                            (GHC.Types.ZMZN )
                
            in
                (qsort1azzP (etasJ5))
    
    let private runrJy : Lazy<DotNet.System.Windows.Window.Window> -> Lazy<DotNet.System.Windows.Application.Application> -> GHC.IOBase.IO<GHC.Unit.Z0T> = 
        (DotNet.System.Windows.Application.run<DotNet.System.Windows.Window.Window, DotNet.System.Windows.Application.Application> (DotNet.System.Windows.Window.zdfSubWindowWindow) (DotNet.System.Windows.Application.zdfSubApplicationApplication))
    
    let private addClickrJA : Lazy<DotNet.System.Windows.RoutedEventHandler.RoutedEventHandler> -> Lazy<DotNet.System.Windows.Controls.Button.Button> -> GHC.IOBase.IO<GHC.Unit.Z0T> = 
        (DotNet.System.Windows.Controls.Button.addClick<DotNet.System.Windows.Controls.Button.Button> (DotNet.System.Windows.Controls.Button.zdfSubButtonButton))
    
    let private createWindowrmw : Lazy<GHC.Types.ZMZN<GHC.Types.Char>> -> GHC.IOBase.IO<DotNet.System.Windows.Window.Window> = 
        fun pathamK ->
            (GHC.Base.zgzgze (GHC.Base.zdfMonadIO) (lazy (DotNet.System.Xml.XmlReader.create (pathamK))) (fun xmlamM ->
                (GHC.Base.zgzgze (GHC.Base.zdfMonadIO) (lazy (DotNet.System.Windows.Markup.XamlReader.load (xmlamM))) (fun oamO ->
                    let 
                        wildB1 : Data.Maybe.Maybe<DotNet.System.Windows.Window.Window> = (Data.Typeable.cast<DotNet.System.Object.Object, DotNet.System.Windows.Window.Window> (DotNet.System.Object.zdfTypeableObject) (DotNet.System.Windows.Window.zdfTypeableWindow) (oamO))
                    in
                        match wildB1 with
                        | Data.Maybe.Just (wamQ) -> 
                            (GHC.Base.hreturn (GHC.Base.zdfMonadIO) (wamQ))
                        | Data.Maybe.Nothing -> 
                            (GHC.Err.error<GHC.IOBase.IO<DotNet.System.Windows.Window.Window>> (lazy (GHC.Base.unpackCStringzh ("Not a Window"))))
                ))))
    
    let private findNamerJC : Lazy<GHC.Types.ZMZN<GHC.Types.Char>> -> Lazy<DotNet.System.Windows.Window.Window> -> GHC.IOBase.IO<DotNet.System.Object.Object> = 
        (DotNet.System.Windows.FrameworkElement.findName<DotNet.System.Windows.Window.Window> (DotNet.System.Windows.Window.zdfSubFrameworkElementWindow))
    
    let private findName1rJE : Lazy<GHC.Types.ZMZN<GHC.Types.Char>> -> Lazy<DotNet.System.Windows.Window.Window> -> GHC.IOBase.IO<DotNet.System.Object.Object> = 
        (DotNet.System.Windows.FrameworkElement.findName<DotNet.System.Windows.Window.Window> (DotNet.System.Windows.Window.zdfSubFrameworkElementWindow))
    
    let private setTextrJG : Lazy<GHC.Types.ZMZN<GHC.Types.Char>> -> Lazy<DotNet.System.Windows.Controls.TextBox.TextBox> -> GHC.IOBase.IO<GHC.Unit.Z0T> = 
        (DotNet.System.Windows.Controls.TextBox.setText<DotNet.System.Windows.Controls.TextBox.TextBox> (DotNet.System.Windows.Controls.TextBox.zdfSubTextBoxTextBox))
    
    let private zddShowrJI : Lazy<GHC.Show.ZCTShow<GHC.Integer.Internals.Integer>> = 
        lazy
        (
            (GHC.Num.zdp2Num<GHC.Integer.Internals.Integer> (GHC.Num.zdfNumInteger))
        )
    
    let private zddShow1rJK : Lazy<GHC.Show.ZCTShow<GHC.Types.ZMZN<GHC.Integer.Internals.Integer>>> = 
        lazy
        (
            (GHC.Show.zdfShowZMZN<GHC.Integer.Internals.Integer> (zddShowrJI))
        )
    
    let private sortedListrmE : Lazy<GHC.Types.ZMZN<GHC.Integer.Internals.Integer>> = 
        lazy
        (
            (qsortrmC<GHC.Integer.Internals.Integer> (GHC.Num.zdfOrdInteger) (lazy (GHC.Types.ZC  ((lazy (GHC.HInteger.smallInteger (3))), (lazy (GHC.Types.ZC  ((lazy (GHC.HInteger.smallInteger (2))), (lazy (GHC.Types.ZC  ((lazy (GHC.HInteger.smallInteger (1))), (lazy (GHC.Types.ZC  ((lazy (GHC.HInteger.smallInteger (0))), (lazy (GHC.Types.ZMZN )))))))))))))))
        )
    
    let private mainrmI : Lazy<GHC.IOBase.IO<GHC.Unit.Z0T>> = 
        lazy
        (
            (GHC.Base.zgzgze (GHC.Base.zdfMonadIO) (lazy (createWindowrmw (lazy (GHC.Base.unpackCStringzh ("Window1.xaml"))))) (fun windowanj ->
                (GHC.Base.zgzgze (GHC.Base.zdfMonadIO) (lazy (GHC.Base.zgzgze (GHC.Base.zdfMonadIO) (lazy (DotNet.HaskellSystem.zh<DotNet.System.Windows.Window.Window, GHC.IOBase.IO<DotNet.System.Object.Object>> (windowanj) ((findName1rJE (lazy (GHC.Base.unpackCStringzh ("btnSort"))))))) (fun ioban4 ->
                    let 
                        wildB1 : Data.Maybe.Maybe<DotNet.System.Windows.Controls.Button.Button> = (Data.Typeable.cast<DotNet.System.Object.Object, DotNet.System.Windows.Controls.Button.Button> (DotNet.System.Object.zdfTypeableObject) (DotNet.System.Windows.Controls.Button.zdfTypeableButton) (ioban4))
                    in
                        match wildB1 with
                        | Data.Maybe.Just (ban6) -> 
                            (GHC.Base.hreturn (GHC.Base.zdfMonadIO) (ban6))
                        | Data.Maybe.Nothing -> 
                            (GHC.Err.error<GHC.IOBase.IO<DotNet.System.Windows.Controls.Button.Button>> (lazy (GHC.Base.unpackCStringzh ("Not a Button"))))
                ))) (fun btnSortanl ->
                    (GHC.Base.zgzgze (GHC.Base.zdfMonadIO) (lazy (GHC.Base.zgzgze (GHC.Base.zdfMonadIO) (lazy (DotNet.HaskellSystem.zh<DotNet.System.Windows.Window.Window, GHC.IOBase.IO<DotNet.System.Object.Object>> (windowanj) ((findNamerJC (lazy (GHC.Base.unpackCStringzh ("tbOutput"))))))) (fun itemamW ->
                        let 
                            wildB1 : Data.Maybe.Maybe<DotNet.System.Windows.Controls.TextBox.TextBox> = (Data.Typeable.cast<DotNet.System.Object.Object, DotNet.System.Windows.Controls.TextBox.TextBox> (DotNet.System.Object.zdfTypeableObject) (DotNet.System.Windows.Controls.TextBox.zdfTypeableTextBox) (itemamW))
                        in
                            match wildB1 with
                            | Data.Maybe.Just (tbamY) -> 
                                (GHC.Base.hreturn (GHC.Base.zdfMonadIO) (tbamY))
                            | Data.Maybe.Nothing -> 
                                (GHC.Err.error<GHC.IOBase.IO<DotNet.System.Windows.Controls.TextBox.TextBox>> (lazy (GHC.Base.unpackCStringzh ("Not a TextBox"))))
                    ))) (fun tbOutputann ->
                        (GHC.Base.zgzgze (GHC.Base.zdfMonadIO) (lazy (DotNet.System.Windows.RoutedEventHandler.newRoutedEventHandler (fun dsdIM ds1dIN ->
                            (DotNet.HaskellSystem.zh<DotNet.System.Windows.Controls.TextBox.TextBox, GHC.IOBase.IO<GHC.Unit.Z0T>> (tbOutputann) ((setTextrJG (lazy (GHC.Show.show<GHC.Types.ZMZN<GHC.Integer.Internals.Integer>> (zddShow1rJK) (sortedListrmE))))))))) (fun handleanp ->
                            (GHC.Base.zgzg (GHC.Base.zdfMonadIO) (lazy (DotNet.HaskellSystem.zh<DotNet.System.Windows.Controls.Button.Button, GHC.IOBase.IO<GHC.Unit.Z0T>> (btnSortanl) ((addClickrJA (handleanp))))) (lazy (GHC.Base.zgzgze (GHC.Base.zdfMonadIO) (lazy (DotNet.System.Windows.Application.newApplication (() ))) (fun appanr ->
                                (DotNet.HaskellSystem.zh<DotNet.System.Windows.Application.Application, GHC.IOBase.IO<GHC.Unit.Z0T>> (appanr) ((runrJy (windowanj))))))))))))))))
        )
    
    let zcmain : GHC.IOBase.IO<GHC.Unit.Z0T> = 
        (GHC.TopHandler.runMainIO<GHC.Unit.Z0T> (mainrmI))
    
    [<System.STAThread>]
    zcmain (GHC.Prim.State (())) |> ignore


//%module main:Main
//  %rec
//  {qsortrmC :: %forall aaAL . (base:GHCziClasses.ZCTOrd aaAL) ->
//                              (ghczmprim:GHCziTypes.ZMZN aaAL) ->
//                              (ghczmprim:GHCziTypes.ZMZN aaAL) =
//     \ @ aaAL
//       (zddOrdaAS::(base:GHCziClasses.ZCTOrd aaAL))
//       (etasJ5::(ghczmprim:GHCziTypes.ZMZN aaAL)) ->
//         %let %rec
//              {qsort1azzP :: (ghczmprim:GHCziTypes.ZMZN aaAL) ->
//                             (ghczmprim:GHCziTypes.ZMZN aaAL) =
//                 \ (dsdI1::(ghczmprim:GHCziTypes.ZMZN aaAL)) ->
//                     %case ((ghczmprim:GHCziTypes.ZMZN aaAL)) dsdI1
//                     %of (wildB1::(ghczmprim:GHCziTypes.ZMZN aaAL))
//                       {ghczmprim:GHCziTypes.ZMZN ->
//                          ghczmprim:GHCziTypes.ZMZN @ aaAL;
//                        ghczmprim:GHCziTypes.ZC
//                        (xan8::aaAL) (xsana::(ghczmprim:GHCziTypes.ZMZN aaAL)) ->
//                          base:GHCziBase.zpzp @ aaAL
//                          (qsort1azzP
//                           (base:GHCziList.filter @ aaAL
//                            (\ (ds1dHX::aaAL) ->
//                                 base:GHCziClasses.zl @ aaAL zddOrdaAS ds1dHX xan8)
//                            xsana))
//                          (base:GHCziBase.zpzp @ aaAL
//                           (ghczmprim:GHCziTypes.ZC @ aaAL xan8
//                            (ghczmprim:GHCziTypes.ZMZN @ aaAL))
//                           (qsort1azzP
//                            (base:GHCziList.filter @ aaAL
//                             (\ (ds1dHZZ::aaAL) ->
//                                  base:GHCziClasses.zgze @ aaAL zddOrdaAS ds1dHZZ xan8)
//                             xsana)))}}
//         %in qsort1azzP etasJ5;
//   runrJy :: DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziWindow.Window
//             ->
//             DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziApplication.Application
//             -> (base:GHCziIOBase.IO ghczmprim:GHCziUnit.Z0T) =
//     DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziApplication.run
//     @ DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziWindow.Window
//     @ DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziApplication.Application
//     DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziWindow.zdf4
//     DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziApplication.zdf3;
//   addClickrJA :: DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziRoutedEventHandler.RoutedEventHandler
//                  ->
//                  DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziControlsziButton.Button
//                  -> (base:GHCziIOBase.IO ghczmprim:GHCziUnit.Z0T) =
//     DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziControlsziButton.addClick
//     @ DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziControlsziButton.Button
//     DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziControlsziButton.zdf5;
//   createWindowrmw :: (ghczmprim:GHCziTypes.ZMZN
//                       ghczmprim:GHCziTypes.Char)
//                      ->
//                      (base:GHCziIOBase.IO
//                       DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziWindow.Window) =
//     \ (pathamK::(ghczmprim:GHCziTypes.ZMZN
//                  ghczmprim:GHCziTypes.Char)) ->
//         base:GHCziBase.zgzgze @ base:GHCziIOBase.IO base:GHCziIOBase.zdf25
//         @ DotNetProxyzm0zi0zi1:DotNetziSystemziXmlziXmlReader.XmlReader
//         @ DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziWindow.Window
//         (DotNetProxyzm0zi0zi1:DotNetziSystemziXmlziXmlReader.create
//          pathamK)
//         (\ (xmlamM::DotNetProxyzm0zi0zi1:DotNetziSystemziXmlziXmlReader.XmlReader) ->
//              base:GHCziBase.zgzgze @ base:GHCziIOBase.IO base:GHCziIOBase.zdf25
//              @ DotNetProxyzm0zi0zi1:DotNetziSystemziObject.Object
//              @ DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziWindow.Window
//              (DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziMarkupziXamlReader.load
//               xmlamM)
//              (\ (oamO::DotNetProxyzm0zi0zi1:DotNetziSystemziObject.Object) ->
//                   %case ((base:GHCziIOBase.IO
//                           DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziWindow.Window)) (base:DataziTypeable.cast
//                                                                                          @ DotNetProxyzm0zi0zi1:DotNetziSystemziObject.Object
//                                                                                          @ DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziWindow.Window
//                                                                                          DotNetProxyzm0zi0zi1:DotNetziSystemziObject.zdf1
//                                                                                          DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziWindow.zdf1
//                                                                                          oamO)
//                   %of (wildB1::(base:DataziMaybe.Maybe
//                                 DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziWindow.Window))
//                     {base:DataziMaybe.Nothing ->
//                        base:GHCziErr.error
//                        @ ((base:GHCziIOBase.IO
//                            DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziWindow.Window))
//                        (base:GHCziBase.unpackCStringzh
//                         ("Not a Window"::ghczmprim:GHCziPrim.Addrzh));
//                      base:DataziMaybe.Just
//                      (wamQ::DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziWindow.Window) ->
//                        base:GHCziBase.return @ base:GHCziIOBase.IO base:GHCziIOBase.zdf25
//                        @ DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziWindow.Window
//                        wamQ}));
//   findNamerJC :: (ghczmprim:GHCziTypes.ZMZN
//                   ghczmprim:GHCziTypes.Char)
//                  ->
//                  DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziWindow.Window ->
//                  (base:GHCziIOBase.IO
//                   DotNetProxyzm0zi0zi1:DotNetziSystemziObject.Object) =
//     DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziFrameworkElement.findName
//     @ DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziWindow.Window
//     DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziWindow.zdf2;
//   findName1rJE :: (ghczmprim:GHCziTypes.ZMZN
//                    ghczmprim:GHCziTypes.Char)
//                   ->
//                   DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziWindow.Window ->
//                   (base:GHCziIOBase.IO
//                    DotNetProxyzm0zi0zi1:DotNetziSystemziObject.Object) =
//     DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziFrameworkElement.findName
//     @ DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziWindow.Window
//     DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziWindow.zdf2;
//   setTextrJG :: (ghczmprim:GHCziTypes.ZMZN ghczmprim:GHCziTypes.Char)
//                 ->
//                 DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziControlsziTextBox.TextBox
//                 -> (base:GHCziIOBase.IO ghczmprim:GHCziUnit.Z0T) =
//     DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziControlsziTextBox.setText
//     @ DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziControlsziTextBox.TextBox
//     DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziControlsziTextBox.zdf4;
//   zddShowrJI :: (base:GHCziShow.ZCTShow
//                  integer:GHCziIntegerziInternals.Integer) =
//     base:GHCziNum.zdp2Num @ integer:GHCziIntegerziInternals.Integer
//     base:GHCziNum.zdf2;
//   zddShow1rJK :: (base:GHCziShow.ZCTShow
//                   ((ghczmprim:GHCziTypes.ZMZN
//                     integer:GHCziIntegerziInternals.Integer))) =
//     base:GHCziShow.zdf20 @ integer:GHCziIntegerziInternals.Integer
//     zddShowrJI;
//   sortedListrmE :: (ghczmprim:GHCziTypes.ZMZN
//                     integer:GHCziIntegerziInternals.Integer) =
//     qsortrmC @ integer:GHCziIntegerziInternals.Integer
//     base:GHCziNum.zdf4
//     (ghczmprim:GHCziTypes.ZC @ integer:GHCziIntegerziInternals.Integer
//      (integer:GHCziInteger.smallInteger (3::ghczmprim:GHCziPrim.Intzh))
//      (ghczmprim:GHCziTypes.ZC @ integer:GHCziIntegerziInternals.Integer
//       (integer:GHCziInteger.smallInteger (2::ghczmprim:GHCziPrim.Intzh))
//       (ghczmprim:GHCziTypes.ZC @ integer:GHCziIntegerziInternals.Integer
//        (integer:GHCziInteger.smallInteger (1::ghczmprim:GHCziPrim.Intzh))
//        (ghczmprim:GHCziTypes.ZC @ integer:GHCziIntegerziInternals.Integer
//         (integer:GHCziInteger.smallInteger (0::ghczmprim:GHCziPrim.Intzh))
//         (ghczmprim:GHCziTypes.ZMZN
//          @ integer:GHCziIntegerziInternals.Integer)))));
//   mainrmI :: (base:GHCziIOBase.IO ghczmprim:GHCziUnit.Z0T) =
//     base:GHCziBase.zgzgze @ base:GHCziIOBase.IO base:GHCziIOBase.zdf25
//     @ DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziWindow.Window
//     @ ghczmprim:GHCziUnit.Z0T
//     (createWindowrmw
//      (base:GHCziBase.unpackCStringzh
//       ("Window1.xaml"::ghczmprim:GHCziPrim.Addrzh)))
//     (\ (windowanj::DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziWindow.Window) ->
//          base:GHCziBase.zgzgze @ base:GHCziIOBase.IO base:GHCziIOBase.zdf25
//          @ DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziControlsziButton.Button
//          @ ghczmprim:GHCziUnit.Z0T
//          (base:GHCziBase.zgzgze @ base:GHCziIOBase.IO base:GHCziIOBase.zdf25
//           @ DotNetProxyzm0zi0zi1:DotNetziSystemziObject.Object
//           @ DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziControlsziButton.Button
//           (DotNetProxyzm0zi0zi1:DotNetziSystem.zh
//            @ DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziWindow.Window
//            @ ((base:GHCziIOBase.IO
//                DotNetProxyzm0zi0zi1:DotNetziSystemziObject.Object))
//            windowanj
//            (findName1rJE
//             (base:GHCziBase.unpackCStringzh
//              ("btnSort"::ghczmprim:GHCziPrim.Addrzh))))
//           (\ (ioban4::DotNetProxyzm0zi0zi1:DotNetziSystemziObject.Object) ->
//                %case ((base:GHCziIOBase.IO
//                        DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziControlsziButton.Button)) (base:DataziTypeable.cast
//                                                                                                 @ DotNetProxyzm0zi0zi1:DotNetziSystemziObject.Object
//                                                                                                 @ DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziControlsziButton.Button
//                                                                                                 DotNetProxyzm0zi0zi1:DotNetziSystemziObject.zdf1
//                                                                                                 DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziControlsziButton.zdf1
//                                                                                                 ioban4)
//                %of (wildB1::(base:DataziMaybe.Maybe
//                              DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziControlsziButton.Button))
//                  {base:DataziMaybe.Nothing ->
//                     base:GHCziErr.error
//                     @ ((base:GHCziIOBase.IO
//                         DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziControlsziButton.Button))
//                     (base:GHCziBase.unpackCStringzh
//                      ("Not a Button"::ghczmprim:GHCziPrim.Addrzh));
//                   base:DataziMaybe.Just
//                   (ban6::DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziControlsziButton.Button) ->
//                     base:GHCziBase.return @ base:GHCziIOBase.IO base:GHCziIOBase.zdf25
//                     @ DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziControlsziButton.Button
//                     ban6}))
//          (\ (btnSortanl::DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziControlsziButton.Button) ->
//               base:GHCziBase.zgzgze @ base:GHCziIOBase.IO base:GHCziIOBase.zdf25
//               @ DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziControlsziTextBox.TextBox
//               @ ghczmprim:GHCziUnit.Z0T
//               (base:GHCziBase.zgzgze @ base:GHCziIOBase.IO base:GHCziIOBase.zdf25
//                @ DotNetProxyzm0zi0zi1:DotNetziSystemziObject.Object
//                @ DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziControlsziTextBox.TextBox
//                (DotNetProxyzm0zi0zi1:DotNetziSystem.zh
//                 @ DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziWindow.Window
//                 @ ((base:GHCziIOBase.IO
//                     DotNetProxyzm0zi0zi1:DotNetziSystemziObject.Object))
//                 windowanj
//                 (findNamerJC
//                  (base:GHCziBase.unpackCStringzh
//                   ("tbOutput"::ghczmprim:GHCziPrim.Addrzh))))
//                (\ (itemamW::DotNetProxyzm0zi0zi1:DotNetziSystemziObject.Object) ->
//                     %case ((base:GHCziIOBase.IO
//                             DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziControlsziTextBox.TextBox)) (base:DataziTypeable.cast
//                                                                                                        @ DotNetProxyzm0zi0zi1:DotNetziSystemziObject.Object
//                                                                                                        @ DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziControlsziTextBox.TextBox
//                                                                                                        DotNetProxyzm0zi0zi1:DotNetziSystemziObject.zdf1
//                                                                                                        DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziControlsziTextBox.zdf1
//                                                                                                        itemamW)
//                     %of (wildB1::(base:DataziMaybe.Maybe
//                                   DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziControlsziTextBox.TextBox))
//                       {base:DataziMaybe.Nothing ->
//                          base:GHCziErr.error
//                          @ ((base:GHCziIOBase.IO
//                              DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziControlsziTextBox.TextBox))
//                          (base:GHCziBase.unpackCStringzh
//                           ("Not a TextBox"::ghczmprim:GHCziPrim.Addrzh));
//                        base:DataziMaybe.Just
//                        (tbamY::DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziControlsziTextBox.TextBox) ->
//                          base:GHCziBase.return @ base:GHCziIOBase.IO base:GHCziIOBase.zdf25
//                          @ DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziControlsziTextBox.TextBox
//                          tbamY}))
//               (\ (tbOutputann::DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziControlsziTextBox.TextBox) ->
//                    base:GHCziBase.zgzgze @ base:GHCziIOBase.IO base:GHCziIOBase.zdf25
//                    @ DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziRoutedEventHandler.RoutedEventHandler
//                    @ ghczmprim:GHCziUnit.Z0T
//                    (DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziRoutedEventHandler.newRoutedEventHandler
//                     (\ (dsdIM::DotNetProxyzm0zi0zi1:DotNetziSystemziObject.Object)
//                        (ds1dIN::DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziRoutedEventArgs.RoutedEventArgs) ->
//                          DotNetProxyzm0zi0zi1:DotNetziSystem.zh
//                          @ DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziControlsziTextBox.TextBox
//                          @ ((base:GHCziIOBase.IO ghczmprim:GHCziUnit.Z0T)) tbOutputann
//                          (setTextrJG
//                           (base:GHCziShow.show
//                            @ ((ghczmprim:GHCziTypes.ZMZN
//                                integer:GHCziIntegerziInternals.Integer))
//                            zddShow1rJK sortedListrmE))))
//                    (\ (handleanp::DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziRoutedEventHandler.RoutedEventHandler) ->
//                         base:GHCziBase.zgzg @ base:GHCziIOBase.IO base:GHCziIOBase.zdf25
//                         @ ghczmprim:GHCziUnit.Z0T @ ghczmprim:GHCziUnit.Z0T
//                         (DotNetProxyzm0zi0zi1:DotNetziSystem.zh
//                          @ DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziControlsziButton.Button
//                          @ ((base:GHCziIOBase.IO ghczmprim:GHCziUnit.Z0T)) btnSortanl
//                          (addClickrJA handleanp))
//                         (base:GHCziBase.zgzgze @ base:GHCziIOBase.IO base:GHCziIOBase.zdf25
//                          @ DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziApplication.Application
//                          @ ghczmprim:GHCziUnit.Z0T
//                          (DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziApplication.newApplication
//                           ghczmprim:GHCziUnit.Z0T)
//                          (\ (appanr::DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziApplication.Application) ->
//                               DotNetProxyzm0zi0zi1:DotNetziSystem.zh
//                               @ DotNetProxyzm0zi0zi1:DotNetziSystemziWindowsziApplication.Application
//                               @ ((base:GHCziIOBase.IO ghczmprim:GHCziUnit.Z0T)) appanr
//                               (runrJy windowanj)))))));
//   main:ZCMain.main :: (base:GHCziIOBase.IO ghczmprim:GHCziUnit.Z0T) =
//     base:GHCziTopHandler.runMainIO @ ghczmprim:GHCziUnit.Z0T mainrmI};
