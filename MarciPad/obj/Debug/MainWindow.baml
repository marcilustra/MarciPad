   M S B A M L   `   `   `  ����C  ?MarciPad, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:MarciPadMarciPad  5   	       MarciPad.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:MarciPad     5   	   -   5          �Name$  
mainWindow��5   	    � Title$ MarciPad��5   	   $	��450��6   $��795.473��6'    � Icon$* $16de5f8dd1ffe99f9e169a0605a960b3.ico��5
   	   $	��300��5   	   $	��480��5   	    � WindowStyle$ ThreeDBorderWindow=�6    � WindowStartupLocation$ CenterScreen=�69    J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$
 Save��5      6J     5   
   -   5        $
 Open��5      6J     5   
   -   5        $	 Cut��5      6A     5   
   -   5        $
 Copy��5      6C     5   
   -   5        $ Paste��5      6E   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   o� -   5         o�Name$ menuBar��5      $��0��6    $��20��6-   	 K� ZIndex$	 1��69   $��Stretch=�6J   $	��Top=�6h   .@�5      m� $��_File��6   .@�5      m� -   5        
 m�Name$
 _Open��5      $��_Open��6*    m� Command$
 Open��6:   m� 5      -	   5        $
 _Save��5      $��_Save��6*   $
 Save��69   m� 5      -
   5        $
 _Close��5      $��_Close��6+   6;   m� 5      -   5        $
 _Exit��5      $
��Exit��6*   68   5       m� 5!      $
��Edit��6   .@�5"      m� -   5        $
 _Copy��5"      $
��Copy��6*   $
 Copy��69   m� 5#      -   5        $

 _Cut��5#      $	��Cut��6)   $	 Cut��67   m� 5$      -   5        $
 _Paste��5$      $��Paste��6+   $ Paste��6;   m� 5%      -   5        $
 _Find��5%      $
��Find��6*   m� 5&      -   5        $
 _Replace��5&      $��Replace��6-   5'      m� 5(      $��Theme��6   .@�5)      m� -   5        $��Light��5)      
 � Tag$ DefaultTheme.xaml��6>   6X   m� 5*      -   5        $
��Dark��5*      $ DarkTheme.xaml��6>   6U   5+      5,      �� 5.   
   $��1��6   $
��Auto=�6$   $
��Auto=�6G   .��5/      �� -   5        $��textBox��5/       �� AcceptsReturn .  �� 
AcceptsTab .  �� TextWrapping$
 Wrap=�6N   $
��Auto��6b   .��6p   ��50      �� 51       �� EndPoint$ 0.5,1&�6*    �� 
StartPoint$ 0.5,0&�6;   .��52      �  � Color$ 	Gainsboro��6'    � Offset$ 1Q�69   � 53      $ White��6'   54      .��55   &   56      57      58      59      