   M S B A M L   `   `   `  ���� F  BTic_Tac_Toe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Tic_Tac_ToeTic_Tac_Toe      Tic_Tac_Toe.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     +localclr-namespace:Tic_Tac_Toe     -     �Name$  KNWindow�� � Icon$ Resources/main_icon.ico�� � Title$# Крестики-нолики��$	��550��$	��800��$y�Visible=� � 
ResizeMode$ CanMinimize=� � AllowsTransparency .  � WindowStyle$
 None=�����  �� ImageSource$&  Resources/Background_800x550.png��.���  J� IsHitTestVisible . $��Disabled=� � UseLayoutRounding . ���� .+��� -   	 ��Name$	 DragMoveLabel��$�� ��$
��Left=�$��30��$��0,8,0,0q�$	��Top=�$	��700�����	#FFC76B6B
 J� Opacity$
 0Q��� -   $	 MinimizeLabel��$�� ��$
��Left=�$��30��$��
724,10,0,0q�$	��Top=�$��30������ $" Resources/Minimize_30x30.png���� -   $	 
CloseLabel��$�� ��$
��Left=�$��30��$��	759,8,0,0q�$	��Top=�$��30������ $ Resources/Close_30x30.png���� -    ��Name$ b2_image��$
��Left=�$��90��$��222,229,0,0q�$	��Top=�$��90���� -   $ b1_image��$
��Left=�$��90��$��222,121,0,0q�$	��Top=�$��90���� -   $ c1_image��$
��Left=�$��90��$��329,121,0,0q�$	��Top=�$��90���� -   $ c2_image��$
��Left=�$��90��$��329,229,0,0q�$	��Top=�$��90���� -	   $ a2_image��$
��Left=�$��90��$��114,229,0,0q�$	��Top=�$��90���� -
   $ b3_image��$
��Left=�$��90��$��222,338,0,0q�$	��Top=�$��90���� -   $ c3_image��$
��Left=�$��90��$��329,338,0,0q�$	��Top=�$��90���� -   $ a3_image��$
��Left=�$��90��$��114,338,0,0q�$	��Top=�$��90���� -   $ a1_image��$
��Left=�$��90��$��114,121,0,0q�$	��Top=�$��90���� -   $	 a1_label��$�� ��$
��Left=�$��90��$��114,121,0,0q�$	��Top=�$��90���� -   $	 b1_label��$�� ��$
��Left=�$��90��$��222,121,0,0q�$	��Top=�$��90���� -   $	 c1_label��$�� ��$
��Left=�$��90��$��329,121,0,0q�$	��Top=�$��90���� -   $	 b2_label��$�� ��$
��Left=�$��90��$��222,229,0,0q�$	��Top=�$��90���� -   $	 c2_label��$�� ��$
��Left=�$��90��$��329,229,0,0q�$	��Top=�$��90���� -   $	 a2_label��$�� ��$
��Left=�$��90��$��114,229,0,0q�$	��Top=�$��90���� -   $	 a3_label��$�� ��$
��Left=�$��90��$��114,338,0,0q�$	��Top=�$��90���� -   $	 b3_label��$�� ��$
��Left=�$��90��$��222,338,0,0q�$	��Top=�$��90���� -   $	 c3_label��$�� ��$
��Left=�$��90��$��329,338,0,0q�$	��Top=�$��90���� -   $ 
info_image��$
��Left=�$	��105��$��
448,82,0,0q�$	��Top=�$	��250���� -   $ info_image2��$
��Left=�$	��105��$��
448,82,0,0q�$	��Top=�$	��250���� -   $ ngImage��$
��Left=�$��50��$��464,216,0,0q�$	��Top=�$	��216���� -   $	 	protector��$�� ��$
��Left=�$	��333��$��387,461,0,-244q�$	��Top=�$	��335��