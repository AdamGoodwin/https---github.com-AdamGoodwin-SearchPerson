   M S B A M L   `   `   `  ����C  ?WpfShare, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WpfShareWpfShare  5   	       WpfShare.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:WpfShare     5   	     � Title$  
MainWindow��5   	   $	��480��6   $	��640��6)    � 	Resources 5	         personViewSource  personInterestViewSource �� Source �� Source��%X   &	        &	      7   S� 5
   
   6   �� 5   
    6@   �� *	Hobbies+8   5      .��5      � $��	0,0,2,-21q�6    J� RenderTransformOrigin$ 0.902,0.002&�6   .+�5   
   �� -   5         ��Name$ 	searchbox��5      $
��Left=�6%   $��23��6@    �� TextWrapping$
 Wrap=�6L   $��TextBox��6`   $	��Top=�6o   $	��120��6�   $��	98,66,0,0q�6�   �� 5   
   -   5         ��Name$ search��5      $��Search��6!   $
��Left=�62   $	��Top=�6M   $��75��6e   $��
421,65,0,0q�6p   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGridPerson��5      $
��Left=�6+   $	��Top=�6F   $��
28,120,0,0q�6^   $	��160��5      $	��540��6    	   AutoGenerateColumns	 .  
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        IdColumn��,  &System.Windows.Controls.DataGridColumn   Header$ Id��5   N      Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6Z      
Visibility$ Hidden=�6o   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *Id+6o     5      -   5        	FirstName��$ 
First Name��5   V   $ 3* 6j    68   �� *	FirstName+6j     5      -   5        LastName��$ 	Last Name��5   T   $ 3* 6g    67   �� *
LastName+6g     5      -   5        Age��$	 Age��5   J   $ 1* 6W    62   �� *Age+6W     5      -   5        Address��$ Address��5   R   $ 3* 6c    66   �� *	Address+6c   5        5   
   -	   5        $ dataGridInterests��5      $
��Left=�6.   $	��Top=�6I   $��195,300,0,0q�5      $	��125��6(   $	��200��65   $ 1.173,0.555&�6A   
 5        5      -
   5        firstinterestcolumn��$ Int 1��5   a   $ 3* 6p    6B   �� *
Hobbies[1]+6p     5      -   5        secondinterestcolumn��$ Int 2��5   b   $ 3* 6q    6C   �� *
Hobbies[2]+6q     5       -   5        thirdinterestcolumn��$ Int 3��5    a   $ 3* 6p    6B   �� *
Hobbies[3]+6p   5"      5$      5%      