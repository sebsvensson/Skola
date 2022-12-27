Om alla filer är blockerade av Windows blir det problematiskt att köra koden i Visual Studio, innuti powershell kör kodraden nedan i det directory som denna fil befinner sig i. Alla filer låser automatiskt upp sig för användning av systemet (istället för att gå in i egenskaper och därefter avblockera för varje fil).

dir -Recurse | Unblock-File