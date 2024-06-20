using DiscountCalculator;

var customer1 = new Customer {
    Id = "001",
    DateOfBirth = DateTime.Now.AddYears(-70),
    DateOfFirstPurchase = null,
    IsVeteran = true,
};

var customer2 = new Customer { 
    Id = "002",
    DateOfBirth = DateTime.Now.AddYears(-25),
    DateOfFirstPurchase = DateTime.Now.AddYears(-2),
    IsVeteran = false,
};

var customer3 = new Customer {
    Id = "003",
    DateOfBirth = DateTime.Now.AddYears(-25),
    DateOfFirstPurchase = DateTime.Now.AddYears(-6),
    IsVeteran = true,
};

var calculator = new DiscountCalculator.DiscountCalculator();

var discount11 = calculator.CalculateDiscountPercentage(customer1);
var discount12 = calculator.GetDiscount(customer1);
if (discount11 == discount12)
    Console.WriteLine("discount11 == discount12");
else 
    Console.WriteLine("discount11 != discount12");

var discount21 = calculator.CalculateDiscountPercentage(customer2);
var discount22 = calculator.GetDiscount(customer2);
if (discount21 == discount22)
    Console.WriteLine("discount21 == discount22");
else 
    Console.WriteLine("discount21 != discount22");
 
var discount31 = calculator.CalculateDiscountPercentage(customer3);
var discount32 = calculator.GetDiscount(customer3);
if (discount31 == discount32)
    Console.WriteLine("discount31 == discount32");
else 
    Console.WriteLine("discount31 != discount32");

Console.WriteLine("Done");