public class Person
{
    public int age;                     // возраст
    public string name;                 // имя
    
    public string family;                 // фамилия

    public string company_name;          // название компании


// a) конструктор без аргументов, который задаёт значения по умолчанию для указанных полей;

    public Person()
    {
        age = 18;
        name = "Иван";
        family = "Оджин";
        company_name = "ABC";
        
    }

// б) конструктор с аргументами, соответствующими полям класса;

    public Person(int _age, string _name, string _family, string _company_name)
    {
        age = _age;
        name = _name;
        family = _family;
        company_name = _company_name;
        
    }
// c) конструктор, принимающий только 2 аргумента: имя и возраст. Остальные параметры заполните значениями по умолчанию.
    public Person(int _age, string _name)

    {
        age = _age;
        name = _name;
        family = "Ниждо";
        company_name = "ACB";

    }

}
