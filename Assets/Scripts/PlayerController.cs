using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed = 5f;
    public int health = 3;
    [SerializeField]
    protected int maxHealth = 5;
    public Transform characterRoot;

    void Awake() 
    {
        Debug.Log("Awake!");
        health = maxHealth;
    }
    void Start() 
    {
    
    }
    void Update() 
    {
        float horizontalMovement = 0.0f;
        horizontalMovement = Input.GetAxis("Horizontal");

        transform.position = transform.position + (Vector3.right * horizontalMovement * Time.deltaTime * movementSpeed);
        //characterRoot.localEulerAngles = new Vector3(0, 45f * horizontalMovement, 0);
        characterRoot.localEulerAngles = new Vector3(0, 
            horizontalMovement>0f?0:
            (horizontalMovement<0f?180f : characterRoot.localEulerAngles.y)
            , 0);
    }


    public void Move() 
    {
    
    }
    
    public void TakeDamage(int amount) 
    {
        health = Mathf.Clamp(health - amount, 0, maxHealth);
    }
    public void HealHealth(int amount) 
    {
        health = Mathf.Clamp(health + amount, 0, maxHealth);
    }

    protected bool IsDead() 
    {
        if (health <= 0) return true;
        else return false;
    }
    public float GetHealthPercentage() 
    {
        return (float) health / (float) maxHealth;
    }
}
