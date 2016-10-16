using UnityEngine;
using System.Collections;
using System.Security.Cryptography;

public class PlayerController : MonoBehaviour
{
    private float speed = 15.0f;
    private float padding = 0.5f;
    private float xmin, xmax;
    public GameObject projectilePrefab;
    public float projectileSpeed = 5f;
    public float fireRate = 0.2f;

    // Use this for initialization
    void Start()
    {
        float distance = transform.position.z - Camera.main.transform.position.z;
        Vector3 leftMost = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, distance));
        Vector3 rightMost = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, distance));
        xmin = leftMost.x + padding;
        xmax = rightMost.x - padding;

    }

    void Fire()
    {
        // GameObject projectile = Instantiate(projectilePrefab, new Vector3(transform.position.x, transform.position.y + 0.5f, 0), Quaternion.identity) as GameObject;
        GameObject projectile = Instantiate(projectilePrefab, new Vector3(transform.position.x, transform.position.y, 1), Quaternion.identity) as GameObject;
        projectile.GetComponent<Rigidbody2D>().velocity = new Vector2(0, projectileSpeed); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            InvokeRepeating("Fire", 0.00001f, fireRate);
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            CancelInvoke("Fire");
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            //transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
            transform.position += Vector3.right * speed * Time.deltaTime;
        }

        // restrict player to the gamespace
        float newX = Mathf.Clamp(transform.position.x, xmin, xmax);
        transform.position = new Vector3(newX, transform.position.y, transform.position.z);

        //Vector3 moveDirection = gameObject.transform.position - _origPos;
        //if (moveDirection != Vector3.zero)
        //{
        //    float angle = Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg;
        //    transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        //}
    }
}
