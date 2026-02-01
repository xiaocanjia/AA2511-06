@echo %date% %time%
@echo  开始获取手机系统LOG

adb wait-for-device
adb root
@echo off
FOR /F "tokens=1-3 delims=/ " %%a IN ("%date%") DO (SET _MyDate=%%a%%b%%c)
FOR /F "tokens=1-4 delims=:." %%a IN ("%time%") DO (SET _MyTime=%%a%%b%%c)
SET _MyTime=%_MyTime: =0%
SET myDIR=%_MyDate%%_MyTime%
SET Screenshots_DIR=%myDIR%\Screenshots

IF not exist %myDIR% (mkdir %myDIR%)
IF not exist %Screenshots_DIR% (mkdir %Screenshots_DIR%)

echo on
adb pull blackbox/ylog ./%myDIR%/blackbox_ylog
adb pull data/ylog ./%myDIR%/data_ylog
adb pull data/vendor/local/media/ ./%myDIR%/
adb pull sdcard/ylog ./%myDIR%/sd_ylog
adb pull sdcard/Pictures/Screenshots ./%myDIR%/
adb pull sdcard/Android/data/com.oplus.logkit/files/Log ./%myDIR%/
::adb pull sdcard/DCIM/Camera ./%myDIR%/Camera
::adb pull sdcard/Movies ./%myDIR%/Movies/
::adb pull sdcard/camera_sfr ./%myDIR%/camera_sfr/
::adb pull sdcard/whiteboard ./%myDIR%/whiteboard/
adb pull sdcard/engineer_camera_config ./%myDIR%/engineer_camera_config/
adb shell "getprop ro.build.version.ota" > ./%myDIR%/Version_PCBA.txt
adb shell dumpsys engineer --query_pcb_number >> ./%myDIR%/Version_PCBA.txt

::Dump_log
adb pull data/minidump ./%myDIR%/minidump


@echo off =========================LOG导出完毕=============================

pause

