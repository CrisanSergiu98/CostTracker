# Domain Models

## User

```csharp
class User: AggregateRoot
{
	User Create();	
	void ChangePassword( string newPasswordHash);
	void ChangeEmail( string newEmail);
	void DeleteAccount();
}
```

```json
{
	"id": "00000000-0000-0000-0000-00000000",
	"fistName": "Mike",
	"lastName": "Jackson";	
	"passwordHash": "wahteverapasswordhashlookslike"	
}
```