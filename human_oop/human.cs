namespace human_oop
{
    // create a base class with properties (that have default values, ie others)
    // or others properties w/o default values (ie name)
    public class Human
    {
        public string _name;
        public int _strength = 3 ;
        public int _intelligence = 3 ;
        public int _dexterity = 3 ;
        public int _health = 100 ;

        // use the base class to add values to prop w/o default 
        public Human(string name)
        {
            _name = name;
        
        }

    // use base class to add properties to those w/o default values 
        public Human(string name, int strength, int intelligence, int dexterity, int health)
        {
            _name = name;
            _strength = strength;
            _intelligence = intelligence;
            _dexterity = dexterity;
            _health = health;
        }

                // to pass an object in method(functions), use this 
            // public void attack(Human attacked){
            //     attacked._health -= 5*_strength;
            // }

            // to pass an object in class 
        public void Attack(object target)
        {
            // how to turn the object into an class grabing all from base class 
            Human enemy = target as Human;
            // how to check if new class has all from base class
            if(enemy != null) 
            {
                enemy._health -= 5 * _strength;
                
                
            }
        }
            

        
    }
}

