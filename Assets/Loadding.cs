using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loadding : MonoBehaviour
{
    public Sprite[] LoaddingSprite;
    public GameObject GameObjectLoaddingSprite;
    public GameObject LoadingUI;
    int number;
    private void Start()
    {
        number = 0;
        StartCoroutine("Loop");
    }

    public IEnumerator Loop()
    {
        while (true)
        {
            if (number == 5)
            {
                StopCoroutine("Loop");
                LoadingUI.SetActive(false);
            }
            yield return new WaitForSeconds(0.2f);
            GameObjectLoaddingSprite.GetComponent<Image>().sprite = LoaddingSprite[number];
            number++;
        }
    }
}
