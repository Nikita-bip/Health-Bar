using UnityEngine;
using UnityEngine.UI;

public class HealthIcon : MonoBehaviour
{
    [SerializeField] private Text _healthText;
    
    public static int Health, MaxHealth = 100;

    private void Update()
    {
        _healthText.text = "Health: " + Health + "%";
    }
}
