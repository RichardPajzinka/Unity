using UnityEngine;

public class Player_pohyb : MonoBehaviour{
    //pridanie "componentu" do sekcie script kde sa moze modifikovat
    public ArticulationBody ab;
    public Rigidbody rb;
    
    public float moveforward = 2000f;
    //preto aby sme mali aj v GUI pri tom objekte moznost menit tie hodnoty
    public float pohybdostran = 500f;

    // Start is called before the first frame update
    void Start()
    {
        //zobrazenie hlasky ale iba v console
        Debug.Log("Hello , player");
        
        //vypnutie gavitacie aj napriek tomu ze satale je zapnuta
        //ab.AddForce(0, 200, 500);
    }

    // "Fixed"update pretoze nastavujeme "fyziku" 
    void FixedUpdate()
    {
        //"vystrelenie" objektu dopredu
        //deltatime by malo byt podla framu taze aby sme to mali viac pod kontorlou aj pre slabsie PC
       rb.AddForce(0, 0, moveforward * Time.deltaTime);

       if(Input.GetKey("d")){
        rb.AddForce(pohybdostran * Time.deltaTime, 0, 0);
       }else if(Input.GetKey("a")){
        rb.AddForce(-pohybdostran * Time.deltaTime, 0, 0);
       }
    }
}
