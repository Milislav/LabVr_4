using UnityEngine;

public class PickUp : MonoBehaviour
{
    private bool pickedUp;


    public GameObject sword;
    public GameObject parent;
    public Transform guide;
    public float upToggleAngle;
    public float downToggleAngle;

    // Use this for initialization
    void Start()
    {
        pickedUp = false;


        sword.GetComponent<Rigidbody>().useGravity = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (pickedUp)
        {
            if (Camera.main.transform.eulerAngles.x >= downToggleAngle && Camera.main.transform.eulerAngles.x <= 90F)
            {
                pickedUp = false;
                OnPutDown(false);
            }
            if (Camera.main.transform.eulerAngles.x <= 360 - upToggleAngle && Camera.main.transform.eulerAngles.x >= 360 - 90)
            {
                pickedUp = false;
                OnPutDown(true);
            }
        }
    }

    public void OnPickUp()
    {
        if (!pickedUp)
        {
            guide.GetComponent<BoxCollider>().enabled = true;
            sword.GetComponent<BoxCollider>().enabled = false;

            sword.GetComponent<Rigidbody>().useGravity = false;
            sword.GetComponent<Rigidbody>().isKinematic = true;

            Vector3 pos = guide.transform.position;
            Vector3 newPos = new Vector3(pos.x, pos.y + 0.1F, pos.z + 0.5F);
            sword.transform.position = newPos;

            sword.transform.rotation = guide.transform.rotation;

            sword.transform.parent = parent.transform;

            pickedUp = true;


        }
    }

    public void OnPutDown(bool look) // true == up, false == down
    {
        guide.GetComponent<BoxCollider>().enabled = false;
        sword.GetComponent<BoxCollider>().enabled = true;

        sword.GetComponent<Rigidbody>().useGravity = true;
        sword.GetComponent<Rigidbody>().isKinematic = false;

        sword.transform.parent = null;

        if (look)
        {
            sword.transform.position = guide.transform.position + new Vector3(0, 0.5F, 0.5F); ;
        }
        else
        {
            sword.transform.position = guide.transform.position + new Vector3(0, 0.5F, 0.5F);
        }
    }
}
