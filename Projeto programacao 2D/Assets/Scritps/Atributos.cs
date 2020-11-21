using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atributos : MonoBehaviour
{
    [Header("Atributos Numeriocos")]

    [HideInInspector]// Oculta variáveis publicas do inspector
    public int socore;

    [SerializeField]//Mostra variáveis privadas no inspector
    private int point;

    [Space]//Espaçamento entre variaveis

    [Header("Outras variaveis")]//Titulo ao cabeçalho
    [Tooltip("Variáveis que não são numéricas")]// instrução ao passar mouse
    public float test;

    [Range(-5,5)]//barra visualdo com dois valores
    public float lifeBar;

    [TextArea]//area de texto grande
    public string textArea;

}
