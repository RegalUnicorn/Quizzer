   M S B A M L   `   `   `  ���� B  >Quizzer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:QuizzerQuizzer      Quizzer.Statistics   !Quizzerclr-namespace:Quizzer  W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008       � 	Resources   �� Source�� $ Styles.xaml?�%    .���  � RowDefinitions �� $��1* ��� $��1* ��� $��0* � � ColumnDefinitions �� $
��227* ��� $
��227* ��� $
��229* �.+�� $��5,5,5,5q�.+��� $��2��$��3�� �� RadiusX$ 10�� �� RadiusY$ 10��$��0������  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ 	#FF191919��	 � Offset$	 1Q�� $ 	#FF292929���� 
���   �$��1q�
 �� CornerRadius$
 10��}�.  J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     ShadowDepth$ 0Q�   
BlurRadius$ 10Q�� -    �Name$ grdGraph��$��0q���Z�  �� $��52 ��� $��1* � �� $��51 �$��51���� $	��270 ��� $��48 �$��48��.+��� -    ��Name$ txbGraphTitle��$��20(� �� TextAlignment$ Center=�$
��Bold"�$��
10,10,10,0q�$$��Percentage Correct per Subject��$	��Top=�$��2��$��41���� $ Right=�$��1��$
��Wrap=�$
��100%��$	��Top=�$��0,0,10,0q�$��21���� $ Right=�$��1��$
��Wrap=�$��0%��$��Bottom=�$��0,0,10,0q�$��22��� $��5,5,5,5q�$��1��$��2��.+��� $��2��$��3��$ 10��$ 10��$��0������ $ 0.5,1&�$ 0.5,0&�.��� $ 	#FF191919��$	 1Q�� $ 	#FF292929���� 
���   �$��1q�$
 10��}�.    $ 0Q�$ 10Q�� -   $ grdQuestionGraph��$��0q���Z�  �� $��52 ��� $��1* � �� $��51 �$��51���� $	��275 ��� $��48 �$��48��.+��� -   $ txbQuestionsGraphTitle��$��20(�$ Center=�$
��Bold"�$��
10,10,10,0q�$0��*No.Q's, Q's Answered, Q's right, Q's wrong��$	��Top=�$��2��$��41���� -   $ txbHighestQuestions��$ Right=�$��1��$
��Wrap=�$
��100%��$	��Top=�$��0,0,10,0q�$��21���� -   $ txbLowestQuestions��$ Right=�$��1��$
��Wrap=�$��0%��$��Bottom=�$��0,0,10,0q�$��22��!   Quizzer.TagRecordStatistics  -     Name$ trsSubjects��$��1��$��5q�  -   $ trsTags��$��2��$��2��$��5q�