using UnityEngine;
using UnityEngine.UI;

public class CameraSwitcher : MonoBehaviour
{
    public GameObject mainCamera;
    public CameraZone[] cameraZones;
    public GameObject panelCameras;
    public Button buttonActivePanel;
    public bool IsActivePanel { get; private set; }

    public static CameraSwitcher Instance;

    private CameraZone _currentZone;
    

    private void Awake()
    {
        Instance = this;   
    }

    private void Start()
    {
        buttonActivePanel.onClick.AddListener(SwitchActivePanel);
    }

    public void SwitchCamera(CameraZone cameraZone)
    {
        SetActiveMainCamera(false);
        for (int i = 0; i < cameraZones.Length; i++)
        {
            if (cameraZone == cameraZones[i])
            {
                _currentZone = cameraZone;
                SetActiveCameraZone(i, true);
            }
            else
                SetActiveCameraZone(i, false);
        }
    }

    private void SetActiveMainCamera(bool active)
    {
        mainCamera.SetActive(active);
    }

    private void SetActiveCameraZone(int cameraID, bool active)
    {
        cameraZones[cameraID].SetActiveCamera(active);
    }

    private void SwitchActivePanel()
    {
        IsActivePanel = !IsActivePanel;
        panelCameras.SetActive(IsActivePanel);
        SetActiveMainCamera(!IsActivePanel);

        if (_currentZone == null)
            _currentZone = cameraZones[0];

        if (IsActivePanel)
            SwitchCamera(_currentZone);
        else
        {
            for (int i = 0; i < cameraZones.Length; i++)
            {
                SetActiveCameraZone(i, false);
            }
        } 
    }
}
