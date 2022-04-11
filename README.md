# HomeworkExample
Shows how test-based homework works

Some homework uses a testing framework. Instead of having a Program class with a Main method, the Main method is hidden inside the testing framework libraries, and the code that you see lives inside test methods.

In this type of a homework assignment, the code you're provided with may contain two types of errors:
1. Syntax errors (compile-time errors) that prevent the solution from building, and
2. Logic errors (run-time errors) that assert something that is not true.

Your goal is to correct the errors so that the project builds and the tests run successfully. Once your tests are passing, push to a branch with your name, and create a pull request.

**Note:** Don't just remove the lines that are causing errors, and don't remove any of the "Assert" statements. While that will technically cause tests to pass, the goal is to *fix* the problems, not to *remove* them. Your code will be reviewed.
