   M S B A M L   `   `   `  ����F  BMVVM_Images, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:MVVM_ImagesMVVM_Images  5   	       MVVM_Images.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:MVVM_Images     5   	     � Title$  Photo��5   	   $	��450��6   $	��800��6$    � 	Resources 5	       �� 
TargetType   btn �� Property �� Value��%�   &	        �� 5
   
   " ��6   .�5      ��  � ��$
 10,5q�6'   �� 5       � ��$ 17(�6)   �� 5       � ��$ Roboto)�6+   �� 5       � ��$
 Bold"�6+   5      5      .��5      �  � RowDefinitions 5   
   �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      $��2* �6   �� 5      .+�5   
   �� ��6   �� *SelectedPhoto.ImageSource+6?   �� 5   
   $��1��6   $��2��6    ��64   �� *Photos+ �� SelectedItem 6S   �� *SelectedPhoto+ �� Mode$ TwoWay=���5      �� 5      .R�5      �� .+�5      �� $��80��6@   $��80��6K   $
��Fill=�6W   ��6    �� *ImageSource+5       �� 5!      $��14(�6>   $��Center=�6L   ��6$   �� *
FileName+6l   5"      5#      ��5&      �� 5'      .R�5(      � 	 � Orientation$	 
Horizontal=�6    5)      5+      �� 5,   
   $��1��6   $��2��6%   .+�5-      �� 
 � DataContext
 6   �� *SelectedPhoto+.+�5.      �� $��	FilePath:��6   6/   �� 5/      ��6   �� *
FullPath+ �� StringFormat$	 {0}��6M   �� 50      $��	Filename:��6   6/   �� 51      ��6   �� *
FileName+68   �� 52      $
��Size��6   6*   �� 53      ��6   �� *
FileSize+$ {0} Кб��6P   54      �� 55      .+�56      �� #���   6   $��20q�68   $	��Add��6F   ��6T   �� *
AddCommand+6u   �� 57      #���   6   $��20q�63   $��Delete��6?   ��6P   �� *DeleteCommand+��6r   �� *SelectedPhoto+6�   58      59      5:      5;      