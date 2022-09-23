using DesignPatterns;

/*
 * The Strategy Pattern defines a family of algorithms, encapsulates each one, and makes them interchangeable. 
 * Strategy lets the algorithm vary independently from clients that use it.
 */

Console.WriteLine("Strategy Pattern with MiniDuckSimulator!");

/*
 * This calls the MallardDuck's inherited PerformQuack() method, wich then  delegates to the object´s QuackBehavior
 * (i.e. calls quack() on the duck's inherited quackBehavior reference).
 * 
 * Then we do the same thig with MallardDuck's inherited PerformFly() method.
 */

Duck mallard = new MallardDuck();
mallard.PerformQuack();
mallard.PerformFly();

/*
 * The first call to PerformFly() delegates to te flyBehavior object set in the ModelDuck constructor, wich is a FlyNoWay instance.
 * This invokes the model's inherited behavior stter method, and... voila! The model suddenly has rocket-powered flying capability!
 * If it worked, the model duck dynamically changed its flying behavior! You can't do THAT if the implementation lives inside the Duck class.
 */

Duck model = new ModelDuck();
model.PerformFly();
model.SetFlyBehavior(new FlyRocketPowered());
model.PerformFly();


