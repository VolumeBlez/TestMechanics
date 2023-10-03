using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class SetDefaultPP : MonoBehaviour
{
    [SerializeField] private PostProcessVolume _volume;
    [SerializeField] private PostProcessProfile _defaultProfile;

    public void SetDefaultProfile()
    {
        _volume.profile = _defaultProfile;
    }
}
