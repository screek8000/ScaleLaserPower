# ScaleLaserPower
Small UI Tool written in C# to scale laser power from 0-255 (software PWM) to 0-100 (hardware PWM) in existing gcode files.

Currently only M3 (or M03) commands with Sxxx values are supported.
If M3 commands without S value are found, S100 (full power) is added.

The scaled file is saved with the suffix "scaledTo100" besides the source file.

Could be easily extended for custom scaling of existing gcode. Feel free to do so.

![Image of UI](https://github.com/screek8000/ScaleLaserPower/raw/master/Download/Scale_Laser_Power_Sample.png)

A binary file can be found below the "Download" directory:
https://github.com/screek8000/ScaleLaserPower/raw/master/Download/ScaleLaserPower.exe

Needs .NET Framework 4.5.2 or newer:
https://www.microsoft.com/net/download/windows (.NET Framework Runtime)

Released under the GNU GPL v3, which you can find at http://www.gnu.org/licenses/gpl-3.0.en.html
