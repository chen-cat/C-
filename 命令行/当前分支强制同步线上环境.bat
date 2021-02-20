cd /d %~dp0
cd ../../
git reset --hard
git clean -df
git checkout .
git submodule update --init -f
git pull --recurse-submodules
git reset --hard
pause