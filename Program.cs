const double COST_OF_SANDWICH = 4.75;
const double COST_OF_TOPPING = 0.55;
const double DISCOUNT_AMOUNT = 0.10;

System.Console.WriteLine("How many sandwiches did you buy?");
int numberOfSandwiches = int.Parse(Console.ReadLine());
double totalSandwichCost = COST_OF_SANDWICH * numberOfSandwiches;

System.Console.WriteLine("How many toppings were needed?");
int numberOfToppings = int.Parse(Console.ReadLine());
double totalToppingCost = COST_OF_TOPPING * numberOfToppings;

System.Console.WriteLine("How much would you like to tip?");
double tip = double.Parse(Console.ReadLine());

double baseCost = totalSandwichCost + totalToppingCost;

double orderCost = (baseCost * (1-DISCOUNT_AMOUNT)) + tip;

System.Console.WriteLine("The order cost is " + orderCost);