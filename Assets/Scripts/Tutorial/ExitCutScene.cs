using UnityEngine;
using UnityEngine.Playables;

public class ExitCutScene : MonoBehaviour
{
    [SerializeField] private PlayableDirector _cutScene;
    public void Exit() 
    {
        Debug.Log("CUT");
        _cutScene.time = 1970;
        _cutScene.Evaluate();
    }
}
