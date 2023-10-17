using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keypad : Interactable

{
    [SerializeField]
    private GameObject Door;
    private bool DoorOpen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    // Hir kommt alles Rein wie Animation usw...
    protected override void Interact()
    {
        DoorOpen = !DoorOpen;
        Door.GetComponent<Animator>().SetBool("IsOpen", DoorOpen);
    }
}
