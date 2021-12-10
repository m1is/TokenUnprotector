# TokenUnprotector
For decryption and deserialization of OWIN OAuth access tokens for use in .NET Core applications or whatever. 

Most of the code is from the Katana project: https://github.com/c4net/katanaproject

The MachineKey class is from here: https://github.com/dmarlow/BearerTokenBridge 

For more information see this post: https://stackoverflow.com/questions/46546254/using-machine-keys-for-idataprotector-asp-net-core

## Example
Find your machine key in your authorization server web app's web.config file to obtain your encryption key and validation keys.
```
<machineKey decryptionKey="{DECRYPTION_KEY}" validationKey="{VALIDATION_KEY}" validation="SHA1" />
```
Then use the keys to Unprotect your access tokens from the Unprotector class.
```
var ticket = Unprotector.Unprotect(token, decryptionKey, validationKey);
```
