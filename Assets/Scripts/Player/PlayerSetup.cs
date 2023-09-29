using UnityEngine;

public class PlayerSetup : MonoBehaviour
{
    [SerializeField] private PlayerData _data;
    [SerializeField] private CharacterController _controller;
    [SerializeField] private Transform _rotateObject;
    [SerializeField] private Camera _camera;

    [Header("Views")]
    [SerializeField] private PlayerPresenterView _presenterView;
    [SerializeField] private BasePlayerView[] _views;

    void Start()
    {
        PlayerModel model = new(_data, _controller, _rotateObject, _camera);
        PlayerPresenter presenter = new(model);

        _presenterView.InitPlayerPresenterView(presenter);

        foreach (BasePlayerView view in _views)
        {
            view.InitView(presenter);
        }
    }


}
