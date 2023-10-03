using UnityEngine;

public class PlayerGameOver : BasePlayerView
{
    [SerializeField] private SceneLoader _sceneLoader;
    public override void InitView(IPlayerPresenter presenter)
    {
        base.InitView(presenter);

        Presenter.Health.HealthChanged += CheckZeroHealth;
    }

    private void CheckZeroHealth()
    {
       if(Presenter.Health.CurrentHealth <= 0)
       {
            _sceneLoader.Reload();
       }
    }
}
