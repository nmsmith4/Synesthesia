u s i n g   U n i t y E n g i n e ; 
 
 u s i n g   S y s t e m . C o l l e c t i o n s ; 
 
 
 
 p u b l i c   c l a s s   C h a n g e C o l o r   :   M o n o B e h a v i o u r   { 
 
 
 
 	 G a m e O b j e c t   C   =   G a m e O b j e c t . F i n d G a m e O b j e c t W i t h T a g ( " C " ) ; 
 
 	 G a m e O b j e c t   E   =   G a m e O b j e c t . F i n d G a m e O b j e c t W i t h T a g ( " E " ) ; 
 
 	 G a m e O b j e c t   G   =   G a m e O b j e c t . F i n d G a m e O b j e c t W i t h T a g ( " G " ) ; 
 
 	 p u b l i c   C o l o r   C C o l o r   =   C o l o r . g r e e n ; 
 
 	 p u b l i c   C o l o r   E C o l o r   =   C o l o r . y e l l o w ; 
 
 	 p u b l i c   C o l o r   G C o l o r   =   C o l o r . b l u e ; 
 
 
 
 	 / /   U s e   t h i s   f o r   i n i t i a l i z a t i o n 
 
 	 v o i d   S t a r t   ( )   { 
 
 	 	 C . G e t C o m p o n e n t < R e n d e r e r > ( ) . m a t e r i a l . c o l o r   =   C C o l o r ; 
 
 	 	 E . G e t C o m p o n e n t < R e n d e r e r > ( ) . m a t e r i a l . c o l o r   =   E C o l o r ; 
 
 	 	 G . G e t C o m p o n e n t < R e n d e r e r > ( ) . m a t e r i a l . c o l o r   =   G C o l o r ; 
 
 	 } 
 
 
 
 	 / /   W h e n   u s e r   h i t s   b u t t o n 
 
 	 v o i d   O n M o u s e O v e r   ( )   { 
 
 	 	 C . G e t C o m p o n e n t < R e n d e r e r > ( ) . m a t e r i a l . c o l o r   =   C o l o r . c l e a r ; 
 
 	 	 E . G e t C o m p o n e n t < R e n d e r e r > ( ) . m a t e r i a l . c o l o r   =   C o l o r . c l e a r ; 
 
 	 	 G . G e t C o m p o n e n t < R e n d e r e r > ( ) . m a t e r i a l . c o l o r   =   C o l o r . c l e a r ; 
 
 	 } 
 
 
 
 	 / /   A f t e r   u s e r   h i t s   b u t t o n 
 
 	 v o i d   O n M o u s e E x i t ( ) { 
 
 	 	 C . G e t C o m p o n e n t < R e n d e r e r > ( ) . m a t e r i a l . c o l o r   =   C C o l o r ; 
 
 	 	 E . G e t C o m p o n e n t < R e n d e r e r > ( ) . m a t e r i a l . c o l o r   =   E C o l o r ; 
 
 	 	 G . G e t C o m p o n e n t < R e n d e r e r > ( ) . m a t e r i a l . c o l o r   =   G C o l o r ; 
 
 	 } 
 
 } 
 
 
 
 
 
 