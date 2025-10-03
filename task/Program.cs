
int num_small = Convert.ToInt32(Console.ReadLine());
int num_large = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Price per small carpets: $25");
Console.WriteLine("Price per large carpets: $35");
long cost = (25 * num_small) + (35 * num_large);
double tax = (.06) * cost;
Console.WriteLine($"Cost : {cost}");
Console.WriteLine($"Tax : {tax}");
Console.WriteLine($"Total estimate : {cost + tax}");
Console.WriteLine("This estimate is valid for 30 days");