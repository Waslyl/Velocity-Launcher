   M S B A M L   `   `   `  ����   VelocityLauncher%    Velocity_Launcher.LoadingScreen   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     -     � Title$  Astro��$	��620��$
��1020�� � 
ResizeMode$ CanMinimize=� � WindowStyle$
 None=�����  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ #0e0f17�� � Offset$ 0Q�� $ #0f101a��$ 1Q�.��� .+��� ���#0d0e17$��416,247,416,269q� �� RadiusX$ 10�� �� RadiusY$ 10���� $��/Images/LoadingBar.png��$��30��$��30��$��Center=�$	��Top=�$��	0,264,0,0q�z��� -   RotationTransform��	 �� CenterX$	 15Q�
 �� CenterY$
 15Q��� -    ��Name$ LoadingTextBox��
�������$
��Bold"�$	��Top=�$��Center=�$��	0,308,0,0q�$��12(�
Loading! � Triggers :�  :� RoutedEvent$ Loaded��.[��� .����  g� RepeatBehavior$ Forever��.��W�  �� 
TargetName$ RotationTransform�� �� TargetProperty$ Angle� W� From 0	 W� To 360 g� Duration$ 0:0:2D�