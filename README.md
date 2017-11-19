# dynamic-facade
This is a dynamic implementation of Facade pattern for calling business objects .

## Benefits and usages
You can call your business objects (BOs) or everything else with less codes in this way. Also Facade object keeps every class in a dictionary so all BOs will be created only one time. All the BOs have the reference of the Facade so they can call other inside without overhead. The only thing you need is to create one instance of Facade object and keep it. 
For example for asp.net webapi apps you can create a Facade instance in a class which all of the controllers inherit it and it can be used in controllers like the used in this project.

## How it works
Every class which wants to be called by Facade must inherit BaseBol and IBaseBol and has a constructor like this :
```
public class SearchBol : BaseBol.BaseBol, BaseBol.IBaseBol
    {
        public SearchBol(Facade facade) : base(facade)
        {
        }
    }
```
For calling a Bol it is need a Facade instance to call GetBol method. GetBol method is generic and the class type you pass to it, must has IBaseBol interface, so Facade will search in a dictionary to find the instance of the class, of nothing found , it will create an instance and add it in this dictionary. This is  an example of using GetBol :
```
facade.GetBol<UserBol>().GetUserNameById(123456)
```

