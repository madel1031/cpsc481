   M S B A M L   `   `   `  ����A  =uOrder, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:EntreesMenuPageEntreesMenuPage  5   	        EntreesMenuPage.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:EntreesMenuPage     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��177* �6   �� 5      $
��340* �6   .+�5   
   �� -   5         ��Name$ 
Image1_png��5      $��10,10,34.373,280q�6$   $��
Image1.png��6>   $��Uniform=�6R   �� 5   
   -   5        $
��menu��5      $
��Menu��6   $��16.627,10,269,280q�6,   $��3q�6G   
�������
�������$��1��6�   �� 5   
   -   5        $��receipt��5      $��View Receipt��6    $��133.627,10,120,280q�67   $��3q�6S   
�������
�������$��1��6�   �� 5   
   -   5        $
��help��5      $
��Help��6   $��77.627,10,224,280q�6,   $��3q�6G   
�������
�������$��1��6�   6�   �� 5   
   -   5        $
��call��5      $��Call Waiter��6   $��234.627,10,27,280q�63   $��3q�6N   
�������
�������$��1��6�   � 5   
   -   5        $��grid2��5      $��	0,44,0,10q�6   $��2��6/    � RowDefinitions 5      �� 5      $	��250 �6     5      �� 5      $	��315 �6#   �� 5      $	��200 �6#   .+�5      �� $��0��6   $��1��6&   $	��200��66   $	��175��6C   $��
10,0,16,48q�6O   $��Bottom=�6c   .@�5      �� $��45��6   $��Order 1��6%   $��10(�66   .��5      �� $
��Auto=�6#   $	��155��6F   .��5      �� $	��150��6%   5       5!      5"      �� 5#      $��45��6   $��Order 2��6%   $��10(�66   �� 5$      $��19��6   $��+��6%   5%      �� 5&      $��0��6   $��1��6"   $��25��62   $	��125��6>   $��Place Order Now��6J   $��60,209,16,17q�6d   �� 5'      $��0��6   $��0��6)   $	��250��66   $��
10,0,10,-9q�6C   $��Bottom=�6W    �� TabStripPlacement$ Right=�6r   .@�5(      �� $��27��6   $��Share��6&   $��10(�65   .��5)      �� $
��Auto=�6#   .��5*      �� $
�� 200��6%   .+�5+      �� $��Tuna Poke in a Jar��6%   $
��Auto=�6B   �� 5,      $A��;avocado, fresh tomatoes, nori crisps, ginger, spring onions��6$   $��8(�6j   �� 5-      $�� + ponzu - 9 ¾��6$   $��8(�6=   �� 5.      $��Korean Fried Cauliflower��6%   �� 5/      $<��6spicy gochujang pepper sauce, jalapeno lime dip - 9 ¾��6$   $��8(�6d   �� 50      $��Calamari��6%   �� 51      $B��<+ tempura prawns, sriracha aioli + sweet chili sauce - 13 ¾��6$   $��8(�6j   �� 52      $��
Bruschetta��6%   �� 53      $
��9 ¾��6$   $��8(�62   �� 54      $��Potstickers��6%   �� 55      $��12 ¾��6$   $��8(�63   �� 56      $��	Med-Bread��6%   �� 57      $.��(fresh baked flatbread, three dips - 9 ¾��6$   $��8(�6V   �� 58      $��Dry Ribs��6%   �� 59      $��11 ¾��6$   $��8(�63   �� 5:      $��Sushi Cones��6%   �� 5;      $9��3tempura prawns, fresh avocado, nori + ponzu - 14 ¼��6$   $��8(�6a   �� 5<      $��Indo Chicken Flatbread��6%   �� 5=      $7��1served open faced, pulled chicken, refried beans,��6$   $��8(�6`   �� 5>      $:��4shredded cheese, crispy lentils on curry naan - 9 ¾��6$   $��8(�6b   �� 5?      $��
Mosaic Dip��6%   �� 5@      $;��5goat cheese, mushrooms, fresh baked flatbread - 14 ¾��6$   $��8(�6c   �� 5A      $��Sweet Chili Chicken��6%   �� 5B      $��12 ¾��6$   $��8(�63   5C      5D      5E      �� 5F      $��27��6   $��Pizza��6&   $��10(�65   �� 5G      $��27��6   $��Soups��6&   $��10(�65   �� 5H      $��27��6   $��Steaks��6&   $��10(�66   �� 5I      $��27��6   $��Mains��6&   $��10(�65   �� 5J      $��27��6   $��Pasta��6&   $��10(�65   .��5K      �� $
��Auto=�6#   .��5L      �� $
�� 200��6%   .+�5M      �� $��Chicken Madeira Rigatoni��6%   $
��Auto=�6H   �� 5N      $6��0pan roasted chicken, creamy mushroom and madeira��6$   $��8(�6_   �� 5O      $6��0wine sauce, fresh rosemary, lemon butter - 18 ¾��6$   $��8(�6^   �� 5P      $��Herb Alfredo��6%   �� 5Q      $7��1grana padano, penne, asiago cream, chives - 13 ¾��6$   $��8(�6_   �� 5R      $��Prawn Linguine��6%   �� 5S      $A��;half baby lobster tail, prawns, rustic tomato sauce - 23 ¾��6$   $��8(�6i   �� 5T      $��Chicken Enchiladas��6%   �� 5U      $4��.guacamole, sour cream and salsa fresca - 17 ¾��6$   $��8(�6\   �� 5V      $��Ginger Teriyaki Rice Bowl��6%   �� 5W      $2��,fresh asian veggies, chipotle yogurt - 14 ½��6$   $��8(�6Z   �� 5X      $��Red Thai Curry Bowl��6%   �� 5Y      $;��5stir-fried veggies, jasmine rice, curry-buttered naan��6$   $��8(�6d   �� 5Z      $��14 ½��6$   $��8(�63   �� 5[      $��Beef Vindaloo��6%   �� 5\      $7��1jasmine rice, yogurt drizzle, curry-buttered naan��6$   $��8(�6`   �� 5]      $��18  ¾��6$   $��8(�64   5^      5_      5`      �� 5a      $��27��6   $��Burgers��6&   $��10(�67   �� 5b      $��27��6   $��	Handhelds��6&   $��10(�69   �� 5c      $��27��6   $��Desserts��6&   $��10(�68   5d      5f      5h      5i      