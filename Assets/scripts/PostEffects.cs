using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;


public class PostEffects : MonoBehaviour
{
    /*
    public Menu menu;
    public Switch change;
    GameObject PostEffectManager;


    // variables for post processing-Zion
    private Volume volume;
    PaniniProjection pan;
    Vignette m_Vignette;
    FilmGrain film;
    SplitToning st;
    public Texture2D texture;
    // varibles for splittoning-Z
    public Color shadows = new Color(0.50f, 0.50f, 0.50f);
    public Color highlights = new Color(0.50f, 0.50f, 0.50f);


    // varibles for Vignette-Z
    public Color color = new Color(0.00f, 0.0f, 0.00f);
    public Vector2 center = new Vector2(0.50f, 0.50f);
    //varibles for fades into to darkmode
    public float darknessSpeed = 0.5f;
    private float currentDarkness = 0f;


    // Start is called before the first frame update
    void Start()
    {
        PostEffectManager.GetComponent<Switch>();

        //Vignette reference-Zion
        volume = GetComponent<Volume>();
        volume.profile.TryGet<Vignette>(out m_Vignette);
        m_Vignette.active = false;
        m_Vignette.intensity.value = 1;
        //FilmGrain refernce-Zion
        volume.profile.TryGet<FilmGrain>(out film);
        film.active = false;
        film.response.value = 0.0f;
        film.intensity.value = 0.93f;
        film.type.value = FilmGrainLookup.Medium1;
        //Split Toning reference-Zion
        volume.profile.TryGet<SplitToning>(out st);
        st.active = false;
        st.balance.value = 3;
        st.shadows.value = new Color(0.0f, 0.1461911f, 0.9150943f);
        st.highlights.value = new Color(0.0f, 0.0f, 0.0f);
        //Panini projection reference-Zion
        volume.profile.TryGet<PaniniProjection>(out pan);
        pan.active = true;
        pan.distance.value = 1.0f;
        pan.cropToFit.value = 1.0f;



    }

   



    void Update()
    {

        //Panini projection-Zion
        pan.active = true;
        pan.distance.value = 1.0f;
        pan.cropToFit.value = 1.0f;
        // timer to become DarkMode
        currentDarkness += darknessSpeed * Time.deltaTime;
        st.shadows.value = new Color(0.0f, 0.1461911f, 0.9150943f);
        st.highlights.value = new Color(0.0f, 0.0f, 0.0f);
        DarkMode();
      

    }

    public void Menu()//Zion
    {
       
        if (change.isAppearing == true)
        {
            if (change.Picture )
            {

            }
            //Vignette-Zion
            // Change vignette intensity using a sinus curve-Zion
            m_Vignette.active = true;
            m_Vignette.intensity.value = Mathf.Sin(Time.realtimeSinceStartup);

            m_Vignette.color.value = color;
            m_Vignette.center.value = center;
            m_Vignette.intensity.value = 1.00f;
            m_Vignette.smoothness.value = 1.00f;
            m_Vignette.rounded.value = true;

            //FilmGrain -Zion
            film.active = true;
            film.intensity.value = Mathf.Sin(Time.realtimeSinceStartup);

            film.texture.value = texture;
            film.response.value = 0.0f;
            film.intensity.value = 0.93f;
            film.type.value = FilmGrainLookup.Medium1;

            //Split Toning -Zion
            st.active = true;
            st.balance.value = Mathf.Sin(Time.realtimeSinceStartup);
            st.balance.value = 3;
            st.shadows.value = new Color(0.0f, 0.1461911f, 0.9150943f);
            st.highlights.value = new Color(0.0f, 0.0f, 0.0f);

           
        }
    }
    */
}
