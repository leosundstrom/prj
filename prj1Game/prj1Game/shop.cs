
public class shop{
    stateM stateM;

    public shop(stateM stateM)
    {
        this.stateM = stateM;
    }

     public void Update()
    {
Console.WriteLine("You enter the shop! Hear you can buy \"potions\" and \"spells\"");
string pText = Console.ReadLine();
if(pText.ToLower() == "forest"){
        stateM.currentState = stateM.States.mainMenu;
    }
    
}