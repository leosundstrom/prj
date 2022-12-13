public class start{
    stateM stateM;

    public start(stateM stateM)
    {
        this.stateM = stateM;
    }

     public void Update()
    {
Console.WriteLine("slagsmål");
Console.ReadLine();
        stateM.currentState = stateM.States.fight;
    }
    
}