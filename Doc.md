# Documentation

Basic examples of package functionality.

## Functions 


* CreateTokenUrl
* GetToken
* GetPageInfo
* CreatePageRequestUrl





## Code

#### GetToken() - Get a Token 


``` 
using Net.Facebook.Graph;
using Net.Facebook.Graph.Models;

Token token = await NetGraphRequest.GetToken("APPID", "APPSECRET");
```

#### GetPageInfo() - Get Page Information

> USERNAME should be either the nickname or the ID of the page.

``` 
using Net.Facebook.Graph;
using Net.Facebook.Graph.Models;

var url = await NetGraphRequest.CreatePageRequestUrl("APPID", "APPSECRET","USERNAME");
Page page = await NetGraphRequest.GetPageInfo(url);
```