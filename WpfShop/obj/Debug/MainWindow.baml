   M S B A M L   `   `   `  ????B  >WpfShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfShop.ViewsWpfShop.Views  5   L   7 clr-namespace:WpfShop.ViewModelsWpfShop.ViewModels  5          WpfShop.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    6&   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     6<   X TFontAwesome.Sharp, Version=6.1.1.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      'localclr-namespace:WpfShop.Views  6L   0	viewModel clr-namespace:WpfShop.ViewModels  5        ? Title$  MainView??6I   $	??550??6Z   $
??1000??6g    ? WindowStyle$
 None=?5   	    ? 
ResizeMode$ NoResize=?6    ? DataContext 5      &    WpfShop.ViewModels.MainViewModel  5   
    ? 	Resources 5
       ?? DataType&    WpfShop.ViewModels.UserViewModel   WpfShop.Views.UserView,   &WpfShop.ViewModels.CreateUserViewModel"   WpfShop.Views.CreateUserView*   $WpfShop.ViewModels.EditUserViewModel    WpfShop.Views.EditUserView*   $WpfShop.ViewModels.CategoryViewModel 	   WpfShop.Views.CategoryView0
   *WpfShop.ViewModels.CreateCategoryViewModel&    WpfShop.Views.CreateCategoryView.   (WpfShop.ViewModels.EditCategoryViewModel$   WpfShop.Views.EditCategoryView)   #WpfShop.ViewModels.ProductViewModel   WpfShop.Views.ProductView/   )WpfShop.ViewModels.CreateProductViewModel%   WpfShop.Views.CreateProductView-  'WpfShop.ViewModels.EditProductViewModel#   WpfShop.Views.EditProductView??%?  (??       5      *, +)(?? 2     5      *, +)(?? d     5      *, +)(?? ?     5      *, +)(?? ?     5      *,
 +)(?? ?     5      *, +)(?? ,    5$      *, +)(?? ^    5'      *, +)(?? ?    5*      *, +)?? 5   
   "  6   .R?5        5      ?? 5   
   "  6   .R?5        5      ?? 5   
   "  6   .R?5        5      ?? 5   
   "  6   .R?5      	  5      ?? 5   
   " 
 6   .R?5        5      ?? 5   
   "  6   .R?5        5       ?? 5$   
   "  6   .R?5%        5&      ?? 5'   
   "  6   .R?5(        5)      ?? 5*   
   "  6   .R?5+        5,      5/      .??53      ??  ?? CornerRadius$ 10??6   $??1q?6   ??54   
   ?? 55       ?? 
StartPoint$	 0,0&?6"    ?? EndPoint$	 1,1&?63   .??56      ?    winBorderColor1	 ? Color#	 [  6   
 ? Offset$
 0Q?6H   ? 57        winBorderColor2#	 [ 6   $	
 0.5Q?6H   ? 58        winBorderColor3#	 [ 6   $
 1Q?6H   59      ._?5<   
   ?  ? ColumnDefinitions 5>      ?? 5@      $	??250 ?6#   ?? 5B      $??* ?6#   .+?5E      ?? $ 	10,0,0,10??6   $??0??6.   ??5F      ?? 5G      $	 0,0&?6*   $ 1,0.7&?6;   .??5H      ?   secondaryBackColor1#	 [ 6'   $
 0Q?6T   ? 5I        secondaryBackColor2#	 [ 6'   $
 1Q?6T   5J      ._?5L      ?? .+?5O      ??  ?? Orientation$ 
Horizontal=?6!   $??35??6:   $??
15,25,0,40q?6F   .+?5Q      ?? $??	FAST FOOD??6$     titleColor2#??[ 65   $??20(?6_   $??
Montserrat)?5R      $??Medium"?65   $??Center=?6I   $??10,0,0,0q?6d   5S      	? 5V        
menuButton#??[ 6"    
 color1
 ? Tag# [ 6F   .??5X      ?? $ 
Horizontal=?6%   .+?5Y      !  FontAwesome.Sharp.IconImage  ?  ?FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.1.1.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$
 Home=?6+     menuButtonIcon#??[ 67   ?? 5Z      $??	Dashboard??6(    	 menuButtonText#??[	 69   5[      5\      	? 5^      #??[ 6"    

 color2# [
 6F   ??5_      ?? *ShowUserViewCommand+.??5`      ?? $ 
Horizontal=?6%   .+?5a        $
 User=?6+   #??[ 67   ?? 5b      $
??User??6(   #??[	 64   5c      5d      	? 5f      #??[ 6"    
 color3# [ 6F   .??5h      ?? $ 
Horizontal=?6%   .+?5i        $ Truck=?6+   #??[ 68   ?? 5j      $??Order??6(   #??[	 65   5k      5l      	? 5n      #??[ 6"    
 color4# [ 6F   ??5o      ?? *ShowProductViewCommand+.??5p      ?? $ 
Horizontal=?6%   .+?5q        $ ShoppingBag=?6+   #??[ 6>   ?? 5r      $??Product??6(   #??[	 67   5s      5t      	? 5v      #??[ 6"    
 color5# [ 6F   ??5w      ?? *ShowCategoryViewCommand+.??5x      ?? $ 
Horizontal=?6%   .+?5y        $	 Box=?6+   #??[ 66   ?? 5z      $??Category??6(   #??[	 68   5{      5|      	? 5}      #??[ 6"    
 color6# [ 6F   .??5~      ?? $ 
Horizontal=?6%   .+?5        $ Wallet=?6+   #??[ 69   ?? 5?      $??	Financial??6(   #??[	 69   5?      5?      5?      5?      ?? 5?      $ 	0,10,10,0??6   $??1??6.   ??5?      ?? 5?      $	 1,1&?6*   $	 0,0&?6;   .??5?      ?   primaryBackColor1#	 [ 6'   ? 5?        primaryBackColor2#	 [ 6'   5?      ._?5?      ?  ? RowDefinitions 5?      ?? 5?      $??25 ?6(   ?? 5?      $??35 ?6(   ?? 5?      $??* ?6(   .+?5?      ?? -   5         ??Name$ pnlControlBar??5?   !   $??0??68   $ 
Horizontal=?6E   $??RightToLeft=?6^   
?????? $??0,0,5,0q?5?   2   .+?5?      ?? -   5         ??Name$ btnClose??5?   !     controlButton#??[ 63   # [ 6Z   .??5?        $ 
XingSquare=?6+     controlButtonIcon#??[ 6=   5?      ?? 5?      -   5        $ btnMaximize??5?   !   #??[ 66   # [ 5?      .??5?        $ Square=?6+   #??[ 69   5?      ?? 5?      -   5        $ btnMinimize??5?   !   #??[ 66   # [ 5?      .??5?        $ WindowMinimize=?6+   #??[ 6A   5?      5?      ? 5?      $??1??6    5?      ?? 5?      5?      .+?5?      ?? $??0??6%   $ 
Horizontal=?65   $??Center=?6N   .+?5?        $??20??6A   $??20??6M      
Foreground# [ 5?   !   $??	35,0,10,0q?6K    5?   +   ?? *Icon+5?   K   ?? 5?      #??[ 6A   $??16(?6k   $??Medium"?5?   !   $??
Montserrat)?65   $??Center=?6M   ??5?   (   ?? *	Caption+5?   M   5?      ?? 5?      $??1??6%   $ 
Horizontal=?65   $??RightToLeft=?6N   $??Center=?5?      $??0,0,10,0q?68   .+?5?      ??   
iconButton#??[ 6%   # [ 6I   .??5?   "     $ 	AngleDown=?6/     iconButtonIcon#??[ 6@   5?      ?? 5?      $??	User Name??6(     titleColor3#??[ 69   $??
Montserrat)?5?   !   $??12(?69   $??Center=?6G   A? 5?      $??35??6&   $??35??62   #??[
 6=   $??2??6^   $??	10,0,10,0q?5?   !   ??5?   "   ?? 5?   &    ?? ImageSource$ /Images/user.png??61   5?      ?? 5?      #??[ 6%   # [ 6I   .??5?   "     $ Clock=?6/   #??[ 6<   5?      ?? 5?      #??[ 6%   # [ 6I   .??5?   "     $ Envelope=?6/   #??[ 6?   5?      ?? 5?      #??[ 6%   # [ 6I   .??5?   "     $
 Bell=?6/   #??[ 6;   5?      5?      5?      ?? 5?      $??2??6J   $??25q?6W   ??6%   ?? *CurrentChildView+6W   5?      5?      5?      5?      5?      