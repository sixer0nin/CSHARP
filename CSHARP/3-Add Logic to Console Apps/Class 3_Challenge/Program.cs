// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
using System.Reflection;

Console.WriteLine("Enter Product Code including '-':\n");

string? inpuSku = Console.ReadLine(); //"01-MN-L";

if (!string.IsNullOrEmpty(inpuSku))
{
    string sku = inpuSku.ToUpper();
    string[] product = sku.Split('-');


    string type = "";//string[] type = new string[4];
    string color = "";//string[] color = new string[4];
    string size = "";//string[] size = new string[4];

    switch (product[0])
    {
        case "01":
            type = "Sweat shirt";
            break;
        case "02":
            type = "T-Shirt";
            break;
        case "03":
            type = "Sweat pants";
            break;
        default:
            type = "Other";
            break;
    }

    switch (product[1])
    {
        case "BL":
            color = "Black";
            break;
        case "MN":
            color = "Maroon";
            break;
        case "WH":
            color = "White";
            break;
        default:
            color = "Burgundy";
            break;
    }

    switch (product[2])
    {
        case "S":
            size = "Small";
            break;
        case "M":
            size = "Medium";
            break;
        case "L":
            size = "Large";
            break;
        default:
            size = "One Size Fits All";
            break;
    }

    Console.WriteLine($"Product: {size} {color} {type}");
}