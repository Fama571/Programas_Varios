   M S B A M L   `   `   `  ����G  CGauss Jordan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Gauss_JordanGauss_Jordan  5   	       Gauss_Jordan.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Gauss_Jordan     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��900��6)   .��5	      � -   5         �Name$ Ventana_Principal��5	       J� RenderTransformOrigin$ 0.5,0.5&�6&    J� Effect 5
   
   3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 10Q�6      ShadowDepth$ 10Q�6/   ��5   
   �� 5       �� ImageSource$� �Fondo/46275161-matemática-vector-sin-patrón-con-el-signo-del-infinito-figuras-matemáticas-y-parcelas-textura-matemáticas-end.jpg��6    �� Opacity$	 0.3Q�6�    �� RelativeTransform 5      V� 5      .~�5      �� 	 �� ScaleY$	 1Q�6)   
 �� ScaleX$
 1Q�64   �� 5       �� AngleY$ 0Q�6(    �� AngleX$ 0Q�63   �� 5       �� Angle$ 0Q�6*   T� 5      5      5      .+�5   
   �� -   5         ��Name$ Textbox1��5      $
��Left=�6$   $��50��6?   $��	66,77,0,0q�6K    �� TextWrapping$
 Wrap=�6^   $	��Top=�6r   $	��100��6�   $ 0.5,0.5&�6�   $��24(�6�   ���	#E5FFFFFF6�   �� 5   
   -   5        $ Textbox5��5      $
��Left=�6$   $��50��6?   $��
66,149,0,0q�6K   $
 Wrap=�6_   $	��Top=�6s   $	��100��6�   $ 0.5,0.5&�6�   $��24(�6�   ���	#E5FFFFFF6�   �� 5   
   -   5        $ Textbox9��5      $
��Left=�6$   $��50��6?   $��
66,233,0,0q�6K   $
 Wrap=�6_   $	��Top=�6s   $	��100��6�   $ 0.5,0.5&�6�   $��24(�6�   ���	#E5FFFFFF6�   �� 5   
   -   5        $ Textbox2��5      $
��Left=�6$   $��50��6?   $��
232,77,0,0q�6K   $
 Wrap=�6_   $	��Top=�6s   $	��100��6�   $ 0.5,0.5&�6�   $��24(�6�   ���	#E5FFFFFF6�   �� 5   
   -   5        $ Textbox6��5      $
��Left=�6$   $��50��6?   $��232,149,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��100��6�   $ 0.5,0.5&�6�   $��24(�6�   ���	#E5FFFFFF6�   �� 5   
   -   5        $ 	Textbox10��5      $
��Left=�6%   $��50��6@   $��232,233,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $	��100��6�   $ 0.5,0.5&�6�   $��24(�6�   ���	#E5FFFFFF6�   �� 5   
   -   5        $ Textbox3��5      $
��Left=�6$   $��50��6?   $��
388,77,0,0q�6K   $
 Wrap=�6_   $	��Top=�6s   $	��100��6�   $ 0.5,0.5&�6�   $��24(�6�   ���	#E5FFFFFF6�   �� 5    
   -	   5        $ Textbox7��5       $
��Left=�6$   $��50��6?   $��388,149,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��100��6�   $ 0.5,0.5&�6�   $��24(�6�   ���	#E5FFFFFF6�   �� 5!   
   -
   5        $ 	Textbox11��5!      $
��Left=�6%   $��50��6@   $��388,233,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $	��100��6�   $ 0.5,0.5&�6�   $��24(�6�   ���	#E5FFFFFF6�   �� 5"   
   -   5        $ Textbox4��5"      $
��Left=�6$   $��50��6?   $��
544,77,0,0q�6K   $
 Wrap=�6_   $	��Top=�6s   $	��100��6�   $ 0.5,0.5&�6�   $��24(�6�   ���	#E5FFFFFF6�   �� 5#   
   -   5        $ Textbox8��5#      $
��Left=�6$   $��50��6?   $��544,149,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��100��6�   $ 0.5,0.5&�6�   $��24(�6�   ���	#E5FFFFFF6�   �� 5$   
   -   5        $ 	Textbox12��5$      $
��Left=�6%   $��50��6@   $��544,233,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $	��100��6�   $ 0.5,0.5&�6�   $��24(�6�   ���	#E5FFFFFF6�   �� 5%   
   -   5         ��Name$ Btn_Calcular��5%      $��Calcular��6'   $
��Left=�6:   $��
698,83,0,0q�6U   $	��Top=�6i   $	��128��6�   $��44��6�   $��24(�6�   ��5&      �� 5'       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5(      �  � Color$ 	#FFD3CBCB��6#    � Offset$ 0Q�65   � 5)      $ 	#FFBB9E9E��6#   $ 1Q�65   5*      ��5,      �� 5-      $ 0.5,1&�6&   $ 0.5,0&�67   .��5.      � $ 	#FFF54B4B��6#   $ 0Q�65   � 5/      $ 	#B2700F00��6#   $ 1Q�65   50      52      �� 53   
   -   5        $ 
btn_Borrar��53      $��Borrar��6%   $
��Left=�66   $��698,155,0,0q�6Q   $	��Top=�6f   $	��128��6~   $��44��6�   $��24(�6�   ��54      �� 55      $ 0.5,1&�6&   $ 0.5,0&�67   .��56      � $ 	#FFD3CBCB��6#   $ 0Q�65   � 57      $ 	#FFBB9E9E��6#   $ 1Q�65   58      ��5:      �� 5;      $ 0.5,1&�6&   $ 0.5,0&�67   .��5<      � $ 	#FFF54B4B��6#   $ 0Q�65   � 5=      $ 	#B2700F00��6#   $ 1Q�65   5>      5@      �� 5A   
   -   5         ��Name$ 
Textblock1��5A      $
��Left=�6(   $��106,314,0,0q�6C   $
��Wrap=�6X   $	��Top=�6l   $��50��6�   $	��140��6�   ���	#7FFFFFFF$��36(�6�   �� 5B   
   -   5        $ 
Textblock2��5B      $
��Left=�6(   $��307,314,0,0q�6C   $
��Wrap=�6X   $	��Top=�6l   $��50��6�   $	��140��6�   ���	#7FFFFFFF$��36(�6�   �� 5C   
   -   5        $ 
Textblock3��5C      $
��Left=�6(   $��508,314,0,0q�6C   $
��Wrap=�6X   $	��Top=�6l   $��50��6�   $	��140��6�   ���	#7FFFFFFF$��36(�6�   �� 5D   
   $��X=��6   $
��Left=�6   $��
45,314,0,0q�68   $��50��6L   $	��Top=�6X   $��36(�6p   �� 5E   
   $��Y=��6   $
��Left=�6   $��251,314,0,0q�68   $��50��6M   $	��Top=�6Y   $��36(�6q   �� 5F   
   -   5         ��Name$
 lblz��5F      $��Z=��6   $
��Left=�6+   $��452,314,0,0q�6F   $��50��6[   $	��Top=�6g   $��36(�6   �� 5G   
   -   5         ��Name$ Combobox��5G      $
��Left=�6%   $��706,253,0,0q�6@   $	��Top=�6U   $	��120��6m   $��30��6�   $��20(�6�   ��5H      �� 5I      $	 0,1&�6&   $	 0,0&�65   .��5J      � $ 	#FFF0F0F0��6#   $ 0Q�65   � 5K      $ 	#B2FF0000��6#   $ 1Q�65   5L      .@�5N      �� -   5         ��Name$ Combo3x3��5N      $	��3x3��6-   $
��Left=�6;   $	��118��6V    �� 
IsSelected . $��18(�6t   
�������6�   �� 5O      -   5        $ Combo2x2��5O      $	��2x2��6-   $
��Left=�6;   $	��118��6V   $��18(�6b   5P      �� 5Q   
   -   5        $ Btn_info��5Q      $��?��6#   $
��Left=�6/   $��744,314,0,0q�6J   $	��Top=�6_   $��66��6w   $��50��6�   $��36(�6�   ��5R      �� 5S      $ 0.5,1&�6&   $ 0.5,0&�67   .��5T      � $ 	#FFD3CBCB��6#   $ 0Q�65   � 5U      $ 	#FFBB9E9E��6#   $ 1Q�65   5V      ��5X      �� 5Y      $ 0.5,1&�6&   $ 0.5,0&�67   .��5Z      � $ 	#FFF54B4B��6#   $ 0Q�65   � 5[      $ 	#FF700F00��6#   $ 1Q�65   5\      5^      �� 5_   
   -   5        $ Textblock_titulo��5_      $
��Left=�6.   $��
200,10,0,0q�6I   $
��Wrap=�6]   $��Gauss Jordan 3x3��6q   $	��Top=�6�   $��50��6�   $	��506��6�   $��36(�6�   ���	#7FFFFFFF �� TextAlignment$ Center=�6�   �� 5`   
   $��+��6   $
��Left=�6   $��
181,77,0,0q�67   $	��Top=�6K   $��36(�6c   $��50��6q   �� 5a   
   $��+��6   $
��Left=�6   $��181,149,0,0q�67   $	��Top=�6L   $��36(�6d   $��50��6r   �� 5b   
   -   5        $
 lbl1��5b      $��+��6   $
��Left=�6*   $��
343,78,0,0q�6E   $	��Top=�6Y   $��36(�6q   $��50��6   �� 5c   
   -   5        $
 lbl3��5c      $��+��6   $
��Left=�6*   $��343,149,0,0q�6E   $	��Top=�6Z   $��36(�6r   $��50��6�   �� 5d   
   -   5        $
 lbl2��5d      $��=��6   $
��Left=�6*   $��
499,77,0,0q�6E   $	��Top=�6Y   $��36(�6q   $��50��6   �� 5e   
   -   5        $
 lbl4��5e      $��=��6   $
��Left=�6*   $��499,149,0,0q�6E   $	��Top=�6Z   $��36(�6r   $��50��6�   �� 5f   
   -   5        $
 lbl5��5f      $��+��6   $
��Left=�6*   $��181,233,0,0q�6E   $	��Top=�6Z   $��36(�6r   $��50��6�   �� 5g   
   -   5        $
 lbl6��5g      $��+��6   $
��Left=�6*   $��343,233,0,0q�6E   $	��Top=�6Z   $��36(�6r   $��50��6�   �� 5h   
   -   5        $
 lbl7��5h      $��=��6   $
��Left=�6*   $��499,233,0,0q�6E   $	��Top=�6Z   $��36(�6r   $��50��6�   5j      5k      