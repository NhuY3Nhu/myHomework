   M S B A M L   `   `   `  ����G  CWpfAppCoffee, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WpfAppCoffeeWpfAppCoffee  5   	       WpfAppCoffee.PageNuoc   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   &localclr-namespace:WpfAppCoffee  5   	     � Title$  PageNuoc��5	   	   $	��450��6   $	��800��6'   .��5
      � ��5   
   �� 5      .��5      �  � Color$ #E07DDC��6    � Offset$ 1Q�6/   � 5      $ #18D8BD��6   $ 0Q�6/   5       � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      6   .+�5   
   � $��1��6    5      �� 5      $
��auto �6    60   �� 5      $
��auto �6    60   �� 5      6"   .+�5      #  MaterialDesignThemes.Wpf.Card  $��0��6"   $��5q�6/   .��5      � $��0 0 0 10q�6   .+�5      �� -   5         ��Name$ txt_mnu��5!   Y   $��5 5 15 5q�5       )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Mã Nước Uống��60    %  !MaterialDesignFloatingHintTextBox#��[  5!      ��5      �� *
MaNuocUong+ �� UpdateSourceTrigger$ PropertyChanged=�5!   Y   �� 5"      -   5        $ txt_tnu��5$   Y   $��5 5 15 5q�5#      $ Tên Nước Uống��60   #��[  5$      ��5"      �� *TenNuocUong+$ PropertyChanged=�5$   Y   �� 5%      -   5        $ txt_gnu��5'   Y   $��5 5 15 5q�5&      $ Giá Nước Uống��60   #��[  5'      ��5%      �� *GiaNuocUong+$ PropertyChanged=�5'   Y   5(      5)        5+      $��1��6"   $��5q�6/   .��5,      � .+�5-      �� -   5        $��Thêm��5-      $��5q�60   $	��100��6;   6^   �� 5.      -   5        $��Cập Nhật��5.      $��5q�60   $	��100��6;   6a   �� 5/      -   5        $
��Xoá��5/      $��5q�60   $	��100��6;   6]   50      51        53      $��2��6"   $��5q�6/   $��Stretch=�6:   .��54      � $��3��6   .+�55      &   System.Windows.Controls.DataGrid  -   5          Name$ NuocUong��55         AutoGenerateColumns .  $��10q�6M   	   Columns	 56      0  *System.Windows.Controls.DataGridTextColumn  57      ,  &System.Windows.Controls.DataGridColumn
   Header$
 ID��61      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6H   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6U   �� *
MaNuocUong+  58      $
 Tên Nước Uống��61   $
 Auto 6H    6U   �� *TenNuocUong+  59      $
 Giá Nước Uống��61   $
 Auto 6H    6U   �� *GiaNuocUong+5;      5<      5=      5>      5?      5@      