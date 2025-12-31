task : 1st Project:
Define Class Maths that has four methods: Add, Subtract, Multiply, and Divide, each of them takes two parameters. Call each method in Main ().
 Modify the program so that you do not have to create an instance of class to call the four methods.

2nd Project:
1.Define Class Duration To include Three Attributes Hours, Minutes and Seconds.

2.Override All System.Object Members (ToString, Equals,GetHasCode) .

3.Define All Required Constructors to Produce this output:
Duration D1 =new  Duration (1,10,15);
D1.ToString(); 
Output: Hours: 1, Minutes :10, Seconds :15
Duration D1 =new Duration (3600);
D1.ToString(); 
Output: Hours: 1, Minutes :0, Seconds :0
Duration D2 =new Duration (7800);
D2.ToString(); 
Output: Hours: 2, Minutes :10, Seconds :0
Duration D3 =new Duration (666);
D3.ToString(); 
Output: Minutes :11, Seconds :6
4.Implement All required Operators overloading to enable this Code:
●D3=D1+D2
●D3=D1 + 7800
●D3=666+D3
●D3= ++D1 (Increase One Minute)
●D3 = --D2 (Decrease One Minute)
●D1= D1 -D2
●If (D1>D2)


Third Project:
You are tasked with designing a system for an e-commerce platform that calculates discounts for different types of users and products.
This system should utilize abstraction and include the following parts:
Part 1: Abstract Discount Class
Create an abstract class Discount with:
oAn abstract method CalculateDiscount(decimal price, int quantity) that returns the discount amount based on the original price and quantity.
oA Name property to store the type of discount.

Part 2: Specific Discounts
Implement the following concrete discount classes:
oPercentageDiscount:
▪Accepts a percentage (e.g., 10%).
▪Formula: Discount Amount=Price×Quantity×(Percentage/100)
oFlatDiscount:
▪Accepts a fixed amount to be deducted (e.g., $50).
▪Formula: Discount Amount=Flat Amount×min(Quantity,1)
oBuyOneGetOneDiscount:
▪Applies a 50% discount if the quantity is greater than 1.
▪Formula: Discount Amount=(Price/2)×(Quantity÷2)

Part 3: Discount Applicability
Create an abstract class User with:
oA Name property to store the user name.
oAn abstract method GetDiscount() that returns a Discount object.
Implement the following specific user types:
oRegularUser: Applies a PercentageDiscount of 5%.
oPremiumUser: Applies a FlatDiscount of $100.
oGuestUser: No discount is applied

Part 4: Integration
Write a program that:
oAsk  the user to input their type (Regular, Premium, or Guest).
oAllows the user to input product details (price and quantity).
oCalculates and displays the total discount and final price after applying the appropriate discount.
●If (D1<=D2)
●If (D1)
●DateTime Obj = (DateTime) D1
