using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _sliderHealth;
    [SerializeField] private Transform _chapterTransform;

    private Health _health = new Health();

    public void ButtonOnClickTakeDamage()
    {
        if (CheckDie())
            _sliderHealth.DOValue(_health.TakeHealth(_sliderHealth), 1f);
    }

    public void ButtonOnClickHealings() 
    {
        if(CheckDie())
            _sliderHealth.DOValue(_health.GiveHealth(_sliderHealth), 1f);
    }

    private bool CheckDie()
    {
        if (_health.Die(_sliderHealth))
        {
            return true;
        }
        else
        {
            _chapterTransform.DORotate(new Vector3(0, 0, 100), 0.1f);
            return false;
        }
    }
}
