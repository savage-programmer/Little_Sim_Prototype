using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class ClothManager : MonoBehaviour
{
    public static Action<Cloth> ClothEquip;

    [SerializeField] private Cloth[] m_ClothsInfo;
    [SerializeField] private Transform m_Cloths;
    [SerializeField] private Transform m_NewClothsParent;

    [SerializeField] private ClothSelection m_ClothPrefab;


    [SerializeField] private Button m_LeftButton;
    [SerializeField] private Button m_RightButton;


    private int _CurrentIndex = 0; 


    private void Awake()
    {
        StartCoroutine(InstantiateCloths());
        m_LeftButton.onClick.AddListener(OnLeftButtonClick);
        m_RightButton.onClick.AddListener(OnRightButtonClick);
        

    }

    private void OnLeftButtonClick()
    {
        if (_CurrentIndex <= 0)
            _CurrentIndex = m_ClothsInfo.Length - 1;
        else
            _CurrentIndex--;

        EnableCloth(_CurrentIndex);

    }

    private void OnRightButtonClick()
    {
        if (_CurrentIndex >= m_ClothsInfo.Length - 1)
            _CurrentIndex = 0;
        else
            _CurrentIndex++;

        EnableCloth(_CurrentIndex);
    }

    private IEnumerator InstantiateCloths()
    {
        foreach (Cloth _cloth in m_ClothsInfo)
        {
            ClothSelection _clothSelection = Instantiate(m_ClothPrefab, m_NewClothsParent);
            _clothSelection.ClothInfo = _cloth;
            _clothSelection.SetClothInfo();
            yield return null;
        }

        EnableCloth(0);
    }

    private void EnableCloth(int _index)
    {
        for(int i = 0; i < m_ClothsInfo.Length; i++)
        {
            bool _active = (i == _index);

            m_NewClothsParent.GetChild(i).gameObject.SetActive(_active);
            m_Cloths.GetChild(i).gameObject.SetActive(_active);
        }
    }





}
