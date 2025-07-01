# GitHub Copilot Custom Instructions

## General Principles
- Always write clean, readable, and efficient code.
- Prefer clarity and maintainability over unnecessary complexity.
- Add XML or Markdown documentation for every new function and method.
- Write appropriate unit tests for every new or changed logic.
- Follow existing naming conventions and project structures.
- Use modern language features when they improve readability and efficiency.

## .NET/C#
- Use properties with `{ get; set; }` for data models.
- Use `IEnumerable<T>` for enumerable returns when no modification is needed.
- Write methods and classes to be as testable as possible.
- Always add unit tests for validation logic.
- Document public APIs with XML comments.

## JavaScript/Node.js
- Use `const` and `let` instead of `var`.
- Follow ESLint recommendations.
- Write asynchronous logic using `async/await`.
- Add JSDoc comments for functions.

## Azure-specific
- Use Azure CLI and recommended tools for Azure-related tasks.
- Follow Azure code and deployment best practices.
- For Azure Functions and Static Web Apps: follow their respective best practices.

## Tests
- Write a unit test for every new or changed functionality.
- Use [Theory] and [InlineData] for parameterized testing in xUnit.
- Test both success and failure cases.

## Miscellaneous
- Write clear and concise commit messages, e.g., “Feature: Added new validation for BasketItem”.
- Adhere to the structure and conventions of the respective project.

---
This file serves as a guideline for Copilot and developers to ensure consistent and high-quality code in the project.