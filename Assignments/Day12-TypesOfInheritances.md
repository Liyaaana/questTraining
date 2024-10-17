### **Single Inheritance**

* **Definition:** A class can inherit from only one base class.  
* **Example:**  
  C\#  
  `class Animal { }`  
  `class Dog : Animal { }`

* **Key Points:**  
  * Provides a clear hierarchical structure.  
  * Ensures code reusability.  
  * Can be used for creating specialized classes from a more general base class.

### **Multiple Inheritance (via Interfaces)**

* **Definition:** A class can implement multiple interfaces.  
* **Example:**  
  C\#  
  `interface IFlyable { void Fly(); }`  
  `interface ISwimable { void Swim(); }`  
  `class Duck : IFlyable, ISwimable { }`

* **Key Points:**  
  * Allows a class to have multiple behaviors without violating the single inheritance principle.  
  * Provides a way to define contracts that classes must adhere to.  
  * Can be used to create flexible and reusable code.

### **Hierarchical Inheritance**

* **Definition:** Multiple classes can inherit from a single base class.  
* **Example:**  
  C\#  
  `class Vehicle { }`  
  `class Car : Vehicle { }`  
  `class Truck : Vehicle { }`

* **Key Points:**  
  * Creates a clear hierarchy of related classes.  
  * Promotes code reuse by sharing common properties and methods.  
  * Can be used to model real-world relationships between objects.

### 

### **Hybrid Inheritance**

* **Definition:** A combination of single and multiple inheritance.  
* **Example:**  
  C\#  
  `interface IFlyable { void Fly(); }`  
  `class Bird : IFlyable { }`  
  `class Eagle : Bird { }`  
  `class Penguin : Bird { }`

* **Key Points:**  
  * Provides a flexible way to combine different types of inheritance.  
  * Can be used to model complex relationships between objects.

### **Multilevel Inheritance**

* **Definition:** A class can inherit from a class that itself inherits from another class.  
* **Example:**  
  C\#  
  `class Animal { }`  
  `class Mammal : Animal { }`  
  `class Dog : Mammal { }`

* **Key Points:**  
  * Creates a deep hierarchy of related classes.  
  * Can be used to model complex relationships between objects.

### **Polymorphic Inheritance**

* **Definition:** The ability of objects of different types to be treated as if they were of the same type.  
* **Example:**  
  C\#  
  `class Animal { public virtual void MakeSound() { } }`  
  `class Dog : Animal { public override void MakeSound() { Console.WriteLine("Woof!"); } }`  
  `class Cat : Animal { public override void MakeSound() { Console.WriteLine("Meow!"); } }`

* **Key Points:**  
  * Enables code to be more flexible and maintainable.  
  * Allows for dynamic method dispatch based on the runtime type of the object.  
  * Can be used to implement design patterns like polymorphism.

### **Abstract Inheritance**

* **Definition:** A class that cannot be instantiated directly.  
* **Example:**  
  C\#  
  `abstract class Shape { public abstract double Area(); }`  
  `class Circle : Shape { public override double Area() { ... } }`

* **Key Points:**  
  * Defines a common interface for related classes.  
  * Forces subclasses to implement specific methods.  
  * Can be used to create abstract base classes that provide common functionality.

### **Sealed Inheritance**

* **Definition:** A class or method that cannot be inherited from.  
* **Example:**  
  C\#  
  `sealed class FinalClass { }`

* **Key Points:**  
  * Prevents subclasses from extending the class.  
  * Can be used to improve performance and prevent unintended modifications.

### **Generic Inheritance**

* **Definition:** A class or method that can work with different data types.  
* **Example:**  
  C\#  
  `class GenericList<T> { }`

* **Key Points:**  
  * Provides flexibility and reusability.  
  * Can be used to create generic data structures and algorithms.

