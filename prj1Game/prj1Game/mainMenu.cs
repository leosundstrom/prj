public class mainMenu{
    stateM stateM;

    public mainMenu(stateM stateM)
    {
        this.stateM = stateM;
    }

     public void Update()
    {
    Console.BackgroundColor = ConsoleColor.White;
Console.Clear();
Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("You're in the city square. Here you can enter the \"blacksmith\"'s shop for weapons and armory, the \"church\" for spells and potions or you could go back to the \"forest\" to fight monsters for gold");
string pText = Console.ReadLine();
if(pText.ToLower() == "forest"){
          stateM.currentState = stateM.States.fight;
          stateM.SetState();
}

}
    }

