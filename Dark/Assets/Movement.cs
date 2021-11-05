using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float velocity = 10.0f;

    public int motivation = 0;
    public GameObject pos1 = new GameObject();
    public GameObject pos2 = new GameObject();
    public GameObject pos3 = new GameObject();
    public GameObject pos4 = new GameObject();
    public GameObject pos5 = new GameObject();
    public GameObject pos6 = new GameObject();
    public GameObject pos7 = new GameObject();
    public GameObject pos8 = new GameObject();
    public bool canMove = false;
    public Vector3 initialPos;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            var selection = hit.transform;

            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                canMove = true;
                initialPos = selection.position;
            }
        }

        if (canMove)
        {
            seek(initialPos);
        }

        /*if (Input.GetKey(KeyCode.Alpha1))
        {
            seek(pos1.transform);
        }
        

        if (Input.GetKey(KeyCode.Alpha2))
        {
            seek(pos2.transform);
        }

        if (Input.GetKey(KeyCode.Alpha3))
        {
            seek(pos3.transform);
        }
        */
    }

    public void seek(Vector3 finalPos)
    {
        transform.position = Vector3.MoveTowards(transform.position, finalPos, velocity * Time.deltaTime);

        if (transform.position == finalPos)
        {
            canMove = false;
        }
    }

}