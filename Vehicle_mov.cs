using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle_mov : MonoBehaviour
{
    // Start is called before the first frame update

    public WheelCollider RightFront;
    public WheelCollider RightBack;
    public WheelCollider LeftFront;
    public WheelCollider LeftBack;

    public float acc;
    float currentacc;

    float currentbrk;
    public float breaks;

    public float turn;
    float currentturn;

    public Rigidbody rb;
    public Transform Com;

    public Transform RightFrontWheel;
    public Transform RightBackWheel;
    public Transform LeftFrontWheel;
    public Transform LeftBackWheel;

    float accInput;
    float revInput;
    float breakInput;

    public GameObject Himalaya_Panel;
    public GameObject Satpura_Panel;
    public GameObject Eastern_Panel;
    public GameObject Eastern_Panel_2;
    public GameObject Vindhya_Panel;
    public GameObject Aravali_Panel;
    public GameObject Aravali_2_Panel;
    void Start()
    {
        rb.centerOfMass = Com.localPosition;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    {
        currentacc = acc * accInput;
        RightBack.motorTorque = currentacc;
        LeftBack.motorTorque = currentacc;



        currentturn = turn * SimpleInput.GetAxis("Horizontal");
        RightFront.steerAngle = currentturn;
        LeftFront.steerAngle = currentturn;

        currentbrk = breaks * breakInput;
        RightBack.brakeTorque = currentbrk;
        LeftBack.brakeTorque = currentbrk;
        RightFront.brakeTorque = currentbrk;
        LeftFront.brakeTorque = currentbrk;

        WheelMeshUpdation(RightBack, RightBackWheel);
        WheelMeshUpdation(RightFront, RightFrontWheel);
        WheelMeshUpdation(LeftBack, LeftBackWheel);
        WheelMeshUpdation(LeftFront, LeftFrontWheel);

    }
    void WheelMeshUpdation(WheelCollider col, Transform tran)
    {
        Vector3 pstn;
        Quaternion rtn;
        col.GetWorldPose(out pstn, out rtn);

        tran.position = pstn;
        tran.rotation = rtn;
    }

    public void AccPush()
    {
        accInput = 1;
    }

    public void Accrelease()
    {
        accInput = 0;
    }

    public void RevPush()
    {
        accInput = -1;
    }

    public void BreakPush()
    {
        breakInput = 1;
    }

    public void BreakRelease()
    {
        breakInput = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Himalaya")
        {
            Himalaya_Panel.SetActive(true);
        }

        if (other.gameObject.tag == "Satpura")
        {
            Satpura_Panel.SetActive(true);
        }

        if(other.gameObject.tag == "Eastern")
        {
            Eastern_Panel.SetActive(true);
        }

        if(other.gameObject.tag == " Eastern_2")
        {
            Eastern_Panel_2.SetActive(true);
        }

        if(other.gameObject.tag == "Vindhya")
        {
            Vindhya_Panel.SetActive(true);
        }

        if(other.gameObject.tag == "Aravali")
        {
            Aravali_Panel.SetActive(true);
        }

        if(other.gameObject.tag == "Aravali_2")
        {
            Aravali_2_Panel.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Himalaya")
        {
            Himalaya_Panel.SetActive(false);
        }

        if (other.gameObject.tag == "Satpura")
        {
            Satpura_Panel.SetActive(false);
        }

        if (other.gameObject.tag == "Eastern")
        {
            Eastern_Panel.SetActive(false);
        }

        if (other.gameObject.tag == " Eastern_2")
        {
            Eastern_Panel_2.SetActive(false);
        }

        if (other.gameObject.tag == "Vindhya")
        {
            Vindhya_Panel.SetActive(false);
        }

        if (other.gameObject.tag == "Aravali")
        {
            Aravali_Panel.SetActive(false);
        }

        if (other.gameObject.tag == "Aravali_2")
        {
            Aravali_2_Panel.SetActive(false);
        }
    }
}