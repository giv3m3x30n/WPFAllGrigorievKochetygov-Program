   M S B A M L   `   `   `  ????K  GWPFAllTotmyamina, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?Eclr-namespace:WPFAllTotmyamina.WindowFolder.SystemAdministratorFolder7WPFAllTotmyamina.WindowFolder.SystemAdministratorFolder  5   	   R    LWPFAllTotmyamina.WindowFolder.SystemAdministratorFolder.ListOfProductsWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   WlocalEclr-namespace:WPFAllTotmyamina.WindowFolder.SystemAdministratorFolder     5   	     ? Title$%  Список продуктов??5   	   $	??750??5	   	   $
??1400??6    ? WindowStartupLocation$ CenterScreen=?5
   	   .??5      ?  ? ColumnDefinitions 5   
   ?? 5      $??10 ?6   ?? 5      $	??120 ?6   ?? 5      ?? 5      $??10 ?6    ? RowDefinitions 5   
   ?? 5      $??10 ?6   ?? 5      $??90 ?6   ?? 5      $??10 ?6   ?? 5      $??70 ?6   ?? 5      $??10 ?6   ?? 5      ?? 5      $??10 ?6   .+?5   
   ??    	LogoImage#???   6   $??1??5      $??1??6    ?? 5    
   $%??Список продуктов??6   $??1??5!      $??2??6     HeadingLabel#???  5"      ?? 5$   
   $??
Поиск??6   $??3??5%      $??1??5&        OrdinaryLabel#???  5'      ?? 5(   
   -   5         ??Name$ SearchTb??5(      $??3??5)      $??2??5*      &   System.Windows.Controls.DataGrid  5,   
   -   5          Name$ 
ProductsDG??5,         
IsReadOnly .    AutoGenerateColumns .  $??1??5-   /   $??2??5.      $??5??5/         Columns 50      0  *System.Windows.Controls.DataGridTextColumn  51      -   5        
dgTcIdUser??,  &System.Windows.Controls.DataGridColumn	   Header$	 	№ п/п??52   %     53      -   5        dgTcName??$	 Наименование??54   %   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 55   %     56      -   5        	dgTcCount??$	 Количество??57   %   $
 * 58   %     59      -   5        	dgTcPrice??$"	 Цена за единицу??5:   %   $
 * 5;   %     5<      -   5        dgTcItogPrice??$	 Итоговая цена??5=   %   $
 * 5>   %   5A      5B      5C      