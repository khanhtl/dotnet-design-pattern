namespace Builder.FunctionalBuilder
{
    public class Person
    {
        public string Name, Position;
        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Position)}: {Position}";
        }

    }

    public abstract class FunctionalBuilder<TSubject, TSelf>
        where TSelf : FunctionalBuilder<TSubject, TSelf>
        where TSubject : new()
    {
        private readonly List<Func<TSubject, TSubject>> actions = new List<Func<TSubject, TSubject>>();

        public TSubject Build() => actions.Aggregate(new TSubject(), (p, f) => f(p));
        public TSelf Do(Action<TSubject> action)
        {
            AddAction(action);
            return (TSelf)this;
        }
        private TSelf AddAction(Action<TSubject> action)
        {
            actions.Add(p =>
            {
                action(p);
                return p;
            });
            return (TSelf)this;
        }
    }

    public static class PersonBuilderExtensions
    {
        public static PersonBuilder WorkAsA(this PersonBuilder builder, string position)
            => builder.Do(p => p.Position = position);
    }
    public static class PersonBuilderExtensions2
    {
        public static PersonBuilder2 WorkAsA(this PersonBuilder2 builder, string position)
            => builder.Do(p => p.Position = position);
    }
    public sealed class PersonBuilder
    {
        private readonly List<Func<Person, Person>> actions = new List<Func<Person, Person>>();
        public PersonBuilder Called(string name) => Do(p => p.Name = name);

        public Person Build() => actions.Aggregate(new Person(), (p, f) => f(p));
        public PersonBuilder Do(Action<Person> action)
        {
            AddAction(action);
            return this;
        }
        private PersonBuilder AddAction(Action<Person> action)
        {
            actions.Add(p =>
            {
                action(p);
                return p;
            });
            return this;
        }

    }

    public sealed class PersonBuilder2 : FunctionalBuilder<Person, PersonBuilder2>
    {
        public PersonBuilder2 Called(string name) => Do(p => p.Name = name);
    }
}
