   M S B A M L   `   `   `  ����A  =uOrder, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:uOrderuOrder  5   	       uOrder.HelpPage   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:uOrder     5   	     � Title$  HelpPage��5   	   $	��650��6   $	��925��6'   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��0* �6   �� 5      $	��13* �6   �� 5      $
��275* �6   �� 5      $
��554* �6   �� 5      $��0* �6   .+�5   
   �� -   5         ��Name$
 menu��5      $
��Menu��6   $��3��6.   $
��Left=�6>   $��	38,17,0,0q�6Y   $	��Top=�6l   $��75��6�   $��3q�6�   
�������
�������$��20(�6�   �� 5   
   -   5        $ receipt��5      $��View Receipt��6"   $��3��69   $
��Left=�6I   $��
259,17,0,0q�6d   $	��Top=�6x   $	��137��6�   $��3q�6�   
�������
�������$��20(�6�   �� 5   
   -   5        $
 help��5      $
��Help��6   
���`���$��3��6G   $
��Left=�6W   $��
155,17,0,0q�6r   $	��Top=�6�   $��75��6�   $��3q�6�   
�������$��20(�6�   �� 5   
   -   5        $
 call��5      $��Call Waiter��6   $��3��65   $
��Left=�6E   $��
428,17,0,0q�6`   $	��Top=�6t   $	��113��6�   $��3q�6�   
�������
�������$��20(�6�   � 5   
   -   5        $��grid2��5      $��0,54,0,0q�6   $��4��6.    J� RenderTransformOrigin$ 0.486,0.558&�6B    � RowDefinitions 5      �� 5      $	��250 �6     5      �� 5      $	��313 �6#   �� 5      $	��202 �6#   �� 5      $	��25* �6#   �� 5      $
��302* �6#   .+�5      �� $��0��6   $��3��6&   $	��391��66   $��0,0,29,-174q�6C   $��Bottom=�6X   $	��1.5q�6s   ���	#FF535050.@�5       �� $��Order 1��6   $��18(�6+   $��
0,0,-15,-1q�69   ���	#FF5F5C5C��5!      �� 5"       �� EndPoint$	 0,1&�6.    �� 
StartPoint$	 0,0&�6=   .��5#      �  � Color$ 	#FFF0F0F0��6+    � Offset$ 0Q�6=   � 5$      $ 	#FFDDDDDD��6+   $ 1Q�6=   5%      .��5'      �� $
��Auto=�6#   $	��155��6F   .��5(      �� $	��150��6%   5*      5+      5,      � 5-      -   5        $��popup��5-      ��. .��5.      �� -   5        $��mylabel��5.      $��This is a pop-up!��6+   
�������
����  �6^   5/      �� 51      ���	#FF5F5C5C$��Order 2��62   $��18(�6C   $��1,0,-4,0q�6Q   $��34��6c   $��Bottom=�6o   ��52      �� 53      $	 0,1&�6.   $	 0,0&�6=   .��54      � $ 	#FFF0F0F0��6+   $ 0Q�6=   � 55      $ 	#FFDDDDDD��6+   $ 1Q�6=   56      58      �� 59      $��35��6   ���	#FF5F5C5C$��+��6=   $��18(�6H   $��1,0,-1,0q�6V   5:      �� 5;      -   5        $ button��5;      $��Place Order Now��6%   $��3��6?   $
��Left=�6O   $��43��6j   $��112,446,0,-238q�6v   $	��1.5q�6�   $	��Top=�6�   $��23(�6�   $	��230��6�   
�������6�   �� 5<      -	   5        $ helppage��5<      $��	Help Page��6'   $��26(�6;   $
��Left=�6I   $��
-22,32,0,0q�6d   $	��Top=�6x   $	��194��6�   $��62��6�   
�������$
��Bold"�6�   ��6�   Z� 6�   �� 5>      $��Visible=�6   $��2��6A   $��0,79,0,-238q�6U   .��5?      �� $	��500��6   .+�5@      �� $��10,10,248,10q�6    ���	#FF872A2A$��20(�6M   $��Segoe Print)�6[   ��6t   Z� �� 6�   $�Exploring our selection��6�   $
��Bold"�6�   6�   �� 5A      $��
10,-5,26,1q�6    ���	#FF2E2929$��16(�6K   $��48��6Y   �� 6f   $H�BIf the device goes idle at any point, a single tap anywhere on the��6j   �� 6�   �� 6�   $(�"screen will bring it back to life.��6�   6�   �� 5B      $��	10,1,26,1q�6    ���	#FF2E2929$��16(�6J   $��51��6X   �� 6e   $F�@Browse our selection with ease by using the scrollbar located to��6i   �� 6�   �� 6�   $>�8the side of the menu, or click and drag within the menu.��6�   6  �� 5C      $
��10,1q�6    ���	#FF2E2929$��16(�6E   $	��130��6S   �� 6a   $K�EWhen there's an item that strikes your fancy, click on it! A detailed��6e   �� 6�   �� 6�   $D�>description of the dish will appear with more information. All��6�   �� 6  �� 6  $I�Ccustomizations available for this item will appear in a scrolldown ��6  �� 6k  �� 6x  $F�@menu or checkboxes for you to choose from. Please let us know if��6|  �� 6�  �� 6�  $J�Dyou have any allergies or if you'd like your dish to be served in a ��6�  �� 6%  �� 62  $G�Aspecific manner in the Note for the Kitchen box by typing it out.��66  6�  �� 5D      $��10,10,299,10q�6    ���	#FF872A2A$��20(�6M   $��Segoe Print)�6[   $
��Bold"�6�   $��40��6�   ��6t   Z� �� 6�   $�Placing an order��6�   6�   �� 5E      $��10,-10,10,1q�6    ���	#FF2E2929$��16(�6L   $	��436��6Z   �� 6h   $F�@When you have decided on a dish and specified just how you like ��6l   �� 6�   �� 6�   $K�Eit, click on 'Add to Order' and the item will appear under the active��6�   �� 5F      �� 6'   $G�Aorder to the side of the screen. Any items that you choose to add��6+   5G      �� 5H      $��10q�6    ���	#FF2E2929$��20(�6C   $��Segoe Print)�6Q   ��6j   Z� �� 6�   $�Viewing your order��6�   6�   �� 5I      $��10q�6    ���	#FF2E2929$��20(�6C   $��Segoe Print)�6Q   ��6j   Z� �� 6�   $�Payment��6�   6�   5J      5K      5N      �� 5O   
   -
   5        	 ��Name$	 
Image1_png��5O      $��2,10,50,549q�6$   $��
Image1.png��69   $
��Fill=�6M   $��2��6\   5Q      5R      