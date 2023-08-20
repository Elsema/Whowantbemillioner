using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ButtonScripts : MonoBehaviour
{
    string TheName;
    public GameObject input;
    public GameObject Text;
    public static int para=100;
    float mebla;
    int mebla2;
    int mebla3;
    [SerializeField] private Slider _slider;
    [SerializeField] private Text sliderText;
    [SerializeField] private Text paraText;
    public GameObject soru1;
    public GameObject soru2;
    public GameObject soru3;
    public GameObject soru4;
    public GameObject soru5;




    public void Start()

    {
        _slider.onValueChanged.AddListener((v) =>
        {
            sliderText.text = v.ToString("0");
        });

        

    }

    public void Update()
    {
        if (para >= 200)
        {
            SceneManager.LoadScene(6);
        }
        paraText.text = "MONEY:" + para.ToString();


    }
    public void soru()
    {
        var arlist = new ArrayList()
        {
            soru1, soru2, soru3, soru4, soru5,
        };
        GameObject panels = ((GameObject)arlist[Random.Range(0, 4)]);
        panels.SetActive(true);
    }

    public void ExitButton()
    {
        Application.Quit();
    }
    
    public void TextShow()
    {
        TheName = input.GetComponent<Text>().text;
        Text.GetComponent<Text>().text = "Yarýþmaya hoþgeldiniz Sayýn " + TheName + ". Lütfen yarýþmaya hangi meblaða ile baþlayacaðýnýzý seçin. ";
    }
   
    public void On_Value_Change(float deger)
    {
        mebla = Mathf.Round(deger);
        mebla2 = Mathf.RoundToInt(mebla);
        
    }
    
    public void meblagirme()
    {
        mebla3 = mebla2;
        para = para - mebla3;
        print(para);
    }
    
    public void CevapDogru()
    {
        mebla3 = mebla3 * 2;
        para = mebla3 + para;
    }
   
    public void DevamEt()
    {
        SceneManager.LoadScene(0);
    }




}
