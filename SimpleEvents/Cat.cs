using System;

namespace SimpleEvents {
    public class Cat {
        private int health;

        public int Id { get; set; }
        public string Name { get; set; }
        public int Health {
            get {
                return this.health;
            }
            set {
                health = value;
                OnHealthChanged?.Invoke (this, this.health);
            }
        }
        public event EventHandler<int> OnHealthChanged;
    }
}