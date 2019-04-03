using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace HealthBar
{
    public class HealthBar : MonoBehaviour
    {
        [Header("Reference to health")]
        // Players maxium health
        public float maxHealth;
        // Players current health
        public float curHealth;
        [Header("Reference to UI elements")]
        // Reference to Slider
        public Slider healthSlider;
        // Reference to Fill
        public Image healthFill;

        void Update()
        {
            healthSlider.value = Mathf.Clamp01(curHealth / maxHealth);
            if (curHealth <= 0 && healthFill.enabled)
            {
                Debug.Log("Dead");
                healthFill.enabled = false;
            }
            else if (!healthFill.enabled && curHealth > 0)
            {
                Debug.Log("Revive");
                healthFill.enabled = enabled;
            }
        }
    }
}