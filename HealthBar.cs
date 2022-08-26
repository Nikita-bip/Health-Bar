using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
   [SerializeField] private Slider _healthBar;

   private void Start()
   {
      HealthIcon.Health = HealthIcon.MaxHealth;
   }

   public void Heal()
   {
      if(HealthIcon.Health < HealthIcon.MaxHealth)
         HealthIcon.Health += 10;
      
      _healthBar.value = HealthIcon.Health;
   }
   
   public void Damage()
   {
      if (HealthIcon.Health > 0)
         HealthIcon.Health -= 10;
      
      _healthBar.value = HealthIcon.Health;
   }
}
