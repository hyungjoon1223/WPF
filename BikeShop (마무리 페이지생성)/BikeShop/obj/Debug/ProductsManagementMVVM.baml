   M S B A M L   `   `   `  ????C  ?BikeShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:BikeShopBikeShop  5      %    BikeShop.ProductsManagementMVVM   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:BikeShop     5      -   5          N?Name$
  page??5	         
background N? 
Background# [  5       N? Title$ ProductsManagementMVVM??5
      $	??564??6&    ? DataContext 5      .  (BikeShop.ProductsManagementMVVMViewModel  5   
   .??5      ? $??
0,64,10,64q?6   .+?5   
   ?? $
??Left=?6   $??	30,20,0,0q?6/   $
??Wrap=?6B   $??Search??6V   $	??Top=?6d   ?? 5   
   -   5         ??Name$ textBox??5      $
??Left=?6#   $??23??6>   $??	92,19,0,0q?6J    ?? TextWrapping$
 Wrap=?6]   $	??Top=?6q   $	??452??6?   ??5      ?? *SearchInput+ ?? UpdateSourceTrigger$ PropertyChanged=?&   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGrid??5      $
??Left=?6%   $	??257??6@   $??	30,68,0,0q?6M   $	??Top=?6`   $	??355??6x   ??5      ?? *FoundProducts+ ?? SelectedItem 5      ?? *SelectedProduct+?? 5   
   
???   ?$??1q?5   !   $
??Left=?65   $	??288??6P   $??
385,68,0,0q?6]   $	??Top=?6q   $	??521??6?   
??????? 5      ?? *SelectedProduct+._?5      ?? $??10,10,10,-13q?6   .+?5      ?? $??Product details??6   $
??Bold"?5      $??16(?5      $??Center=?5      $??10q?5      ?? 5      $??Title??6   ?? 5      ??6   ?? *Title+?? 5       $??Price??6   ?? 5!      ??6   ?? *Price+?? 5"      $??Color??6   ?? 5#      ??6   ?? *Color+?? 5$      $??10??5%      ??5$      ?? *Color+5%      ?? 5&      $??	Reference??6   ?? 5'      ??6   ?? *	Reference+?? 5(      $??Visible=?6   .??5)      ??  6   ?? *DataContext+	 ?? ElementName$
	 page??._?5*      ?? 
 ?? Orientation$
 
Horizontal=?6H    6%   ?? *
AddProduct+.+?5,      ?? $??Title??6(   ?? 5-      ??6&   ?? *Title+?? 5.      $??Price??6(   ?? 5/      ??6&   ?? *Price+?? 50      $??Color??6(   ?? 51      ??6&   ?? *Color+?? 52      $??10??53      ??52   %   ?? *Color+53      ?? 54      $??	Reference??6(   ?? 55      ??6&   ?? *	Reference+56      57      58      ?? 59      -   5        $ ??원소를 추가합니다.??59      6.   ?? 5:      -   5        $.??(원소 추가를 위한 페이지 생성??5:      64   5;      5<      5>      5?      