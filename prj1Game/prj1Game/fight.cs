public class fight{
     stateM stateM;

Random generator = new Random();
    public fight(stateM stateM)
    {
        this.stateM = stateM;
    }

bool enemyBeaten = false;
    int enemyNameTurn = 0;
    string[] enemies = { "hugo", "goblin", "troll", "ogre", "beast" };
    
     public void Update()
    {
     // monster list


     
            bool playerTurn = true; 

    Console.BackgroundColor = ConsoleColor.DarkRed;
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Black;
    stateM.enemy.name = enemies[enemyNameTurn];
    if(enemyNameTurn == 2){Console.WriteLine($"You find an {stateM.enemy.name} while wandering in the monster filled forest!");}else{
    Console.WriteLine($"You find a {stateM.enemy.name} while wandering in the monster filled forest! Press Enter to engage.");}
     Console.ReadLine();
    Console.WriteLine("Write attack to attack, spell for spells and potion for potions");
    while(stateM.enemy.hp >= 1){
        if(playerTurn = true){
            stateM.player.hp = stateM.player.baseHP;
            string pText = Console.ReadLine();
        if(pText.ToLower() == "attack"){
            stateM.player.damage = generator.Next(stateM.player.minDmg, stateM.player.maxDmg);
            stateM.enemy.hp -= stateM.player.damage/stateM.enemy.armor;
            Console.WriteLine($"The {stateM.enemy.name} took {stateM.player.damage} damage! The {stateM.enemy.name} now has {stateM.enemy.hp} health.");
           playerTurn = false;
        }
        if(pText.ToLower() == "spell"){
            Console.WriteLine("Pick a spell \n Strength");
        }
        if(playerTurn == false){
            int enemyDamage = generator.Next(stateM.enemy.minDmg,stateM.enemy.maxDmg);
            stateM.player.hp -= enemyDamage;
            Console.ReadLine();
            Console.WriteLine($"The enemy swung his weapon and dealt {enemyDamage} damage, your HP is now {stateM.player.hp}");
            playerTurn = true;
        }
    }
    }
    

if(stateM.enemy.hp <= 1){
        enemyNameTurn++;
       enemyBeaten = true;
}
    if(enemyBeaten == true){
        EnemySwitch();
    }
}


void EnemySwitch(){
    //stat increase on enemies
    if(enemyNameTurn == 1){
        stateM.enemy.hp = stateM.enemy.basehp;
         float rounding = stateM.enemy.hp;
        rounding*= 1.5f;
      stateM.enemy.hp = Convert.ToInt32(rounding);
      stateM.enemy.basehp = stateM.enemy.hp;
         float dmgRounding1 = stateM.enemy.minDmg;
        dmgRounding1 *= 1.25f;
      stateM.enemy.minDmg = Convert.ToInt32(dmgRounding1);
        float dmgRounding2 = stateM.enemy.maxDmg;
        dmgRounding2 *= 1.25f;
      stateM.enemy.maxDmg = Convert.ToInt32(dmgRounding2);
          stateM.currentState = stateM.States.mainMenu;
          stateM.SetState();
    }
    
}
    }

     
