# DotNetUpgradeDemo-4.8

This project is created with a purpose of demoing mmigration from .NET Framework into .NET Core

I. Performing analysis for dependencies
Make sure to make sure that packages that are used in the project either compatible with .NET Core or you can find a version of it that can be used in .NET Core

II. Performing upgrade
1. Installing upgrade assistant via this command: dotnet tool install -g upgrade-assistant
2. Navigate to the project directory
3. Enter this command: upgrade-assistant upgrade
4. Choose project to upgade
   ![image](https://github.com/VuNTruong/DotNetUpgradeDemo-4.8/assets/56061432/67920c62-12a8-4fcc-92fe-a166f1cfcf43)
5. Choose target framework
   ![image](https://github.com/VuNTruong/DotNetUpgradeDemo-4.8/assets/56061432/5dc9bb78-3638-4631-a88c-530e9f851927)
6. Enter "y" to perform upgrade
   ![image](https://github.com/VuNTruong/DotNetUpgradeDemo-4.8/assets/56061432/524b3966-239d-49e4-87a5-3c336fbff6ef)
