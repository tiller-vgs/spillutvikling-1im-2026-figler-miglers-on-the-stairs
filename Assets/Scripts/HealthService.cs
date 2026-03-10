using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
	public class HealthService : MonoBehaviour
	{
		[SerializeField] int maxHealth = 100;
		int remainingHealth;

		public event System.Action OnDeath;
		public int CurrentHealth => remainingHealth;
		public int MaxHealth => maxHealth;
		public bool IsDead => remainingHealth <= 0;

		void Awake()
		{
			remainingHealth = maxHealth;
		}

        public int DecreaseHealth(int amount)
		{
			if (IsDead) return 0;
			remainingHealth = Mathf.Max(0, remainingHealth - amount);
			if (remainingHealth <= 0) OnDeath?.Invoke();
			return remainingHealth;
		}

		public int IncreaseHealth(int amount)
		{
			remainingHealth = Mathf.Min(maxHealth, remainingHealth + amount);
			return remainingHealth;
		}
	}
}
