   M S B A M L   `   `   `  ����N  JPozoristeSeminarski, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:PozoristeSeminarskiPozoristeSeminarski  5   	   )    #PozoristeSeminarski.KorisnikPregled   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:PozoristeSeminarski     5   	   $	��450��5   	   $	��900��6   
����d�  � WindowStyle$  SingleBorderWindow=�5
   	    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��450 �6   �� 5      .+�5   
   �� $��0��6   .+�5      � 
����ح�$��2��5      $	��435��6"   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ IzvodjenjeDataGrid��5         AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID izvodjenja��6D      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6\   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6-   �� *ID+6\     5      $ Naziv Predstave��6P   $ * 6i   	 6-   �� *NazivPredstave+6i     5      $ 
Naziv sale��6K   $ * 6_   	 6-   �� *	NazivSale+6_     5      $ Vreme Izvodjenja��6Q   $ * 6k   	 6-   �� *VremeIzvodjenja+6k   5      5       5!      �� 5#   
   $��1��6   .+�5$      � .+�5&      �� $��
DOBRODOSLI��6   $��Center=�6-   $��20(�6Q   $
��Bold"�6_   $��
0,0,0,-196q�6q   
 J� RenderTransformOrigin$
 0.5,0.5&�6�   z�5'      V� 5(      .~�5)      �� �� 5*       �� AngleX$ -0.106Q�6,   �� 5+      T� 5,       T� X$ -0.547Q�61   5-      5/      �� 50      $��IZABERITE PREDSTAVU:��6   $��0,40,0,-194q�67   $
��Bold"�6L   $��16(�6^   $
 0.502,1.636&�6l   �� 51      -   5        $��	Predstava��51      $��253,46,10,170q�6,   �� 53      -   5         ��Name$ btnRezervisi��53      $��	Rezervisi��6/   $��0,385,0,-173q�6C   
�������6p   54      55      57      59      