using System;
using System.Collections;
using UnityEngine;

public class EnemyScreamer : MonoBehaviour
{
    [SerializeField] private float delay;
    [SerializeField] private EnemyMove enemyMove;

    private InterectObject _interectObject;
    public static Action<GameObject> ScreamEvent;

    private void OnEnable()
    {
        enemyMove.OnMovementComoleteEvent += StartScream;
    }

    private void OnDisable()
    {
        enemyMove.OnMovementComoleteEvent -= StartScream;
    }

    private void StartScream()
    {
        StartCoroutine(DelayScream());
    }

    private IEnumerator DelayScream()
    {
        yield return new WaitForSeconds(delay);
        if (_interectObject)
        {
            if (_interectObject.IsActive == false)
                ScreamEvent?.Invoke(gameObject);
        }
    }

    public void SetInterectObject(InterectObject interectObject)
    {
        _interectObject = interectObject;
    }
}
