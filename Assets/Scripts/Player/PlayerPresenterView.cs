using UnityEngine;

public class PlayerPresenterView : MonoBehaviour
{
    private IPlayerPresenter _presenter;
    public IPlayerPresenter Presenter => _presenter;

    public void InitPlayerPresenterView(IPlayerPresenter presenter) => _presenter = presenter;
}
