using TMPro;
using UnityEngine;

public class FlashLightView : BasePlayerView
{
    [SerializeField] private GameObject _lightObject;
    [SerializeField] private TMP_Text _chargeViewText;

    public override void InitView(IPlayerPresenter presenter)
    {
        base.InitView(presenter);
        presenter.FlashLight.InitFlashLight(_lightObject, 100f);
    }

    void Update()
    {
        Presenter.FlashLight.Charge = Presenter.FlashLight.Charge - Time.deltaTime;

        _chargeViewText.text = $"Charge: {((int)Presenter.FlashLight.Charge)}";
    }
}
