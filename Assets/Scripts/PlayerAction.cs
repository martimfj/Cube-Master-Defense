using UnityEngine;

public class PlayerAction : MonoBehaviour
{
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit))
            {
                SphereCollider sc = hit.collider as SphereCollider;
                if(sc.tag == "Enemy")
                {
                    Destroy(sc.gameObject);
                    PlayerStats.Score++;
                }
            }
        }
    }
}
