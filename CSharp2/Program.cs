int meal_cost = Convert.ToInt32(Console.ReadLine());
int tip_percent = Convert.ToInt32(Console.ReadLine());
int tax_percent = Convert.ToInt32(Console.ReadLine());

double tip = (tip_percent * 0.01) * meal_cost;
double tax = (tax_percent * 0.01) * meal_cost;
int total = Convert.ToInt32(tax + tip + meal_cost);
Console.WriteLine(total);
Console.ReadLine();