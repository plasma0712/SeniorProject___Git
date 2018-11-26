using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillSetactive : Singleton<SkillSetactive>
{
    public GameObject SkillUI;
    private void Start()
    {
        SkillUI.SetActive(false);
    }

    public void SetactiveTrue()
    {
        SkillUI.SetActive(true);
    }
    public void SetactiveFalse()
    {
        SkillUI.SetActive(false);
    }

}
