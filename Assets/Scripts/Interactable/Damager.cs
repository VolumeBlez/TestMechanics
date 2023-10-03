using DigitalRuby.LightningBolt;
using UnityEngine;

public class Damager : MonoBehaviour
{
    [SerializeField] private LightningBoltScript _lightning;
    [SerializeField] private float _force = 2f;
    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.TryGetComponent(out PlayerPresenterView presenterView))
        {
            _lightning.gameObject.SetActive(true);
            _lightning.EndObject = other.gameObject;

            presenterView.Presenter.Health.Decrement(10);
            float DX = presenterView.transform.position.x - transform.position.x;
            float DZ = presenterView.transform.position.z - transform.position.z;
            //new Vector3(-DX, 2f, -DZ)

            presenterView.Presenter.SetImpact(new Vector3(DX, 4f, DZ), _force);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        _lightning.EndObject = null;
        _lightning.gameObject.SetActive(false);
    }
}
