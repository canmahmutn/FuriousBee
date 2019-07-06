using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yorunge : MonoBehaviour
{
    float timeCount = 50;
    public float speed;
    public float width;
    public float height;
    public float crossmove;
    public bool crossmovecontrol;
    public float crossmovespeed;
    public float crossmovecounter;
    public float crossmovecounter2;
    public bool crossmovecontrol2;
    public float counter = 0;
    public float flametimer = 0;
    public bool flm = false;
    public float cooldown = 0;
    public float up_down=300;
    Vector2 scale;

    void Start()
    {
        speed = 4;
        width = 1;
        height = 1;
        transform.localEulerAngles = new Vector3(0, 0,-90);
        crossmovespeed = 3;
        crossmovecontrol = false;
        crossmovecounter = 0;
        crossmovecontrol2 = false;
        crossmovecounter2 = 0;
    }



    // Update is called once per frame
    void Update()
    {
        timeCount += Time.deltaTime * speed;
        float x = Mathf.Sin (timeCount)*width;
        float y = Mathf.Cos(timeCount)*height;
//        crossmovecounter += Time.deltaTime;
//        if (!crossmovecontrol)
//        {
//            if (crossmovecounter >= 10)
//            {
//                crossmove += Time.deltaTime * crossmovespeed;
//                if (crossmove >= 5)
//                {
//                    crossmovecontrol = true;
//                    crossmovecounter = 0;
//                }
//            }
//
//        }
//        else
//        {
//            if (crossmovecounter >= 10)
//            {
//                crossmove -= Time.deltaTime * crossmovespeed;
//                if (crossmove<=0.5f)
//                {
//                    crossmovecontrol = false;
//                    crossmovecounter = 0;
//                }
//            }
//        }
        transform.position = new Vector2(x-4,y+3);
        if (Input.GetMouseButton(0))
        {
            counter += Time.deltaTime;
            if (speed <30)
            {
                speed += speed * Time.deltaTime *2;
                if ( width < 2 && height < 2)
                {
                    width += width * Time.deltaTime *2;
                    height += height * Time.deltaTime *2;
                }
            }
            else if (speed >= 30 && counter >=3 && speed < 60)
            {

                speed += speed * Time.deltaTime *2;
                if (width >= 2 && height >= 2)
                {
                    width -= width * Time.deltaTime * 2;
                    height -= height * Time.deltaTime * 2;
                }
                else if (width <= 1 && height <= 1)
                {
                    width = width * 1;
                    height = height * 1;
                }
            }
            else if (speed >= 59 && counter >= 3)
            {
                flm = true;
                gameObject.GetComponent<SpriteChanger>().ChangerFlame();
                scale.x = 1;
                scale.y = 1;
                transform.localScale = scale;
            }
            else
            {
                speed -= speed * Time.deltaTime * 2;
            }

            if (flm)
            {
                flametimer += Time.deltaTime;
                if (flametimer >= 2)
                {
                    gameObject.GetComponent<SpriteChanger>().ChangerBee();
                    scale.x = 0.15f;
                    scale.y = 0.19f;
                    transform.localScale = scale;
                    flm = false;
                    flametimer = 0;
                }
                else
                {
                    transform.Rotate(0, 0, -7000 * Time.deltaTime);
                    speed = 4;
                    width = 1;
                    height = 1;
                    counter = 0;
                }
            }
            else
            {
                transform.localEulerAngles = new Vector3(0, 0, -90);
            }
        }

        else
        {
            if (speed >4)
            {
                counter = 0;
                speed -= speed * Time.deltaTime *2;
                if ( width > 1 && height > 1)
                {
                    width -= width * Time.deltaTime *2;
                    height -= height * Time.deltaTime *2;
                }
            }
            if (flm)//flm true ise kullanıcı 5 saniyeden fazla ekrana basılı tutmuştur ve power modu açmıştır.
            {
                flametimer += Time.deltaTime;

                if (flametimer >= 2)//Power mode 2 saniye sürüyor ve kapanıyor.
                {
                    gameObject.GetComponent<SpriteChanger>().ChangerBee();
                    scale.x = 0.15f;
                    scale.y = 0.19f;
                    transform.localScale = scale;
                    flm = false;
                    flametimer = 0;
                }
                else//Hala power moddaysak ateş topumuzu döndürüyoruz.
                {
                    transform.Rotate(0, 0, -7000 * Time.deltaTime);
                    counter = 0;
                }
            }
            else//Eğer power modun süresi bittiyse her şeyi durduruyoruz.
            {
                    transform.localEulerAngles = new Vector3(0, 0, -90);
            }

        }

    }
}