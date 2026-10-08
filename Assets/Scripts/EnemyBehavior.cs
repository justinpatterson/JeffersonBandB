using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public float speed = 1f;
    // Update is called once per frame
    void Update()
    {
        transform.position = (transform.position) + (transform.forward * speed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision c) 
    {
        if (c.gameObject.CompareTag("Player")) 
        {
            Debug.Log("OM NOM NOM NOM");
            c.gameObject.GetComponent<PlayerController>().TakeDamage(1);
        }
    }
}
