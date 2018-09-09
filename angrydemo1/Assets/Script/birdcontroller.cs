using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdcontroller : MonoBehaviour {

    // Use this for initialization
    public Rigidbody2D rb;
    public Rigidbody2D Hook;
    private bool isPressed = false;
    public float releaseTime =.15f;
    public float max_distance=2f;
	// Update is called once per frame
 
	void Update () {

        if (isPressed)
        {
            Vector2 mousePos=Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (Vector3.Distance(mousePos,Hook.position)>max_distance)   
                rb.position = Hook.position+ (mousePos-Hook.position).normalized*max_distance;
            else rb.position= mousePos;

        }
	}
    void OnMouseDown()
    {
        isPressed = true;
        rb.isKinematic = true;    
    }
    void OnMouseUp()
    {
        isPressed = false;
        rb.isKinematic = false;
        StartCoroutine(Release());
    }
    IEnumerator Release()
    {
        
        yield return new WaitForSeconds(releaseTime);
        GetComponent<SpringJoint2D>().enabled = false;
        this.enabled=false;                                                  
    }
}
