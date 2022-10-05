using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;




public class SnakeController : MonoBehaviour
{
    [SerializeField] private GameObject LosePanel;

    public GameManager gm;
    public Rigidbody rb;    

    public TextMeshPro PointsText;

    private bool ignoreNextCollision;

    public List<GameObject> tailObjects = new List<GameObject>(); //tailObjects - Snake Lives    

    

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
            
            //gm.EndGame();
            Debug.Log("Game Over");
        }

        if (ignoreNextCollision)
        {
            return;
        }

        if (collision.collider.tag == "Block")
        {
            ignoreNextCollision = true;
            Invoke("AllowCollision", .2f);
            Debug.Log("Check");
        }

        if (collision.collider.tag == "EndLevel")
        {
            
           // gm.EndGame();
            Debug.Log("You Win!");
        }

    }

    private void AllowCollision()
    {
        ignoreNextCollision = false;
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
        
        Destroy(TailPrefab);
                

        tailObjects.RemoveAt(tailObjects.Count - 1);


        if (tailObjects.Count == 0)
        {
            Destroy(gameObject);
            LosePanel.SetActive(true);
            //GetComponent<GameManager>().EndGame();
           ///Debug.Log("Game Over"); Доделать тут метод endGame!
        }
        //
        //PointsText.text = tailObjects.Count.ToString();

    }
    

}
