using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public static Manager instance = null; // Declaring and initializing a public static Manager class to null.
    public string menu = "Main_Menu"; // This is the string that populates the current menu

    void Awake()
    {
        if (instance == null) // Determine if our instance is null
            instance = this; // Assign instance to this instance of the class
        else if (instance != null) // Determine if our instance is already assigned to something else
            Destroy(gameObject);
        
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
