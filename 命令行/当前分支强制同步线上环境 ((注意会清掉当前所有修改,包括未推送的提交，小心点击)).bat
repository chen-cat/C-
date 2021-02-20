cd /d %~dp0
cd ../../

call git symbolic-ref --short -q HEAD >file.txt
for /f %%i in (file.txt) do (
    set file=%%i
    git reset --hard origin/%%i
)
git clean -df
git checkout .
git submodule update --init -f
git pull --recurse-submodules
git reset --hard
pause