   M S B A M L   `   `   `  ����E  ARestorator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Restorator.ViewModelRestorator.ViewModel  5   	   !    Restorator.View.DepotWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   4local"clr-namespace:Restorator.ViewModel     5   	     � Title$   Restorator - Product depot��5   	   $	��400��5   	   $	��900��5   	    � WindowStartupLocation$ CenterScreen=�5   	    � ShowInTaskbar .  � SizeToContent$ WidthAndHeight=�5
   	    � Topmost .  � Icon$ ../Images/big_icon.png��5   	    � 
ResizeMode$ 	CanResize=�5   	    � DataContext 5      /  )Restorator.ViewModel.DepotWindowViewModel  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   	 � ColumnDefinitions	 5   
   �� 5      $��* �6   .+�5   
   &   System.Windows.Controls.DataGrid  $��10q�5      $
��auto��5       "
   VerticalScrollBarVisibility$

 Auto=�5!         CanUserReorderColumns .    CanUserResizeRows .     CanUserSortColumns . ���	#FFEBEBFF   
IsReadOnly .  {�.    RowBackground
 �����$��18.667(�5+      $��Times New Roman)�5,         SelectionMode$ Single=�5-         AutoGenerateColumns .     MaxColumnWidth$	 300Q�5/       � ToolTip$ Click to change data��51      ��5&      Z� ��5*      �� *
Products+ �� SelectedItem 50      �� *SelectedProduct+   Columns 52      0  *System.Windows.Controls.DataGridTextColumn  53         
Foreground
 �   �   
FontFamily$ Source Code Pro Semibold)�56   %   ,  &System.Windows.Controls.DataGridColumn   Header$ Bar code��57   %      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 53   %   �� *	ProductId+   ClipboardContentBinding 54   %   Z� 58   %     59      $ Source Code Pro Semibold)�5;   %   $
 Name��5<   %    59   %   �� *Name+ 5:   %   Z� 5<   %     5=      $ Segoe Print)�5?   %   $ Description��5@   %    5=   %   �� *Description+ 5>   %   Z� 5@   %     5A      $ Source Code Pro Semibold)�5C   %   $ Price��5D   %    5A   %   �� *Price+ 5B   %   Z� 5D   %     5E      $ Source Code Pro Semibold)�5G   %   $ Count��5H   %    5E   %   �� *Count+ 5F   %   Z� 5H   %     5I      $ Century Gothic)�5K   %   $ Dishes��5L   %    .  5I   %   �� *Dishes+ 5J   %   Z� 5L   5   5N      �� 5P   
   $��1��6   $��0��5Q       �� Orientation$ 
Horizontal=�5R      .+�5T      �� $��Add product��6   $
��Left=�5U      $��
10,0,10,10q�5V      $
��auto��5W      $��39��5X      $	��150��5Y      $��35��5Z      $��Bottom=�5\      ��5[      �� *AddProductCommand+5\      �� 5^      $��Delete��6   $
��Left=�5_      $��
10,0,10,10q�5`      $
��auto��5a      $
��auto��5b      $	��100��5c      $��35��5d      ��5e      �� *DeleteProductCommand+�� 5g      $��Refresh��6   $
��Left=�5h      $��
10,0,10,10q�5i      $
��auto��5j      $
��auto��5k      $	��100��5l      $��35��5m      ��5n      �� *!RefreshTableWithProductsCommand+�� 5p      $��Save changes��6   $
��Left=�5q      $��
10,0,10,10q�5r      $
��auto��5s      $
��auto��5t      $	��100��5u      $��35��5v      ��5w      �� *" SaveChangesInProductTableCommand+�� 5y      $	��170��6   $��Right=�5z      $��20(�5{      $��	90,3,0,13q�5|      $ Enter name of product��5~      ��5}      �� *ProductToFind+5~      �� 5�      $��Right=�6   $��0,0,0,10q�5�      $
��auto��5�      $
��auto��5�      ��5�      Z� ��5�      Z� ��5�      �� *FindProductCommand+.��5�      �� $��../Images/find.png��6   $��27��5�      $) #Enter name of product to near field��5�      5�      5�      5�      5�      