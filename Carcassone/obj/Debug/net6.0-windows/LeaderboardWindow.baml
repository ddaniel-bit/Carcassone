   M S B A M L   `   `   `  ����E  ACarcassone, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Carcassone
Carcassone  5   	   "    Carcassone.LeaderboardWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Carcassone     5   	   -   5        $	��720��5   	   $
��1280��6     � Title$  
Carcassone��6#    � WindowStyle$
 None=�5	   	    � 
ResizeMode$ NoResize=�5
   	   
������  � AllowsTransparency$
 True��5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Icon$ /img/icon.ico��5   	   .��5      ��  �� CornerRadius$ 25��6   ��5   
   �� 5       �� ImageSource$ \img\background.jpg��6   ._�5   
   �  � RowDefinitions 5      �� 5      �� 5      $��8* �6    �� 5      .+�5      �� $��Right=�6   .+�5      �� -   5        	 ��Name$	 btnTalcaraTesz��5         ButtonStyleHover#���   5      
������ $��-��5       $��50(�5!      
 � Cursor$

 Hand��5"      
������ $��
0 -15 15 0q�5%      $��50��5&       J� Effect 5'      3  -System.Windows.Media.Effects.DropShadowEffect  5(      ��5+      �� 5,       �� EndPoint$ 0.5,1&�6.    �� 
StartPoint$ 0.5,0&�6?   .��5-      �  � Color$ #FFE55C��6+   � 5.      $ #B5634A��6+    � Offset$ 1Q�5/   '   50      53      54      &   System.Windows.Controls.DataGrid  56      -   5          Name$ dgLeaderboard��56   I     DataGridStyleCarcassone#���  6   $��1��57      
������ 
������ $��24(�59   1   $

 Hand��6?   $��Center=�6M   $��Center=�6j    5:        5;      ��5=      �� 5>      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5?      � $ #FFE55C��6'   � 5@      $ #B5634A��6'   $ 1Q�67   5A      5C      �� 5E      -   5        $	 btnExit��5F      #���   5E      $��2��5G      $	��450��5H      $��50��5I      $��Vissza a fömenübe��5J      $��45(�5K      $��Algerian)�5L      
������ 
������ $

 Hand��5R       5S        5T      ��5W      �� 5X      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5Y      � $ #FFE55C��6'   � 5Z      $ #B5634A��6'   $ 1Q�67   5[      5^      5_      5`      5b      