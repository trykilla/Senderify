   M S B A M L   `   `   `  ????D  @Senderify, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Senderify	Senderify  5   	       Senderify.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Senderify     5   	   -   5          ?Name$  	Sendirify??5   	    ? WindowStartupLocation$ CenterScreen=?5   	    ? Title$ 	Sendirify??5	   	   $	??550??6   $	??800??6(    ? Icon$ /arbolico_png.png??64    ? 
ResizeMode$ NoResize=?6M   .??5
      ?  ? RowDefinitions 5   
   ?? 5      $	??70* ?6   ?? 5      $	??70* ?6   ?? 5      $	??40* ?6   ?? 5      $	??40* ?6   ?? 5      $	??40* ?6    ? ColumnDefinitions 5   
   ?? 5      $
??160* ?6   ?? 5      $	??55* ?6   ?? 5      $
??249* ?6   ?? 5      $
??122* ?6   ?? 5      $	??55* ?6   ?? 5      $
??160* ?6   .+?5   
   ?? -   5         ??Name$ fondo??5      
???   ?$??6??62   $??5??6F   $??0??6W   $??0??6g   ??5      ?? 5       ?? ImageSource$ /foto_trans.png??6   5      ?? 5"   
   -   5        	 ??Name$		 esi??5"      $??0??6   $??0??6-   $??/esi_logo.png??6:   $??21,26,24,38q?6Q   ?? 5#   
   -   5        $ login_cuadro??5#      $??1??6*   $??1??6:   
???   ?$??4??6V   ???	#FF26221F
 ?? StrokeEndLineCap$
 Round=?6x    ?? StrokeStartLineCap$ Round=?6?    ?? StrokeLineJoin$ Round=?6?    ?? StrokeDashCap$ Round=?6?    ?? RadiusX$ 10??6?    ?? RadiusY$ 10??6?   $??0,0,0,82q?6?   $??4??6  ?? 5$   
   -   5         ??Name$ 
txt_inicio??5$      $??2??6$   $??¡Bienvenido a Sendirify!??64   $
??Left=?6W   $??1??6r   $	??Top=?6   
???????$??49??6?   $	??348??6?   $??30(?6?   $??Comic Sans MS)?6?   $??	11,23,0,0q?6?   $??2??6?   ?? 5%   
   -   5         ??Name$ user_box??5%      $??2??6%   $
??Left=?65   $??
51,115,0,0q?6P   $??1??6d    ?? TextWrapping$
 Wrap=?6q   $	??Top=?6?   $	??268??6?   $??29??6?   $??2??6?    ?? IsUndoEnabled$ False??6?   4  .System.Windows.Automation.AutomationProperties   HelpText$ Introduzca el usuario...??6?   $??Introduzca el usuario...??6  $??Comic Sans MS)?65  $??Italic$?6P  
???????$??16(?6?  $??2??6  .??6   ? 	Resources 5&       ?? 
TargetType ?? Property ?? Value??%d   '??       ?? 5'      " ??6   .?5(      ??  ?@??CornerRadius$ 10??65   6B   5)      5*      .??6!   5+      ?? 5,   
   -   5        $ pass_box??5,      $??2??6$   $
??Left=?64   $??2??6O   $
 Wrap=?6\   $"??Introduzca la contraseña...??6p   $	??268??6?   $??	51,41,0,0q?6?   $??29??6?   $	??Top=?6?   $??16(?6?   $??Comic Sans MS)?6?   $??Italic$?6?   
???????${?False??6?  $??2??6?  .??6?   5-      ??%d   '??       ?? 5.      " ??6   .?5/      ??  ?@??CornerRadius$ 10??65   6B   50      51      .??6!   52      ?? 53   
   -   5         ??Name$ 	btn_login??53       ? Cursor$
 Hand??6   $??Entrar??62   $??2??6C   $??25,23,25,24q?6S   $??3??6h   ???	#FF2F6539
???????$??Comic Sans MS)?6?   $??20(?6?   $??2??6$   54      ??%d   '??       ?? 55      " ??6   .?56      ??  ?@??CornerRadius$ 10??65   6B   57      58      59      ?? 5:   
   -	   5        $ main_helpbutton??5:      $
 Hand??6   $??5??68   $??Button??6H   $??Center=?6Y   $??56??6t    J? RenderTransformOrigin$ 0.552,0.661&?6?   $??	51,0,51,0q?6?   ??6?   Z? ??6?   Z? ??5;      ?? 5<      $ 
/ayuda.png??6   5>      5@      5A      