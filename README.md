# C# 🚀

## OOPS
- [Encapsulation](#Encapsulation)
- [Abstraction](#Abstraction)
- [Inheritance](#Inheritance)
- [Polymorphism](#Polymorphism)

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

### Single Inheritance:
 When properties of a parents is inherited into a single child.

### Multilevel Inheritance:
 When child class is inheriting from a parent class which is inheriting it's properties of parents class(Grandparents for the child class).

### Hierarchical Inheritance:
 When multiple children class inherits properties from single parent.

### Multiple Inheritance:
 Multiple inheritance is not supported directly in C#, we can acheive multipl Inheritance by using sealed class and static class.
 Only difference of sealed and static class is that we can create objects of the sealed class and not with the static class.

### Hybrid Inheritance:
 A combinition of two or more types of [Inheritance](#inheritance). 


## Polymorphism
Ploymorphism is a greek word where poly means 'Many' and morphism means 'ways to represent'.
In OOP polymorphism refers to where methods of the same name can have different output based on the object referenced to it.

Two types polymorphism:
1. [Compile Time](#Compile Time) (==Method overloading==)
2. [Run Time](#Run Time) (==Method Overriding==)

### Compile Time
- Compile time polymorphism is also called as method overloading where we overload the parameters of the methods and based on that we get the output.

- It occures when we have same methods but with different parameters, different numbers of parameters and different return type in a sigle class.

### Run Time
- Run time polymorphism occurs when we have methods of the same name in different class and one of the class derived from the same class.

- It can be acheived using ==virtual keyword== used along with the methods in the parent class and ==override keyword== used along with the method is the child class.
