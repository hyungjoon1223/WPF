   M S B A M L   `   `   `  ????K  GPersonBindingApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:PersonBindingAppPersonBindingApp  5   	   !    PersonBindingApp.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:PersonBindingApp     5   	   _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3b+http://schemas.microsoft.com/xaml/behaviors  5   	     ? Title$  
MainWindow??5	   	   $	??450??6   $	??800??6)    ? 	Resources 5
         PersonBindingApp.Person   per   Name
   Age
   Clr%   PersonBindingApp.ColorConverter  clrConverter  dt1 ?? DataType ?? 	Converter 
 style1 ?? 
TargetType ?? Property	 ?? Value  ct1
 ?? 
TargetType??%?  &	        &	 L     &	 _     7  (??     5      *, +)7  &	 ?    7  '?? /    &	 }      5   
   $ 임시디자인이름??6#   $ 10??62   $	 Red??6;     5   
   6   ?? 5   
   "  6#   .R?5      ?? ?? 6   $?Name : ??6   ?? 6.   .F?5      ?? ??6    ?? *Name+5      ?? 6&   $? Age : ??6*   ?? 6;   .F?5      ?? ??6    ?? *Age+5      ?? 6&   $?	 Color : ??6*   ?? 6=   .F?5      ?? ??6    ?? *Clr+5      ?? 6&   $? ??6*   ?? 65   .F?5      ?? $??50??6    $??10??6+   ??5      ?? *Clr+8   5      6'   5      ?? 5   
   "  6   .R?5      ?? ?? 6   $?Name : ??6   ?? 6.   .F?5      ?? ??6    ?? *Name+5      ?? 6&   $? Age : ??6*   ?? 6;   .F?5      ?? ??6    ?? *Age+5      ?? 6&   $? ??6*   ?? 65   .F?5      ?? ??6   ?? *Clr+8   ._?5       ?? ?? 6%   $?Color : ??6)   ?? 6;   .F?5!   "   ?? ??6,   ?? *Clr+5"      63   5#      5$      6'   5%      ?? 5'   
   " ??6   .?5(      ??  ? ??$	 10q?6'   ?? 5)       ? ??8	   6-   5*      ?? 5+   
   " ??6   .?5,      ??  ? ??$	 0,0,0,10q?6'   5-      ?? 5.   
   "
 ??6&   .R?5/      ? .+?50      A? #??z??6   #??z??6:   #??z??6\   ?? 51      $??Center=?6#   $??Center=?6>   52      53      56      .??57      ?  ? ColumnDefinitions 58   
   ?? 59      ?? 5:      .+?5<   
   ?? .+?5=      ?? $??5q?6/   ??6   ?? *Name+.??5>      ??  ?? Orientation$ 
Horizontal=?6   $??22??66   .+?5?      ?? -   5         ??Name$ tbName??5?       ??60   ?? *Name+?? 5@      -   5         ??Name$ tbAge??5@      ??6-   ?? *Age+?? 5A      -   5        $ tbColor??5A       ??61   ?? *Clr+??5B      ?? *Clr+# [ ?? 5C      $??10q?6   ?? 5D      ??6    ?? *Age+?? 5E      $??5q?6   ?? 5F      -   5        $??생일??5F   2   5G      5H      ?? 5I      $??5q?6/   ??6   ?? *Name+.??5J      ?? $ 
Horizontal=?6   $??22??66   .+?5K      ?? ??6    ?? *Text+ ?? ElementName$ tbName???? 5L      ??6   ?? *Text+$ tbAge???? 5M      ??6    ?? *Text+$ tbColor????5N      ?? *
Background+$ tbColor???? 5O      $??10q?6   ?? 5P      ??6    ?? *Age+?? 5Q      $??5q?6   ?? 5R      -   5        $??생일??5R   2   5S      5T      ?? 5V      -   5        $??data1??5V      $	??200??6%   $??50??61   ??5W      ?? 5X      "
 ??6&   .R?5Y      ? .+?5Z      A? $	??100??6&   $??50??62   
????  ?6>   ?? 5[      $??Center=?6/   $??Center=?6J   5\      5]      5_      ?? 5`      $??data1??6   $	??150??6%   $??50??61   
??? ???*  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5a      +  %Microsoft.Xaml.Behaviors.EventTrigger  5b         	EventName$ Click??6%   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 5c      4  .Microsoft.Xaml.Behaviors.Core.CallMethodAction     
MethodName$ Click??6F      TargetObject 6-   ?? 6F   5d      ??5f      ?? 5g      "
 ??6&   .R?5h      ? .+?5i      A? #??z??6&   #??z??6F   #??z??6h   ?? 5j      $??Center=?6/   $??Center=?6J   5k      5l      5n      ?? 5o      -   5        $??data1??5o      $	??150??6%   $??50??61   
???????#??[ 5p      6T   ?? 5q      -   5         ??Name$ button??5q      $??data2??6%   $	??150??65   $??50??6A   
???????#??[ 5r       5s        5t      $ 
MouseEnter??6%   . 5u      8  2Microsoft.Xaml.Behaviors.Core.ChangePropertyAction     PropertyName$ 
Background??6]   4  .Microsoft.Xaml.Behaviors.TargetedTriggerAction   TargetObject 61   ?? $ button??   Value 5v      ?? 5w   "    ?? Color$ Yellow??62   5y      5z        5{      $ 
MouseLeave??6%   . 5|        $ 
Background??6]    61   ?? $ button?? 5}      ?? 5~   "   $ 
LightGreen??62   5?      5?      5?      ?? 5?      $??data1??6   $	??150??6%   $??50??61   5?      ?? 5?   
   $??1??5?       ? DataContext 5?      ??  
 people ?? Source# [ .+?5?      ?? #??[ 6.   ??6   ?? 6.   ?? 5?      $??10??6   ?? 5?      #??[ 6.   ??6   ?? 6.   ?? 5?      $??10??6   ?? 5?      ??6   ?? ?? 5?      $??10??6   ?? 5?      ??6   ?? ?? 5?      $??10??6   ?? 5?      ??6   ?? 5?      5?      5?      