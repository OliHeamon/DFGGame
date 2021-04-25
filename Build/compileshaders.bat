@echo off

echo ----------------------------------------
echo Compiling Shaders...
echo ----------------------------------------

for %%f in (%1*.fx) do (
  echo Compiling %%f
  fxc /Od /Zi /T fx_2_0 /Fo %2%%~nf.fxc %%f
)

echo ----------------------------------------
echo Copying assets to output directory...
echo ----------------------------------------