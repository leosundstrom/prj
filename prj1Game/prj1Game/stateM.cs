public class stateM{
//Creates an instance of every class
    public Player player = new();
    public Enemy enemy = new();
    public fight fight;
    public mainMenu mainMenu;
    public start start;

    public dead dead;
    public States currentState = States.start;

    public stateM()
    {
        mainMenu = new(this);
        start = new(this);
        fight = new(this);
    }


//Sends the player to the correct state depending on the variebal currentstate
    public void SetState()
    {
        while(1!=2)
        {
        if(currentState == States.start)
        {
            start.Update();
        }else if(currentState == States.mainMenu)
        {
            mainMenu.Update();
        }else if(currentState == States.fight)
        {
            fight.Update();
        }else
        {
            dead.Update(); 
        }
        }
    }


//Clears the console and shows the stats of player and enemy (enemy only shows while in fight)
    public void ClearConsole()
    {
        Console.Clear();
    }


//The diffrent states the player can be in
    public enum States
    {
    dead, mainMenu, fight, start
    }

}