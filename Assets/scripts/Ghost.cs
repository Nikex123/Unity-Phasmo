using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    public MeshRenderer visible;

    public float Ghosteventlength = 3f;
    public float Ghosteventmin = 10;
    public float Ghosteventmax = 30;

    public float fingerprintsmin = 15;
    public float fingerprintsmax = 35;
    public AudioSource fingerprintssound;
    private float TimerFinger;


    public float GhostSoundeventmin = 10;
    public float GhostSoundeventmax = 30;
    private float TimerSound = 0;

    public float blinklength = 0.5f;
    public float ThrowMin = 300f;
    public float ThrowMax = 600f;

    private int randomaudio = 3;
    private int audiorn = 0;

    public AudioSource source;
    public AudioSource source2;
    public AudioSource source3;

    public Fingerprints fs;

    public Transform tf;

    public ghosthandler gh;

    public throwable ta;
    public throwable ta2;
    public throwable ta3;
    public throwable ta4;

    public GameObject boysroom;
    public GameObject bathroom;
    public GameObject nursery;
    public GameObject foyer;
    public GameObject Livingroom;
    public GameObject Masterbedroom;
    public GameObject BathroomM;
    public GameObject EatRoom;
    public GameObject Kitchen;
    public GameObject utility;
    public GameObject Garage;

    private int Ghostrooms = 11;
    private int Ghostroom = 0;


    private bool Timer3plus = false;
    private bool Timer3minus = false;

    private float Timer = 0f;
    private float Timer2 = 0f;
    private float Timer3 = 0f;

    void Start()
    {
        Timer3minus = false;
        Timer3plus = false;
        Timer = Random.Range(Ghosteventmin, Ghosteventmax);
        TimerSound = Random.Range(GhostSoundeventmin, GhostSoundeventmax);

        TimerFinger = Random.Range(fingerprintsmin, fingerprintsmax);

        

        visible.enabled = false;
        Ghostroom = Random.Range(0, Ghostrooms);

        if (Ghostroom == 0)
        {
            //boysroom
            tf.transform.position = new Vector3(-11, 1, 11);
            Destroy(bathroom);
            Destroy(nursery);
            Destroy(foyer);
            Destroy(Livingroom);
            Destroy(Masterbedroom);
            Destroy(BathroomM);
            Destroy(EatRoom);
            Destroy(Kitchen);
            Destroy(utility);
            Destroy(Garage);
           
        }
        if (Ghostroom == 1)
        {
            //bathroom
            tf.transform.position = new Vector3(-11, 1, 16);
            Destroy(nursery);
            Destroy(foyer);
            Destroy(Livingroom);
            Destroy(Masterbedroom);
            Destroy(BathroomM);
            Destroy(EatRoom);
            Destroy(Kitchen);
            Destroy(utility);
            Destroy(Garage);
            Destroy(boysroom);
        }
        if (Ghostroom == 2)
        {
            //nursery
            tf.transform.position = new Vector3(-11, 1, 32);
            Destroy(bathroom);
            Destroy(foyer);
            Destroy(Livingroom);
            Destroy(Masterbedroom);
            Destroy(BathroomM);
            Destroy(EatRoom);
            Destroy(Kitchen);
            Destroy(utility);
            Destroy(Garage);
            Destroy(boysroom);
        }
        if (Ghostroom == 3)
        {
            //foyer
            tf.transform.position = new Vector3(-7, 1, 20);
            Destroy(bathroom);
            Destroy(nursery);
            Destroy(Livingroom);
            Destroy(Masterbedroom);
            Destroy(BathroomM);
            Destroy(EatRoom);
            Destroy(Kitchen);
            Destroy(utility);
            Destroy(Garage);
            Destroy(boysroom);
        }

        if (Ghostroom == 4)
        {
            // Livingroom
            tf.transform.position = new Vector3(2, 1, 44);
            Destroy(bathroom);
            Destroy(nursery);
            Destroy(foyer);
            Destroy(Masterbedroom);
            Destroy(BathroomM);
            Destroy(EatRoom);
            Destroy(Kitchen);
            Destroy(utility);
            Destroy(Garage);
            Destroy(boysroom);
        }
        if (Ghostroom == 5)
        {
            //masterbedroom
            tf.transform.position = new Vector3(-12, 1, 40);
            Destroy(bathroom);
            Destroy(nursery);
            Destroy(foyer);
            Destroy(Livingroom);
            Destroy(BathroomM);
            Destroy(EatRoom);
            Destroy(Kitchen);
            Destroy(utility);
            Destroy(Garage);
            Destroy(boysroom);
        }
        if (Ghostroom == 6)
        {

            //BathroomM
            tf.transform.position = new Vector3(-17, 1, 50);
            Destroy(bathroom);
            Destroy(nursery);
            Destroy(foyer);
            Destroy(Livingroom);
            Destroy(Masterbedroom);
            Destroy(EatRoom);
            Destroy(Kitchen);
            Destroy(utility);
            Destroy(Garage);
            Destroy(boysroom);
        }
        if (Ghostroom == 7)
        {
            //eatRoom
            tf.transform.position = new Vector3(19, 1, 42);
            Destroy(bathroom);
            Destroy(nursery);
            Destroy(foyer);
            Destroy(Livingroom);
            Destroy(Masterbedroom);
            Destroy(BathroomM);
            Destroy(Kitchen);
            Destroy(utility);
            Destroy(Garage);
            Destroy(boysroom);
        }

        if (Ghostroom == 8)
        {
            //kitchen
            tf.transform.position = new Vector3(19, 1, 24);
            Destroy(bathroom);
            Destroy(nursery);
            Destroy(foyer);
            Destroy(Livingroom);
            Destroy(Masterbedroom);
            Destroy(BathroomM);
            Destroy(EatRoom);
            Destroy(utility);
            Destroy(Garage);
            Destroy(boysroom);
        }
        if (Ghostroom == 9)
        {
            //utility
            tf.transform.position = new Vector3(9, 1, 31);
            Destroy(bathroom);
            Destroy(nursery);
            Destroy(foyer);
            Destroy(Livingroom);
            Destroy(Masterbedroom);
            Destroy(BathroomM);
            Destroy(EatRoom);
            Destroy(Kitchen);
            Destroy(Garage);
            Destroy(boysroom);
        }
        if (Ghostroom == 10)
        {
            //garage
            tf.transform.position = new Vector3(19, 1, 20);
            Destroy(bathroom);
            Destroy(nursery);
            Destroy(foyer);
            Destroy(Livingroom);
            Destroy(Masterbedroom);
            Destroy(BathroomM);
            Destroy(EatRoom);
            Destroy(Kitchen);
            Destroy(utility);
            Destroy(boysroom);
        }
        
    }

    // Update is called once per frame
    void Update()
    {

        TimerSound -= Time.deltaTime;

        TimerFinger -= Time.deltaTime;

        if(TimerFinger < 0 )
        {
            fingerprintssound.Play();
            if(gh.Obakeactive == true)
            {
                fs.FingerprintsAction();
            }
            if(gh.Mylingactive == true)
            {
                fs.FingerprintsAction();
            }

            TimerFinger = Random.Range(fingerprintsmin, fingerprintsmax);

        }

        if (TimerSound <= 0)
        {

            Sound();
            TimerSound = Random.Range(GhostSoundeventmin, GhostSoundeventmax); ; 
        }

        if(Timer3plus == true)
        {
            Timer3 += Time.deltaTime;
        }
        if(Timer3minus == true)
        {
            Timer3 -= Time.deltaTime;
        }
        if (Timer2 < 0)
        {
            Timer3plus = false;
            Timer3minus = false;
            visible.enabled = false;
            gh.ghosteventactive = false;
        }
        if(Timer3 >= blinklength)
        {
            visible.enabled = true;
            Timer3minus = true;
            Timer3plus = false;
        }
        if(Timer3 <= 0f)
        {
            visible.enabled = false;
            Timer3plus = true;
            Timer3minus = false;
        }

      

        Timer -= Time.deltaTime;
        Timer2 -= Time.deltaTime;

     
        if (Timer < 0f )
        {
            Timer2 = Ghosteventlength;
            Ghostevent();
            Timer = Random.Range(Ghosteventmin, Ghosteventmax) + 10f;
            
        }
    }

  
    public void Sound() 
    {
        audiorn = Random.Range(0, randomaudio);

        ta.CurrentThrow = Random.Range(ThrowMin, ThrowMax);
        ta.Throw();
        ta2.CurrentThrow = Random.Range(ThrowMin, ThrowMax);
        ta2.Throw();
        ta3.CurrentThrow = Random.Range(ThrowMin, ThrowMax);
        ta3.Throw();

        if ( audiorn == 0)
        {
            source.Play();
        }
        if(audiorn == 1)
        {
            source2.Play();
        }
        if(audiorn == 2)
        {
            source3.Play();
        }
    }
    public void Ghostevent()
    {
         
           visible.enabled = true;
           Timer3 = blinklength;
           gh.ghosteventactive = true;
           ta.CurrentThrow = Random.Range(ThrowMin, ThrowMax);
           ta.Throw();
           ta2.CurrentThrow = Random.Range(ThrowMin, ThrowMax);
           ta2.Throw();
           ta3.CurrentThrow = Random.Range(ThrowMin, ThrowMax);
           ta3.Throw();
           ta4.CurrentThrow = Random.Range(ThrowMin, ThrowMax);
           ta4.Throw();
    }
}
