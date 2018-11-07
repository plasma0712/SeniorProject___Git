using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickEvent : MonoBehaviour
{
    public int InherentNumber;
    private void OnMouseUp()
    {
        TutorialText.Instance.TutorialEvent3132(InherentNumber);
    }

}
