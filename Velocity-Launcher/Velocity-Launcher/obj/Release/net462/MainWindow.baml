   M S B A M L   `   `   `  ���� K  GVelocityLauncher, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Velocity_LauncherVelocity_Launcher  "    Velocity_Launcher.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     1localclr-namespace:Velocity_Launcher     D @ModernWpf, Version=0.9.6.0, Culture=neutral, PublicKeyToken=nullM IModernWpf.Controls, Version=0.9.6.0, Culture=neutral, PublicKeyToken=null,ui!http://schemas.modernwpf.com/2019     � Title$  Velocity Launcher��$	��620��$
��1020�����#2725370  *ModernWpf.Controls.Primitives.WindowHelper   UseModernWindowStyle$
 True�� � 
ResizeMode$ CanMinimize=�.��� ���#151a26 � ColumnDefinitions �� $	��23* ��� $��8* ��� $	��31* ��� $
��340* ��� $��6* ��� $��0* ��� $
��612* �.+�� ���#1a1e29$��4��$��0,0,277,338q�'  !ModernWpf.Controls.NavigationView  -     Name$ NavView��   PaneDisplayMode$
 Left=�   IsBackButtonVisible$ 	Collapsed=�    IsPaneToggleButtonVisible$ False��   
IsPaneOpen$
 True��$
��Left=�$	��124��	 J� Opacity$	 1Q����#1a1e29
�������$��4��$��	0,102,0,0q�
 � 	Resources
  #  NavigationViewTopPaneBackground �� Color ' #NavigationViewDefaultPaneBackground ( $NavigationViewExpandedPaneBackground+  %ModernWpf.Controls.NavigationViewItem �� 
TargetType �� Property �� Value��%�   &	        &	      &	 .     '  E     �� $ Transparent���� $ Transparent���� $ Transparent���� "  .���  � ��
 �����   	MenuItems      Icon-  'ModernWpf.Controls.IconElementConverter$
 Home 
 � Tag$
 Home��$
��Home��  $ Download $ 	Downloads��$��Download��  ModernWpf.Controls.Frame  -     Name$ ContentFrame��$��4��$��86,204,53,36q�$��3��   ContentTransitions 4  .ModernWpf.Media.Animation.TransitionCollection  9  3ModernWpf.Media.Animation.NavigationThemeTransition  �� $��/Banner.png��$	��177��$��
86,27,53,0q�$	��Top=�$��3��$��4��$��UniformToFill=��� $��3��$��Velocity��$
��Left=�$��
131,74,0,0q�$	��Top=�$��38(�$��Bahnschrift SemiBold)��� $��3��$Q��KWelcome to Velocity, a Fortnite Private Server to play Chapter 2 Season 2 !��$
��Left=�$��131,125,0,0q�$	��Top=�$��17(�$��Bahnschrift SemiBold)�$��4��$	��573�����	#FFDCDBDB�� $
��Left=�$	��103��$��	10,10,0,0q�$	��Top=�$	��107��$��/Velocity-Logo.png��$��4��