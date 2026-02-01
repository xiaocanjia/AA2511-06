adb wait-for-device
adb root
echo on
:start
for /f  %%i IN ('adb devices')do (set aa=%%i)
if "%aa%"=="%bb%" (
	echo 与上台机器一致，请更换机器
	TIMEOUT /T 2
	set bb=%aa%
	goto start
) else (
    set bb=%aa%
    goto abc
)
:abc
echo on
mkdir %bb%
adb shell dumpsys engineer --execute_switch_log --ei enable 0 
TIMEOUT /T 23
adb pull /mnt/oplus/op2/media/log/boot_log ./%bb%/boot_log
adb pull /sdcard/Android/data/com.oplus.logkit/files/Log ./%bb%/
adb pull /sdcard/TpTestReport ./%bb%/
adb pull /sdcard/DCIM ./%bb%/
adb pull sdcard/Pictures/Screenshots ./%bb%/Screenshots
adb shell dumpsys engineer --query_factory_version > ./%bb%/Version_PCBA.txt
adb shell dumpsys engineer --query_pcb_number >> ./%bb%/Version_PCBA.txt
:: 截图
adb shell screencap /sdcard/Pictures/jietu.png && adb pull /sdcard/Pictures/jietu.png ./%bb%/Screenshots
pause

