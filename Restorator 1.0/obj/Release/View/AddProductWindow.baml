   M S B A M L   `   `   `  ���� E  ARestorator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Restorator.ViewModelRestorator.ViewModel  &     Restorator.View.AddProductWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     4local"clr-namespace:Restorator.ViewModel       � Title$"  Restorator - Add new product��$	��260��$	��340��$	��340��$	��260�� � WindowStartupLocation$ CenterScreen=� � WindowStyle$ 
ToolWindow=� � ShowInTaskbar .  � SizeToContent$ WidthAndHeight=� � Topmost .  � Icon$ ../Images/big_icon.png�� � DataContext 4  .Restorator.ViewModel.AddProductWindowViewModel  .���  � RowDefinitions �� $
��Auto ��� $
��Auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto �	 � ColumnDefinitions	 �� $	��330 �.+��� $��0��
 �� Orientation$
 
Horizontal=�$��5,10,5,0q�.+��� $��Name:��$��21.333(�$��Yu Gothic UI Semibold)�$
��Left=�$��	10,0,58,0q�   
LabelStyle#��[  �� $	��170��$��30��$��Right=�$��20(����� *Name+�� $��1��$
 
Horizontal=�$��5,0,5,0q�.+��� $��Description:��$��21.333(�$��Yu Gothic UI Semibold)�$
��Left=�$��10,0,5,0q�#��[  �� $	��170��$��30��$��Right=�$��20(����� *Description+�� $��2��$
 
Horizontal=�$��5,0,5,0q�.+��� $��Price:��$��21.333(�$��Yu Gothic UI Semibold)�$
��Left=�$��	10,0,68,0q�#��[  �� $	��170��$��30��$��Right=�$��20(����� *Price+�� $��3��$
 
Horizontal=�$��5,0,5,0q�.+��� $��Count:��$��21.333(�$��Yu Gothic UI Semibold)�$
��Left=�$��	10,0,56,0q�#��[  �� $	��170��$��30��$��Right=�$��20(����� *Count+�� $��4��$
 
Horizontal=�$��5,0,5,0q�.+��� $��
Clear text��$��Center=�$
��Left=�$��15,10,50,10q�$��5q����� *ClearTextCommand+�� $��Save product��$��Right=�$��20,10,15,10q����� *SaveProductCommand+