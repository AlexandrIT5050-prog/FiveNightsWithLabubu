using UnityEngine;

public class InterectObject : MonoBehaviour
{
    public bool IsActive { get; protected set; }

    public bool ChekInterect()
    {
        return !CameraSwitcher.Instance.IsActivePanel;
    }
}
