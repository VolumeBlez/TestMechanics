using TMPro;
using UnityEngine;

public class HealthView : BasePlayerView
{
    [SerializeField] private TMP_Text _healthViewText;

    public override void InitView(IPlayerPresenter presenter)
    {
        base.InitView(presenter);
        Presenter.Health.HealthChanged += UpdateHealthView;

        UpdateHealthView();
    }

    private void UpdateHealthView() 
    {
        _healthViewText.text = $"Health: {Presenter.Health.CurrentHealth}";
    }
}
