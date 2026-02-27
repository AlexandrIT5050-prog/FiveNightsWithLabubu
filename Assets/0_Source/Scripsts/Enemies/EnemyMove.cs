using System;
using System.Collections;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] private float waitTime;

    private int _currentPointIndex;
    private Transform[] _movePoints;

    public  event Action OnMovementComoleteEvent;

    public void StartMovement(Transform movePoints)
    {
        if (movePoints == null)
        {
            Debug.LogError("No movePoints found");
            return;
        }
        InitilizationPoints(movePoints);
        _currentPointIndex = 0;

        StartCoroutine(MoveRoutine());
    }

    private IEnumerator MoveRoutine()
    {
        while (_currentPointIndex < _movePoints.Length)
        {
            yield return new WaitForSeconds(waitTime);
            transform.position = _movePoints[_currentPointIndex].position;
            transform.rotation = _movePoints[_currentPointIndex].rotation;
            _currentPointIndex++;
        }

        OnMovementComoleteEvent?.Invoke();
    }

    private void InitilizationPoints(Transform movePoints)
    {
        _movePoints = new Transform[movePoints.childCount];
        for (int i = 0; i < movePoints.childCount; i++)
        {
            _movePoints[i] = movePoints.GetChild(i);
        }
    }
}
