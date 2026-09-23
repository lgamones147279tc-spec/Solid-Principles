README - SOLID Refactoring 

OVERVIEW
Refactored a monolithic Windows Forms app into a clean, maintainable architecture using SOLID principles without changing user-facing features.

SOLID PRINCIPLES IMPLEMENTED

1. Single Responsibility Principle (SRP)
Problem: Form1 handled UI, calculations, database saves, emails, and printing.
Solution: Moved calculations to OrderCalculator, database logic to SqlOrderRepository, and printing/emailing to separate services.

2. Open/Closed Principle (OCP)
Problem: Adding a discount required changing if-else blocks in Form1.
Solution: Created IDiscountStrategy. New discounts are added by creating new classes without modifying existing code.

3. Liskov Substitution Principle (LSP)
Problem: FreeShippingDiscount throws NotSupportedException when used, breaking the application.
Solution: LSP states that implementations must be safely swappable without throwing unexpected errors or breaking contracts.

4. Interface Segregation Principle (ISP)
Problem: Single large interfaces force classes to implement unused methods.
Solution: Created smaller, targeted interfaces (IInvoiceEmailer and IInvoicePrinter).

5. Dependency Inversion Principle (DIP)
Problem: Form1 relied directly on concrete SQL and SMTP classes.
Solution: Form1 now relies on abstractions (interfaces), allowing easy swapping of database and email implementations.

TESTING WITH FAKE ORDER REPOSITORY
FakeOrderRepository lets you test order saving in memory without needing a real database connection. Makes the unit testing faster and safer.
