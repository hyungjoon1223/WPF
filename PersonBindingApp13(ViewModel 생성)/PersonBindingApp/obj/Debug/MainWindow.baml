   M S B A M L   `   `   `  ????K  GPersonBindingApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:PersonBindingAppPersonBindingApp  5   	   !    PersonBindingApp.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:PersonBindingApp     5   	   _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3b+http://schemas.microsoft.com/xaml/behaviors  5   	     ? Title$  
MainWindow??5	   	   $	??450??6   $	??800??6)    ? 	Resources 5      $   PersonBindingApp.AgeValidation   ageValidation ?? 
TargetType ?? Property ?? Value  lbs1??%  &	        '??      &	 y      5   
   6   ?? 5   
   " ??6   .?5      ??  ? ?? 5      ?? 5      .R?5      ?? ?? 5      $??이름::??6(    ?? 5      ??6&   ?? *Name+ ?? 5      $??나이:??6(    ?? 5      ??6&   ?? *Age+ ?? 5      $??색상:??6(    ?? 5      ??6&   ?? *Clr+5      5      5      5      ?? 5   
   " ??6   .?5      ??  ? ?? 5      ?? 5       .R?5!      ?? .??5"      ?? $??10q?6)   .+?5#   "   ?? $??이름:??6,   ?? 5$   "   ??6*   ?? *Name+?? 5%   "   $??나이:??6,   ?? 5&   "   ??6*   ?? *Age+?? 5'   "   $??색상:??6,   ?? 5(   "   ??6*   ?? *Clr+5)      5*      5+      5-      5.      5/      .??50      ? -   5         ?Name$
 grid??50       ? DataContext 6   ?? *	PerList+ ? ColumnDefinitions 51   
   ?? 52      ?? 53       ? RowDefinitions 55   
   ?? 56      ?? 57      .+?59   
   ?? -   5        $	??lb1??59      $	 ?? IsSynchronizedWithCurrentItem$
	 TrueY?5:      ??59      ?? 5;      ?? 5<   
   $??1??6   $
	 TrueY?69   #??[ 5=      
?????????5<      ?? ??5>      ?? 5?      .R?5@      ?? .??5A      ? 
 ? ActualWidth#??z
 6   .+?5B      ?? $??5q?6(   #??z??63   ?? 5C      $??10q?6-   5D      5E      5F      ??5H      ?? 5I      .R?5J      ? 5K      5M      ?? 5N   
   $??1??6   .+?5O      ??  ?? Orientation$ 
Horizontal=?6   .+?5P      ?? 	이름:6!   ?? 5Q      $??80??6   ??6%   ?? *Name+?? 5R      	나이:6!   ?? 5S      $??80??6    ? ToolTip 6%   ??  ?? Path$) #(Validation.Errors)[0].ErrorContent? ?? RelativeSource ?? *Self+.??6?   ??5T      ?? 5U      $	 Age?6"    ?? ValidationRules 5V        5W   "   5Y      .??5Z   $   5[      ?? 5\      	색상:6!   ?? 5]      $??80??6   ??6%   ?? *Clr+5^      ?? 5_      $??추가??6    6"   ?? *DataContext+ ?? ElementName$ 
mainWindow????6^   ?? *AddPerCommand+5`      5a      5b      