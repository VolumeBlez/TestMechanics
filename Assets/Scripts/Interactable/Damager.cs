using UnityEngine;

public class Damager : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.TryGetComponent(out PlayerPresenterView presenterView))
        {
            presenterView.Presenter.Health.Decrement(5);
        }
    }
}
