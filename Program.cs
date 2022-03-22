
using RomanNumerals;

string passedValue = args.Length > 0 ? args[0].ToString() : "";

if (passedValue == "")
{
    Console.WriteLine("Please enter an integer or Roman Numeral to convert:");

    var response = Console.ReadLine();
    if (response != null) passedValue = response;
}

if (passedValue == "")
{
    Console.WriteLine("Nothing to convert!");
    return;
}

try
{
    int value = int.Parse(passedValue);

    var rnc = new RomanNumeralConverter();
    Console.WriteLine(rnc.ConvertToRomanNumerals(value));

} catch
{
    var rnc = new RomanNumeralConverter();
    Console.WriteLine(rnc.ConvertToInteger(passedValue));
}
