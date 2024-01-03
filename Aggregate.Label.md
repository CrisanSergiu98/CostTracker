# Domain Models

## Label

```csharp
class Label: AggregateRoot
{
	Label CreateLabel();
	void CreateFinancialEvent(FinancialEvent event);
}
```

```json
{
	"id": "00000000-0000-0000-0000-00000000",
	"userId": "00000000-0000-0000-0000-00000000",
	"name": "WhateverLabel",
	"targetAmmount": 300,
	"targetCurrencyId": "00000000-0000-0000-0000-00000000",
	"description": "description description description",
	"category": "Nameofthecategory"
	"financialEvents": [
		{
			"id": "00000000-0000-0000-0000-00000000",
			"date": "12/12/2012"
			"amount": 200,
			"currencyId": "00000000-0000-0000-0000-00000000",
			"note": "paid weed dept..."
		},
		...]	
}
```
