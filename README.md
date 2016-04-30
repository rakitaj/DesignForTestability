# DesignForTestability

This is an example project with code that exhibits common issues that make it hard to write tests. 


The exercise is to take the current implementation of the Yucky class, refactor it into testable code, and add those tests.

My recommended approach is to look at the code, write down the issues that you have found, and take a try at refactoring. Then, go
and read the "You suck at TDD series", come back, and see if you have any new thoughts. 



<a href="https://social.msdn.microsoft.com/Search/en-US?query=You%20Suck%20At%20TDD&beta=0&rn=Eric+Gunnerson%26%2339%3bs+Compendium&rq=site:blogs.msdn.com/b/ericgu/&ac=5">You Suck at TDD</a>

After the fork from Eric Gunnersion's repository I did some refactoring and added tests. In summary my changes are:
1) Created pinning tests for both types of EmployeeFilter to keep things safe  while I refactored.
2) Extracted methods and classes from Yucky.cs to separate the database call logic from the employee object creation logic.
3) Created a constructor for the employee class. No more need to directly set properties.
4) Added tests for the new employee class.
5) Formatted the existing filtering logic so it is easier to read. No logic changes here.
6) Changed the filtering from an enum and logic based on conditionals to multiple classes. This is the replace type switch with inheritance refactoring.
7) That's all I have for now :) Any and all feedback is welcome.