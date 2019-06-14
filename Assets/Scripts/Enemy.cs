using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 10f;
    private Transform target;
    private int wavepointindex = 0;

    void Start()
    {
        target = Waypoints.points[0];
    }

    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if(Vector3.Distance(transform.position, target.position) <= 0.4f)
        {
            GetNextWaypoint();
        }
    }

    void GetNextWaypoint()
    {
        if (wavepointindex >= Waypoints.points.Length - 1)
        {
            EndPath();
            return;
        }

        wavepointindex++;
        target = Waypoints.points[wavepointindex];
    }

    void EndPath()
    {   
        if(GameManager.gameEnded){
            Destroy(gameObject);
        }
        else{
            PlayerStats.Lives--;
            Destroy(gameObject);
        }
    }
}
