@echo off
:inizio
title Convertitori - Creato da Vichingo455
cd /d "%~dp0" > nul
cls
set var=66
echo Convertitori - Seleziona l'operazione da eseguire:
echo.
echo [1] Converti da Binario a Decimale
echo.
echo [2] Converti da Decimale a Binario
echo.
echo [3] Converti da Decimale a Esadecimale
echo.
echo [4] Converti da Decimale a Ottale
echo.
echo [5] Converti da Esadecimale a Decimale
echo.
echo [6] Converti da Ottale a Decimale
echo.
echo [0] Esci
echo.
set /p var=La tua scelta: 
if %var% == 1 goto bin2dec
if %var% == 2 goto dec2bin
if %var% == 3 goto dec2hex
if %var% == 4 goto dec2oct
if %var% == 5 goto hex2dec
if %var% == 6 goto oct2dec
if %var% == 0 exit
goto inizio

:bin2dec
cls
title Convertitore da Binario a Decimale - Creato da Vichingo455
echo Convertitore da Binario a Decimale
echo.
"%~dp0bin\bin2dec.exe"
goto inizio

:dec2bin
cls
title Convertitore da Decimale a Binario - Creato da Vichingo455
echo Convertitore da Decimale a Binario
echo.
"%~dp0bin\dec2bin.exe"
goto inizio

:dec2hex
cls
title Convertitore da Decimale a Esadecimale - Creato da Vichingo455
echo Convertitore da Decimale a Esadecimale
echo.
"%~dp0bin\dec2hex.exe"
goto inizio

:dec2oct
cls
title Convertitore da Decimale a Ottale - Creato da Vichingo455
echo Convertitore da Decimale a Ottale
echo.
"%~dp0bin\dec2oct.exe"
goto inizio

:hex2dec
cls
title Convertitore da Esadecimale a Decimale - Creato da Vichingo455
echo Convertitore da Esadecimale a Decimale
echo.
"%~dp0bin\hex2dec.exe"
goto inizio

:oct2dec
cls
title Convertitore da Ottale a Decimale - Creato da Vichingo455
echo Convertitore da Ottale a Decimale
echo.
"%~dp0bin\oct2dec.exe"
goto inizio