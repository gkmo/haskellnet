-----------------------------------------------------------------------------
--
-- Module      :  DotNet.System.Windows
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

module DotNet.System.Windows (
    Application,
    SubApplication,
    newApplication,
    run,
    getStartupUri,
    setStartupUri,
    FrameworkElement,
    SubFrameworkElement,
    findName,
    RoutedEventArgs,
    SubRoutedEventArgs,
    newRoutedEventArgs,
    RoutedEventHandler,
    SubRoutedEventHandler,
    newRoutedEventHandler,
    Window,
    SubWindow,
    newWindow,
    show,
    activate,
    close,
    setTitle,
    getTitle
) where

import Prelude hiding (show)

import DotNet.System.Windows.Application
import DotNet.System.Windows.FrameworkElement
import DotNet.System.Windows.RoutedEventArgs
import DotNet.System.Windows.RoutedEventHandler
import DotNet.System.Windows.Window
