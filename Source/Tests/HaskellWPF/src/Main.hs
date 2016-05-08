
module Main (


) where

import Data.Typeable
import Data.Maybe

import DotNet.System
import DotNet.System.Windows hiding (show)
import DotNet.System.Windows.Controls
import DotNet.System.Windows.Controls.TextBox
import DotNet.System.Xml.XmlReader as XmlReader
import DotNet.System.Windows.Markup.XamlReader as XamlReader

createWindow :: String ->  IO Window
createWindow path =
    do
        xml <-  XmlReader.create path
        o <-  XamlReader.load xml
        case ((cast o) :: Maybe Window) of
            Just w ->  return w
            Nothing ->  error "Not a Window"

findTextBox :: Window ->  String ->  IO TextBox
findTextBox w name =
    do
        item <- (w # findName name)
        case ((cast item) :: Maybe TextBox) of
            Just tb ->  return tb
            Nothing ->  error "Not a TextBox"			

findButton :: Window ->  String ->  IO Button
findButton w name =
    do
        iob <- (w # findName name)
        case ((cast iob) :: Maybe Button) of
            Just b ->  return b
            Nothing ->  error "Not a Button"
			
qsort []     = []
qsort (x:xs) = qsort (filter (< x) xs) ++ [x] ++ qsort (filter (>= x) xs)
		
sortedList = qsort (3:2:1:0:[])
		
onClick :: Window -> TextBox -> Object ->  RoutedEventArgs ->  IO ()
onClick window tb _ _ =
    do
        tb # setText (show (sortedList))
		
main = 
	do
		window <- createWindow "Window1.xaml"
		btnSort <- findButton window "btnSort"	
		tbOutput <- findTextBox window "tbOutput"
		handle <- newRoutedEventHandler (onClick window tbOutput)
		btnSort # addClick handle
		app <- newApplication ()
		app # run window
