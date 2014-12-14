@echo off
echo EXECUTING BATCH PROCESS AUTOMATION
echo - Checking Maintaining Balances
sqlcmd.exe -S AGAPHETOS -Q "USE [cms] EXEC automateMaintainingBalances"