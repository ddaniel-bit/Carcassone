   M S B A M L   `   `   `  ����E  ACarcassone, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Carcassone
Carcassone  5   	   #    Carcassone.PalyaBetoltoWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Carcassone     5   	   -   5        $	��360��5   	   $	��640��6     � Title$  
Carcassone��6"    � WindowStyle$
 None=�5	   	    � 
ResizeMode$ NoResize=�5
   	   
������  � AllowsTransparency$
 True��5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Icon$ /img/icon.ico��5   	   .��5      ��  �� CornerRadius$ 25��6   ��5   
   �� 5       �� ImageSource$ \img\palyavalasztobg.jpg��6   ._�5   
   �  � RowDefinitions 5      �� 5      �� 5      $��3* �6    �� 5      	 � ColumnDefinitions	 5      �� 5      �� 5      .+�5       �� $��Válassz pályát!��6   $��Center=�5!      $��Center=�5"      $��48(�5#      $��Algerian)�5$      $��2��5%      ��5&      �� 5'      
 �� EndPoint$
 0.5,1&�6*    �� 
StartPoint$ 0.5,0&�6;   .��5(      �  � Color$ #FFE55C��6'   � 5)      $ #B5634A��6'    � Offset$ 1Q�5*   '   5+       J� Effect 5-      3  -System.Windows.Media.Effects.DropShadowEffect  5.      51      �� 53      -   5         ��Name$ btnUj��53      $��
Új pálya��54      
������ 
������    ButtonStyleHover#���   57      $��32(�58      $��Algerian)�59       � Cursor$
 Hand��5:      $��1��5;      $��Center=�5<      $��Center=�5=      $��40��5>      ��5?      �� 5@      $
 0.5,1&�6*   $ 0.5,0&�6;   .��5A      � $ #FFE55C��6'   � 5B      $ #B5634A��6'   $ 1Q�5C   '   5D       5F        5G      5I      �� 5K      -   5        $ btnTallozas��5K      $��Tallózás fájlból��5L      
������ 
������ #���   5O      $��32(�5P      $��Algerian)�5Q      $
 Hand��5R      $��1��5S      $��1��5T      $��Center=�5U      $��Center=�5V      $��40��5W      ��5X      �� 5Y      $
 0.5,1&�6*   $ 0.5,0&�6;   .��5Z      � $ #FFE55C��6'   � 5[      $ #B5634A��6'   $ 1Q�5\   '   5]       5_        5`      5b      5d      5e      5f      