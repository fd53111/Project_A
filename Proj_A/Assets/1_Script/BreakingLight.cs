using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakingLight : MonoBehaviour
{
    [SerializeField]
    private GameObject Lamp;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Monster")
        {
            Debug.Log("ÆÄ±«");
            Destroy(gameObject);
        }
    }
}
