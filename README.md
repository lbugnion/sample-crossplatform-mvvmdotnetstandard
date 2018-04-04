# .NET Core console application with MVVM Light (and running it on Linux...)

This sample shows a console application [built with .NET Core](http://gslb.ch/a146a) and [MVVM Light for .NET Standard](http://www.mvvmlight.net/std10).

This console application leverages [MVVM Light's SimpleIoc](http://gslb.ch/a147a) component. This is an IOC container that can be used to register services to a central cache and compose components (such as ViewModels or any other object) that wants to leverage the service without having to know about its implementation.

This sample shows:

- [How to build the .NET Core application, test it on Windows](./Doc/Creating.md)

- [How to Publish the app to a local folder](./Doc/Publish.md)

 - [How to run the app standalone on Windows](./Doc/RunningWindows.md)

 - [How to run the app on Ubuntu](./Doc/RunningUbuntu.md) on the [Windows Subsystem for Linux](http://gslb.ch/a148a).

![Running the app on Ubuntu](./Doc/Img/2018-04-04_10-52-27.png)