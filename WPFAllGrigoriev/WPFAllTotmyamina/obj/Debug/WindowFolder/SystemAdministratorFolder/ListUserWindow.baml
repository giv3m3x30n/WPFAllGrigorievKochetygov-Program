   M S B A M L   `   `   `  ????K  GWPFAllTotmyamina, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?Eclr-namespace:WPFAllTotmyamina.WindowFolder.SystemAdministratorFolder7WPFAllTotmyamina.WindowFolder.SystemAdministratorFolder  5   	   L    FWPFAllTotmyamina.WindowFolder.SystemAdministratorFolder.ListUserWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   WlocalEclr-namespace:WPFAllTotmyamina.WindowFolder.SystemAdministratorFolder     5   	   -   5          ? Title$-  'Список пользователей??5   	   $	??750??5	   	   $
??1400??6    ? WindowStartupLocation$ CenterScreen=?5
   	   .??5      ?  ? ColumnDefinitions 5   
   ?? 5      $??10 ?6   ?? 5      $	??120 ?6   ?? 5      ?? 5      $??10 ?6    ? RowDefinitions 5   
   ?? 5      $??10 ?6   ?? 5      $??90 ?6   ?? 5      $??10 ?6   ?? 5      $??70 ?6   ?? 5      $??10 ?6   ?? 5      ?? 5      $??10 ?6   .+?5   
   ??    	LogoImage#???   6   $??1??5      $??1??6    ?? 5!   
   $-??'Список пользователей??6   $??1??5"      $??2??6     HeadingLabel#???  5#      ?? 5%   
   $??
Поиск??6   $??3??5&      $??1??5'        OrdinaryLabel#???  5(      ?? 5)   
   -   5         ??Name$ SearchTb??5)      $??3??5*      $??2??5+      &   System.Windows.Controls.DataGrid  5-   
   -   5          Name$ UserDG??5-         
IsReadOnly .    AutoGenerateColumns .  $??1??5.   /   $??2??5/      $??5??50         Columns 51      0  *System.Windows.Controls.DataGridTextColumn  52      -   5        dgTcIdStaff??,  &System.Windows.Controls.DataGridColumn	   Header$	 	№ п/п??53   %   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 54   %   ?? *IdUser+  55      -   5        dgTcLastName??$	 
Логин??56   %      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 57   %   
 58   %   ?? *	LoginUser+  59      -   5        dgTcFirstName??$	 Пароль??5:   %   $ * 5;   %   
 5<   %   ?? *PasswordUser+  5=      -   5        dgTcMiddleName??$	 Роль??5>   %   $ * 5?   %   
 5@   %   ?? *
NameRole+5C      5D      5E      