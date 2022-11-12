namespace rts_demo {
    abstract public class Warrior : IUnit {
		public int Health { get; set; }
		public int MaxHealth { get; set; }
		public int Damage { get; set; }

        public abstract void Attack(IUnit target);
    }
}
