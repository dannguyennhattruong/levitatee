   M S B A M L   `   `   `  ����C  ?Levitate, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Levitate.PropertiesLevitate.Properties  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      7 clr-namespace:Levitate.ViewModelLevitate.ViewModel  5      -clr-namespace:Levitate.ViewLevitate.View  5	      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity 5      U QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5          Levitate.View.MainWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      /p!clr-namespace:Levitate.Properties     5      9system&clr-namespace:System;assembly=mscorlib     5      6	viewModel clr-namespace:Levitate.ViewModel     5      -localclr-namespace:Levitate.View     5	      U QGongSolutions.WPF.DragDrop, Version=1.1.0.0, Culture=neutral, PublicKeyToken=nullddurn:gong-wpf-dragdrop  5
      XiPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity  5      U	 QMaterialDesignThemes.Wpf, Version=2.3.0.823, Culture=neutral, PublicKeyToken=nullX
 TMaterialDesignThemes.MahApps, Version=0.0.10.0, Culture=neutral, PublicKeyToken=nullHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes 	 
 5      LControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro 	 
 5      R NMahApps.Metro.IconPacks, Version=1.9.0.0, Culture=neutral, PublicKeyToken=null=	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks  5      -   5           MaterialDesignPaper#���   5        AccentColorBrush#���  5        � Title$  Levitate��5       � Icon$6 0pack://application:,,,/Resources/Images/ICON.ico��5      $	��600��5      $	��800��5       � WindowStartupLocation$ CenterScreen=�5      (  "MahApps.Metro.Controls.MetroWindow   SaveWindowPosition .  � ShowInTaskbar .    ShowMaxRestoreButton .    ShowMinButton .    ShowCloseButton .    ShowTitleBar .  	 J� 	AllowDrop	 . ��5      �� "  Levitate.Properties.Settings
   Default �� Source# Z
  �� Path$ 
MainHeight� �� Mode$ TwoWay=���5      �� # Z
 $ 	MainWidth�$ TwoWay=� � 	Resources 5)        DragAdornerTrack �� DataType & "Accent                 ColorBrush3 �� Orientation  DragAdornerPlaylist  AccentColorBrush27   1Levitate.ViewModel.PlayStateToVisibilityConverter  PlayStateConverver8   2Levitate.ViewModel.PauseStateToVisibilityConverter  PauseStateConverver��%M  &	       7  &	 4    7  &	 �    &	 
    �� 5*   
   " ]�60   .R�5+      � $	��400��6   $��40��5,      $��1q�5-      8��  .+�50      �� $��10,0,0,0q�6   $��Center=�51   )   $ Vertical=�52   )   .+�53      �� 
���������63   �� *Title+�� 54      
���������63   �� *Artist+55      56      57      �� 59   
   .R�5:      � $	��190��6   $��25��5;      8��  .+�5=      �� $��10,0,0,0q�6   $
��Left=�5>   (   $��Center=�5?   (   
���������5A   (   �� 5B      5C        5E   
   63     5F   
   64   5H       � DataContext 5L      ,   &Levitate.ViewModel.MainWindowViewModel  5M   
    J� InputBindings 5R      �� 5S   
   
 �� Key$ O��63    �� 	Modifiers$
 Ctrlf�6;    �� Command 6   �� *	AddFolder+6;   �� 5T   
   $ N��65   $
 Ctrlf�6=    6   �� *NewPlaylist+6=   �� 5U   
   $ Return��69    6   �� *TogglePlayPause+69   �� 5V   
   $
 Left��66    6   �� *PlayBackward+66   �� 5W   
   $ Right��65    6   �� *PlayForward+65   .��5]      � -   5        
������  �� BitmapScalingMode$ HighQuality=�5^       �� CachingHint$ Cache=�5_       �� ClearTypeHint$ Enabled=�5`       � RowDefinitions 5b   
   �� 5c      $��80 �6   �� 5d      $��* �6    � ColumnDefinitions 5g   
   �� 5h      $	��200 �6   �� 5i      �� 5j      $	��200 �6   .+�5o   
   � $��0��6   
������ $��3��65    5p      �� 5q      $
��230* �6#   �� 5r      $
��372* �6#   �� 5s      $
��230* �6#   .+�5w      � $��0��6    K� ZIndex$ 1��6#   .+�5y      ' 	 !MaterialDesignThemes.Wpf.PopupBox  $��4,8,0,39q�6*      	StaysOpen . $��33��5{   "   $��0��5|   "   $��0��6/      PopupContent. 5}      � $	��250��6   $��10 10 10 10q�6'    5~       �� 
TargetType  MaterialDesignRadioButton �� BasedOn  �� Property! �� Value��%b   '	�       7  �� 5      " 	�6$   8   .�5�   "   ��   � ��$! 	12 8 10 8q�6;   5�      5�      .+�5�      �� $ Vertical=�6%   .+�5�      �� -   5        " ��Name$" button_AddFiles��5�   %   $��0 0 0 0q�6>   $��Center=�6k   ��6O   �� *	AddFile+.��5�   "   �� $ 
Horizontal=�6-   $��0 15 0 0q�6F   .+�5�   &   �� $<��6pack://application:,,,/Resources/Images/popup_File.png��6,   $��25��6l   $��25��6x   $ HighQuality=�5�   $   �� 5�   &    	 addfile#��� 	 60   $��8,0,0,0q�6Q   5�   #   5�      �� 5�      -   5        $" button_AddFolder��5�   %   $��0 0 0 0q�6@   $��Center=�6o   ��6Q   �� *	AddFolder+.��5�   "   �� $ 
Horizontal=�6-   $��0 15 0 0q�6F   .+�5�   &   �� $>��8pack://application:,,,/Resources/Images/popup_Folder.png��6,   $��25��6n   $��25��6z   $ HighQuality=�5�   $   �� 5�   &    
 	addfolder#��� 
 60   $��8,0,0,0q�6S   5�   #   5�      �� 5�      �� 5�      -   5        # ��Name$# label_chooseLang��5�   $     
chooseLang#���  6>   $��
10,10,10,5q�6f   	� 5�      -   5        $ 	�Name$$ radioButton_en��5�   *     english#���  6B   $��Center=�6f   6�   	� 5�      -   5        $$ radioButton_vn��5�   *     
vietnamese#���  6B   $��Center=�6i   6�   	� 5�      -   5        $$ radioButton_jp��5�   *     japanese#���  6B   $��Center=�6g   6�   �� 5�      �� 5�      -	   5        $" button_ClearAll��5�   %   $��0 0 0 0q�6>   $��Center=�6r   ��6O   �� *CleanUpLibrary+.��5�   "   �� $ 
Horizontal=�6-   $��0 15 0 0q�6F   .+�5�   &   �� $=��7pack://application:,,,/Resources/Images/popup_Clean.png��6,   $��25��6m   $��25��6y   $ HighQuality=�5�   $   �� 5�   &     cleanUp#���  60   $��8,0,0,0q�6Q   5�   #   5�      �� 5�      �� 5�      -
   5        $" button_About��5�   %   $��0 0 0 0q�6;   $��Center=�6j   ��6L   �� *	OpenAbout+.��5�   "   �� $ 
Horizontal=�6-   $��0 15 0 0q�6F   .+�5�   &   �� $7��1pack://application:,,,/Resources/Images/about.png��6,   $��25��6g   $��25��6s   $ HighQuality=�5�   $   �� 5�   &    	 about#���  60   $��8,0,0,0q�6O   5�   #   5�      5�      5�      5�      � 5�      $��0��6   $
��55,0q�6'   $ 2��65   .+�5�      �� -   5        $" button_play��5�       & "MaterialDesignFloatingActionButton#���  62   
������ 
������ $ HighQuality=�5�   L   $��48��6z   $��	44,10,0,0q�6�   $��48��6�   $	��Top=�6�   $
��Left=�6�   ��5�   o   �� *TogglePlayPause+y�6�   �� *MusicManager.State+% �� 	Converter#% [ & �� UpdateSourceTrigger$& Default=�.��5�      �� $��5 0 0 0q�6    $B��</Levitate;component/Resources/Images/Controls/buttonPlay.png��61   $��30��6w   5�      �� 5�      -   5        $" button_pause��5�      #���  63   
������ 
������ $ HighQuality=�5�   L   $��48��6z   $��	44,10,0,0q�6�   $��48��6�   $	��Top=�6�   $
��Left=�6�   ��5�   p   �� *TogglePlayPause+y�6�   �� *MusicManager.State+#% [ $& Default=�.��5�      �� $��0 0 0 0q�6    $C��=/Levitate;component/Resources/Images/Controls/buttonPause.png��61   $��30��6x   5�      �� 5�      -   5        $" button_back��5�      #���  62   
������ 
������ $ HighQuality=�5�   L   $��40��6z   $��4,14,0,0q�6�   $��38��6�   $
��Left=�6�   $	��Top=�6�   ��5�   o   �� *PlayBackward+.��5�      �� $��0 0 5 0q�6    $B��</Levitate;component/Resources/Images/Controls/buttonBack.png��61   $��25��6w   5�      �� 5�      -   5        $" button_next��5�      #���  62   
������ 
������ $ HighQuality=�5�   L   $��40��6z   $��	94,14,0,0q�6�   $��38��6�   $
��Left=�6�   $	��Top=�6�   ��5�   o   �� *PlayForward+.��5�      �� $��5 0 0 0q�6    $B��</Levitate;component/Resources/Images/Controls/buttonNext.png��61   $��25��6w   5�      �� 5�      -   5        ' ��Name$' slider_volume��5�      
������ $��
10,64,0,-5q�5�      ( � Minimum$( 0Q�61   ) � Maximum$) 1Q�6=   $
��Left=�5�      $	��116��68   * �� IsMoveToPointEnabled* .   ttip_volume+ � ToolTip#+ �  5�      , � Value, 5�   I   �� *MusicManager.Player.Volume+5�      5�      5�      � 5�      $��1��6   $ 1��6#   ��5�      �� 5�      - �� Color$- 	#FF0E0E0E��6&   . �� Opacity$	. 0.3Q�68   .+�5�      �� -   5        / ��Name$/ header_coverArt��5�      $��80��5�   Z   $	��Top=�6f   $
��Left=�6~   $��80��6�   ��6   �� *#!MusicManager.CurrentTrackCoverArt+$ OneWay=�6�   �� 5�      -   5        $%" header_button_miniPlayerChanger��5�      $��80��5�      $	��Top=�6%   $
��Left=�6=   $��80��6X   
������ $��0q�5�   2   
������ 0 J� Opacity$0 0Q�6`   ��5�   B   �� *OpenMiniPlayer+��5�      �� 5�      1 �� Triggers1 5�      :� 5�   "   2 :� RoutedEvent$2 Control.MouseEnter��6/   .[�5�   &   �� .��5�   *   �� .��5�   .   W� 3 g� Duration$3 0:0:0.3D�6>   	4 W� To$4 1X�6Q   5 �� TargetProperty$5 Opacity�6X   5�   +   5�   '   5�   #   :� 5�   "   $2 Control.MouseLeave��6/   .[�5�   &   �� .��5�   *   �� .��5�   .   W� $3 0:0:0.3D�6>   $4 0X�6Q   $5 Opacity�6X   5�   +   5�   '   5�   #   5�      .��5�      �� $@��:/Levitate;component/Resources/Images/miniPlayerChanger.png��6   5�      �� 5�      -   5        $# headerLabel_Title��5�      $
��Left=�63   $��	123,5,0,0q�6N   $	��Top=�6a   	 . $	��236��6�   + 6�   �� *!MusicManager.CurrentTrack.Title+.��5�      �� -   5        6 ��Name$6 headerTextBlock_Title��5�       
�������$��CharacterEllipsis=�6R   $��SemiBold"�6�   $��16(�6�   ��6s   �� *!MusicManager.CurrentTrack.Title+7 J� Effect7 5�      3  -System.Windows.Media.Effects.DropShadowEffect  5�      8   Color$8 Black��6/   9   	Direction$9 0Q�6=   :   ShadowDepth$: 0Q�6K   ;   
BlurRadius$; 20Q�6[   <   Opacity$	< 1.2Q�6k   5�      5�      �� 5�      -   5        $# headerLabel_Album��5�      $
��Left=�63   $��
123,31,0,0q�6N   $	��Top=�6b   	 . $	��236��6�   $��29��6�   + 6�   �� *!MusicManager.CurrentTrack.Album+.��5�      �� -   5        $6 headertextBlock_Album��5�       
�������$��CharacterEllipsis=�6R   $
��Auto��6�   $��13(�6�   $��Light"�6�   ��6s   �� *!MusicManager.CurrentTrack.Album+7 5�        5      $8 Black��6/   $9 0Q�6=   $: 0Q�6K   $; 20Q�6[   $	< 1.2Q�6k   5     5     d� 5      ( $MaterialDesignActionDarkToggleButton#���  6   
������ $��35��5     $��35��6'   $��0,4,0,0q�5  U   $	��Top=�6f   $��Right=�6~   = d� 	IsChecked= 6   �� *MusicManager.IsShuffle+$ TwoWay=���5	     �� 5
     $?��9/Levitate;component/Resources/Images/Controls/shuffle.png��6    $
0 0.55Q�6c   $��26��6r   $��26��6~   1 	 +MaterialDesignThemes.Wpf.ToggleButtonAssist>   	OnContent> 5     �� 5     $?��9/Levitate;component/Resources/Images/Controls/shuffle.png��6    $��26��6c   $��26��6o   5     d� 5     #���  6   
������ $��35��5     $��35��6'   $��83,4,0,0q�5  U   $	��Top=�6g   $
��Left=�6   ��5  ^   �� *SetLoopMode+= 5     �� *MusicManager.IsLoopOne+$ TwoWay=���5     �� 5     $?��9/Levitate;component/Resources/Images/Controls/loopAll.png��6    $��26��6c   $��26��6o   > 5     �� 5     $?��9/Levitate;component/Resources/Images/Controls/loopOne.png��6    $��26��6c   $��26��6o   5     �� 5     -   5        $' slider_Timeline��5     $��80,70,0,-11q�63   $��21��6H   $	��Top=�6T   
������ * . , 5!     �� *MusicManager.Position+$ OneWay=�) 6N   �� *MusicManager.MaxPosition+$ OneWay=��� 5#     -   5        $6 label_position��5#     $
��Left=�64   {�.  
�������$��	85,54,0,0q�5$     $	��Top=�6/   $��64��6G   $��11(�6R   ? �� TextAlignment$
? Left=�6`   ��5%     �� *MusicManager.TimeGone+@ �� StringFormat$@ {0:mm}:{0:ss}���� 5&     -   5        $6 label_remaining��5&     $��Right=�65   {�.  
�������$��0,54,5,0q�5'     $	��Top=�6*   $��64��6B   $��11(�6M   $? Right=�6[   ��5(     �� *MusicManager.TimeRemain+$@ {0:mm}:{0:ss}��5,     �� 50     -   5        $/ header_backdrop��50     $	��233��6o   $	��Top=�51     $��3��52     $
0 0.65Q�6(   $��-38,-116,-38,-37q�67   $
��Fill=�53     $ 0��6#   ��50  -   �� *#!MusicManager.CurrentTrackCoverArt+$ OneWay=�7 54     -	  'System.Windows.Media.Effects.BlurEffect	  55     A 	  Radius$A 50Q�6!   57     � 59     $��2��6   $��80��6#   $	��Top=�6/    5:     �� 5;     $	��29* �6'   �� 5<     $
��189* �6'   �� 5=     $	��29* �6'   .+�5?     �� -   5        B ��Name$B textBox_SearchBox��5?     $��
35,23,0,27q�65   $��1��6�   ��6I   �� *MusicManager.SearchText+$& PropertyChanged=�6�   �� 5A     -   5        $/ image��5A     $5��//Levitate;component/Resources/Images/search.png��6'   $��30��6`   $��0,23,0,0q�6l   $	��Top=�6~   $ HighQuality=�5B     $��1��6F   $
��Left=�6V   $��30��6q   5C     5F     �� 5M  
   $��0��6   $��1��6%   $��0,16,0,0q�62   $
��Auto��6D   $	��Top=�6R   .+�5O     �� -   5        $" button_RecentlyAdded��5O     $
��Left=�63     MaterialDesignFlatButton#���  5P     $��45��5Q     $	��200��6!   $��0��5R     $��1��6%     ttip_recentlyAdded#+ �  5S     ��5O  U   �� *ShowRecentlyAdded+.��5T     �� $ 
Horizontal=�6   $��0 5 0 5q�66   .+�5U     �� $G��Apack://application:,,,/Resources/Images/listbox_recentlyAdded.png��6   $��20��6g   $��20��6s   $��5 0 15 0q�6~   �� 5V       recentlyAdded#���  6    
�������$��Center=�6^   $��Center=�6{   $��15(�6�   5W     5X     �� 5Z     -   5        $" lbItem_Songs��5Z     $
��Left=�6+   #���  5[     $��45��5\     $	��200��6!   $��0��5]     $��1��6%   ��5Z  M   �� *ShowAllSongs+.��5^     �� $ 
Horizontal=�6   $��0 5 0 5q�66   .+�5_     �� $?��9pack://application:,,,/Resources/Images/listbox_songs.png��6   $��20��6_   $��20��6k   $��5 0 15 0q�6v   �� 5`      	 songs#���  6    
�������$��Center=�6V   $��Center=�6s   $��15(�6�   5a     5b     �� 5d     -   5        $" lbItem_Favourite��5d     $
��Left=�6/   #���  5e     $��45��5f     $	��200��6!   $��0��5g     $��1��6%   ��5d  Q   �� *ShowFavourites+.��5h     �� $ 
Horizontal=�6   $��0 5 0 5q�66   .+�5i     �� $C��=pack://application:,,,/Resources/Images/listbox_favourite.png��6   $��20��6c   $��20��6o   $��5 0 15 0q�6z   �� 5j       	favourite#���  6    
�������$��Center=�6Z   $��Center=�6w   $��15(�6�   5k     5l     5m     �� 5p  
   -   5        C ��Name$C listBox_sidebar��5p     $��0��6+   $��1��6;   $��Hidden=�5r     )
  #GongSolutions.Wpf.DragDrop.DragDrop D 
  DefaultDragAdornerOpacity$	D 0.8Q�5t     E 
  DragAdornerTemplate#E [ 5u     F 
  IsDragSourceF . G 
  IsDropTargetG . $��
0,156,0,51q�5x  V   ��5q     �� *MusicManager.Playlists+H �� SelectedItemH 5s     �� *MusicManager.SelectedPlaylist+I 
  DropHandlerI 5x     �� *PlaylistListDropHandler+ 5{     �� 5|     $ F2��6H    6   �� *RenameSelectedPlaylist+6H   �� 5}     $ Delete��6I    6   �� *DeleteSelectedPlaylists+J �� CommandParameterJ 5~  %   �� K �� ElementName$K listBox_sidebar��$ SelectedItems��� 5     $ Delete��6D   $ Shiftf�6Q    6   �� *DeleteAllPlaylists+6Q   L � ContextMenuL 5�     �� 5�     .@�5�     m� -    5        M m�Name$M lb_contextMenu_Play��5�       play#���  6<   N m� CommandN 6\   �� *PlaySelectedPlaylist+�� 5�     m� 5�     -!   5        $M lb_contextMenu_Rename��5�      
 rename#���  6>   N 6`   �� *RenameSelectedPlaylist+m� 5�     -"   5        $M lb_contextMenu_Delete��5�      
 delete#���  6>   N 5�  '   �� *DeleteSelectedPlaylists+O m� CommandParameterO 5�  '   �� P �� RelativeSourceP �� Q �� AncestorType"Q ��$# PlacementTarget.SelectedItems�5�     ��5�     �� 5�     .R�5�     �� $ 
Horizontal=�6!   $��0 5 0 5q�6:   .+�5�     �� $��15��68   $��15��6D   $��	15,0,10,0q�6O   $ HighQuality=�6b   ��6    �� *Icon+6b   �� 5�     
�������$��Center=�6Q   $��Center=�6n   $��15(�6�   $��Regular"�6�   ��6$   �� *Name+6�   5�     5�     5�       5�  
   -#   5        R  Name$R popupBox��5�  "    - )MaterialDesignMultiFloatingActionPopupBox#��[ 5�  "     options#+ �  5�  "   S   PlacementMode$S TopAndAlignCentres=�5�  "   $��	15,0,0,15q�5�  "   $��1��5�  "   $��45��5�  "   $��45��5�  "   $��Bottom=�5�  "   $
��Left=�6=   $ HighQuality=�5�  "   . 5�     �� .+�5�     ��   createNewPlaylist#+ �  6   ��6G   �� *NewPlaylist+��5�     7  1MahApps.Metro.IconPacks.PackIconMaterialExtension  *PlaylistPlus+�� 5�       deleteAllPlaylist#+ �  6   ��6G   �� *DeleteAllPlaylists+��5�     <  6MahApps.Metro.IconPacks.PackIconMaterialLightExtension  *Delete+5�     5�     �� 5�  
   -$   5        T ��Name$T listView_View��5�     
������ $y�Visible=�5�     U �� SelectionMode$U Extended=�5�     V %� IsVirtualizingV . #E [ 5�     F . G . $��2��5�  E   $��1��6Y   $��1��6i   $��0,10,0,0q�6v   ��5�     �� *MusicManager.ViewSource+H 5�     �� *MusicManager.SelectedTrack+I 5�     �� *TrackListDropHandler+ 5�     �� 5�     $ F2��5�      5�     �� *GetTrackInfo+5�     �� 5�     $ Return��5�      5�     �� *PlaySelectedTrack+5�     �� 5�     $ C��5�     $
 Ctrlf�6%    5�     �� *Copy2Clipboard+J 5�     �� $K listView_View��$ SelectedItems��� 5�     $ Delete��5�      5�     �� *DeleteSelectedTracks+J 5�     �� $K listView_View��$ SelectedItems� 5�     &   System.Windows.Media.TextOptions��%  '��       �� 5�     " ��6   .�5�     ��   � ��$! CharacterEllipsis=�65   �� 5�       �@ TextRenderingMode$! 	ClearType=�6F   �� 5�       � ��! 61   �� # Z
 $ col_MinWidth�$ OneWay=��� 5�       � ��$! Center=�6:   5�     5�     L 5�     �� 5�     .@�5�     m� -%   5        $"M listView_contextMenu_GetInfo��5�        getinfo#���   6E   N 6h   �� *GetTrackInfo+�� 5�     m� 5�     -&   5        $M listView_contextMenu_Play��5�     #���  6B   N 6b   �� *PlaySelectedTrack+�� 5�     m� 5�     -'   5        $M listView_contextMenu_Copy��5�      ! copy#��� ! 5�     N 5�     �� *Copy2Clipboard+O 5�     �� P �� "Q ��$# PlacementTarget.SelectedItems�m� 5�     -(   5        $!M listView_contextMenu_Delete��5�     #���  5�     N 5�     �� *DeleteSelectedTracks+O 5�     �� P �� "Q ��$# PlacementTarget.SelectedItems�{�5�     �� *'%MusicManager.SelectedPlaylist.CanEdit+5�     ��5�     �� 5�      " MetroListViewItem# [" 6   " ��6E   .�5�     ��   � ��$! 0 0 0 0q�6/   �� 5�       � ��
! ���� 63   5�     W �� ViewW 5      �� 5     -)   5        gridview��.P�5     �� -*   5        col_PlayingState��X �� Width$X 35��5  %   Y �� CellTemplateY 5     �� 5     .R�5  "   �� $��28��6(   $��28��64   $ HighQuality=�5	  (   $��Uniform=�6V   ��5  ?   �� *PlayingState+$ OneWay=�Z �� TargetNullValueZ Z� 5	  V   5
     5     �� 5     -+   5        	col_Title��X 5  %   �� # Z
 $ 	col_Title�$ OneWay=�[ �� DisplayMemberBinding[ 5  %   �� *Title+��5     �� 5     -,   5        
\ � Tag$\ Title��5  3    	# title#��� # 6Z   5     �� 5     --   5        col_Duration��X 5  %   �� # Z
 $ col_Duration�$ TwoWay=�[ 5  %   �� *TrueDuration+��5     �� 5     -.   5        $\ Duration��5  3    $ duration#��� $ 6]   5     �� 5!     -/   5        
col_Artist��X 5"  %   �� # Z
 $ 
col_Artist�$ TwoWay=�[ 5#  %   �� *Artist+��5$     �� 5%     -0   5        $\ Artist��5%  3    
% artist#��� % 6[   5'     �� 5*     -1   5        	col_Album��X 5+  %   �� # Z
 $ 	col_Album�$ TwoWay=�[ 5,  %   �� *Album+��5-     �� 5.     -2   5        $\ Album��5.  3    	& album#��� & 6Z   50     �� 53     -3   5        	col_Genre��X 54  %   �� # Z
 $ 	col_Genre�$ TwoWay=�[ 55  %   �� *Genre+��56     �� 57     -4   5        $\ Genre��57  3    	' genre#��� ' 6Z   59     �� 5<     -5   5        col_Favourite��X 5=  %   �� # Z
 $ col_Favourite�$ TwoWay=���5?     �� 5@     -6   5        $\ IsFavourite��5@  3   ��6`     *Heart+�  �MahApps.Metro.IconPacks.PackIconExtension`2[[MahApps.Metro.IconPacks.PackIconMaterial, MahApps.Metro.IconPacks, Version=1.9.0.0, Culture=neutral, PublicKeyToken=null],[MahApps.Metro.IconPacks.PackIconMaterialKind, MahApps.Metro.IconPacks, Version=1.9.0.0, Culture=neutral, PublicKeyToken=null]]]   Height$] 14X�^   Width$^ 14X�Y 5C     �� 5D     .R�5E  "   d� -7   5         $(  MaterialDesignActionToggleButton#��[( 5E  /   
������ $��Center=�5G  /   $��Center=�5H  /   $��18��5I  /   $��18��6;   = 5J  /   �� *IsFavourite+$ TwoWay=���5L  &   .  (MahApps.Metro.IconPacks.PackIconMaterial  5M  *   �  �ControlzEx.PackIconBase`1[[MahApps.Metro.IconPacks.PackIconMaterialKind, MahApps.Metro.IconPacks, Version=1.9.0.0, Culture=neutral, PublicKeyToken=null]]_   Kind$_ HeartOutline=�6E   $	0 0.3Q�6Y   $��14��6g   $��14��6s   
�������6~   > 5O  &     5P  *   $_ Heart=�6E   $��14��6R   $��14��6^   
�������6i   5R  #   5S     5U     5W     5Y     5^     5_     