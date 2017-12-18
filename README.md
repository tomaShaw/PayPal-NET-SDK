# PayPal SDK 2.0.0-beta

This is a preview of how PayPal SDKs will look in the next major version. We've simplified the interface to only provide HTTPRequest that can easily be called via our HttpClient. This SDK is fully dotnet core 2.0 compatible. 

### Creating a Payment

```cs
using System.Linq;
using PayPal.Core;
using PayPal.PaymentExperience;

var environment = new SandboxEnvironment("AdV4d6nLHabWLyemrw4BKdO9LjcnioNIOgoz7vD611ObbDUL0kJQfzrdhXEBwnH8QmV-7XZjvjRWn0kg", "EPKoPC_haZMTq5uM9WXuzoxUVdgzVqHyD5avCyVC1NCIUJeVaNNUZMnzduYIqrdw-carG9LBAizFGMyK");
var client = new PayPalHttpClient(environment);

WebProfileCreateRequest request = new WebProfileCreateRequest();
var profile = new WebProfile()
            {
                Name = "some_name",
                Presentation = new Presentation()
                {
                    BrandName = "Sample brand",
                    LocaleCode = "US",
                    LogoImage = "https://www.paypal.com/",
                    NoteToSellerLabel = "Thx",
                    ReturnUrlLabel = "Retreat!"
                },
                InputFields = new InputFields()
                {
                    AddressOverride = 1,
                    AllowNote = true,
                    NoShipping = 0
                },
                FlowConfig = new FlowConfig()
                {
                    BankTxnPendingUrl = "https://www.paypal.com/",
                    LandingPageType = "billing",
                    UserAction = "commit",
                    ReturnUriHttpMethod = "GET"
                },
                Temporary = true
            };

request.RequestBody(profile);

try 
{
  HttpResponse response = await client().Execute(request);
  var statusCode = response.StatusCode;
  WebProfile result = response.Result<WebProfile>();
} 
catch(HttpException httpException) 
{
  var statusCode = httpException.StatusCode;
  var debugId = httpException.Headers.GetValues("PayPal-Debug-Id").FirstOrDefault();
}
```

If you're migrating from v1, check out our [Migration Guide](./docs/Migrating.md).
We have tried to answer few obvious questions at [FAQs](./docs/FAQ.md).

## Building

To try this out, update the version of `paypal-rest-sdk` by running:
```sh
$ dotnet add package PayPal -v 2.0.0.beta.0
```

Please feel free to create an issue in this repo with any feedback, questions, or concerns you have.

## Running tests

To run integration tests using your client id and secret, clone this repository and run the following command:
```sh
$ dotnet test -v normal
```

*NOTE*: This API is still in beta, is subject to change, and should not be used in production.

## Feedback

If you have any suggestions/remarks/feedback related to SDK 2.0.0, feel free to create an issue.

## License
PayPal-NET-SDK is open source. See the [LICENSE](./LICENSE) file for more info.

## Contributions
Pull requests and new issues are welcome. See [CONTRIBUTING.md](CONTRIBUTING.md) for details.
