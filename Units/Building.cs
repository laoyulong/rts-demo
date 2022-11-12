namespace rts_demo {
    public class Building: IUnit {
		public int Health { get; set; }
		public int MaxHealth { get; set; }

		public int Damage { get; set; }

        public Building(int MaxHealth, int Damage) {
            this.MaxHealth = MaxHealth;
            this.Damage = Damage;
        }

		public void Attack(IUnit target) {

        }
    }
}
