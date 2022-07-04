class GameSettings
{
    public int ConsoleWidht {get; set;} = 80;
    public int ConsoleHight {get; set;} = 30;

    //-------------------------------------------------------

    public int NumberOfSwarmRows {get; set;} = 2;
    public int NumberOfSwarmColls {get; set;} = 60;

    public int SwarmStartXCoordinate  {get; set;} = 10;
    public int SwarmStartYCoordinate  {get; set;} = 2;

    //public int[] SwarmStartMoving {get; set;} =(1, 1);
    public char AllienShip {get; set;} = 'O';
    public int SwarmSpeed {get; set;} = 20;

    //-------------------------------------------------------

    public int PlayerShipStartXCoordinate {get; set;} = 40;
    public int PlayerShipStartYCoordinate {get; set;} = 19;
    public char PlayerShip {get; set;} = '^';
    //-------------------------------------------------------
    public int GroundStartXCoordinate {get; set;} = 1;
    public int GroundStartXCoordinate {get; set;} = 20;
    
    public char Ground {get; set;} = 'П';
    public int NumberOfGroundRows {get; set;} = 1;
    public int NumberOfGroundColls {get; set;} = 80;

    //------------------------------------------------------

    public char PlayerMissle {get; set;} = '|';
    public int PlayerMissleSpeed {get; set;} = 5;

    //--------------------------------------------------------

    public int GameSpeed {get; set;}= 100;
}