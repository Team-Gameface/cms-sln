@echo off
echo EXECUTING BATCH PROCESS AUTOMATION
echo - Checking Savings Interest
sqlcmd.exe -S AGAPHETOS -Q "USE [cms] EXEC automateSavingsInterests"