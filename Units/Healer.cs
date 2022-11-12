namespace rts_demo {
    abstract class Healer : IUnit {
		public int Health { get; set; }
		public int MaxHealth { get; set; }
		int Mana { get; set; }

        public abstract void Heal(IUnit target);
    }
}
