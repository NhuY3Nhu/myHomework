   M S B A M L   `   `   `  ����G  CWpfAppCoffee, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WpfAppCoffeeWpfAppCoffee  5   	       WpfAppCoffee.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   &localclr-namespace:WpfAppCoffee  5   	   -   5        $��LoginWindow��5   	     � Title$  Đăng nhập��5	   	   $	��450��6   $	��800��6(   $��Regular"�5
   
   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	   
������ .��5      � ��5   
   �� 5      .��5      �  � Color$ #E07DDC��6    � Offset$ 1Q�6/   � 5      $ #18D8BD��6   $ 0Q�6/   5      .+�5   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $	��350��6   .+�5      �� $G��AC:\Users\NHU Y\OneDrive\Hình ảnh\Saved Pictures\catcoffee.JPG��6   $	��300��6a   $	��400��6m   5      �� 5      $	��374��6   .+�5      �� $��Đăng Nhập��6   $��40(�6-   $��70q�5        �� TextAlignment$ Center=�5!      
�������5"      �� 5$      $ 
Horizontal=�6   $��10q�66   .+�5%      �� .+�5&      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 User=�62   
�������$��33��5'   2   $��36��6>   5(      �� 5)      -   5         ��Name$ tbTenDangNhap��5)   ,   $
��10,0q�6   )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$	 Tên Đăng Nhập��5*      
�������$��20(�5+   1   $	��288��6?   
���������5-      �� *TENDANGNHAP+
 �� Mode$
 TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5.      �� 50      $ 
Horizontal=�6   $��10q�67   .+�51      �� .+�52        $ Password=�62   
�������$��33��54   2   $��36��6>   55      G� 56      -   5         G�Name$ 	tbMatKhau��58   6   $	 ******��56   "   
�������$��20(�57   5   $	��288��6C   
�������58   6   59      �� 5;      $��10q�6   $��Center=�6)   .+�5<      �� -   5        $	��130��5<   !   $��40��6-   
��� ��� "  MaterialDesignRaisedDarkButton#��[  5>   !   
�������$��5,5,5,5q�5@   "    �� 	IsDefault . $��Đăng Nhập��5C   !   ��5A   2   �� *DangNhapCommand+��5B   !   ��  �� ElementName$ 	tbMatKhau��5D      5E      5F      �� 5H      $��80��6   .+�5I      �� -   5         ��Name$ btnExit��5K   >   $��10, 20q�5I       , (MaterialDesignFloatingActionAccentButton#��[ 5J       � ToolTip$ Đóng��5K   /   
���������6   Z� .��5M        $ Close=�5N   !   $��40��6.   $��40��69   5O      5P      5Q      5R      5S      