using UnityEngine;

public class CameraLookController : MonoBehaviour
{
    public float sensitivity = 80f;
    public float maxAngle = 40f;
    public float engeSize = 500f;
    private float currentY;

    void Update()
    {
        float screenWidth = Screen.width;

        if (Input.mousePosition.x >= screenWidth - engeSize)
            currentY += sensitivity * Time.deltaTime;
        else if (Input.mousePosition.x <= engeSize)
            currentY -= sensitivity * Time.deltaTime;

        currentY = Mathf.Clamp(currentY, -maxAngle, maxAngle);
        transform.localRotation = Quaternion.Euler(0, currentY, 0);
    }
}
