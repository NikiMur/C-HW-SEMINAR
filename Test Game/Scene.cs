class Scene
{
   List <GameObject> _swarm;
   
   List <GameObject> _ground;

   GameObject _playrShip;

   List<GameObject> _playerShipMissle;

   GameSettings _gameSettings;

   
  private static Scene _scene;

  private Scene();

   private Scene(GameSettings gameSettings)
  {
    _gameSettings = gameSettings;
    _swarm = new AllienShipFactory(_gameSettings).GetSwarm();

  }

  public static Scene GetScene(GameSettings gameSettings)
  {
    if( _scene == null)
    {
        _scene =new Scene(gameSettings);

    }
    return _scene;
  }

}