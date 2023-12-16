import clr #import clr from pythonnet
#load our dll file(mine is in my C:\\ folder)
clr.AddReference("A:\\wallpaperChanger\\WallpaperLibrary\\bin\\Debug\\net7.0\\WallpaperLibrary.dll")
#import our calculator class from Our C# namespace MyCalculator
from WallpaperLibrary import Functions

calc = Functions() #create our Calculator object

#calling our methoths and printing
print("Addition: "+str(calc.Add(3999, 2)))
calc.SetWallPaper('A:\\wallpaperChanger\\WallpaperLoad\\test\\wallpaper1.png',0)

