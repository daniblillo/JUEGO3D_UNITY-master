﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorDeArmas : MonoBehaviour
{
    public LogicaArma[]armas;
    private int indiceArmaActual=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RevisarCambiodeArma();
        
    }

    public void CambiarArmaActual(){
        for(int i=0; i<transform.childCount; i++){
            transform.GetChild(i).gameObject.SetActive(false);

        }
        armas[indiceArmaActual].gameObject.SetActive(true);
    }

    public void RevisarCambiodeArma(){
            float ruedaMouse= Input.GetAxis("Mouse ScrollWheel");
            if(ruedaMouse>0f){
                SeleccionarArmaAnterior();
                armas[indiceArmaActual].recargando=false;
                
            }else if(ruedaMouse<0f){
                SeleccionarArmaSiguiente();
                armas[indiceArmaActual].recargando=false;

            }
    }
    void SeleccionarArmaAnterior(){
        if(indiceArmaActual==0){
            indiceArmaActual=armas.Length-1;

        }else{
            indiceArmaActual--;
        }
        CambiarArmaActual();
    }

        void SeleccionarArmaSiguiente(){
        if(indiceArmaActual >=(armas.Length-1)){
            indiceArmaActual=0;

        }else{
            indiceArmaActual++;
        }
        CambiarArmaActual();
    }
    }

