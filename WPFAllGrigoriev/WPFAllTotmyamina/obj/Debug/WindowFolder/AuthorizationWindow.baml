   M S B A M L   `   `   `  ????K  GWPFAllTotmyamina, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:WPFAllTotmyamina.WindowFolderWPFAllTotmyamina.WindowFolder  5   	   7    1WPFAllTotmyamina.WindowFolder.AuthorizationWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:WPFAllTotmyamina.WindowFolder     5   	     ? Title$  Авторизация??5   	   $	??470??5	   	   $	??400??6   $	??470??5
   	   $	??400??6   $	??470??5   	   $	??400??6    ? WindowStartupLocation$ CenterScreen=?5   	   .??5      ?  ? ColumnDefinitions 5   
   ?? 5      $??10 ?6   ?? 5      $	??150 ?6   ?? 5      ?? 5      $??10 ?6    ? RowDefinitions 5   
   ?? 5      $??10 ?6   ?? 5      ?? 5      $??10 ?6   ?? 5      $??70 ?6   ?? 5      $??10 ?6   ?? 5      $??70 ?6   ?? 5      $??10 ?6   ?? 5      $??70 ?6   ?? 5       $??10 ?6   ?? 5"      $??70 ?6   ?? 5#      $??10 ?6   .+?5&   
   ??    	LogoImage#???   6   $??1??5'      $??1??6    ?? 5)   
   $??Авторизация??6   $??1??5*      $??2??6     HeadingLabel#???  5+      ?? 5-   
   $??
Логин??6   $??3??5.      $??1??5/        OrdinaryLabel#???  50      ?? 52   
   -   5         ??Name$ LoginTb??52      $??3??53      $??2??54      ?? 56   
   $??Пароль??6   $??5??57      $??1??58      #???  59      G? 5:   
   -   5         G?Name$ 
PasswordPb??5:      $??5??5;      $??2??5<      ?? 5>   
   -   5         ??Name$ LoginBtn??5>      $??2??5?      $??7??5@      $??
Войти??5A      5B      ?? 5D   
   -   5        $ ExitBtn??5D      $??1??5E      $??7??5F      $??
Выйти??5G      5H      ?? 5J   
   -   5        $ RegistrationBtn??5J      $??1??5K      $??9??5L      $??Регистрация??5M      $??2??5N      5O      5T      5U      