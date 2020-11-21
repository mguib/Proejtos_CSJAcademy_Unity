using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrcController : MonoBehaviour
{
    public List<Orc> ListOrc = new List<Orc>();
    
    Dictionary<string, Orc> orc = new Dictionary<string, Orc>();

    // Start is called before the first frame update
    void Start()
    {
        //UsingList();
        UsingDictionary();
    }

    public void UsingList()
    {
        ListOrc.Add(new Orc("Durotan", 10));
        ListOrc.Add(new Orc("Draca", 20));
        ListOrc.Add(new Orc("Aggralan", 10));

        foreach (Orc orc in ListOrc)
        {
            Debug.Log(orc.Name);
        }
    }

    public void UsingDictionary()
    {
        Orc orc1 = new Orc("Durotram", 50);
        Orc orc2 = new Orc("Draca", 50);
        Orc orc3 = new Orc("Aggralan", 50);

        orc.Add("guerreiro", orc1);
        orc.Add("cozinheiro", orc2);
        orc.Add("mago", orc3);

        Orc orc4 = orc["mago"];
        Orc orc5 = null;

        if (orc.TryGetValue("fazendeiro", out orc4))
        {
            // SE VERDADEIRO
            Debug.Log("Ta certo");
        }
        else
        {
            // SE FALSO
            Debug.Log("Não deu certo");
        }
    }
}
