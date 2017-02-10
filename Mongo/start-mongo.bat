@echo off
cd %~dp0
if not exist "data\db" mkdir "data\db"
if not exist "log" mkdir "log"

mongod --config "mongo.config"
PAUSE