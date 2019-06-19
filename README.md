# Specification Patterns

Specification pattern is a pattern that helps achieve two goals:
- First, it helps avoid domain knowledge duplication in certain scenarios : DRY principle.
- Secondly, it enables a declarative approach, which in turn increases maintainability of your code base.

The basic idea behind this pattern is that when you have some piece of domain knowledge you can encapsulate this knowledge into a single unit, **Specification**, and then reuse in different parts of your code base. 

### Specifications : General Guidelines
- Avoid ISpecification Interface
- Make Specification as specific as possible.
- Make Specification immutable
