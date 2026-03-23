using UnityEngine;
using UnityEngine.UI;

public class StaminaBarUI : MonoBehaviour
{
    [SerializeField] private Image staminaFillImage;
    private PlayerStamina playerStamina;

    private void Start()
    {
        playerStamina = FindFirstObjectByType<PlayerStamina>();
    }

    private void Update()
    {
        if (playerStamina == null || staminaFillImage == null)
            return;

        UpdateStaminaBar(playerStamina.CurrentStamina);
    }

    private void UpdateStaminaBar(float currentStamina)
    {
        staminaFillImage.fillAmount = currentStamina / playerStamina.MaxStamina;
    }
}