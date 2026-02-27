using UnityEngine;
using UnityEngine.Playables;

public class ScreemerManager : MonoBehaviour
{
    [SerializeField] private Transform pointAnimatronic;
    [SerializeField] private PlayableDirector director;

    private void OnEnable()
    {
        EnemyScreamer.ScreamEvent += StartScreamer;
    }

    private void OnDisable()
    {
        EnemyScreamer.ScreamEvent -= StartScreamer;
    }

    private void Start()
    {
        director.Stop();
    }


    private void StartScreamer(GameObject enemy)
    {
        enemy.transform.SetParent(pointAnimatronic);
        enemy.transform.rotation = pointAnimatronic.rotation;
        enemy.transform.position = pointAnimatronic.position;
        director.Play();
    }
}
