// In case you need some guidance: https://refactoring.guru/design-patterns/observer

namespace DesignPattern.Observer
{
    public class ConcreteObserver(string userName) : IObserver
    {
        public string UserName { get; }

        private readonly ISubject subject;

        public ConcreteObserver(ISubject subject, string userName)
        {
            UserName = userName;

            //register automatically the observer to the subject
            subject.RegisterObserver(this);
        }

        //add observer to subject
        public void AddSubscriber(ISubject subject)
        {
            subject.RegisterObserver(this);
        }

        //remove observer from subject
        public void RemoveSubscriber(ISubject subject)
        {
            subject.RemoveObserver(this);
        }

        //method to update observer when subject's state changes
        public void Update(string availability)
        {
            Console.WriteLine("初めまして " + UserName + ", プロダクトがある！ " + availability + " 早く買いましょう！");
        }

        // Your code goes here... make sure to add this features:
        // done 1. Allow to hold the observer's name (e.g. when user Adam wants to observe the subject) 
        // done 2. Creating the Observer
        // done 3. Registering the Observer with the Subject
        // done 4. Removing the Observer from the Subject
        // done (sugoi version *^ω^*) 5. Observer will get a notification from the Subject using the following Method
    }
}
