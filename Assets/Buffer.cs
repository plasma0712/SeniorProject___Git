using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buffer : Singleton<Buffer>
{
    [HideInInspector] public float fTowerAttack;
    [HideInInspector] public float CurrentfTowerAttack;
    [HideInInspector] public float fEnemySpeed;
    [HideInInspector] public float CurrentfEnemySpeed;
    [HideInInspector] public float fTowerDelay;
    [HideInInspector] public float CurrentfTowerDelay;

    XMLCharInfoCharacteristicData CurrentData;

    public void CurrentCharacteristicData(int _CUPV_CharacteristicName)
    {
        CurrentData = XMLCharInfoCharacteristic.Instance.GetCharacteristic((int)_CUPV_CharacteristicName);
    }

    public void Characteristic()
    {
        for (int i = 0; i < XMLCharInfoCharacteristic.Instance.CharacteristicLength(); i++)
        {
            CurrentCharacteristicData(i);
            CharacteristicActivation(CurrentData.InherentNumber);
        }
    }

    public void CharacteristicActivation(int _InherentNumber)
    {
        #region 빨강색 특성, 타워 공격력 증가
        if (_InherentNumber == 0)
        {
            fTowerAttack = 1.0f;
            CurrentfTowerAttack += fTowerAttack;
        }
        else if (_InherentNumber == 1)
        {
            fTowerAttack = 2.0f;
            CurrentfTowerAttack += fTowerAttack;
        }
        else if (_InherentNumber == 2)
        {
            fTowerAttack = 4.0f;
            CurrentfTowerAttack += fTowerAttack;
        }
        else if (_InherentNumber == 3)
        {
            fTowerAttack = 8.0f;
            CurrentfTowerAttack += fTowerAttack;
            Debug.Log(CurrentfTowerAttack);
        }
        #endregion
        #region 파랑색 특성, 적 이동속도 감소
        else if (_InherentNumber == 4)
        {
            fEnemySpeed = 0.01f;
            CurrentfEnemySpeed -= fEnemySpeed;
        }
        else if (_InherentNumber == 5)
        {
            fEnemySpeed = 0.02f;
            CurrentfEnemySpeed -= fEnemySpeed;
        }
        else if (_InherentNumber == 6)
        {
            fEnemySpeed = 0.04f;
            CurrentfEnemySpeed -= fEnemySpeed;
        }
        else if (_InherentNumber == 7)
        {
            fEnemySpeed = 0.08f;
            CurrentfEnemySpeed -= fEnemySpeed;
        }
        #endregion
        #region 노랑색 특성, 타워 공격 딜레이 감소
        else if (_InherentNumber == 8)
        {
            fTowerDelay = 0.001f;
            CurrentfTowerDelay -= fTowerDelay;
        }
        else if (_InherentNumber == 9)
        {
            fTowerDelay = 0.002f;
            CurrentfTowerDelay -= fTowerDelay;
        }
        else if (_InherentNumber == 10)
        {
            fTowerDelay = 0.004f;
            CurrentfTowerDelay -= fTowerDelay;
        }
        else if (_InherentNumber == 11)
        {
            fTowerDelay = 0.008f;
            CurrentfTowerDelay -= fTowerDelay;
        }
        #endregion
        else
        {
            return;
        }
    }

    public void CharacteristicReset()
    {
        CurrentfTowerAttack = 0;
        CurrentfEnemySpeed = 0;
        CurrentfTowerDelay = 0;
    }
}
