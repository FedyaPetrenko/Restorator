   M S B A M L   `   `   `  ����E  ARestorator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Restorator.ViewModelRestorator.ViewModel  5   	   &     Restorator.View.AddProductWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   4local"clr-namespace:Restorator.ViewModel     5   	     � Title$"  Restorator - Add new product��5   	   $	��260��5   	   $	��340��5   	   $	��340��5   	   $	��260��5	   	    � WindowStartupLocation$ CenterScreen=�5
   	    � WindowStyle$ 
ToolWindow=�5   	    � ShowInTaskbar .  � SizeToContent$ WidthAndHeight=�5   	    � Topmost .  � Icon$ ../Images/big_icon.png��5   	    � DataContext 5      4  .Restorator.ViewModel.AddProductWindowViewModel  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   	 � ColumnDefinitions	 5!   
   �� 5"      $	��330 �6   .+�5%   
   �� $��0��6   
 �� Orientation$
 
Horizontal=�5&      $��5,10,5,0q�5'      .+�5)      �� $��Name:��6   $��21.333(�5*      $��Yu Gothic UI Semibold)�5+      $
��Left=�5,      $��	10,0,58,0q�5-         
LabelStyle#��[  5.      �� 50      $	��170��6   $��30��51      $��Right=�52      $��20(�53      ��54      �� *Name+55      �� 57   
   $��1��6   $
 
Horizontal=�58      $��5,0,5,0q�59      .+�5;      �� $��Description:��6   $��21.333(�5<      $��Yu Gothic UI Semibold)�5=      $
��Left=�5>      $��10,0,5,0q�5?      #��[  5@      �� 5B      $	��170��6   $��30��5C      $��Right=�5D      $��20(�5E      ��5F      �� *Description+5G      �� 5I   
   $��2��6   $
 
Horizontal=�5J      $��5,0,5,0q�5K      .+�5M      �� $��Price:��6   $��21.333(�5N      $��Yu Gothic UI Semibold)�5O      $
��Left=�5P      $��	10,0,68,0q�5Q      #��[  5R      �� 5T      $	��170��6   $��30��5U      $��Right=�5V      $��20(�5W      ��5X      �� *Price+5Y      �� 5[   
   $��3��6   $
 
Horizontal=�5\      $��5,0,5,0q�5]      .+�5_      �� $��Count:��6   $��21.333(�5`      $��Yu Gothic UI Semibold)�5a      $
��Left=�5b      $��	10,0,56,0q�5c      #��[  5d      �� 5f      $	��170��6   $��30��5g      $��Right=�5h      $��20(�5i      ��5j      �� *Count+5k      �� 5m   
   $��4��6   $
 
Horizontal=�5n      $��5,0,5,0q�5o      .+�5q      �� $��
Clear text��6   $��Center=�5r      $
��Left=�5s      $��15,10,50,10q�5t      $��5q�5u      ��5v      �� *ClearTextCommand+�� 5x      $��Save product��6   $��Right=�5y      $��20,10,15,10q�5z      ��5{      �� *SaveProductCommand+5|      5}      5~      