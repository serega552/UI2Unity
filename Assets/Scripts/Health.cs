using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    private float _countDamage = 10f;
    private float _countHealing = 10f;
    private float _tempValueSlider;

    public float TakeHealth(Slider slider)
    {
        _tempValueSlider = slider.value + _countDamage;
        return _tempValueSlider;
    }

    public float GiveHealth(Slider slider)
    {
        _tempValueSlider = slider.value - _countHealing;
        return _tempValueSlider;
    }

    public bool Die(Slider slider)
    {
        if (slider.value == slider.maxValue)
        {
            return false;
        }

        return true;
    }
}
