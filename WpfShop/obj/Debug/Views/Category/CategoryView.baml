   M S B A M L   `   `   `  ????B  >WpfShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfShop.ViewsWpfShop.Views  5           WpfShop.Views.CategoryView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:WpfShop.Views     5      g cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ac _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5      .??5      ? $??1??6   $??10 20 20 20q?6     ? RowDefinitions  5   
   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $??* ?6   ?? 5      $
??auto ?6   .+?5   
   ?? $??Members??6   $??1??6#   $??32(?60   $??SemiBold"?6>   $??0 20 0 0q?6T   ???#121518$
??Left=?6{   ?? 5   
      	addButton#??[  6B   $	??NaN??6e   $??0,24,0,4q?6r   $??2??6?   ??6   ?? *ShowCreateProductViewCommand+.??5      ??  ?? Orientation$ 
Horizontal=?6   .+?5      .  (MahApps.Metro.IconPacks.PackIconMaterial     Kind$
 Plus=?6(   $??Center=?64   $??0 1 8 0q?6O   $??11??6`   $??11??6k   ?? 5      $??Add New Member??6   5      5      ?? 5"   
   $??1??6   $??3??6   ???#DAE2EA$??	0 -1 0 10q?6A   ?? 5%   
   $??68 Club Staff??6   $??4??6)   $??18(?66   $??SemiBold"?6D   ???#121518$
??Left=?6o   $??Center=?6?   ?? 5'   
   $??	Filter by??6   $??4??6%   $??13(?62   $??SemiBold"?6@   $??	0 0 215 0q?6V   ???#121518$??Right=?6~   $??Center=?6?   ? 5*   
   $	??200??6   $??Right=?6   $??4??67   .+?5+      ?? $
??15 0q?6   $??Center=?6&   ???#B0B9C6 J? IsHitTestVisible .   K? ZIndex$ 1??5,      $??Search in Members ...??6-   ?? 5.      -   5        $??textBoxFilter??5.        filterTextBox#??[ 6+   5/      &   System.Windows.Controls.DataGrid  52   
   -   5          Name$ membersDataGrid??52   i     DataGridCellStyle1   	CellStyle# ?  68     DataGridStyle1#???  6?   ??6   ?? *CategoryList+   Columns 53      0  *System.Windows.Controls.DataGridTextColumn  54      ,  &System.Windows.Controls.DataGridColumn   Header$ #??6%   	   
IsReadOnly	 . 
   CanUserResize
 .     Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6X     55      $ Id??6%   	 . $ * 6Z   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   ?? *Id+6Z     56      $
 Name??6%   	 . $ * 6^    63   ?? *Name+6^     57      $ Price ??6%   	 . $ * 6g    65   ?? *Description+6g   4  .System.Windows.Controls.DataGridTemplateColumn  58      $ 
Operations??6)   $
 auto 6=      CellTemplate 59      ?? 5:      .R?5;      ?? $ 
Horizontal=?6)   .+?5<   "   ??   gridEditButton#??[ 6?   ??6)   ??  ?? Path$- 'DataContext.ShowEditCategoryViewCommand? ?? ElementName$ membersDataGrid????6?   ?? *Id+.??5=   &     $ PencilOutline=?6<     gridButtonIcon#??[ 6Q   5>   #   ?? 5?   "   $??5 0 0 0q?6?     gridRemoveButton#??[ 6?   ??6)   ?? $' !DataContext.DeleteCategoryCommand?$ membersDataGrid????6?   ?? *Id+.??5@   &     $ DeleteOutline=?6<   #??[ 6Q   5A   #   5B      5C      5E      5G      ?? 5J   
   $??6??6   $??Right=?6   ???#DEE4EC$??1q?6P    ?? CornerRadius$ 5??6d    ?? Padding$ 5q?6u   ???#ffffff$??
0 10 10 10q?6?   ._?5K      ?? $ 
Horizontal=?6   .+?5L      ??   pagingButton#??[ 6   .??5M        $ ChevronLeft=?6,     pagingButtonIcon#??[ 6?   5N      ?? 5O      $??1??6   ???#DEE4EC$	??3 7q?65   ?? 5Q      #??[ 6   $??1??6?   ?? 5R      #??[ 6   $??2??6?   ???#7950F2???#ffffff6`   ?? 5S      #??[ 6   $??3??6?   ?? 5U      $	??...??6   ???#6C7682$??Center=?6<   $
??10 0q?6W   $??15(?6e   ?? 5W      #??[ 6   $??7??6?   ?? 5X      #??[ 6   $??8??6?   ?? 5Y      #??[ 6   $??9??6?   ?? 5[      $??1??6   ???#DEE4EC$	??3 7q?65   ?? 5\      #??[ 6   .??5]        $ ChevronRight=?6,   #??[ 6@   5^      5_      5`      5b      5d      