using System;

namespace SpaceShipsExampleEvents
{
	public class Fighter
    {
		private int _hp;

		public int HP
		{
			get => _hp;
			set 
			{
				_hp = value;
				if (HP <= 0)
				{
					Destroy();
				}
			}
		}

		public string Name { get; private set; }

		public event Action<Fighter> OnDestroy = delegate { };

		public Fighter(string name)
		{
			Name = name;
			HP = 100;
		}

		public void Destroy()
		{
			OnDestroy?.Invoke(this);

			Console.WriteLine($"\nBOOM - {Name}\n");
		}

		public override string ToString()
		{
			return $"Fighter:{Name} with: {HP} HP";
		}
	}
}
