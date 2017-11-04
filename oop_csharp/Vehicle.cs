namespace oop_csharp{

// the class
    public class Vehicle{
// name attribute here , numpass, dist
        public int numPassenger;
        public double distance;
// to add default values to our  attibutes 
        public Vehicle(int val)
        {
            numPassenger = val;
            distance = 0.0;
        } 
// to create a function in that class
        public void Move(double miles)
        {
            distance+= miles;
        }

    }
}