   M S B A M L   `   `   `  ����E  ARestorator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Restorator.ViewModelRestorator.ViewModel  5   	   !    Restorator.View.AboutWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8	viewModel"clr-namespace:Restorator.ViewModel     5   	     � Title$  About��5   	   $	��360��5	   	   $	��360��5
   	   $	��500��5   	   $	��500��5   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$ 
ToolWindow=�5   	    � ShowInTaskbar .  � SizeToContent$ WidthAndHeight=�5   	   $
��Bold"�5   	    � Icon$ ../Images/big_icon.png��5   	    J� 	AllowDrop .  � DataContext 5      /  )Restorator.ViewModel.AboutWindowViewModel  5   
   6+   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $	��171 �6   	 � ColumnDefinitions	 5    
   �� 5!      $
��239* �6   �� 5"      $
��253* �6   .+�5%   
   �� $��0��6   $��0��5&      $
��Left=�5'      $��	10,10,0,0q�5(      $	��Top=�5)      $��../Images/big_icon.png��5*      $	��228��5+      $	��229��6   � 5-   
   $��0��6   $��1��6   $��Center=�5.      $��0,0,0,0q�5/      $	��234��6    	 51      �� 52      $��0* �6#   �� 53       56      �� 57      $	��50* �6    �� 58      $
��197* �6    .+�5;      �� $��
Restorator��6   ���	#FF212121$��40(�5=      $��Vivaldi)�5>      $��Center=�5?      $��Center=�5@      $	��Top=�5A      $��0��5B      
 J� RenderTransformOrigin$
 0.5,1.8&�5C      $��	30,0,42,0q�5D      $��1��5E      $��49��5F      $	��162��5G      �� 5H      $��Stretch=�5I      $
��Left=�5J      $��0,0,-9,0q�5K      $����     Program is created for automation of any restaurant. You can control the circulation of goods in stock, add new ones and delete that are not needed. Our manager has the ability to add new employees and guests, giving them a discount to the size of the order. Guests can choose meals and immediately receive a check for payment.��5N      $��Italic$�5O      $��Normal"�5P       �� TextWrapping$ WrapWithOverflow=�5Q      $	��243��5R      $��14(�5S      $��1��5T      $��2��5U      $��0��5V       �� IsReadOnlyCaretVisible . {�.  ��5L      Z� ��5M      Z�  �� SelectionBrush 5W      Z� 5Y      5[      �� 5\   
   $��0��6   $��0��5]      $��Version 2.1��5^      $��Center=�5_      $��89,0,88,154q�5`      $��Bottom=�5a      $
 -3.367,0.077&�5b      $��Normal"�5c      $��9.333(�5d      $��22��5e      $��62��5f      $��2��6   �� 5h   
   $��2��5i      $��0��5j      $����     Developer: Petrenko F. V., a student of IT-42, FICT, NTUU 'KPI'. With the desire to improve the system, please contact petrenkofv@ukr.net or (099)-343-23-65.��5m      $ WrapWithOverflow=�5n      $��12,10,98,104q�5o      $��1��5p      $��14(�5q       . {�.  ��5k      Z� ��5l      Z� 5s      �� 5u   
   $
��Back��6   $��1��5v      $��Right=�5w      $��	0,10,10,0q�5x      $��1��5y      $	��Top=�5z      $��88��5{      $��57��5|      ��5}      �� *CloseAboutWindowCommand+5~      5      