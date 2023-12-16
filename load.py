import clr #import clr from pythonnet
#load our dll file(mine is in my C:\\ folder)
clr.AddReference("W:\\WallpaperLibrary\\dll\\WallpaperLibrary.dll")
#import our Functions class from Our C# namespace WallpaperLibrary
from WallpaperLibrary import Functions

#create our Functions object
fun = Functions() 
#calling our methoths and printing
print("Addition: "+str(fun.Add(3999, 2)))
fun.ClearWallPaper();
fun.SetWallPaper('W:\\WallpaperLibrary\\test\\w1_0.jpg',1)
fun.SetWallPaper('W:\\WallpaperLibrary\\test\\w1_1.jpg',0)

## ref  https://dev.to/towernter/how-to-create-a-dynamic-link-library-dll-and-use-it-in-net-and-python-31oo


