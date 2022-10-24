API Documentation
----

1. The API we used for this group work is PokeApiNet. The main purpose of the API we wanted to specifically get is getting the names of random pokemon by id between 1 and 400 into our application every time the user presses randomize. At first we wanted to use an API that randomizes Shakespeare Quotes, however our group ran into the problem where the API would only allow a limited amount of requests (5 per hour). As a result, we decided to switch to PokeAPiNet which allows us to request however much we wanted. 

2. The Actual Implementation of the API to the project itself was fairly simple. First, we create a new project using Visual Studios as well as download the PokeApiNet package from github(provided below). After the program loads up, we locate the Dependencies(or Reference file) of our program and select Manage NuGet Packages. If user does not see or have NuGet packages, documentation on how to install it will be provided below. User will then select "browse section" and search for the PokeApiNet and install it when prompted. After the package is installed, in order to use the API, the statement "using PokiApiNet;" is required at the head of the source code. 

3. Links and resources:
 these first 2 links are the API themselves as well as instructions on how to use them and what else they could be used for:
 
https://pokeapi.co/docs/v2#pokemon
https://github.com/mtrdp642/PokeApiNet

These resource is to teach and help us understand how packages and async work in visual studios:

https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/async/
https://learn.microsoft.com/en-us/nuget/quickstart/install-and-use-a-package-in-visual-studio

Note: some of our members encountered an error "Error 0x80010135 (path too long)" when downloading the solution and running it. We found to bypass this was simply pressing skip when that error appears and the program would continue to run fine.

https://stackoverflow.com/questions/17807281/visual-studio-pathtoolongexception-even-when-the-path-length-is-less-than-260


---
