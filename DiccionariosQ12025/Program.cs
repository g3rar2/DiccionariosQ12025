Dictionary<int, string> dic = new Dictionary<int, string>()
{
    { 1, "Juan Perez"},
    {2,"Carlos Perez" },
    {3,"Maria Perez" },
};

dic.Add(4, "Jesus Ortega");
dic.Add(5, "Presentacion Lopez");

foreach (var item in dic) { 
Console.WriteLine(item);

} ;

