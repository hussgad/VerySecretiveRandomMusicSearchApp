   M S B A M L   `   `   `  ����\  XVerySecretiveRandomMusicSearchApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:VerySecretiveRandomMusicSearchApp!VerySecretiveRandomMusicSearchApp  5      >    8VerySecretiveRandomMusicSearchApp.NumberSelectionControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Alocal/clr-namespace:VerySecretiveRandomMusicSearchApp     5      -   5          >�Name$  NumberSelectionUC��5	       � 	Resources 5
      A   ;VerySecretiveRandomMusicSearchApp.ConvertToIntegerConverter   ConvertToIntegerConverter  ThumbTextColor �� Color �� 
TargetType �� Property �� Value �� Triggers :� RoutedEvent ��Name	 �� TargetProperty	
 �� To g� Duration  
ThumbStyle �� 
TargetType J� SnapsToDevicePixels A�Name �� Padding �� RelativeSource �� AncestorType �� 	Converter �� Triggers P� Property P� Value �� 
TargetName � RowDefinitions �Name � ColumnDefinitions ]� Thumb m�Name m� Fill m� 	Placement �� 	Resources��%�  &	        &	      '�� 8     '_� �    &	 �    7  7   '�� i    7  '�� �      5   
   6*   �� 5   
   $ #CEABB1��5      �� 5   
   " ��6   .�5      ��  � ��$ 80(�5      �� 5       � ��$ 
ExtraLight"�5      �� 5       � ��
 ���� 5       5      :� 5      $ Loaded��6   .[�5      �� .��5      �� $ 
TextAppear��6%   .��5      �� $(	 "Foreground.(SolidColorBrush.Color)�6-   $
 #CEABB1X�5   -   $ 0:0:2D�5   -   5      5      5      5       �� 5!   
   " _�5"      .�5#      ��  � ��
 ���� 5$      �� 5%       � ��
 ���� 5&      �� 5'       � �� �#CEABB15(      �� 5)       � ��$ 15(�5*      5+      �� 5,   
   " n�6#   .�5-      ��  � |� .  5.      �� 5/       �@�OverridesDefaultStyle . 50      �� 51       � ��$ 30��52      �� 53       � ��$ 30��54      �� 55       � �� 56      �� 57      " n�6&   .R�58      ��  . .+�59      � $��30��6#   $��30��5:   #   .+�5;   "   A� $ 
Background��6*   ���#444545$��30��5=   %   $��30��5>   %   ���#CEABB15?   %   �� 5@   "   
������ $��20��5A   )   ._�5B   &   �� $��Center=�60   $��Stretch=�5C   ,   8��  $��14(�5E   ,   $��0q�5F   ,   $ 0q�5G   ,   ��5H   ,   �� *Value+ �� " ��8  5K   #   5L      5M       5N      P� 5O       �@J�IsMouseOver . . �5Q   "   �� $ 
Background��5R   )    � �� �	#FFDADADA5S   )   5T      P� 5U       �@n�
IsDragging . . �5W   "   �� $ 
Background��5X   )    � �� �#CEABB15Y   )   5Z      5\      5^      5_      �� 5`   
   " ��6   .�5a      ��  � ��
 ���� 5b      �� 5c       �@��AutoToolTipPlacement$ TopLeft=�5d      �� 5e       �@��AutoToolTipPrecision$ 0��5f      �� 5g       �@�Cursor$
 Hand��5h      �� 5i       �@��IsSnapToTickEnabled . 5j      �� 5k       �@��TickPlacement$ BottomRight=�5l      �� 5m       �@��TickFrequency$ 1Q�5n      �� 5o       �@�OverridesDefaultStyle . 5p      �� 5q       �@�Value 5r      �� *SliderValue+�� 5s       � �� 5t      �� 5u      " ��6&   .R�5v      �  5w      �� 5x   "   $
��auto �60   �� 5y   "   $	 row��6>   $
��auto �60   6>   �� 5z   "   $
��auto �60    5|      �� 5}   "   $
��auto �63   �� 5~   "   $ column��6=   $��* �63   6=   �� 5   "   $
��auto �63   .+�5�      �� $��PART_Border��6%   ���	#FFDADADA$��1q�5�   =   $��1��5�   %   $��1��62   
������ $��Stretch=�5�   %   $��Center=�5�   %   ]� 5�      $��
PART_Track��6$   $��Stretch=�5�      $��Center=�5�      $��1��5�      $��1��6,   #��z��5�      #��z��5�       5�   "   n� 5�   &   8��  6,   5�      m� 5�      $ 
BottomTick��6&    . $��2��5�   &   $��3��5�   &    �#CEABB1$ Bottom=�5�   &   $��10��5�   &   $
��auto��5�   &   $y�Visible=�5�   &   5�      5�      5�      5�      �� 5�   
   " ��6    5�      ���� 5�      '��       " ��6   .�5�      ��  �@��CornerRadius$ 20��65   5�      5�      .�5�      ��  � �� �#CEABB16+   �� 5�       � �� �#4445456+   �� 5�       � ��$ 30(�6)   �� 5�       � ��$ 
ExtraLight"�6+   �� 5�       � ��$ Stretch=�69   �� 5�       � ��$ Center=�6;   5�      5�      .��5�      �  5�   
   �� 5�      $��2* �6   �� 5�      �� 5�      .+�5�   
   �� $��Center=�6   $��Bottom=�5�      $��0 0 0 30q�5�      ��5�      �� *Text+ �� ElementName$ NumberSelectionUC���� 5�   
   -   5        $��NumberSlider��5�      $��1��5�      $	��400��5�   %   $��50��61     � Minimum  5�      �� *MinSelection+$ NumberSelectionUC��! � Maximum! 5�      �� *MaxSelection+$ NumberSelectionUC���� 5�   
   -   5        $��
NextButton��5�      $��2��5�      $
��Next��5�      $	��100��5�      $��50��5�      $��0 20 0 0q�5�      $��0q�5�      5�      5�      5�      