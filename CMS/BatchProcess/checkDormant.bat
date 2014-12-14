@echo off
echo EXECUTING BATCH PROCESS AUTOMATION
echo - Checking Dormant Accounts
sqlcmd.exe -S AGAPHETOS -Q "USE [cms] EXEC automateCheckDormantAccounts"