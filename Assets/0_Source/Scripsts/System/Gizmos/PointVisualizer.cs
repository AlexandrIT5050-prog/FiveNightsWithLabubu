using UnityEngine;

public class PointVisualizer : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;

        for (int i = 0; i < transform.childCount-1; i++)
        {
            Gizmos.DrawLine(transform.GetChild(i).position, transform.GetChild(i + 1).position);
        }
    }
}
