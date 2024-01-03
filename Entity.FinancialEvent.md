# Domain Models

## FinancialEvent

```csharp
class FinancialEvent: Entity
{
	Result<FinancialEvent> Create();	
}
```

```json
{
	"id": "00000000-0000-0000-0000-00000000",
	"date": "12/12/2012"
	"amount": 200,
	"currencyId": "00000000-0000-0000-0000-00000000",
	"note": "paid weed dept..."	
}
```
