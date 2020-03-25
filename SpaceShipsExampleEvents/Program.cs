namespace SpaceShipsExampleEvents
{
    class Program
    {
        static void Main()
        {
            var motherShipOne = new MotherShip("X-wing");
            var motherShipTwo = new MotherShip("Sky Lynx");

            var fighterIronMan = new Fighter("Tony Stark");
            var fighterBigShip = new Fighter("Tanos");
            var fighterRainbowBridge = new Fighter("Tor");

            motherShipOne.AddFighter(fighterIronMan, fighterBigShip, fighterRainbowBridge);
            motherShipOne.PrintAll();
            
            motherShipTwo.AddFighter(fighterBigShip);
            motherShipTwo.PrintAll();
            
            // Destroy!
            fighterBigShip.HP = -115;
            motherShipOne.PrintAll();
            motherShipTwo.PrintAll();
        }
    }
}
