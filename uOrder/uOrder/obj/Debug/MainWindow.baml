   M S B A M L   `   `   `  ����A  =uOrder, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:uOrderuOrder  5   	       uOrder.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:uOrder     5   	     � Title$)  #uOrder - Restaurant Ordering System��5   	   $
��1020��65   $
��1950��6C    � 
ResizeMode$ CanResizeWithGrip=�6P    � WindowStyle$ 
ToolWindow=�6o    � WindowStartupLocation$ CenterOwner=�6�   $��Center=�6�   $��Center=�6�   .��5	      � -   5        $��myGrid��5	       � RowDefinitions 5
   
   �� 5      -   5         �Name$ first��5      $	��100 �6)   �� 5      -   5        $ second��5      $	��850 �6+   �� 5      -   5        $ third��5      $
��Auto �6)    � ColumnDefinitions 5   
   �� 5      $
��1950 �6   .+�5   
   �� $��0��6   ���	#FF4F0D0D6"   �� 5   
   -   5         ��Name$ Image6_png3��5      $��0��6%   $��25,0,1581,0q�62   $��
Image6.png��6G   $��Uniform=�6[   �� 5   
   -   5        $
��menu��5      $��0��6   $
��MENU��6*   $��28(�69   $��Heavy"�6G   ���	#FFEEE6E4���	#FF4F0D0D���	#FF4F0D0D$��3q�6�   $��778,20,999,20q�6�   6�   �� 5   
   -   5        $
��help��5      $��0��6   $
��HELP��6*   $��28(�69   $��Heavy"�6G   ���	#FFEEE6E4���	#FF4F0D0D���	#FF4F0D0D$��3q�6�   $��1060,20,754,20q�6�   6�   �� 5   
   -   5        $��receipt��5      $��0��6    $��VIEW RECEIPT��6-   $��28(�6D   $��Heavy"�6R   ���	#FFEEE6E4���	#FF4F0D0D���	#FF4F0D0D$��3q�6�   $��1329,20,350,20q�6�   6�   �� 5   
   -	   5        $
��call��5      $��0��6   $��CALL WAITER��6*   $��28(�6@   $��Heavy"�6N   ���	#FFEEE6E4���	#FF4F0D0D���	#FF4F0D0D$��3q�6�   $��1683,20,25,20q�6�   6�   �� 5   
   -
   5        $ 
Image5_png��5      $��2��6$   $��25,10,1450,27q�61   $��
Image5.png��6H   $��Uniform=�6\   �� 5   
   $��1��6   ���	#FFC7C2C26!   �� 5   
   -   5        $��page_viewer��5   "   $��1��6   $��10q�65   .+�5      �� -   5         ��Name$ enter��5      	 � Cursor$
	 Hand��6$   $��Button��62   $��1��6C   $
��1932��6Q   $	��979��6^   
 J� Opacity$
 0Q�6k   6w   5      �� 5   
   -   5        $��start��5      $��3��6    J� IsHitTestVisible .  ���	#FF4F0D0D.��5      �� -   5        $ 
Image6_png��5      $��
Image6.png��6(   $��Uniform=�6<   5       5"      5#      