//[access modifier] - [class] - [identifier]
public class Customer
{
  // Fields, properties, methods and events go here...
}

Customer object1 = new Customer();

// inicializador de campo
public class Container
{
  // Initialize capacity field to a default value of 10:
  private int _capacity = 10;
}

// construtor 
public class Container
{
  private int _capacity;

  public Container(int capacity) => _capacity = capacity;
}

// construtor primário
public class Container(int capacity)
{
  private int _capacity = capacity;
}

// inicializador de objeto 

public class Person
{
  public required string LastName { get; set; }
  public required string FirstName { get; set; }
}

var p1 = new Person(); // Error! Required properties not set
var p2 = new Person() { FirstName = "Grace", LastName = "Hopper" };

// Herança de classes
public class Manager : Employee
{
  // Employee fields, properties, methods and events are inherited
  // New Manager fields, properties, methods and events go here...
}