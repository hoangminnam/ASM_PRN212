   M S B A M L   `   `   `  ����A  =WPFApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WPFAppWPFApp  5   	       WPFApp.RoomManagerWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:WPFApp     5   	   -   5          � Title$  RoomManagerWindow��5   	   $	��450��6#   $	��800��60    � WindowStartupLocation$ CenterScreen=�5
   	   .��5      � ��5   
   �� 5       �� 
StartPoint$	 0,0&�6"    �� EndPoint$	 1,1&�63   .��5      �  � Color$ #0099FF��6    � Offset$ 0Q�6/   � 5      $ 	#FF347BDA��6   $ 0.794Q�61   � 5      $ 	#FF60B1E7��6   $ 1Q�61   � 5      $ 	#FF596FDD��6   $ 0.309Q�61   � 5      $ 	#FF472FDE��6   $ 0.484Q�61   5       � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgData��5      $��0��6#   $��10q�60      AutoGenerateColumns$ False��6<   	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Room ID��6%      
IsReadOnly$
 True��6Q   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *RoomId+6Q     5      $
 Room Number��6%   $
 True��6Y    6:   �� *
RoomNumber+6Y     5      $
 Description��6%   $
 True��6^    6:   �� *RoomDescription+6^     5      $
 Max Capacity��6%   $
 True��6_    6;   �� *RoomMaxCapacity+6_     5       $
 Status��6%   $
 True��6T    65   �� *
RoomStatus+6T     5!      $
 Price Per Date��6%   $
 True��6b    6=   �� *RoomPricePerDate+6b     5"      $
 Room Type ID��6%   $
 True��6Z    6;   �� *
RoomTypeId+6Z   5$      �� 5(   
   $��1��6    �� Orientation$ 
Horizontal=�6"   $��Center=�6;   $��10q�6X   .+�5)      �� -   5        $
��Back��5)      $��75��6$   $��5q�6/   6:   �� 5*      -   5        $��Create��5*      $��75��6&   $��5q�61   6<   �� 5+      -   5        $��Update��5+      $��75��6&   $��5q�61   6<   �� 5,      -   5        $��Delete��5,      $��75��6&   $��5q�61   6<   5-      5/      50      