using TMPro;
using UnityEngine;

public class TextHealthDisplay : HealthDisplay
{
    [SerializeField] private TextMeshProUGUI _healthText;
    [SerializeField] private string _nameOfDisplayedValue;

    private string _currentValueHealthInText;
    private string _maximumHealthValueInText;

    public override void SetMaximumHealthDisplay()
    {
        _maximumHealthValueInText = Health.MaximumHealthPoints.ToString();
    }

    public override void UpdateHealthDisplay()
    {
        _currentValueHealthInText = Health.HealthPoints.ToString();

        _healthText.text = $"{_nameOfDisplayedValue} {_currentValueHealthInText}/{_maximumHealthValueInText}";
    }
}
