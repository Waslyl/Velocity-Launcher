   M S B A M L   `   `   `  ����   AstroLauncher!    AstroLauncher.LoadingScreen   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     ���#111111  � Title$  Astro��$	��620��$
��1020�� � 	Resources    CircularProgressBar �� 
TargetType �� Property �� Value �� 
TargetType A�Name � Color � Offset	 �� Triggers
 P� Property P� Value N� EnterActions �� 
TargetName �� TargetProperty W� From	 W� To g� Duration g� RepeatBehavior��%�  &	        �� " �.���  � �� �� " �.R�� .+�A� $ 
PART_Track��$��2�����#C0C0C0A� $ PART_Indicator��$��2�����#0078D7��
� .��� $ #0078D7��$ 0Q�� $ #0078D7��$	 0.3Q�� $ Transparent��$ 1Q�z��� SpinnerRotate��	 P� 
 �@�IsIndeterminate$
 True�� �� .���� .��W� $ SpinnerRotate��$ Angle� 0 360$ 0:0:1.5D�$ Forever��.��� .+��� $!��/Images/LoadingScreenBG.jpg��$
��Fill=� J� Effect -  'System.Windows.Media.Effects.BlurEffect     Radius$ 20Q���  �� CornerRadius$ 5�����#292b2e$��Center=�$��Center=�$	��241��$	��388�� J� Opacity$ 1Q�._��  � IsIndeterminate$
 True��$��	0,234,0,0q�$	��126��$	��Top=��� -    ��Name$ LoadingTextBox��$$��Initializing Configurations...��
������ $��Center=�$��Center=�$��20(�$
��Bold"�
�������