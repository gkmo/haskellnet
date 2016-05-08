-----------------------------------------------------------------------------
--
-- Module      :  DotNet.System.Windows.RoutedEventArgs
-- Copyright   :
-- License     :  AllRightsReserved
--
-- Maintainer  :  Guilherme Oliveira
-- Stability   :  Alfa
-- Portability :
--
-- |
--
-----------------------------------------------------------------------------

module DotNet.System.Windows.RoutedEventArgs (
    RoutedEventArgs,
    SubRoutedEventArgs,
    newRoutedEventArgs
) where

import DotNet.System
import DotNet.System.Object

data RoutedEventArgs = RoutedEventArgs
class SubRoutedEventArgs a
instance SubRoutedEventArgs RoutedEventArgs
instance SubObject RoutedEventArgs

newRoutedEventArgs :: () -> IO RoutedEventArgs
newRoutedEventArgs _ = undefined
