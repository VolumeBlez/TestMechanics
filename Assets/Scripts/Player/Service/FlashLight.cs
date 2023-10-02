using UnityEngine;

public sealed class FlashLight
{
    private GameObject _light;
    private bool _isActive = false;
    private bool _isTurnable = true; // if charge <= 0 then you can't turn on\off light
    private float _charge = 100f;

    public bool IsActive => _isActive;
    public float Charge 
    {
        get => _charge;
        set => UpdateCharge(value);
    }

    public void InitFlashLight(GameObject light, float startCharge = 100f)
    {
        _light = light;
        _charge = startCharge;
    }

    public void TurnFlashLight()
    {
        if(_light == null) return;
        if(_isTurnable == false) return;

        _isActive = !_isActive;

        _light.SetActive(_isActive);
    }

    public void UpdateCharge(float newCharge)
    {
        _charge = Mathf.Clamp(newCharge, 0f, 100f);
        if(_charge <= 0)
        {
            _light.SetActive(false);
            _isTurnable = false;
        }
    }
}
