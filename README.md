# Snakes and Ladders


## 1. Approach
The completion of the exercise follows the principles of Test Driven Development where unit tests are written before implementation of user stories. It also follows SOLID principles. Unit test cases are specified by the user stories written in `Feature 1 - Moving Your Token`

1. Read `Feature 1` to identify the business domain glossary: the potential objects (state only), services, statuses, actions and user stories outlined in `Feature 1`
	1. Objects and services
		1. game (squares from 1 to 100)
		1. token (with 1-to-1 relationship to player)
        1. die (yields integer numbers from 1 to 6 inclusive)
	1. The states of these objects
	   1. game started or not started
	   1. position of token
       1. player has won the game
	1. Actions
	   1. place token on the board
	   1. move token
       1. roll die  
    1. User stories: each of the bullet points in the 3 boxes: `Token Can Move Across the Board`, `Moves Are Determined By Dice Rolls`, `Player Can Win the Game`
1. Read Features 2, 3 and 4 to make sure that user stories intoduced in these features are not included in `Feature 1` and that `Feature 1` is ready for extension to have these next features added with minimised modification of existing code: 
     1. snakes and ladders
     1. multiple players
     1. play order 
     1. computer controller character
1. Identify the highest level functionality accessible by users. The following items will be the first unit tests written: 
   1. placing the token on the board
   2. moving the token using dice rolls
   3. knowing where the token is on the game board
   4. determine if a player has won by having landed on the last square


## 2. Writing code

1. Open Visual Studio
1. Create an empty solution
1. Create .NET Framework C# Library and corresponding .NET Framework C# Unit Test Project in the solution
1. Add the Library as a project reference to the Unit Test Project
   1. Write unit tests for each of the 3 sections asserting each of their points with their test methods
      1. Token Can Move Across the Board
      1. Moves Are Determined By Dice Rolls
      1. Player Can Win the Game
   1. In order for the test to compile, write the interface of services and empty domain objects: IGame and Token
   1. Add empty methods to the services and properties to the domain objects for the Unit Test methods to compile      
1. Write the implementation code in .NET library to make the tests pass


## 3. Key decisions and alternatives considered
   1. The Die class is not unit tested as it only returns the result of Random.Next(int minValue, int maxValue). There is no need to test Ramdom.Next as we can trust Microsoft to have done their work.
   1. Game started or not started determined by a boolean property of the Game object or just by the existence of the Game object. The existence of a Game object is chosen for reason of simplicity and no requirements to have.
   1. Use another Unit Test framework. The Microsoft Unit Test Framework may not be the most feature full or the one executing the test the fastest but it does not require additional tooling to run the tests. It is integrated in Visual Studio Community.
   1. Use a mocking framework or just manually mock with C# code: the FakeItEasy library is used because it is very expressive.

 
## 4. Running the code
Because this is only the feature 1 of the game and user interface or web services are not part of the scope, the best way to run the code is by running its corresponding unit tests. In Visual Studio select menu `Test` => menu item `Windows` then menu item `Test Explorer`. In the Test explorer pane click on `Run All`. This will run all the tests and indicate which ones pass or fail.


## 5. Evolving the solution
A token landing on snakes or ladders as described in `Feature 2` is transfered to the other side of the snake or ladder regardless of the number yielded by the die. Unit tests already written for `Feature 1` should still pass as `Feature 1` is still part of the rules of the game. Implementing `Feature 2` will require decoupling `TokenMover` from the new code that implements `Feature 2`. This change will respect the Single Responsibility and Open-Closed principles where `TokenMover` will not contain code that implements `Feature 2` will not know about it. Instead another class will call the unmodified `TokenMover` then the class responsible for the snakes and the ladders.