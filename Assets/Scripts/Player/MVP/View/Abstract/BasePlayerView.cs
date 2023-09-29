using UnityEngine;

public abstract class BasePlayerView : MonoBehaviour
{
    protected IPlayerPresenter Presenter;
    public virtual void InitView(IPlayerPresenter presenter)
    {
        Presenter = presenter;
    }
}
