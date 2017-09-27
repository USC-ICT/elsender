
@setlocal

@rem Windows VS2015 build
@rem set up visual studio path
call "%VS140COMNTOOLS%\..\..\VC\vcvarsall.bat" x86
@rem vcvarsall turns echo off and doesn't turn it back on
@echo on

pushd elsender
devenv elsender.sln /build "Debug"
devenv elsender.sln /build "Release"
popd

@endlocal
