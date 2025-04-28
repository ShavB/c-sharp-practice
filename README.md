# C# 

## OOPS
- [Encapsulation](#Encapsulation)
- [Abstraction](#Abstraction)
- [Inheritance](#Inheritance)

## Encapsualtion
Encapsulation is a fundamental part of oop it promotes code modularity and integrity of the data.
It involves binding or bundling of data(fields,properties) along with their Behaviours(Methods) into single unit called Class. Encapsulation restricts direct access to some of the components of objects and exposes only the required functionalities to outside world.

We can achieve (#Encapsulation) by using access modifiers like private and protected and we provide control access of the data using getters and setter methods.

## Abstraction
Abstraction involves hiding the implementation of the functionalities and show only the required functionalities to the outside world which the user can use.
It promotes data security, simplicity and reduces complexity of the code.

Eg. When you drive we just have to know how use pedals and streering of the car and rest is taken care of. We don't have to know anything about how the engines works.

We can achieve abstraction using interface and abstract class.

## Inheritance 
- Reusability
- Extensibility
- Abstraction

Inheritance where a child class inherits all the properties from the parent class and not vice versa.
It promotes code reusability, extensibility, and reduces redundancy.

Eg. Let's say we have parent class as Box which has properties like 'Length', 'width', and 'Height'. Let's say we have child class as 'Cube' here child class inherits all the properties of parent class(Box) and the child class have it's own properties.

We have different types of Inheritance:
1. Single inheritance 
2. Hierarchical inheritance
3. Multi level inheritance
4. Hybrid inheritance
5. Multuple inheritance (C# does not support multiple inheitance directly)

# Single Inheritance:
 When properties of a parents is inherited into a single child.

# Multilevel Inheritance:
 When child class is inheriting from a parent class which is inheriting it's properties of parents class(Grandparents for the child class).

# Hierarchical Inheritance:
 When multiple children class inherits properties from single parent.

# Multiple Inheritance:
 Multiple inheritance is not supported directly in C#, we can acheive multipl Inheritance by using sealed class and static class.
 Only difference of sealed and static class is that we can create objects of the sealed class and not with the static class.
