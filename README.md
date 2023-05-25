Konzová aplikace pro správu pojištěnců
========================================
Konzolová aplikace, ve které je možné:
* zadávat pojištěnce do seznamu pojištěnců
* vypisovat všechny pojištěnce
* vyhledávat podle jména a příjmení.

Pojištěncům je možné zadat
* jméno
* příjmení
* věk
* telefoní číslo.

## Migrations

Create migration

```
dotnet ef migrations add "MigrationName" -c InsuranceDbContext -p ../Insurance.Persistence -o ../Insurance.Persistence/Migrations
```

Apply migration

```
dotnet ef database update -c InsuranceDbContext -p ../Insurance.Persistence
```