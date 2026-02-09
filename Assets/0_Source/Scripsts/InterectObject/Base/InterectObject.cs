using UnityEngine;

public class InterectObject : MonoBehaviour
{
    public bool ChekInterect()
    {
        return !CameraSwitcher.Instance.IsActivePanel;
    }
}
