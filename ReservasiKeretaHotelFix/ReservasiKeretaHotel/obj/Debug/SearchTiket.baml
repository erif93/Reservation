   M S B A M L   `   `   `  ����O  KReservasiKeretaHotel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:ReservasiKeretaHotelReservasiKeretaHotel  5   	   &     ReservasiKeretaHotel.SearchTiket   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:ReservasiKeretaHotel     5   	     � Title$  SearchTiket��5   	   $	��629��6   $��889.2��6*   .��5	      � 
���2͚�.+�5
   
   �� $ ��RESERVASI TIKET KERETA API��6   $
��Left=�67   $	��Top=�6R   $	��881��6j   $	��598��6v   $��15(�6�    J� RenderTransformOrigin$ 
0.109,0.47&�6�   .��5      �� -   5        $
��Cari��5      $
��Left=�6$   $��
10,216,0,0q�6?   $	��Top=�6S   $	��117��6k   6w   5      �� 5   
   -   5         ��Name$ combostasiunasal��5       �� SelectedValuePath$ Id��6O    �� DisplayMemberPath$
 Name��6f   $
��Left=�6   $��	10,68,0,0q�6�   $	��Top=�6�   $	��120��6�   ��6-   �� *
getcombo+6�   �� 5   
   $��STASIUN ASAL��6   $
��Left=�6'   $��	10,36,0,0q�6B   $	��Top=�6U   $	��120��6m   �� 5   
   $��STASIUN TUJUAN��6   $
��Left=�6)   $��	10,94,0,0q�6D   $	��Top=�6W   $	��120��6o   �� 5   
   -   5        $ combostasiuntujuan��5      $ Id��6Q   $
 Name��6h   $
��Left=�6�   $��
10,125,0,0q�6�   $	��Top=�6�   $	��120��6�   ��6/   �� *
getcombo+6�   �� 5   
   $��TANGGAL KEBERANGKATAN��6   $
��Left=�60   $��
10,162,0,0q�6K   $	��Top=�6_   $	��178��6w   (  "System.Windows.Controls.DatePicker  5   
   $
��Left=�6   $��
10,193,0,0q�60   $	��Top=�6D   $	��120��6\   $��32��6h   �� 5   
   -   5         ��Name$ reservation��5   !   $��Pesan��6   $
��Left=�67   $��200,276,0,0q�6R   $	��Top=�6g   $	��195��6   $��36��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
jadwalGrid��5         AutoGenerateColumns .  $
��Left=�6e   $	��240��6�   $��
200,31,0,0q�6�   $	��Top=�6�   $	��571��6�   ���	#FFF5F4F4���	#FFF9FBFD��6(   �� *
trainall+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Id��6%   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 61   �� *Id+6J     5      $	 Nama Kereta��6%   
 6:   �� *trains.Name+6\     5      $	 Stasiun Asal��6%   
 6;   �� *stations.Name+6_     5      $	 Stasiun Tujuan��6%   
 6=   �� *destinations.Name+6e     5      $	 Jam Keberangkatan��6%   
 6@   �� *	departure+6`     5      $	 Jam Tiba��6%   
 67   �� *	arrival+6U     5      $	 Harga��6%   
 64   �� *trains.Price+6W     5      $	 Kelas��6%   
 64   �� *trains.wagons.Name+6]   5        5    
   -   5        $ 	tschedule��5        .  $
��Left=�6b   $��200,344,0,0q�6}   $	��Top=�6�   $	��219��6�   $	��571��6�   ��6'   �� *tampil+ 5!   
     5"      $	 Id��6%   
 61   �� *Id+6J     5#      $	 Nama Kereta��6%   
 6:   �� *trains.Name+6\     5$      $	 Gerbong��6%   
 66   �� *stations.Name+6Z     5%      $	 Kelas��6%   
 64   �� *destinations.Name+6\     5&      $	 Harga��6%   
 64   �� *Price+6P     5'      $	 Nama Kereta��6%   
 6:   �� *trains.Name+6\     5(      $	 Gerbong��6%   
 66   �� *wagons.Name+6X     5)      $	 Kelas��6%   
 64   �� *wagons.trainclas.Name+6`     5*      $	 Harga��6%   
 64   �� *Price+6P   5,      5-      5.      