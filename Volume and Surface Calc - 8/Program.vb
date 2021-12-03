'
' Created by SharpDevelop.
' User: 19ofoster
' Date: 14/10/2021
' Time: 12:21
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Module Program
	Sub Main()
		'define some variables
		Dim height As Double = 0
		Dim width As Double = 0
		Dim depth As Double = 0
		Dim volume As Double = 0
		Dim SA As Double = 0
		
		'Asks te user for some data
		Console.WriteLine("Please enter the height . . . ")
		height = Console.ReadLine()
		Console.WriteLine("Please enter the width . . . ")
		width = Console.ReadLine()
		Console.WriteLine("Please enter the depth . . . ")
		depth = Console.ReadLine()
		
		'Calculates the volume 
		volume = depth * width * height
		
		'Calculates the surface area
		SA = 2*(depth*width + depth*height + height*width)
		
		Console.WriteLine("The volume was " & volume & " and the surface area was " & SA)
		Console.Write("Press any key to continue . . . ")
		Console.ReadKey(True)
	End Sub
End Module
