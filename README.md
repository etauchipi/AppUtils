# AppUtils - Calculadora del Dígito de Verificación (NIT)

## Descripción
**AppUtils** es una biblioteca de clases de utilidades escrita en C#. Su función principal, proporcionada a través de la clase `IdentificaUtils`, es calcular el Dígito de Verificación (DV) de un Número de Identificación Tributaria (NIT), un proceso comúnmente utilizado en Colombia por la DIAN.

## Pila Tecnológica (Tech Stack)
Basado en el código fuente y los archivos de configuración, el proyecto utiliza las siguientes tecnologías:
- **Lenguaje:** C#
- **Framework:** .NET Framework 4.5
- **Entorno de Construcción:** MSBuild / Visual Studio

## Instrucciones de Instalación Local y Configuración
El proyecto no requiere dependencias externas adicionales, ya que utiliza únicamente las bibliotecas estándar de `.NET`.

### Requisitos Previos
- Tener instalado **Visual Studio** o las herramientas de compilación de **MSBuild** para `.NET Framework 4.5`.

### Pasos para compilar:
1. Clona este repositorio o descarga el código fuente en tu máquina local.
2. Abre una terminal o consola de comandos (Command Prompt, PowerShell o Developer Command Prompt para VS).
3. Navega hasta la raíz del proyecto donde se encuentra el archivo `.sln` (`AppUtils.sln`).
4. Para compilar el proyecto usando MSBuild, ejecuta el siguiente comando:
   ```bash
   msbuild AppUtils.sln /p:Configuration=Release
   ```
   *Alternativamente, puedes abrir `AppUtils.sln` directamente en Visual Studio y presionar `F6` (Construir Solución).*
5. Una vez compilado con éxito, la biblioteca de clases compilada (`AppUtils.dll`) se encontrará en el directorio `AppUtils/bin/Release/` (o `AppUtils/bin/Debug/` si usas la configuración Debug).

## Estructura de Carpetas
La estructura principal del repositorio es la siguiente:
```text
.
├── AppUtils.sln               # Archivo de la solución para abrir con Visual Studio o compilar con MSBuild.
└── AppUtils/                  # Carpeta del proyecto principal.
    ├── AppUtils.csproj        # Archivo de proyecto de C# con las configuraciones y referencias.
    ├── AppUtils.cs            # Código fuente principal que contiene la lógica de cálculo del NIT.
    └── Properties/
        └── AssemblyInfo.cs    # Información del ensamblado (.NET).
```

## Guía Básica de Uso
Una vez que el proyecto haya sido compilado, puedes añadir una referencia al archivo `AppUtils.dll` en tu propio proyecto de C#.

### Ejemplo de código en C#

A continuación se muestra un ejemplo básico de cómo instanciar y usar la utilidad para obtener el Dígito de Verificación de un NIT:

```csharp
using System;
// Importamos el espacio de nombres de la biblioteca
using AppUtils;

namespace EjemploUso
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciar la clase IdentificaUtils dentro de AppUtils
            AppUtils.IdentificaUtils util = new AppUtils.IdentificaUtils();

            // NIT de ejemplo (reemplaza por el valor real sin puntos ni guiones)
            long miNit = 890900050;

            // Calcular el dígito de verificación
            int digitoVerificacion = util.Calculo_NIT_DV(miNit);

            // Imprimir el resultado
            Console.WriteLine($"El Dígito de Verificación para el NIT {miNit} es: {digitoVerificacion}");
        }
    }
}
```
