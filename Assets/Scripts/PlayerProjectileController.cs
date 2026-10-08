using UnityEngine;

public class PlayerProjectileController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject projectilePrefab;
    public Camera playerCamera;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) 
        {
            Vector3 mousePosition = Input.mousePosition;
            Vector3 playerScreenPosition = playerCamera.WorldToScreenPoint(this.transform.position);
            
            Debug.Log("Fire! " + mousePosition);
            GameObject pInst = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
            Vector3 screenDirection = mousePosition - playerScreenPosition;
            screenDirection.z = 0f;
            Vector3 transposedDirection = new Vector3(screenDirection.x, screenDirection.z, screenDirection.y);
            pInst.GetComponent<Rigidbody>().AddForce(screenDirection);

            pInst.transform.rotation = Quaternion.LookRotation(screenDirection, Vector3.forward);


        }
    }
}
