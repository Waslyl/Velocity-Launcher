   M S B A M L   `   `   `  ���� H  DAstroLauncher, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:AstroLauncherAstroLauncher      AstroLauncher.MainWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -localclr-namespace:AstroLauncher     D @ModernWpf, Version=0.9.6.0, Culture=neutral, PublicKeyToken=nullM IModernWpf.Controls, Version=0.9.6.0, Culture=neutral, PublicKeyToken=null,ui!http://schemas.modernwpf.com/2019     � Title$  Astro��$	��620��$
��1020�����#1C1C1C0  *ModernWpf.Controls.Primitives.WindowHelper   UseModernWindowStyle$
 True�� � 
ResizeMode$ CanMinimize=�.��� ���#1C1C1C � ColumnDefinitions �� $	��43* ��� $
��236* ��� $��4* ��� $��0* ��� $
��426* �.+�'  !ModernWpf.Controls.NavigationView  -     Name$ NavView��   PaneDisplayMode$
 Left=�   IsBackButtonVisible$ 	Collapsed=�    IsPaneToggleButtonVisible$ False��   
IsPaneOpen$
 True��$
��Left=�$��40��	 J� Opacity$		 0.2Q����#1C1C1C
�������
 � 	Resources
  #  NavigationViewTopPaneBackground �� Color ' #NavigationViewDefaultPaneBackground ( $NavigationViewExpandedPaneBackground+  %ModernWpf.Controls.NavigationViewItem �� 
TargetType �� Property �� Value��%�   &	        &	      &	 .     '  E     �� $ Transparent���� $ Transparent���� $ Transparent���� "  .���  � ��
 �����   	MenuItems      Icon-  'ModernWpf.Controls.IconElementConverter$
 Home 
 � Tag$
 Home��$
��Home��  $ Library $ Library��$��Library��  $ Download $ 	Downloads��$��Download��  ModernWpf.Controls.Frame  -     Name$ ContentFrame��$��4��$��31,204,53,36q�$��1��   ContentTransitions 4  .ModernWpf.Media.Animation.TransitionCollection  9  3ModernWpf.Media.Animation.NavigationThemeTransition  �� $��Images/Bar.png��$
��Fill=�$	��150��$��
31,27,53,0q�$	��Top=�$��1��$��4��