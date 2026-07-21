# Data Structures and Algorithms – Hands-on Exercises

This repository contains solutions and analysis for common **Data Structures and Algorithms (DSA)** exercises implemented using Java. Each exercise demonstrates the practical application of data structures and algorithms in real-world scenarios.

---

# Table of Contents

1. Inventory Management System
2. E-commerce Platform Search Function
3. Sorting Customer Orders
4. Employee Management System
5. Task Management System
6. Library Management System
7. Financial Forecasting

---

# Exercise 1: Inventory Management System

## Scenario
Develop an inventory management system for a warehouse where efficient storage and retrieval of products are essential.

## Objectives

### Understanding the Problem
- Importance of Data Structures and Algorithms in inventory management.
- Suitable data structures:
  - ArrayList
  - HashMap
  - LinkedList

### Implementation
- Create a `Product` class with:
  - productId
  - productName
  - quantity
  - price
- Store products using **HashMap** (recommended).
- Implement:
  - Add Product
  - Update Product
  - Delete Product

### Time Complexity

| Operation | HashMap |
|-----------|----------|
| Add | O(1) |
| Update | O(1) |
| Delete | O(1) |
| Search | O(1) |

### Optimization
- Use HashMap for constant-time access.
- Avoid duplicate product IDs.
- Validate inputs before updating inventory.

---

# Exercise 2: E-commerce Platform Search Function

## Scenario
Implement fast product searching for an e-commerce platform.

## Objectives

### Asymptotic Notation
- Big O Notation measures algorithm efficiency.
- Search Cases:
  - Best Case
  - Average Case
  - Worst Case

### Implementation

Create a `Product` class containing:

- productId
- productName
- category

Implement:

- Linear Search
- Binary Search

Store products in:

- Normal Array (Linear Search)
- Sorted Array (Binary Search)

### Time Complexity

| Algorithm | Best | Average | Worst |
|------------|------|----------|-------|
| Linear Search | O(1) | O(n) | O(n) |
| Binary Search | O(1) | O(log n) | O(log n) |

### Conclusion
Binary Search is preferred for sorted datasets because it reduces search time significantly.

---

# Exercise 3: Sorting Customer Orders

## Scenario
Sort customer orders according to total price.

## Objectives

### Sorting Algorithms

- Bubble Sort
- Insertion Sort
- Quick Sort
- Merge Sort

### Implementation

Create an `Order` class with:

- orderId
- customerName
- totalPrice

Implement:

- Bubble Sort
- Quick Sort

### Time Complexity

| Algorithm | Best | Average | Worst |
|------------|------|----------|-------|
| Bubble Sort | O(n) | O(n²) | O(n²) |
| Quick Sort | O(n log n) | O(n log n) | O(n²) |

### Conclusion

Quick Sort is generally preferred because:

- Faster for large datasets
- Efficient divide-and-conquer approach
- Lower average execution time

---

# Exercise 4: Employee Management System

## Scenario
Store and manage employee records efficiently.

## Objectives

### Array Representation

Arrays:

- Store elements in contiguous memory.
- Provide constant-time indexing.

Advantages:

- Fast access
- Simple implementation

### Implementation

Create an `Employee` class:

- employeeId
- name
- position
- salary

Operations:

- Add Employee
- Search Employee
- Traverse Employees
- Delete Employee

### Time Complexity

| Operation | Complexity |
|------------|------------|
| Add | O(1) |
| Search | O(n) |
| Traverse | O(n) |
| Delete | O(n) |

### Limitations

- Fixed size
- Costly insertions/deletions
- Memory wastage if oversized

---

# Exercise 5: Task Management System

## Scenario
Manage tasks dynamically using linked lists.

## Objectives

### Linked Lists

Types:

- Singly Linked List
- Doubly Linked List

### Implementation

Create a `Task` class:

- taskId
- taskName
- status

Implement:

- Add Task
- Search Task
- Traverse Tasks
- Delete Task

### Time Complexity

| Operation | Complexity |
|------------|------------|
| Add (Beginning) | O(1) |
| Search | O(n) |
| Traverse | O(n) |
| Delete | O(n) |

### Advantages

Compared to arrays:

- Dynamic size
- Efficient insertions/deletions
- No contiguous memory requirement

---

# Exercise 6: Library Management System

## Scenario
Search books by title or author efficiently.

## Objectives

### Search Algorithms

Implement:

- Linear Search
- Binary Search

### Implementation

Create a `Book` class:

- bookId
- title
- author

Store books in:

- Array
- Sorted Array

### Time Complexity

| Algorithm | Complexity |
|------------|------------|
| Linear Search | O(n) |
| Binary Search | O(log n) |

### Conclusion

Use:

- Linear Search for small or unsorted datasets.
- Binary Search for large sorted datasets.

---

# Exercise 7: Financial Forecasting

## Scenario
Predict future financial values using recursion.

## Objectives

### Recursion

Recursion solves problems by calling the same function repeatedly until reaching a base condition.

### Implementation

Implement a recursive method to calculate future financial growth based on previous values.

Example:

Future Value = Current Value × (1 + Growth Rate)

### Time Complexity

| Method | Complexity |
|---------|------------|
| Recursive | O(n) |

### Optimization

Improve recursion using:

- Memoization
- Dynamic Programming

These techniques eliminate repeated calculations and improve performance.

---

# Technologies Used

- Java
- Object-Oriented Programming
- Data Structures
- Algorithms

---

# Data Structures Covered

- Arrays
- ArrayList
- HashMap
- Linked List

---

# Algorithms Covered

- Linear Search
- Binary Search
- Bubble Sort
- Quick Sort
- Recursion

---

# Learning Outcomes

After completing these exercises, you will understand:

- Choosing the right data structure
- Time complexity analysis using Big O notation
- Searching techniques
- Sorting algorithms
- Recursive problem solving
- Performance optimization
- Real-world applications of DSA

---

# Author

**Thushika Reddy**

B.Tech Computer Science Engineering

---
