# Examples of Design Patterns in C&#35;

## Purpose
This repository is to provide examples of the commonly-understood Gang of Four (GoF) design patterns.
We will be adding to this repository as we work through different design patterns.

## Patterns Overview

### Creational Patterns
| Name | Description | Status |
| --- | --- | --- |
| Builder | Separates object construction from its representation | Completed |
| Factory Method | Creates an instance of several derived classes | Completed |
  
### Structural Patterns
| Name | Description | Status |
| --- | --- | --- |
| Adapter | Match interfaces of different classes | [Planned](https://github.com/ssiko/design-pattern-examples/issues/6) |
| Bridge | Separates an object’s interface from its implementation | Completed |
| Flyweight | A fine-grained instance used for efficient sharing | [Planned](https://github.com/ssiko/design-pattern-examples/issues/7) |
  
### Behavioral Patterns
| Name | Description | Status |
| --- | --- | --- |
| Chain of Responsibility | A way of passing a request between a chain of objects | [Planned](https://github.com/ssiko/design-pattern-examples/issues/8) |
| State| Alter an object's behavior when its state changes | [Planned](https://github.com/ssiko/design-pattern-examples/issues/9) |
| Strategy | Encapsulates an algorithm inside a class | Completed |
| Template Method | Defer the exact steps of an algorithm to a subclass | Completed |
| Visitor | Defines a new operation to a class without change | Completed |

## Contributing
We want to keep it as easy as possible to contribute changes that
get things working in your environment. There are a few guidelines that we
need contributors to follow so that we can have a chance of keeping on
top of things.

### Getting Started

* Make sure you have a [GitHub account](https://github.com/signup/free)
* Submit a ticket for your issue, assuming one does not already exist.
  * Clearly describe the issue including steps to reproduce when it is a bug.
  * Make sure you fill in the earliest version that you know has the issue.
* Fork the repository on GitHub

### Making Changes

* Create a topic branch from where you want to base your work.
  * This is usually the master branch.
  * Only target release branches if you are certain your fix must be on that
    branch.
  * To quickly create a topic branch based on master; `git checkout -b
    fix/my_contribution master`. Please avoid working directly on the
    `master` branch.
* Make commits of logical units.
* Check for unnecessary whitespace with `git diff --check` before committing.

### Submitting Changes

* Push your changes to a topic branch in your fork of the repository.
* Submit a pull request to the repository.
