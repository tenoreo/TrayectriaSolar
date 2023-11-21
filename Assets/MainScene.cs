using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class MainScene : MonoBehaviour
{
    public bool targetFoundCostaRica;
    public bool targetFoundGermany;
    public bool targetFoundChile;
    public bool targetFoundPlanet;
    public bool targetFoundJune;
    public bool targetFoundDecember;
    public bool targetFoundSeptember;
    public bool targetFoundMarch;
    public bool targetFoundGuy;
    //text
    public TextMeshProUGUI alturaSolar;
    public TextMeshProUGUI anguloAcimutal;
    public TextMeshProUGUI horaDia;
    public RectTransform panelSuperior;
    public RectTransform infomacionSolarCRChile;
    /*informacion de CR-Chile*/
    public TextMeshProUGUI alturaCRChile;
    public TextMeshProUGUI alturaChileCR;
    public TextMeshProUGUI acimutalCRChile;
    public TextMeshProUGUI acimutalChileCR;
    public TextMeshProUGUI horasCRChile;
    public TextMeshProUGUI horasChileCR;
    public RectTransform infomacionSolarChileAlemania;
    /*informacion de Chile-Alemania*/
    public TextMeshProUGUI alturaChileAlemania;
    public TextMeshProUGUI alturaAlemaniaChile;
    public TextMeshProUGUI acimutalChileAlemania;
    public TextMeshProUGUI acimutalAlemaniaChile;
    public TextMeshProUGUI horasChileAlemania;
    public TextMeshProUGUI horasAlemaniaChile;
    public RectTransform infomacionSolarCRAlemania;
    /*informacion de Chile-Alemania*/
    public TextMeshProUGUI alturaCRAlemania;
    public TextMeshProUGUI alturaAlemaniaCR;
    public TextMeshProUGUI acimutalCRAlemania;
    public TextMeshProUGUI acimutalAlemaniaCR;
    public TextMeshProUGUI horasCRAlemania;
    public TextMeshProUGUI horasAlemaniaCR;
    public RectTransform infomacionSolarCRChileAlemania;
    /*informacion de CR-Chile-Alemania*/
    public TextMeshProUGUI alturaCR;
    public TextMeshProUGUI alturaChile;
    public TextMeshProUGUI alturaAlemania;
    public TextMeshProUGUI acimutalCR;
    public TextMeshProUGUI acimutalAlemania;
    public TextMeshProUGUI acimutalChile;
    public TextMeshProUGUI horasCR;
    public TextMeshProUGUI horasAlemania;
    public TextMeshProUGUI horasChile;

    public void Start()
    {
        targetFoundCostaRica = false;
        targetFoundGermany= false;
        targetFoundChile= false;
        targetFoundPlanet= false;
        targetFoundGuy = false;
        targetFoundJune= false;
        targetFoundDecember= false;
        targetFoundSeptember= false;
        targetFoundMarch= false;
        targetFoundGuy = false;
        alturaSolar.gameObject.SetActive(false);
        anguloAcimutal.gameObject.SetActive(false);
        horaDia.gameObject.SetActive(false);
        panelSuperior.gameObject.SetActive(false);
        infomacionSolarCRChile.gameObject.SetActive(false);
        infomacionSolarChileAlemania.gameObject.SetActive(false);
        infomacionSolarCRAlemania.gameObject.SetActive(false);
        infomacionSolarCRChileAlemania.gameObject.SetActive(false);
    }

    public void changeStatusCostaRica()
    {
        targetFoundCostaRica = true;
        actualizarCRMarzo();
        actualizarCRDiciembre();
        actualizarCRJunio();
        actualizarCRSeptiembre();
        actualizarCRChileAlemaniaMarzo();
        actualizarCRChileAlemaniaSeptiembre();
        actualizarCRChileAlemaniaJunio();
        actualizarCRChileAlemaniaDiciembre();
        actualizarChileCRDiciembre();
        actualizarChileCRJunio();
        actualizarChileCRMarzo();
        actualizarChileCRSeptiembre() ;
        actualizarCRAlemaniaDiciembre() ;
        actualizarCRAlemaniaJunio() ;
        actualizarCRAlemaniaMarzo() ;
        actualizarCRAlemaniaSeptiembre();
    }
    public void changeStatusInverseCostaRica()
    {
        targetFoundCostaRica = false;
        actualizarInverseCRMarzo();
        actualizarInverseCRDiciembre();
        actualizarInverseCRJunio();
        actualizarInverseCRSeptiembre();
        actualizarInverseCRChileAlemaniaMarzo();
        actualizarInverseCRChileAlemaniaSeptiembre();
        actualizarInverseCRChileAlemaniaJunio();
        actualizarInverseCRChileAlemaniaDiciembre();
        actualizarInverseChileCRDiciembre();
        actualizarInverseChileCRJunio();
        actualizarInverseChileCRMarzo();
        actualizarInverseChileCRSeptiembre();
        actualizarInverseCRAlemaniaDiciembre();
        actualizarInverseCRAlemaniaJunio();
        actualizarInverseCRAlemaniaMarzo();
        actualizarInverseCRAlemaniaSeptiembre() ;
    }
    public void changeStatusGermany()
    {
        targetFoundGermany = true;
        actualizarGermanyDiciembre();
        actualizarGermanySeptiembre();
        actualizarGermanyJunio();
        actualizarGermanyMarzo();
        actualizarCRChileAlemaniaMarzo();
        actualizarCRChileAlemaniaSeptiembre();
        actualizarCRChileAlemaniaJunio();
        actualizarCRChileAlemaniaDiciembre();
        actualizarCRAlemaniaDiciembre();
        actualizarCRAlemaniaJunio();
        actualizarCRAlemaniaMarzo();
        actualizarCRAlemaniaSeptiembre();
        actualizarChileAlemaniaDiciembre();
        actualizarChileAlemaniaJunio();
        actualizarChileAlemaniaMarzo();
        actualizarChileAlemaniaSeptiembre();
    }
    public void changeStatusInverseGermany()
    {
        targetFoundGermany = false;
        actualizarInverseGermanyDiciembre();
        actualizarInverseGermanySeptiembre();
        actualizarInverseGermanyJunio();
        actualizarInverseGermanyMarzo();
        actualizarInverseCRChileAlemaniaMarzo();
        actualizarInverseCRChileAlemaniaSeptiembre();
        actualizarInverseCRChileAlemaniaJunio();
        actualizarInverseCRChileAlemaniaDiciembre();
        actualizarInverseCRAlemaniaDiciembre();
        actualizarInverseCRAlemaniaJunio();
        actualizarInverseCRAlemaniaMarzo();
        actualizarInverseCRAlemaniaSeptiembre();
        actualizarInverseChileAlemaniaDiciembre();
        actualizarInverseChileAlemaniaJunio();
        actualizarInverseChileAlemaniaMarzo();
        actualizarInverseChileAlemaniaSeptiembre();
    }

    public void changeStatusChile()
    {
        targetFoundChile = true;
        actualizarChileSeptiembre();
        actualizarChileMarzo();
        actualizarChileDiciembre();
        actualizarChileJunio();
        actualizarCRChileAlemaniaMarzo();
        actualizarCRChileAlemaniaSeptiembre();
        actualizarCRChileAlemaniaJunio();
        actualizarCRChileAlemaniaDiciembre();
        actualizarChileAlemaniaDiciembre();
        actualizarChileAlemaniaJunio();
        actualizarChileAlemaniaMarzo();
        actualizarChileAlemaniaSeptiembre();
        actualizarChileCRDiciembre();
        actualizarChileCRJunio();
        actualizarChileCRMarzo();
        actualizarChileCRSeptiembre();
    }
    public void changeStatusInverseChile()
    {
        targetFoundChile = false;
        actualizarInverseChileSeptiembre();
        actualizarInverseChileMarzo();
        actualizarInverseChileDiciembre();
        actualizarInverseChileJunio();
        actualizarInverseCRChileAlemaniaMarzo();
        actualizarInverseCRChileAlemaniaSeptiembre();
        actualizarInverseCRChileAlemaniaJunio();
        actualizarInverseCRChileAlemaniaDiciembre();
        actualizarInverseChileAlemaniaDiciembre();
        actualizarInverseChileAlemaniaJunio();
        actualizarInverseChileAlemaniaMarzo();
        actualizarInverseChileAlemaniaSeptiembre();
        actualizarInverseChileCRDiciembre();
        actualizarInverseChileCRJunio();
        actualizarInverseChileCRMarzo();
        actualizarInverseChileCRSeptiembre();
    }
    public void changeStatusPlanet()
    {
        targetFoundPlanet = true;
    }
    public void changeStatusInversePlanet()
    {
        targetFoundPlanet = false;
    }

    public void changeStatusJune() 
    {
        targetFoundJune = true;
        actualizarCRMarzo();
        actualizarCRDiciembre();
        actualizarCRSeptiembre();
        actualizarChileMarzo();
        actualizarChileDiciembre();
        actualizarChileSeptiembre();
        actualizarGermanyDiciembre();
        actualizarGermanyMarzo();
        actualizarGermanySeptiembre();
        actualizarCRChileAlemaniaMarzo();
        actualizarCRChileAlemaniaDiciembre();
        actualizarCRChileAlemaniaSeptiembre();
        actualizarChileAlemaniaDiciembre();
        actualizarChileAlemaniaMarzo();
        actualizarChileAlemaniaSeptiembre();
        actualizarChileCRSeptiembre();
        actualizarChileCRMarzo();
        actualizarChileCRDiciembre();
        actualizarCRAlemaniaDiciembre();
        actualizarCRAlemaniaSeptiembre();
        actualizarCRAlemaniaMarzo();
    }
    public void changeStatusInverseJune()
    {
        targetFoundJune = false;
        actualizarInverseCRMarzo();
        actualizarInverseCRDiciembre();
    }
    public void changeStatusMarch()
    {
        targetFoundMarch = true;
        actualizarCRDiciembre();
        actualizarCRJunio();
        actualizarCRSeptiembre();
        actualizarChileDiciembre();
        actualizarChileJunio();
        actualizarChileSeptiembre();
        actualizarGermanyDiciembre();
        actualizarGermanyJunio();
        actualizarGermanySeptiembre();
        actualizarCRChileAlemaniaJunio();
        actualizarCRChileAlemaniaDiciembre();
        actualizarCRChileAlemaniaSeptiembre();
        actualizarChileAlemaniaDiciembre();
        actualizarChileAlemaniaJunio();
        actualizarChileAlemaniaSeptiembre();
        actualizarChileCRSeptiembre();
        actualizarChileCRJunio();
        actualizarChileCRDiciembre();
        actualizarCRAlemaniaDiciembre();
        actualizarCRAlemaniaSeptiembre();
        actualizarCRAlemaniaJunio();
    }
    public void changeStatusInverseMarch()
    {
        targetFoundMarch = false;
        actualizarCRDiciembre();
        actualizarCRJunio();
        actualizarCRSeptiembre();
        actualizarChileDiciembre();
        actualizarChileJunio();
        actualizarChileSeptiembre();
        actualizarGermanyDiciembre();
        actualizarGermanyJunio();
        actualizarGermanySeptiembre();
        actualizarCRChileAlemaniaJunio();
        actualizarCRChileAlemaniaDiciembre();
        actualizarCRChileAlemaniaSeptiembre();
        actualizarChileAlemaniaDiciembre();
        actualizarChileAlemaniaJunio();
        actualizarChileAlemaniaSeptiembre();
        actualizarChileCRSeptiembre();
        actualizarChileCRJunio();
        actualizarChileCRDiciembre();
        actualizarCRAlemaniaDiciembre();
        actualizarCRAlemaniaSeptiembre();
        actualizarCRAlemaniaJunio();
    }
    public void changeStatusDecember()
    {
        targetFoundDecember = true;
        actualizarCRMarzo();
        actualizarCRJunio();
        actualizarCRSeptiembre();
        actualizarChileMarzo();
        actualizarChileJunio();
        actualizarChileSeptiembre();
        actualizarGermanyJunio();
        actualizarGermanyMarzo();
        actualizarGermanySeptiembre();
        actualizarCRChileAlemaniaMarzo();
        actualizarCRChileAlemaniaJunio();
        actualizarCRChileAlemaniaSeptiembre();
        actualizarChileAlemaniaJunio();
        actualizarChileAlemaniaMarzo();
        actualizarChileAlemaniaSeptiembre();
        actualizarChileCRSeptiembre();
        actualizarChileCRJunio();
        actualizarChileCRMarzo();
        actualizarCRAlemaniaSeptiembre();
        actualizarCRAlemaniaJunio();
        actualizarCRAlemaniaMarzo();

    }
    public void changeStatusInverseDecember()
    {
        targetFoundDecember= false;
        actualizarInverseCRMarzo();
    }
    public void changeStatusSeptember()
    {
        targetFoundSeptember = true;
        actualizarCRMarzo() ;
        actualizarCRDiciembre();
        actualizarCRJunio();
        actualizarChileMarzo();
        actualizarChileDiciembre();
        actualizarChileJunio();
        actualizarGermanyDiciembre();
        actualizarGermanyJunio();
        actualizarGermanyMarzo();
        actualizarCRChileAlemaniaMarzo();
        actualizarCRChileAlemaniaJunio();
        actualizarCRChileAlemaniaDiciembre();
        actualizarChileAlemaniaDiciembre();
        actualizarChileAlemaniaJunio();
        actualizarChileAlemaniaMarzo();
        actualizarChileCRDiciembre();
        actualizarChileCRJunio();
        actualizarChileCRMarzo();
        actualizarCRAlemaniaDiciembre();
        actualizarCRAlemaniaJunio();
        actualizarCRAlemaniaMarzo();
        
    }
    public void changeStatusInverseSeptember()
    {
        targetFoundSeptember = false;
        actualizarInverseCRMarzo();
    }
    public void changeStatusGuy()
    {
        targetFoundGuy = true;
    }
    public void changeStatusInverseGuy()
    {
        targetFoundGuy = false ;
    }
    public void goHome()
    {
        SceneManager.LoadSceneAsync(0);
    }
    public void Update()
    {
        //marzo
       /* if (targetFoundJune && targetFoundSeptember && targetFoundDecember)
        {
            alturaSolar.text = "Altura solar: 79°";
            anguloAcimutal.text = "Ángulo acimutal: -153°";
            horaDia.text = "Horas del día: 12h";
            //Debug.Log("JSD");
            //costa rica
            if (targetFoundCostaRica && !targetFoundChile && !targetFoundGermany)
            {
                Debug.Log("entro CR");
                interfaz.alturaSolar.text = "Altura solar: 79°";
                interfaz.anguloAcimutal.text = "Ángulo acimutal: -153°";
                interfaz.horaDia.text = "Horas del día: 12h";
            }
            //chile
            else if (!targetFoundCostaRica && targetFoundChile && !targetFoundGermany)
            {
                interfaz.alturaSolar.text = "Altura solar: 47°";
                interfaz.anguloAcimutal.text = "Ángulo acimutal: -0,7°";
                interfaz.horaDia.text = "Horas del día: 12h";
            }
            //alemania
            else if (!targetFoundCostaRica && !targetFoundChile && targetFoundGermany)
            {
                interfaz.alturaSolar.text = "Altura solar: 37°";
                interfaz.anguloAcimutal.text = "Ángulo acimutal:172°";
                interfaz.horaDia.text = "Horas del día: 12h";
            }
            //CR-Chile
            else if (targetFoundCostaRica && targetFoundChile && !targetFoundGermany)
            {
                interfaz.infomacionSolarCRChile.gameObject.SetActive(true);
                interfaz.alturaCRChile.text = "79°";
                interfaz.alturaChileCR.text = "47°";
                interfaz.acimutalCRChile.text = "-153°";
                interfaz.acimutalChileCR.text = "-0,7°";
                interfaz.horasCRChile.text = "12h";
                interfaz.horasChileCR.text = "12h";
            }
            //Chile-Alemania
            else if (!targetFoundCostaRica && targetFoundChile && targetFoundGermany)
            {
                interfaz.infomacionSolarChileAlemania.gameObject.SetActive(true);
                interfaz.alturaChileAlemania.text = "30.2°";
                interfaz.alturaAlemaniaChile.text = "37°";
                interfaz.acimutalChileAlemania.text = "30.2°";
                interfaz.acimutalAlemaniaChile.text = "172°";
                interfaz.horasChileAlemania.text = "12h";
                interfaz.horasAlemaniaChile.text = "12h";
            }
            //CostaRica-Alemania
            else if (targetFoundCostaRica && !targetFoundChile && targetFoundGermany)
            {
                interfaz.infomacionSolarCRAlemania.gameObject.SetActive(true);
                interfaz.alturaCRAlemania.text = "79°";
                interfaz.alturaAlemaniaCR.text = "37°";
                interfaz.acimutalCRAlemania.text = "-153°";
                interfaz.acimutalAlemaniaCR.text = "172°";
                interfaz.horasCRAlemania.text = "12h";
                interfaz.horasAlemaniaCR.text = "12h";
            }
            //CostaRica-Chile-Alemania
            else if (targetFoundCostaRica && targetFoundChile && targetFoundGermany)
            {
                interfaz.infomacionSolarCRChileAlemania.gameObject.SetActive(true);
                interfaz.alturaCR.text = "79°";
                interfaz.alturaAlemania.text = "37°";
                interfaz.alturaChile.text = "47°";
                interfaz.acimutalCR.text = "-153°";
                interfaz.acimutalAlemania.text = "172°";
                interfaz.acimutalChile.text = "-0,7°";
                interfaz.horasCR.text = "12h";
                interfaz.horasAlemania.text = "12h";
                interfaz.horasChile.text = "12h";
            }
        }
        //junio
        else if (!targetFoundJune && targetFoundMarch && targetFoundSeptember && targetFoundDecember)
        {
            //costa rica
            if (targetFoundCostaRica && !targetFoundChile && !targetFoundGermany)
            {
                interfaz.alturaSolar.text = "Altura solar: 75°";
                interfaz.anguloAcimutal.text = "Ángulo acimutal: -23°";
                interfaz.horaDia.text = "Horas del día: 12h";
            }
            //chile
            else if (!targetFoundCostaRica && targetFoundChile && !targetFoundGermany)
            {
                interfaz.alturaSolar.text = "Altura solar: 24°";
                interfaz.anguloAcimutal.text = "Ángulo acimutal: -1.9°";
                interfaz.horaDia.text = "Horas del día: 9h";
            }
            //alemania
            else if (!targetFoundCostaRica && !targetFoundChile && targetFoundGermany)
            {
                interfaz.alturaSolar.text = "Altura solar: 60°";
                interfaz.anguloAcimutal.text = "Ángulo acimutal: 171°";
                interfaz.horaDia.text = "Horas del día: 16h";
            }
            //CR-Chile
            else if (targetFoundCostaRica && targetFoundChile && !targetFoundGermany)
            {
                interfaz.infomacionSolarCRChile.gameObject.SetActive(true);
                interfaz.alturaCRChile.text = "75°";
                interfaz.alturaChileCR.text = "24°";
                interfaz.acimutalCRChile.text = "-23°";
                interfaz.acimutalChileCR.text = "-1,9°";
                interfaz.horasCRChile.text = "12h";
                interfaz.horasChileCR.text = "9h";
            }
            //Chile-Alemania
            else if (!targetFoundCostaRica && targetFoundChile && targetFoundGermany)
            {
                interfaz.infomacionSolarChileAlemania.gameObject.SetActive(true);
                interfaz.alturaChileAlemania.text = "30.2°";
                interfaz.alturaAlemaniaChile.text = "60°";
                interfaz.acimutalChileAlemania.text = "30.2°";
                interfaz.acimutalAlemaniaChile.text = "171°";
                interfaz.horasChileAlemania.text = "9h";
                interfaz.horasAlemaniaChile.text = "16h";
            }
            //CostaRica-Alemania
            else if (targetFoundCostaRica && !targetFoundChile && targetFoundGermany)
            {
                interfaz.infomacionSolarCRAlemania.gameObject.SetActive(true);
                interfaz.alturaCRAlemania.text = "75°";
                interfaz.alturaAlemaniaCR.text = "60°";
                interfaz.acimutalCRAlemania.text = "-23°";
                interfaz.acimutalAlemaniaCR.text = "171°";
                interfaz.horasCRAlemania.text = "12h";
                interfaz.horasAlemaniaCR.text = "16h";
            }
            //CostaRica-Chile-Alemania
            else if (targetFoundCostaRica && targetFoundChile && targetFoundGermany)
            {
                interfaz.infomacionSolarCRChileAlemania.gameObject.SetActive(true);
                interfaz.alturaCR.text = "75°";
                interfaz.alturaAlemania.text = "60°";
                interfaz.alturaChile.text = "24°";
                interfaz.acimutalCR.text = "-23°";
                interfaz.acimutalAlemania.text = "171°";
                interfaz.acimutalChile.text = "-1.9°";
                interfaz.horasCR.text = "12h";
                interfaz.horasAlemania.text = "16h";
                interfaz.horasChile.text = "9h";
            }
        }
        //diciembre
        else if (!targetFoundJune && !targetFoundMarch && !targetFoundSeptember && targetFoundDecember)
        {
            //costa rica
            if (targetFoundCostaRica && !targetFoundChile && !targetFoundGermany)
            {
                interfaz.alturaSolar.text = "Altura solar: 55°";
                interfaz.anguloAcimutal.text = "Ángulo acimutal: -168°";
                interfaz.horaDia.text = "Horas del día: 11h";
            }
            //chile
            else if (!targetFoundCostaRica && targetFoundChile && !targetFoundGermany)
            {
                interfaz.alturaSolar.text = "Altura solar: 70°";
                interfaz.anguloAcimutal.text = "Ángulo acimutal: -8°";
                interfaz.horaDia.text = "Horas del día: 15h";
            }
            //alemania
            else if (!targetFoundCostaRica && !targetFoundChile && targetFoundGermany)
            {
                interfaz.alturaSolar.text = "Altura solar: 13°";
                interfaz.anguloAcimutal.text = "Ángulo acimutal:176°";
                interfaz.horaDia.text = "Horas del día: 7h";
            }
            //CR-Chile
            else if (targetFoundCostaRica && targetFoundChile && !targetFoundGermany)
            {
                interfaz.infomacionSolarCRChile.gameObject.SetActive(true);
                interfaz.alturaCRChile.text = "55°";
                interfaz.alturaChileCR.text = "70°";
                interfaz.acimutalCRChile.text = "-168°";
                interfaz.acimutalChileCR.text = "-8°";
                interfaz.horasCRChile.text = "11h";
                interfaz.horasChileCR.text = "15h";
            }
            //Chile-Alemania
            else if (!targetFoundCostaRica && targetFoundChile && targetFoundGermany)
            {
                interfaz.infomacionSolarChileAlemania.gameObject.SetActive(true);
                interfaz.alturaChileAlemania.text = "30.2°";
                interfaz.alturaAlemaniaChile.text = "13°";
                interfaz.acimutalChileAlemania.text = "30.2°";
                interfaz.acimutalAlemaniaChile.text = "176°";
                interfaz.horasChileAlemania.text = "15h";
                interfaz.horasAlemaniaChile.text = "7h";
            }
            //CostaRica-Alemania
            else if (targetFoundCostaRica && !targetFoundChile && targetFoundGermany)
            {
                interfaz.infomacionSolarCRAlemania.gameObject.SetActive(true);
                interfaz.alturaCRAlemania.text = "55°";
                interfaz.alturaAlemaniaCR.text = "13°";
                interfaz.acimutalCRAlemania.text = "-168°";
                interfaz.acimutalAlemaniaCR.text = "176°";
                interfaz.horasCRAlemania.text = "11h";
                interfaz.horasAlemaniaCR.text = "7h";
            }
            //CostaRica-Chile-Alemania
            else if (targetFoundCostaRica && targetFoundChile && targetFoundGermany)
            {
                interfaz.infomacionSolarCRChileAlemania.gameObject.SetActive(true);
                interfaz.alturaCR.text = "55°";
                interfaz.alturaAlemania.text = "60°";
                interfaz.alturaChile.text = "70°";
                interfaz.acimutalCR.text = "-168°";
                interfaz.acimutalAlemania.text = "176°";
                interfaz.acimutalChile.text = "-8°";
                interfaz.horasCR.text = "11h";
                interfaz.horasAlemania.text = "7h";
                interfaz.horasChile.text = "15h";
            }
        }
        //septiembre
        else if (targetFoundJune && !targetFoundMarch && !targetFoundSeptember && !targetFoundDecember)
        {
            //costa rica
            if (targetFoundCostaRica && !targetFoundChile && !targetFoundGermany)
            {
                interfaz.alturaSolar.text = "Altura solar: 77°";
                interfaz.anguloAcimutal.text = "Ángulo acimutal: -136°";
                interfaz.horaDia.text = "Horas del día: 12h";
            }
            //chile
            else if (!targetFoundCostaRica && targetFoundChile && !targetFoundGermany)
            {
                interfaz.alturaSolar.text = "Altura solar: 46°";
                interfaz.anguloAcimutal.text = "Ángulo acimutal: -6°";
                interfaz.horaDia.text = "Horas del día: 12h";
            }
            //alemania
            else if (!targetFoundCostaRica && !targetFoundChile && targetFoundGermany)
            {
                interfaz.alturaSolar.text = "Altura solar: 38°";
                interfaz.anguloAcimutal.text = "Ángulo acimutal: 176°";
                interfaz.horaDia.text = "Horas del día: 12h";
            }
            //CR-Chile
            else if (targetFoundCostaRica && targetFoundChile && !targetFoundGermany)
            {
                interfaz.infomacionSolarCRChile.gameObject.SetActive(true);
                interfaz.alturaCRChile.text = "77°";
                interfaz.alturaChileCR.text = "46°";
                interfaz.acimutalCRChile.text = "-136°";
                interfaz.acimutalChileCR.text = "-6°";
                interfaz.horasCRChile.text = "12h";
                interfaz.horasChileCR.text = "12h";
            }
            //Chile-Alemania
            else if (!targetFoundCostaRica && targetFoundChile && targetFoundGermany)
            {
                interfaz.infomacionSolarChileAlemania.gameObject.SetActive(true);
                interfaz.alturaChileAlemania.text = "30.2°";
                interfaz.alturaAlemaniaChile.text = "37°";
                interfaz.acimutalChileAlemania.text = "30.2°";
                interfaz.acimutalAlemaniaChile.text = "172°";
                interfaz.horasChileAlemania.text = "15h";
                interfaz.horasAlemaniaChile.text = "12h";
            }
            //CostaRica-Alemania
            else if (targetFoundCostaRica && !targetFoundChile && targetFoundGermany)
            {
                interfaz.infomacionSolarCRAlemania.gameObject.SetActive(true);
                interfaz.alturaCRAlemania.text = "77°";
                interfaz.alturaAlemaniaCR.text = "37°";
                interfaz.acimutalCRAlemania.text = "-136°";
                interfaz.acimutalAlemaniaCR.text = "172°";
                interfaz.horasCRAlemania.text = "12h";
                interfaz.horasAlemaniaCR.text = "12h";
            }
            //CostaRica-Chile-Alemania
            else if (targetFoundCostaRica && targetFoundChile && targetFoundGermany)
            {
                interfaz.infomacionSolarCRChileAlemania.gameObject.SetActive(true);
                interfaz.alturaCR.text = "77°";
                interfaz.alturaAlemania.text = "38°";
                interfaz.alturaChile.text = "46°";
                interfaz.acimutalCR.text = "-136°";
                interfaz.acimutalAlemania.text = "176°";
                interfaz.acimutalChile.text = "-6°";
                interfaz.horasCR.text = "12h";
                interfaz.horasAlemania.text = "12h";
                interfaz.horasChile.text = "12h";
            }
        }*/
    }
    //costaRica
    public void actualizarCRMarzo()
    {
        if (targetFoundJune && targetFoundSeptember && targetFoundDecember && targetFoundCostaRica)
        {
            panelSuperior.gameObject.SetActive(true);
            alturaSolar.gameObject.SetActive(true);
            anguloAcimutal.gameObject.SetActive(true);
            horaDia.gameObject.SetActive(true);
            alturaSolar.text = "Altura solar: 79°";
            anguloAcimutal.text = "Ángulo acimutal: -153°";
            horaDia.text = "Horas del día: 12h";
        }
    }

    public void actualizarCRDiciembre()
    {
        if (targetFoundJune && targetFoundSeptember && targetFoundMarch && targetFoundCostaRica)
        {
            panelSuperior.gameObject.SetActive(true);
            alturaSolar.gameObject.SetActive(true);
            anguloAcimutal.gameObject.SetActive(true);
            horaDia.gameObject.SetActive(true);
            alturaSolar.text = "Altura solar: 55°";
            anguloAcimutal.text = "Ángulo acimutal: -168°";
            horaDia.text = "Horas del día: 11h";
        }
    }
    public void actualizarCRSeptiembre()
    {
        if (targetFoundJune && targetFoundMarch && targetFoundDecember && targetFoundCostaRica)
        {
            panelSuperior.gameObject.SetActive(true);
            alturaSolar.gameObject.SetActive(true);
            anguloAcimutal.gameObject.SetActive(true);
            horaDia.gameObject.SetActive(true);
            alturaSolar.text = "Altura solar: 77°";
            anguloAcimutal.text = "Ángulo acimutal: -136°";
            horaDia.text = "Horas del día: 12h";
        }
    }
    public void actualizarCRJunio()
    {
        if (targetFoundMarch && targetFoundSeptember && targetFoundDecember && targetFoundCostaRica)
        {
            panelSuperior.gameObject.SetActive(true);
            alturaSolar.gameObject.SetActive(true);
            anguloAcimutal.gameObject.SetActive(true);
            horaDia.gameObject.SetActive(true);
            alturaSolar.text = "Altura solar: 75°";
            anguloAcimutal.text = "Ángulo acimutal: -23°";
            horaDia.text = "Horas del día: 12h";
        }
    }

    public void actualizarInverseCRMarzo()
    {
        if (!targetFoundJune && !targetFoundSeptember && !targetFoundDecember && !targetFoundCostaRica)
        {
            panelSuperior.gameObject.SetActive(false);
            alturaSolar.gameObject.SetActive(false);
            anguloAcimutal.gameObject.SetActive(false);
            horaDia.gameObject.SetActive(false);
            alturaSolar.text = "";
            anguloAcimutal.text = "";
            horaDia.text = "";
        }
    }
    public void actualizarInverseCRDiciembre()
    {
        if (!targetFoundJune && !targetFoundSeptember && !targetFoundMarch && !targetFoundCostaRica)
        {
            panelSuperior.gameObject.SetActive(false);
            alturaSolar.gameObject.SetActive(false);
            anguloAcimutal.gameObject.SetActive(false);
            horaDia.gameObject.SetActive(false);
            alturaSolar.text = "";
            anguloAcimutal.text = "";
            horaDia.text = "";
        }
    }
    public void actualizarInverseCRSeptiembre()
    {
        if (!targetFoundJune && !targetFoundMarch && !targetFoundDecember && !targetFoundCostaRica)
        {
            panelSuperior.gameObject.SetActive(false);
            alturaSolar.gameObject.SetActive(false);
            anguloAcimutal.gameObject.SetActive(false);
            horaDia.gameObject.SetActive(false);
            alturaSolar.text = "";
            anguloAcimutal.text = "";
            horaDia.text = "";
        }
    }
    public void actualizarInverseCRJunio()
    {
        if (!targetFoundMarch && !targetFoundSeptember && !targetFoundDecember && !targetFoundCostaRica)
        {
            panelSuperior.gameObject.SetActive(false);
            alturaSolar.gameObject.SetActive(false);
            anguloAcimutal.gameObject.SetActive(false);
            horaDia.gameObject.SetActive(false);
            alturaSolar.text = "";
            anguloAcimutal.text = "";
            horaDia.text = "";
        }
    }
    //alemania
    public void actualizarGermanyMarzo()
    {
        if (targetFoundJune && targetFoundSeptember && targetFoundDecember && targetFoundCostaRica)
        {
            panelSuperior.gameObject.SetActive(true);
            alturaSolar.gameObject.SetActive(true);
            anguloAcimutal.gameObject.SetActive(true);
            horaDia.gameObject.SetActive(true);
            alturaSolar.text = "Altura solar: 37°";
            anguloAcimutal.text = "Ángulo acimutal:172°";
            horaDia.text = "Horas del día: 12h";
        }
    }

    public void actualizarGermanyDiciembre()
    {
        if (targetFoundJune && targetFoundSeptember && targetFoundMarch && targetFoundCostaRica)
        {
            panelSuperior.gameObject.SetActive(true);
            alturaSolar.gameObject.SetActive(true);
            anguloAcimutal.gameObject.SetActive(true);
            horaDia.gameObject.SetActive(true);
            alturaSolar.text = "Altura solar: 13°";
            anguloAcimutal.text = "Ángulo acimutal:176°";
            horaDia.text = "Horas del día: 7h";
        }
    }
    public void actualizarGermanySeptiembre()
    {
        if (targetFoundJune && targetFoundMarch && targetFoundDecember && targetFoundCostaRica)
        {
            panelSuperior.gameObject.SetActive(true);
            alturaSolar.gameObject.SetActive(true);
            anguloAcimutal.gameObject.SetActive(true);
            horaDia.gameObject.SetActive(true);
            alturaSolar.text = "Altura solar: 38°";
            anguloAcimutal.text = "Ángulo acimutal: 176°";
            horaDia.text = "Horas del día: 12h";
        }
    }
    public void actualizarGermanyJunio()
    {
        if (targetFoundMarch && targetFoundSeptember && targetFoundDecember && targetFoundCostaRica)
        {
            panelSuperior.gameObject.SetActive(true);
            alturaSolar.gameObject.SetActive(true);
            anguloAcimutal.gameObject.SetActive(true);
            horaDia.gameObject.SetActive(true);
            alturaSolar.text = "Altura solar: 60°";
            anguloAcimutal.text = "Ángulo acimutal: 171°";
            horaDia.text = "Horas del día: 16h";
        }
    }

    public void actualizarInverseGermanyMarzo()
    {
        if (targetFoundJune && targetFoundSeptember && targetFoundDecember && targetFoundCostaRica)
        {
            panelSuperior.gameObject.SetActive(false);
            alturaSolar.gameObject.SetActive(false);
            anguloAcimutal.gameObject.SetActive(false);
            horaDia.gameObject.SetActive(false);
            alturaSolar.text = "";
            anguloAcimutal.text = "";
            horaDia.text = "";
        }
    }
    public void actualizarInverseGermanyDiciembre()
    {
        if (targetFoundJune && targetFoundSeptember && targetFoundMarch && targetFoundCostaRica)
        {
            panelSuperior.gameObject.SetActive(false);
            alturaSolar.gameObject.SetActive(false);
            anguloAcimutal.gameObject.SetActive(false);
            horaDia.gameObject.SetActive(false);
            alturaSolar.text = "";
            anguloAcimutal.text = "";
            horaDia.text = "";
        }
    }
    public void actualizarInverseGermanySeptiembre()
    {
        if (targetFoundJune && targetFoundMarch && targetFoundDecember && targetFoundCostaRica)
        {
            panelSuperior.gameObject.SetActive(false);
            alturaSolar.gameObject.SetActive(false);
            anguloAcimutal.gameObject.SetActive(false);
            horaDia.gameObject.SetActive(false);
            alturaSolar.text = "";
            anguloAcimutal.text = "";
            horaDia.text = "";
        }
    }
    public void actualizarInverseGermanyJunio()
    {
        if (targetFoundMarch && targetFoundSeptember && targetFoundDecember && targetFoundCostaRica)
        {
            panelSuperior.gameObject.SetActive(false);
            alturaSolar.gameObject.SetActive(false);
            anguloAcimutal.gameObject.SetActive(false);
            horaDia.gameObject.SetActive(false);
            alturaSolar.text = "";
            anguloAcimutal.text = "";
            horaDia.text = "";
        }
    }

    //chile
    public void actualizarChileMarzo()
    {
        if (targetFoundJune && targetFoundSeptember && targetFoundDecember && targetFoundCostaRica)
        {
            panelSuperior.gameObject.SetActive(true);
            alturaSolar.gameObject.SetActive(true);
            anguloAcimutal.gameObject.SetActive(true);
            horaDia.gameObject.SetActive(true);
            alturaSolar.text = "Altura solar: 47°";
            anguloAcimutal.text = "Ángulo acimutal: -0,7°";
            horaDia.text = "Horas del día: 12h";
        }
    }

    public void actualizarChileDiciembre()
    {
        if (targetFoundJune && targetFoundSeptember && targetFoundMarch && targetFoundCostaRica)
        {
            panelSuperior.gameObject.SetActive(true);
            alturaSolar.gameObject.SetActive(true);
            anguloAcimutal.gameObject.SetActive(true);
            horaDia.gameObject.SetActive(true);
            alturaSolar.text = "Altura solar: 70°";
            anguloAcimutal.text = "Ángulo acimutal: -8°";
            horaDia.text = "Horas del día: 15h";
        }
    }
    public void actualizarChileSeptiembre()
    {
        if (targetFoundJune && targetFoundMarch && targetFoundDecember && targetFoundCostaRica)
        {
            panelSuperior.gameObject.SetActive(true);
            alturaSolar.gameObject.SetActive(true);
            anguloAcimutal.gameObject.SetActive(true);
            horaDia.gameObject.SetActive(true);
            alturaSolar.text = "Altura solar: 46°";
            anguloAcimutal.text = "Ángulo acimutal: -6°";
            horaDia.text = "Horas del día: 12h";
        }
    }
    public void actualizarChileJunio()
    {
        if (targetFoundMarch && targetFoundSeptember && targetFoundDecember && targetFoundCostaRica)
        {
            panelSuperior.gameObject.SetActive(true);
            alturaSolar.gameObject.SetActive(true);
            anguloAcimutal.gameObject.SetActive(true);
            horaDia.gameObject.SetActive(true);
            alturaSolar.text = "Altura solar: 24°";
            anguloAcimutal.text = "Ángulo acimutal: -1.9°";
            horaDia.text = "Horas del día: 9h";
        }
    }

    public void actualizarInverseChileMarzo()
    {
        if (targetFoundJune && targetFoundSeptember && targetFoundDecember && targetFoundCostaRica)
        {
            panelSuperior.gameObject.SetActive(false);
            alturaSolar.gameObject.SetActive(false);
            anguloAcimutal.gameObject.SetActive(false);
            horaDia.gameObject.SetActive(false);
            alturaSolar.text = "";
            anguloAcimutal.text = "";
            horaDia.text = "";
        }
    }
    public void actualizarInverseChileDiciembre()
    {
        if (targetFoundJune && targetFoundSeptember && targetFoundMarch && targetFoundCostaRica)
        {
            panelSuperior.gameObject.SetActive(false);
            alturaSolar.gameObject.SetActive(false);
            anguloAcimutal.gameObject.SetActive(false);
            horaDia.gameObject.SetActive(false);
            alturaSolar.text = "";
            anguloAcimutal.text = "";
            horaDia.text = "";
        }
    }
    public void actualizarInverseChileSeptiembre()
    {
        if (targetFoundJune && targetFoundMarch && targetFoundDecember && targetFoundCostaRica)
        {
            panelSuperior.gameObject.SetActive(false);
            alturaSolar.gameObject.SetActive(false);
            anguloAcimutal.gameObject.SetActive(false);
            horaDia.gameObject.SetActive(false);
            alturaSolar.text = "";
            anguloAcimutal.text = "";
            horaDia.text = "";
        }
    }
    public void actualizarInverseChileJunio()
    {
        if (targetFoundMarch && targetFoundSeptember && targetFoundDecember && targetFoundCostaRica)
        {
            panelSuperior.gameObject.SetActive(false);
            alturaSolar.gameObject.SetActive(false);
            anguloAcimutal.gameObject.SetActive(false);
            horaDia.gameObject.SetActive(false);
            alturaSolar.text = "";
            anguloAcimutal.text = "";
            horaDia.text = "";
        }
    }
    //chile-CR
    public void actualizarChileCRMarzo()
    {
        if (targetFoundJune && targetFoundSeptember && targetFoundDecember && targetFoundCostaRica && targetFoundChile)
        {
                panelSuperior.gameObject.SetActive(false);
                alturaSolar.gameObject.SetActive(false);
                anguloAcimutal.gameObject.SetActive(false);
                horaDia.gameObject.SetActive(false);
                infomacionSolarCRChile.gameObject.SetActive(true);
                alturaCRChile.text = "79°";
                alturaChileCR.text = "47°";
                acimutalCRChile.text = "-153°";
                acimutalChileCR.text = "-0,7°";
                horasCRChile.text = "12h";
                horasChileCR.text = "12h";
        }
        
    }

    public void actualizarChileCRDiciembre()
    {
        if (targetFoundMarch && targetFoundSeptember && targetFoundJune && targetFoundCostaRica && targetFoundChile)
        {
                panelSuperior.gameObject.SetActive(false);
                alturaSolar.gameObject.SetActive(false);
                anguloAcimutal.gameObject.SetActive(false);
                horaDia.gameObject.SetActive(false);
                infomacionSolarCRChile.gameObject.SetActive(true);
                alturaCRChile.text = "55°";
                alturaChileCR.text = "70°";
                acimutalCRChile.text = "-168°";
                acimutalChileCR.text = "-8°";
                horasCRChile.text = "11h";
                horasChileCR.text = "15h";
        }
        
    }
    public void actualizarChileCRSeptiembre()
    {
        if (targetFoundMarch && targetFoundJune && targetFoundDecember && targetFoundCostaRica && targetFoundChile)
        {
                panelSuperior.gameObject.SetActive(false);
                alturaSolar.gameObject.SetActive(false);
                anguloAcimutal.gameObject.SetActive(false);
                horaDia.gameObject.SetActive(false);
                infomacionSolarCRChile.gameObject.SetActive(true);
                alturaCRChile.text = "77°";
                alturaChileCR.text = "46°";
                acimutalCRChile.text = "-136°";
                acimutalChileCR.text = "-6°";
                horasCRChile.text = "12h";
                horasChileCR.text = "12h";
            }
    }
    public void actualizarChileCRJunio()
    {
        if (targetFoundMarch && targetFoundSeptember && targetFoundDecember && targetFoundCostaRica && targetFoundChile)
        {
                panelSuperior.gameObject.SetActive(false);
                alturaSolar.gameObject.SetActive(false);
                anguloAcimutal.gameObject.SetActive(false);
                horaDia.gameObject.SetActive(false);
                infomacionSolarCRChile.gameObject.SetActive(true);
                alturaCRChile.text = "75°";
                alturaChileCR.text = "24°";
                acimutalCRChile.text = "-23°";
                acimutalChileCR.text = "-1,9°";
                horasCRChile.text = "12h";
                horasChileCR.text = "9h";
            }
        
    }

    public void actualizarInverseChileCRMarzo()
    {
        if (!targetFoundJune && !targetFoundSeptember && !targetFoundDecember && !targetFoundCostaRica && !targetFoundChile)
        {
                panelSuperior.gameObject.SetActive(false);
                alturaSolar.gameObject.SetActive(false);
                anguloAcimutal.gameObject.SetActive(false);
                horaDia.gameObject.SetActive(false);
                infomacionSolarCRChile.gameObject.SetActive(false);
                alturaCRChile.text = "";
                alturaChileCR.text = "";
                acimutalCRChile.text = "";
                acimutalChileCR.text = "";
                horasCRChile.text = "";
                horasChileCR.text = "";
            }
        
    }
    public void actualizarInverseChileCRDiciembre()
    {
        if (!targetFoundMarch && !targetFoundSeptember && !targetFoundJune && !targetFoundCostaRica && !targetFoundChile)
        {
            panelSuperior.gameObject.SetActive(false);
            alturaSolar.gameObject.SetActive(false);
            anguloAcimutal.gameObject.SetActive(false);
            horaDia.gameObject.SetActive(false);
            infomacionSolarCRChile.gameObject.SetActive(false);
            alturaCRChile.text = "";
            alturaChileCR.text = "";
            acimutalCRChile.text = "";
            acimutalChileCR.text = "";
            horasCRChile.text = "";
            horasChileCR.text = "";
        }
        
    }
    public void actualizarInverseChileCRSeptiembre()
    {
            if (!targetFoundMarch && !targetFoundJune && !targetFoundDecember && targetFoundCostaRica && targetFoundChile)
            {
                panelSuperior.gameObject.SetActive(false);
                alturaSolar.gameObject.SetActive(false);
                anguloAcimutal.gameObject.SetActive(false);
                horaDia.gameObject.SetActive(false);
                infomacionSolarCRChile.gameObject.SetActive(false);
                alturaCRChile.text = "";
                alturaChileCR.text = "";
                acimutalCRChile.text = "";
                acimutalChileCR.text = "";
                horasCRChile.text = "";
                horasChileCR.text = "";
            }
    }
    public void actualizarInverseChileCRJunio()
    {
            if (!targetFoundMarch && !targetFoundSeptember && !targetFoundDecember && targetFoundCostaRica && targetFoundChile)
            {
                panelSuperior.gameObject.SetActive(false);
                alturaSolar.gameObject.SetActive(false);
                anguloAcimutal.gameObject.SetActive(false);
                horaDia.gameObject.SetActive(false);
                infomacionSolarCRChile.gameObject.SetActive(false);
                alturaCRChile.text = "";
                alturaChileCR.text = "";
                acimutalCRChile.text = "";
                acimutalChileCR.text = "";
                horasCRChile.text = "";
                horasChileCR.text = "";
            }
    }
    //chile-alemania
    public void actualizarChileAlemaniaMarzo()
    {

        if (targetFoundJune && targetFoundSeptember && targetFoundDecember && targetFoundGermany && targetFoundChile)
        {
            panelSuperior.gameObject.SetActive(false);
            alturaSolar.gameObject.SetActive(false);
            anguloAcimutal.gameObject.SetActive(false);
            horaDia.gameObject.SetActive(false);
            infomacionSolarChileAlemania.gameObject.SetActive(true);
            alturaChileAlemania.text = "30.2°";
            alturaAlemaniaChile.text = "37°";
            acimutalChileAlemania.text = "30.2°";
            acimutalAlemaniaChile.text = "172°";
            horasChileAlemania.text = "12h";
            horasAlemaniaChile.text = "12h";
        }

    }

    public void actualizarChileAlemaniaDiciembre()
    {
        if (targetFoundJune && targetFoundMarch && targetFoundSeptember && targetFoundGermany && targetFoundChile)
        {
            panelSuperior.gameObject.SetActive(false);
            alturaSolar.gameObject.SetActive(false);
            anguloAcimutal.gameObject.SetActive(false);
            horaDia.gameObject.SetActive(false);
            infomacionSolarChileAlemania.gameObject.SetActive(true);
            alturaChileAlemania.text = "30.2°";
            alturaAlemaniaChile.text = "13°";
            acimutalChileAlemania.text = "30.2°";
            acimutalAlemaniaChile.text = "176°";
            horasChileAlemania.text = "15h";
            horasAlemaniaChile.text = "7h";
        }

    }
    public void actualizarChileAlemaniaSeptiembre()
    {

        if (targetFoundJune && targetFoundMarch && targetFoundDecember && targetFoundGermany && targetFoundChile)
        {
            panelSuperior.gameObject.SetActive(false);
            alturaSolar.gameObject.SetActive(false);
            anguloAcimutal.gameObject.SetActive(false);
            horaDia.gameObject.SetActive(false);
            infomacionSolarChileAlemania.gameObject.SetActive(true);
            alturaChileAlemania.text = "30.2°";
            alturaAlemaniaChile.text = "37°";
            acimutalChileAlemania.text = "30.2°";
            acimutalAlemaniaChile.text = "172°";
            horasChileAlemania.text = "15h";
            horasAlemaniaChile.text = "12h";
        }


    }
    public void actualizarChileAlemaniaJunio()
    {

        if (targetFoundSeptember && targetFoundMarch && targetFoundDecember && targetFoundGermany && targetFoundChile)
        {
            panelSuperior.gameObject.SetActive(false);
            alturaSolar.gameObject.SetActive(false);
            anguloAcimutal.gameObject.SetActive(false);
            horaDia.gameObject.SetActive(false);
            infomacionSolarChileAlemania.gameObject.SetActive(true);
            alturaChileAlemania.text = "30.2°";
            alturaAlemaniaChile.text = "60°";
            acimutalChileAlemania.text = "30.2°";
            acimutalAlemaniaChile.text = "171°";
            horasChileAlemania.text = "9h";
            horasAlemaniaChile.text = "16h";
        }

    }

    public void actualizarInverseChileAlemaniaMarzo()
    {

        if (!targetFoundJune && !targetFoundMarch && !targetFoundDecember && !targetFoundGermany && !targetFoundChile)
        {
            panelSuperior.gameObject.SetActive(false);
            alturaSolar.gameObject.SetActive(false);
            anguloAcimutal.gameObject.SetActive(false);
            horaDia.gameObject.SetActive(false);
            infomacionSolarChileAlemania.gameObject.SetActive(false);
            alturaChileAlemania.text = "";
            alturaAlemaniaChile.text = "";
            acimutalChileAlemania.text = "";
            acimutalAlemaniaChile.text = "";
            horasChileAlemania.text = "";
            horasAlemaniaChile.text = "";
        }

    }
    public void actualizarInverseChileAlemaniaDiciembre()
    {

        if (!targetFoundJune && !targetFoundMarch && !targetFoundSeptember && !targetFoundGermany && targetFoundChile)
        {
            panelSuperior.gameObject.SetActive(false);
            alturaSolar.gameObject.SetActive(false);
            anguloAcimutal.gameObject.SetActive(false);
            horaDia.gameObject.SetActive(false);
            infomacionSolarChileAlemania.gameObject.SetActive(false);
            alturaChileAlemania.text = "";
            alturaAlemaniaChile.text = "";
            acimutalChileAlemania.text = "";
            acimutalAlemaniaChile.text = "";
            horasChileAlemania.text = "";
            horasAlemaniaChile.text = "";
        }

    }
    public void actualizarInverseChileAlemaniaSeptiembre()
    {

        if (!targetFoundJune && !targetFoundMarch && !targetFoundDecember && !targetFoundGermany && targetFoundChile)
        {
            panelSuperior.gameObject.SetActive(false);
            alturaSolar.gameObject.SetActive(false);
            anguloAcimutal.gameObject.SetActive(false);
            horaDia.gameObject.SetActive(false);
            infomacionSolarChileAlemania.gameObject.SetActive(false);
            alturaChileAlemania.text = "";
            alturaAlemaniaChile.text = "";
            acimutalChileAlemania.text = "";
            acimutalAlemaniaChile.text = "";
            horasChileAlemania.text = "";
            horasAlemaniaChile.text = "";
        }

    }
    public void actualizarInverseChileAlemaniaJunio()
    {
        if (!targetFoundMarch && !targetFoundSeptember && !targetFoundDecember && targetFoundGermany && targetFoundChile)
        {
            panelSuperior.gameObject.SetActive(false);
            alturaSolar.gameObject.SetActive(false);
            anguloAcimutal.gameObject.SetActive(false);
            horaDia.gameObject.SetActive(false);
            infomacionSolarChileAlemania.gameObject.SetActive(false);
            alturaChileAlemania.text = "";
            alturaAlemaniaChile.text = "";
            acimutalChileAlemania.text = "";
            acimutalAlemaniaChile.text = "";
            horasChileAlemania.text = "";
            horasAlemaniaChile.text = "";
        }

    }
    //cr-alemania
    public void actualizarCRAlemaniaMarzo()
    {
        if (targetFoundJune && targetFoundSeptember && targetFoundDecember && targetFoundGermany && targetFoundCostaRica)
        {
            panelSuperior.gameObject.SetActive(false);
            alturaSolar.gameObject.SetActive(false);
            anguloAcimutal.gameObject.SetActive(false);
            horaDia.gameObject.SetActive(false);
            infomacionSolarCRAlemania.gameObject.SetActive(true);
            alturaCRAlemania.text = "79°";
            alturaAlemaniaCR.text = "37°";
            acimutalCRAlemania.text = "-153°";
            acimutalAlemaniaCR.text = "172°";
            horasCRAlemania.text = "12h";
            horasAlemaniaCR.text = "12h";
        }

    }

    public void actualizarCRAlemaniaDiciembre()
    {

        if (targetFoundMarch && targetFoundSeptember && targetFoundJune && targetFoundGermany && targetFoundCostaRica)
        {
            panelSuperior.gameObject.SetActive(false);
            alturaSolar.gameObject.SetActive(false);
            anguloAcimutal.gameObject.SetActive(false);
            horaDia.gameObject.SetActive(false);
            infomacionSolarCRAlemania.gameObject.SetActive(true);
            alturaCRChile.text = "55°";
            alturaCRAlemania.text = "70°";
            acimutalCRChile.text = "-168°";
            acimutalCRAlemania.text = "-8°";
            horasCRChile.text = "11h";
            horasCRAlemania.text = "15h";
        }

    }
    public void actualizarCRAlemaniaSeptiembre()
    {

        if (targetFoundMarch && targetFoundJune && targetFoundDecember && targetFoundGermany && targetFoundCostaRica)
        {
            panelSuperior.gameObject.SetActive(false);
            alturaSolar.gameObject.SetActive(false);
            anguloAcimutal.gameObject.SetActive(false);
            horaDia.gameObject.SetActive(false);
            infomacionSolarCRAlemania.gameObject.SetActive(true);
            alturaCRAlemania.text = "77°";
            alturaAlemaniaCR.text = "37°";
            acimutalCRAlemania.text = "-136°";
            acimutalAlemaniaCR.text = "172°";
            horasCRAlemania.text = "12h";
            horasAlemaniaCR.text = "12h";
        }


    }
    public void actualizarCRAlemaniaJunio()
    {
        if (targetFoundMarch && targetFoundSeptember && targetFoundDecember && targetFoundGermany && targetFoundCostaRica)
        {
            panelSuperior.gameObject.SetActive(false);
            alturaSolar.gameObject.SetActive(false);
            anguloAcimutal.gameObject.SetActive(false);
            horaDia.gameObject.SetActive(false);
            infomacionSolarCRAlemania.gameObject.SetActive(true);
            alturaCRAlemania.text = "75°";
            alturaAlemaniaCR.text = "60°";
            acimutalCRAlemania.text = "-23°";
            acimutalAlemaniaCR.text = "171°";
            horasCRAlemania.text = "12h";
            horasAlemaniaCR.text = "16h";
        }

    }

    public void actualizarInverseCRAlemaniaMarzo()
    {

        if (!targetFoundJune && !targetFoundSeptember && !targetFoundDecember && !targetFoundGermany && !targetFoundCostaRica)
        {
            panelSuperior.gameObject.SetActive(false);
            alturaSolar.gameObject.SetActive(false);
            anguloAcimutal.gameObject.SetActive(false);
            horaDia.gameObject.SetActive(false);
            infomacionSolarCRAlemania.gameObject.SetActive(false);
            alturaCRAlemania.text = "";
            alturaAlemaniaChile.text = "";
            acimutalCRAlemania.text = "";
            acimutalAlemaniaChile.text = "";
            horasCRAlemania.text = "";
            horasAlemaniaChile.text = "";
        }

    }
    public void actualizarInverseCRAlemaniaDiciembre()
    {

        if (!targetFoundMarch && !targetFoundSeptember && !targetFoundJune && !targetFoundGermany && !targetFoundCostaRica)
        {
            panelSuperior.gameObject.SetActive(false);
            alturaSolar.gameObject.SetActive(false);
            anguloAcimutal.gameObject.SetActive(false);
            horaDia.gameObject.SetActive(false);
            infomacionSolarCRAlemania.gameObject.SetActive(false);
            alturaCRAlemania.text = "";
            alturaAlemaniaChile.text = "";
            acimutalCRAlemania.text = "";
            acimutalAlemaniaChile.text = "";
            horasCRAlemania.text = "";
            horasAlemaniaChile.text = "";
        }

    }
    public void actualizarInverseCRAlemaniaSeptiembre()
    {
        if (!targetFoundMarch && !targetFoundJune && !targetFoundDecember && !targetFoundGermany && !targetFoundCostaRica)
        {
            panelSuperior.gameObject.SetActive(false);
            alturaSolar.gameObject.SetActive(false);
            anguloAcimutal.gameObject.SetActive(false);
            horaDia.gameObject.SetActive(false);
            infomacionSolarCRAlemania.gameObject.SetActive(false);
            alturaCRAlemania.text = "";
            alturaAlemaniaChile.text = "";
            acimutalCRAlemania.text = "";
            acimutalAlemaniaChile.text = "";
            horasCRAlemania.text = "";
            horasAlemaniaChile.text = "";
        }

    }
    public void actualizarInverseCRAlemaniaJunio()
    {
        if (!targetFoundMarch && !targetFoundSeptember && !targetFoundDecember && !targetFoundGermany && !targetFoundCostaRica)
        {
            panelSuperior.gameObject.SetActive(false);
            alturaSolar.gameObject.SetActive(false);
            anguloAcimutal.gameObject.SetActive(false);
            horaDia.gameObject.SetActive(false);
            infomacionSolarCRAlemania.gameObject.SetActive(false);
            alturaCRAlemania.text = "";
            alturaAlemaniaChile.text = "";
            acimutalCRAlemania.text = "";
            acimutalAlemaniaChile.text = "";
            horasCRAlemania.text = "";
            horasAlemaniaChile.text = "";
        }

    }
    //cr-chile-Alemania
    public void actualizarCRChileAlemaniaMarzo()
    {

        if (targetFoundJune && targetFoundSeptember && targetFoundDecember && targetFoundGermany && targetFoundCostaRica && targetFoundChile)
        {
            panelSuperior.gameObject.SetActive(false);
            alturaSolar.gameObject.SetActive(false);
            anguloAcimutal.gameObject.SetActive(false);
            horaDia.gameObject.SetActive(false);
            infomacionSolarCRChileAlemania.gameObject.SetActive(true);
            alturaCR.text = "79°";
            alturaAlemania.text = "37°";
            alturaChile.text = "47°";
            acimutalCR.text = "-153°";
            acimutalAlemania.text = "172°";
            acimutalChile.text = "-0,7°";
            horasCR.text = "12h";
            horasAlemania.text = "12h";
            horasChile.text = "12h";
        }

    }

    public void actualizarCRChileAlemaniaDiciembre()
    {

        if (targetFoundMarch && targetFoundSeptember && targetFoundJune && targetFoundGermany && targetFoundCostaRica && targetFoundChile)
        {
            panelSuperior.gameObject.SetActive(false);
            alturaSolar.gameObject.SetActive(false);
            anguloAcimutal.gameObject.SetActive(false);
            horaDia.gameObject.SetActive(false);
            infomacionSolarCRChileAlemania.gameObject.SetActive(true);
            alturaCR.text = "55°";
            alturaAlemania.text = "60°";
            alturaChile.text = "70°";
            acimutalCR.text = "-168°";
            acimutalAlemania.text = "176°";
            acimutalChile.text = "-8°";
            horasCR.text = "11h";
            horasAlemania.text = "7h";
            horasChile.text = "15h";
        }

    }
    public void actualizarCRChileAlemaniaSeptiembre()
    {

        if (targetFoundMarch && targetFoundJune && targetFoundDecember && targetFoundGermany && targetFoundCostaRica && targetFoundChile)
        {
            panelSuperior.gameObject.SetActive(false);
            alturaSolar.gameObject.SetActive(false);
            anguloAcimutal.gameObject.SetActive(false);
            horaDia.gameObject.SetActive(false);
            infomacionSolarCRChileAlemania.gameObject.SetActive(true);
            alturaCR.text = "77°";
            alturaAlemania.text = "38°";
            alturaChile.text = "46°";
            acimutalCR.text = "-136°";
            acimutalAlemania.text = "176°";
            acimutalChile.text = "-6°";
            horasCR.text = "12h";
            horasAlemania.text = "12h";
            horasChile.text = "12h";
        }


    }
    public void actualizarCRChileAlemaniaJunio()
    {

        if (targetFoundMarch && targetFoundSeptember && targetFoundDecember && targetFoundGermany && targetFoundCostaRica && targetFoundChile)
        {
            panelSuperior.gameObject.SetActive(false);
            alturaSolar.gameObject.SetActive(false);
            anguloAcimutal.gameObject.SetActive(false);
            horaDia.gameObject.SetActive(false);
            infomacionSolarCRChileAlemania.gameObject.SetActive(true);
            alturaCR.text = "75°";
            alturaAlemania.text = "60°";
            alturaChile.text = "24°";
            acimutalCR.text = "-23°";
            acimutalAlemania.text = "171°";
            acimutalChile.text = "-1.9°";
            horasCR.text = "12h";
            horasAlemania.text = "16h";
            horasChile.text = "9h";
        }

    }

    public void actualizarInverseCRChileAlemaniaMarzo()
    {

        if (!targetFoundJune && !targetFoundSeptember && !targetFoundDecember && !targetFoundGermany && !targetFoundCostaRica && !targetFoundChile)
        {
            panelSuperior.gameObject.SetActive(false);
            alturaSolar.gameObject.SetActive(false);
            anguloAcimutal.gameObject.SetActive(false);
            horaDia.gameObject.SetActive(false);
            infomacionSolarCRChileAlemania.gameObject.SetActive(false);
            alturaCR.text = "";
            alturaAlemania.text = "";
            alturaChile.text = "";
            acimutalCR.text = "";
            acimutalAlemania.text = "";
            acimutalChile.text = "";
            horasCR.text = "";
            horasAlemania.text = "";
            horasChile.text = "";
        }

    }
    public void actualizarInverseCRChileAlemaniaDiciembre()
    {

        if (!targetFoundMarch && !targetFoundSeptember && !targetFoundJune && !targetFoundGermany && !targetFoundCostaRica && !targetFoundChile)
        {
            panelSuperior.gameObject.SetActive(false);
            alturaSolar.gameObject.SetActive(false);
            anguloAcimutal.gameObject.SetActive(false);
            horaDia.gameObject.SetActive(false);
            alturaCR.text = "";
            alturaAlemania.text = "";
            alturaChile.text = "";
            acimutalCR.text = "";
            acimutalAlemania.text = "";
            acimutalChile.text = "";
            horasCR.text = "";
            horasAlemania.text = "";
            horasChile.text = "";
        }

    }
    public void actualizarInverseCRChileAlemaniaSeptiembre()
    {

        if (!targetFoundJune && !targetFoundMarch && !targetFoundDecember && !targetFoundGermany && !targetFoundCostaRica && !targetFoundChile)
        {
            panelSuperior.gameObject.SetActive(false);
            alturaSolar.gameObject.SetActive(false);
            anguloAcimutal.gameObject.SetActive(false);
            horaDia.gameObject.SetActive(false);
            alturaCR.text = "";
            alturaAlemania.text = "";
            alturaChile.text = "";
            acimutalCR.text = "";
            acimutalAlemania.text = "";
            acimutalChile.text = "";
            horasCR.text = "";
            horasAlemania.text = "";
            horasChile.text = "";
        }

    }
    public void actualizarInverseCRChileAlemaniaJunio()
    {
        if (!targetFoundJune && !targetFoundMarch && !targetFoundDecember && !targetFoundGermany && !targetFoundCostaRica && targetFoundChile)
        {
            panelSuperior.gameObject.SetActive(false);
            alturaSolar.gameObject.SetActive(false);
            anguloAcimutal.gameObject.SetActive(false);
            horaDia.gameObject.SetActive(false);
            alturaCR.text = "";
            alturaAlemania.text = "";
            alturaChile.text = "";
            acimutalCR.text = "";
            acimutalAlemania.text = "";
            acimutalChile.text = "";
            horasCR.text = "";
            horasAlemania.text = "";
            horasChile.text = "";
        }

    }
}
