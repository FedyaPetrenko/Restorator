   M S B A M L   `   `   `  ����E  ARestorator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Restorator.ViewModelRestorator.ViewModel  5   	   #    Restorator.View.AddDishWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8	viewModel"clr-namespace:Restorator.ViewModel     5   	     � Title$  Restorator - Add dish��5   	   $
��auto��5	   	   $
��Auto��5
   	   $	��340��5   	   $	��260��5   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$ 
ToolWindow=�5   	    � ShowInTaskbar .  � SizeToContent$ WidthAndHeight=�5   	    � Topmost .  � Icon$ ../Images/big_icon.png��5   	    � DataContext 5      1  +Restorator.ViewModel.AddDishWindowViewModel  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5       $
��auto �6   �� 5!      $
��auto �6   	 � ColumnDefinitions	 5$   
   �� 5%      $
��auto �6   �� 5&      $
��auto �6   .+�5)   
   �� $��../Images/PNG.png��6   $	��200��5*      $��4��5+      
 J� Opacity$	
 0.9Q�5,       � ToolTip$ Click to change image��5-      $��Center=�5.      �� 50   
   $��0��6   $��1��51       �� Orientation$ 
Horizontal=�52      $��5,10,5,0q�53      .+�55      �� $��Name:��6   $��21.333(�56      $��Yu Gothic UI Semibold)�57      $
��Left=�58      $��	10,0,58,0q�59         
LabelStyle#��[  5:      �� 5<      $	��170��6   $��30��5=      $��Right=�5>      $��20(�5?      $��15,0,0,0q�5@      ��5A      �� *Name+5B      �� 5D   
   $��1��6   $��1��5E      $ 
Horizontal=�5F      $��5,0,5,0q�5G      .+�5I      �� $��Type of meal:��6   $��21.333(�5J      $��Yu Gothic UI Semibold)�5K      $
��Left=�5L      $��10,0,5,0q�5M      #��[  5N      �� 5P      $	��170��6   $��30��5Q      4  .System.Windows.Automation.AutomationProperties   ItemType$ string��5R       �� SelectedIndex$ 0��5T      $��18(�6)   $��Source Code Pro Semibold)�67   $
��Bold"�6]   $��Italic$�6o   ��5S      �� *TypesOfMeal+5T   o   5W      �� 5Y   
   $��2��6   $��1��5Z      $ 
Horizontal=�5[      $��5,0,5,0q�5\      .+�5^      �� $��Weight:��6   $��21.333(�5_      $��Yu Gothic UI Semibold)�5`      $
��Left=�5a      $��	10,0,60,0q�5b      #��[  5c      �� 5e      $	��170��6   $��30��5f      $��Right=�5g      $��20(�5h      ��5i      �� *Weight+5j      �� 5l   
   $��3��6   $��1��5m      $ 
Horizontal=�5n      $��5,0,5,0q�5o      .+�5q      �� $��Composition:��6   $��21.333(�5r      $��Yu Gothic UI Semibold)�5s      $
��Left=�5t      $��10,0,5,0q�5u      #��[  5v      �� 5x      $	��170��6   $��30��5y      5z      �� 5|   
   $��4��6   $��1��5}      $ 
Horizontal=�5~      $��5,0,5,0q�5      .+�5�      �� $��Price:��6   $��21.333(�5�      $��Yu Gothic UI Semibold)�5�      $
��Left=�5�      $��	10,0,82,0q�5�      #��[  5�      �� 5�      $	��170��6   $��30��5�      $��Right=�5�      $��20(�5�      ��5�      �� *Price+5�      �� 5�   
   $��4��6   $��0��5�      $ 
Horizontal=�5�      $��0,0,0,0q�5�      .+�5�      �� $��
Clear text��6   $��Center=�5�      $
��Left=�5�      $��10,10,10,10q�5�      $��5q�5�      ��5�      �� *ClearTextButtonCommand+�� 5�      $��	Save dish��6   $��Right=�5�      $��
10,10,0,10q�5�      ��5�      �� *SaveDishButtonCommand+5�      5�      5�      