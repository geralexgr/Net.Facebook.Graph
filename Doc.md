# Documentation

Basic examples of package functionality.

## Functions 


* CreateTokenUrl
* GetToken



## Code

#### Get A token 


``` 
using Net.Facebook.Graph;
using Net.Facebook.Graph.Models;

Token token = await NetGraphRequest.GetToken("APPID", "APPSECRET");
```
