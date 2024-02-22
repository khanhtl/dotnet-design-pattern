namespace Builder.FacetedBuilder
{
    public class Address
    {
        public string Street, City;
    }
    public class Company
    {
        public string CompanyName, Position;
    }
    public class Salary
    {
        public int AnnualIncome;
    }
    public class Person
    {
        public string Name;
        public int Age;
        public Address Address;
        public Company Company = new Company();
        public Salary Salary = new Salary();
        public override string ToString()
        {
            return $@"
            Name: {Name},
            Age: {Age},
            Address: 
                Street: {Address.Street},
                City: {Address.City},
            Company: 
                CompanyName: {Company.CompanyName},
                Position: {Company.Position},
            Salary: 
                AnnualIncome: {Salary.AnnualIncome},
            ";
        }
    }

    /// <summary>
    /// Facade
    /// </summary>
    public class PersonBuilder
    {
        protected Person person = new Person();

        public PersonInfoBuilder Info => new PersonInfoBuilder(person);
        public PersonaAddressBuilder Live => new PersonaAddressBuilder(person);
        public PersonCompanyBuilder Work => new PersonCompanyBuilder(person);
        public PersonSalaryBuilder Salary => new PersonSalaryBuilder(person);

        public static implicit operator Person(PersonBuilder pb) => pb.person;
        public Person ToPerson() => this.person;
    }

    public class PersonInfoBuilder : PersonBuilder
    {
        public PersonInfoBuilder(Person person)
        {
            this.person = person;
        }

        public PersonInfoBuilder Called(string name)
        {
            this.person.Name = name;
            return this;
        }

        public PersonInfoBuilder Old(int age)
        {
            this.person.Age = age;
            return this;
        }
    }

    public class PersonaAddressBuilder : PersonBuilder
    {
        public PersonaAddressBuilder(Person person)
        {
            this.person = person;
        }

        public PersonaAddressBuilder At(string street)
        {
            if (this.person.Address is null)
            {
                this.person.Address = new Address();
            }
            this.person.Address.Street = street;
            return this;
        }

        public PersonaAddressBuilder In(string city)
        {
            if (this.person.Address is null)
            {
                this.person.Address = new Address();
            }
            this.person.Address.City = city;
            return this;
        }
    }

    public class PersonCompanyBuilder : PersonBuilder
    {
        public PersonCompanyBuilder(Person person)
        {
            this.person = person;
        }

        public PersonCompanyBuilder At(string company)
        {
            if (this.person.Company is null)
            {
                this.person.Company = new Company();
            }
            this.person.Company.CompanyName = company;
            return this;
        }

        public PersonCompanyBuilder Position(string position)
        {
            if (this.person.Company is null)
            {
                this.person.Company = new Company();
            }
            this.person.Company.Position = position;
            return this;
        }
    }

    public class PersonSalaryBuilder : PersonBuilder
    {
        public PersonSalaryBuilder(Person person)
        {
            this.person = person;
        }

        public PersonSalaryBuilder Earn(int income)
        {
            if (this.person.Salary is null)
            {
                this.person.Salary = new Salary();
            }
            this.person.Salary.AnnualIncome = income;
            return this;
        }
    }
}
