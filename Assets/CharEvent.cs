using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharEvent : MonoBehaviour
{
    public GameObject Box;
    public int InherentNumber;

    private void Start()
    {
        Box.gameObject.SetActive(false);
    }

    public void BoxSetActiveTrue()
    {
        Box.gameObject.SetActive(true);
    }











}
