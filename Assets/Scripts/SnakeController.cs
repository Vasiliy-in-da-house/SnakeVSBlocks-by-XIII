using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;




public class SnakeController : MonoBehaviour
{
    public GameManager gm;
    public Rigidbody rb;    

    public TextMeshPro PointsText;

    public List<GameObject> tailObjects = new List<GameObject>();   

    public GameObject TailPrefab;

    public float z_offset = 3.5f;

    public float runSpeed = 10f;
    public float rotateSpeed = 100f;

    protected bool strafeLeft = false;
    protected bool strafeRight = false;

    void Start()
    {       

        tailObjects.Add(gameObject);
        
    }

    private void Awake()
    {
        
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag  == "Obstacle")
        {            
            Debug.Log("Game Over");
        }

        if (collision.collider.tag == "EndLevel")
        {           
            Debug.Log("You Win!");
        }
    }

    void Update()
    {
        if (Input.GetKey("a"))
        {
            strafeLeft = true;
        }
        else
        {
            strafeLeft = false;
        }
        if (Input.GetKey("d"))
        {
            strafeRight = true;
        }
        else
        {
            strafeRight= false;
        }
                
    }

    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * runSpeed * Time.deltaTime);
        
        if (strafeLeft)
        {
            transform.Rotate(Vector3.up *-1 * rotateSpeed * Time.deltaTime);
        }

        if (strafeRight)
        {
            transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
        }

        PointsText.text = tailObjects.Count.ToString();
    }

    public void AddTail()
    {        
        Vector3 newTailPosition = tailObjects[tailObjects.Count -1].transform.position;
        newTailPosition.z -= z_offset;
        tailObjects.Add(GameObject.Instantiate(TailPrefab, newTailPosition, Quaternion.identity) as GameObject);
        
    }

    public void LoseTail()
    {
        //Destroy(tailObjects[1].gameObject);
                
    }
    

}
