   M S B A M L   `   `   `  ����C  ?Levitate, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Levitate.PropertiesLevitate.Properties  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      7 clr-namespace:Levitate.ViewModelLevitate.ViewModel  5      -clr-namespace:Levitate.ViewLevitate.View  5	      U QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5          Levitate.View.MiniPlayer   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      /p!clr-namespace:Levitate.Properties     5      9system&clr-namespace:System;assembly=mscorlib     5      6	viewModel clr-namespace:Levitate.ViewModel     5      -localclr-namespace:Levitate.View     5	      U QMaterialDesignThemes.Wpf, Version=2.3.0.823, Culture=neutral, PublicKeyToken=nullX TMaterialDesignThemes.MahApps, Version=0.0.10.0, Culture=neutral, PublicKeyToken=nullHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5      LControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro   5      R	 NMahApps.Metro.IconPacks, Version=1.9.0.0, Culture=neutral, PublicKeyToken=null=	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks 	 5      -   5           MaterialDesignPaper#���   5        AccentColorBrush#���  5        � Title$  Levitate��5      $	��300��5      $	��300��5       � Icon$6 0pack://application:,,,/Resources/Images/ICON.ico��5      $	��300��5      $	��500��6)   $	��300��5      $	��500��6)    � 
ResizeMode$ 	CanResize=�5       � WindowStartupLocation$ CenterScreen=�5      (  "MahApps.Metro.Controls.MetroWindow   SaveWindowPosition .  � ShowInTaskbar .    ShowMaxRestoreButton .     ShowMinButton .     ShowCloseButton . 	   ShowTitleBar	 .  $��0q�5"      
 �� BitmapScalingMode$
 HighQuality=�5#       � 	Resources 5'      7   1Levitate.ViewModel.PlayStateToVisibilityConverter  PlayStateConverver8   2Levitate.ViewModel.PauseStateToVisibilityConverter  PauseStateConverver��%:   &	       &	        5(   
   63     5)   
   64   5*      .��5,      � .+�5-   
   �� -   5         ��Name$ image_background��5-      $��3��6l   $��UniformToFill=�6�   ��6*   �� *#!MusicManager.CurrentTrackCoverArt+ �� Mode$ OneWay=�6�   � 50   
   ��52      �� 53       �� Triggers 54      :� 55       :� RoutedEvent$ Control.MouseEnter��6'   .[�56      �� .��57   "   �� .��58   &   W�  g� Duration$ 0:0:0.3D�66   	 W� To$ 1X�6I    �� TargetProperty$ Opacity�6P   59   #   5:      5;      :� 5<      $ Control.MouseLeave��6'   .[�5=      �� .��5>   "   �� .��5?   &   W� $ 0:0:0.3D�66   $ 0X�6I   $ Opacity�6P   5@   #   5A      5B      5D      .+�5G      � 
���   � J� Opacity$	 0.6Q�6&   $��-22,0,-22,-23q�64    K� ZIndex$ 0��6K   $	��128��6\   $��Bottom=�6i    J� Effect 5H      -  'System.Windows.Media.Effects.BlurEffect  5I         Radius$ 50Q�6!   5K      � 5M      $ 1��6   $��80��6$   $��Bottom=�60   $��0,0,0,1q�6K    � ColumnDefinitions 5N      �� 5O      �� 5P      $	��140 �6'   �� 5Q      .+�5T      �� -   5         ��Name$ slider_Timeline��5T      $��Bottom=�62   $��0q�6M   
������  �� IsMoveToPointEnabled . $��3��5W   �   $��18��6�   $��	0,-9,0,71q�6�    � Value 6   �� *MusicManager.Position+$ OneWay=� � Maximum 6F   �� *MusicManager.MaxPosition+$ OneWay=�6�   � 5Y      $��1��6   $��0,0,0,15q�6'   $ 2��69   $��48��6J   $��Bottom=�6V   .+�5[      �� -   5         ��Name$ button_play��5[       & "MaterialDesignFloatingActionButton#���  62   
������ 
������ $
 HighQuality=�5\   L   $
��Auto��6z   $
��46,0q�6�   $
��Auto��6�   ��5[   o   �� *TogglePlayPause+y�6�   �� *MusicManager.State+ �� 	Converter# [  �� UpdateSourceTrigger$ PropertyChanged=�.��5]      �� $��5 0 0 0q�6    $B��</Levitate;component/Resources/Images/Controls/buttonPlay.png��61   $��30��6w   5^      �� 5`      -   5        $ button_pause��5`      #���  63   
������ 
������ $
 HighQuality=�5a   L   $��48��6z   $
��46,0q�6�   $
��Auto��6�   $	��Top=�6�   ��5`   p   �� *TogglePlayPause+y�6�   �� *MusicManager.State+# [ $ PropertyChanged=�.��5b      �� $��0 0 0 0q�6    $C��=/Levitate;component/Resources/Images/Controls/buttonPause.png��61   $��30��6x   5c      �� 5e      -   5        $ button_back��5e      #���  62   
������ 
������ $
 HighQuality=�5f   L   $
��Auto��6z   $��6,4,0,4q�6�   $��41��6�   $
��Left=�6�   ��5e   o   �� *PlayBackward+.��5g      �� $��0 0 5 0q�6    $B��</Levitate;component/Resources/Images/Controls/buttonBack.png��61   $��25��6w   5h      �� 5j      -   5        $ button_next��5j      #���  62   
������ 
������ $
 HighQuality=�5k   L   $
��Auto��6z   $��0,4,6,4q�6�   $��41��6�   $��Right=�6�   ��5j   o   �� *PlayForward+.��5l      �� $��5 0 0 0q�6    $B��</Levitate;component/Resources/Images/Controls/buttonNext.png��61   $��25��6w   5m      5o      �� 5q      -   5         ��Name$ label_position��5q      $
��Left=�64   {�.  
�������$��5,0,0,56q�5r      $��64��6.   $��11(�69     �� TextAlignment$
  Left=�6G   $��16��5s   n   $��Bottom=�6z   ��6   �� *MusicManager.TimeGone+! �� StringFormat$! {0:mm}:{0:ss}��$ OneWay=�6z   �� 5u      -	   5        $ label_remaining��5u      $��Right=�65   {�.  
�������$��64��6v   $��11(�6�   $  Right=�6�   $��16��5v   p   $��Bottom=�6|   $��0,0,5,56q�6�   $��2��6�   ��6   �� *MusicManager.TimeRemain+$! {0:mm}:{0:ss}��$ OneWay=�6�   d� 5x       ( $MaterialDesignActionDarkToggleButton#���  6   
������ $��35��5z      $��35��6'   $��0,0,4,21q�5{   U   $��Bottom=�6g   $��Right=�6�   ��5x   ^   �� *SetLoopMode+" d� 	IsChecked" 5{      �� *MusicManager.IsLoopOne+$ TwoWay=�1  +MaterialDesignThemes.Wpf.ToggleButtonAssist#   	OnContent# 5|      �� 5}      $?��9/Levitate;component/Resources/Images/Controls/loopOne.png��6    $��26��6c   $��26��6o   .��5      �� $?��9/Levitate;component/Resources/Images/Controls/loopAll.png��6   $��26��6_   $��26��6k   5�      d� 5�      #���  6   
������ $��35��5�      $��35��6'   $��4,0,0,21q�5�   U   $��2��6g   $��Bottom=�6w   $
��Left=�6�   " 6   �� *MusicManager.IsShuffle+$ TwoWay=�# 5�      �� 5�      $?��9/Levitate;component/Resources/Images/Controls/shuffle.png��6    $��26��6c   $��26��6o   .��5�      �� $?��9/Levitate;component/Resources/Images/Controls/shuffle.png��6   $
 0.55Q�6_   $��26��6n   $��26��6z   5�      5�      d� 5�      -
   5         $  MaterialDesignActionToggleButton#��[ 5�      
������ $
��Left=�5�   #   $	��Top=�5�   #   $��32��5�   #   $��32��6/   $
 HighQuality=�5�   #   $��	10,10,0,0q�5�   l   $��0q�5�   #   " 5�   #   �� *'%MusicManager.CurrentTrack.IsFavourite+$ TwoWay=� 5�      3  -System.Windows.Media.Effects.DropShadowEffect  5�      $   Color$$ Black��6'   %   
BlurRadius$% 10Q�65   &   	Direction$& 0Q�6E   '   ShadowDepth$' 0Q�6S   # 5�      . 	 (MahApps.Metro.IconPacks.PackIconMaterial  5�      � 	 �ControlzEx.PackIconBase`1[[MahApps.Metro.IconPacks.PackIconMaterialKind, MahApps.Metro.IconPacks, Version=1.9.0.0, Culture=neutral, PublicKeyToken=null]](   Kind$( Heart=�61   
���  ��$��28��6O   $��28��6[   $
 HighQuality=�6f   .��5�        $( HeartOutline=�6-   
�������$��28��6T   $��28��6`   $	 0.5Q�6k   $
 HighQuality=�6y   5�      5�      5�      5�      