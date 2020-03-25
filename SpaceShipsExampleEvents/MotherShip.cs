using System;
using System.Collections.Generic;

namespace SpaceShipsExampleEvents
{
    public class MotherShip
    {

        private List<Fighter> _fighters;

        public string Name { get; private set; }

        public MotherShip(string name)
        {
            _fighters = new List<Fighter>();
            Name = name;
        }

        private void OnFighterDestroyHandler(Fighter fighter)
        {
            RemoveFighter(fighter);
        }

        public void AddFighter(Fighter fighter)
        {
            if (!_fighters.Contains(fighter))
            {
                _fighters.Add(fighter);
                fighter.OnDestroy += OnFighterDestroyHandler;
            }
            else
            {
                Console.WriteLine("Fighter already added!");
            }
        }

        public void AddFighter(params Fighter[] fighters)
        {
            foreach (var item in fighters)
            {
                AddFighter(item);
            }
        }

        public void RemoveFighter(Fighter fighter)
        {
            if (_fighters.Contains(fighter) && fighter != null)
            {
                _fighters.Remove(fighter);
                fighter.OnDestroy -= OnFighterDestroyHandler;
            }
            else
            {
                throw new ArgumentNullException("Incorrect fighter or null", "fighter");
            }
        }

        public void PrintAll()
        {
            Console.WriteLine($"MotherShip: {Name}");

            if (_fighters.Count == 0 || _fighters == null)
            {
                Console.WriteLine(" Null");
            }

            foreach (var item in _fighters)
            {
                Console.WriteLine($" {item}");
            }

            Console.WriteLine();
        }

    }
}
