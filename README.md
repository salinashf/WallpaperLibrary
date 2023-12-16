# WallpaperLibrary
Librería para personalizar el fondo de pantalla por cada monitor utilizando   netCore y Python  

#### Dependencias Python  

Dependencias net core 

```sh
pip install pythonnet
```

#### Crear proyecto con  Linea de comando    

Creacion de proyecto desde linea de comando   utilizando  net core 

```sh
dotnet new classlib -o WallpaperLibrary
```
para compilar y generar dll 
```sh
dotnet build
```

#### Para  dividir las imagenes 

Dependencias para dividir 
[split-image](https://pypi.org/project/split-image/) - Documentacion lib Split Image

```sh
pip install split-image
```

Divide la imagen en 1 fila  y dos columnas 

```sh
split-image imgpath.png 1 2
```


