   M S B A M L   `   `   `  ????J  FItemsControlApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ItemsControlAppItemsControlApp  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	        ItemsControlApp.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:ItemsControlApp     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	     ? Title$  
MainWindow??5	   	   $	??450??6   $	??800??6)    ? 	Resources 5
         ItemsControlApp.StrList   lt??%Y   &	          5   
   ??5      123??6   ??5      	45678??6    5      5      .??5      ?  ? ColumnDefinitions 5   
   ?? 5      6!   ?? 5      6!    ? RowDefinitions 5   
   ?? 5      $	??100 ?6   6+   ?? 5      6   .+?5   
   ?? .+?5      ?? $??리스트 정보??6   .??5      ?? ?? 5      $??Count : ??6    ?? 5      ??6   ?? *
List.Count+ ?? Mode$ OneWay=? ?? 5      $??리스트 이름: ??6    ?? 5      ??6   ?? *List.ListName+$ OneWay=?5       5!      ?? 5"      $??5q?6   ?? 5#      $	??100??6D   ??6   ?? *SelectedItem+ ?? ElementName$ lb??6D   ?? 5$      $	??100??6E   ??6   ?? *SelectedIndex+$ lb??6E   5%      ?? 5&   
   -   5         ??Name$ lb??5&      $??1??6;   ??6   ?? *List+6;   ?? 5'   
   $??1??6E   $??1??6R   ??6   ??  ?? Source# [  6R   ?? 5(   
   -   5        $??1??5(      $??오른쪽추가??6!   $
??Left=?61   $??22??6L   $??
252,60,0,0q?6X   $	??Top=?6l   $??98??6?    J? RenderTransformOrigin$ 0.495,-1.18&?6?   6?   ?? 5)   
   -   5        $??1??5)      $??왼쪽추가??6!   $
??Left=?60   $??25??6K   $??
252,30,0,0q?6W   $	??Top=?6k   $??98??6?   6?   ?? 5*   
   -   5        	 ??Name$		 tb1??5*      $??1??6   $
??Left=?6/   $??25??6J   $??	73,30,0,0q?6V   
 ?? TextWrapping$

 Wrap=?6i   $??TextBox??6}   $	??Top=?6?   $	??159??6?   ?? 5+   
   -   5        $		 tb2??5+      $??1??6   $
??Left=?6/   $??22??6J   $??	73,60,0,0q?6V   $

 Wrap=?6i   $??TextBox??6}   $	??Top=?6?   $	??159??6?   5,      5-      