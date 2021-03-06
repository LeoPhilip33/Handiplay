﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{

    public float m_speed = 100f;
    public Rigidbody2D m_rb2D; 

    public int m_score = 0;
    public int m_items = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()

    {


         if (Input.GetAxis("Horizontal") < 0f) 
        {
         m_rb2D.MovePosition(m_rb2D.position + Time.fixedDeltaTime * m_speed * Vector2.left); 
        }  

         if (Input.GetAxis("Horizontal") > 0f) 
        {
         m_rb2D.MovePosition(m_rb2D.position + Time.fixedDeltaTime * m_speed * Vector2.right); 
        } 

         if (Input.GetAxis("Vertical") > 0f) 
        {
         m_rb2D.MovePosition(m_rb2D.position + Time.fixedDeltaTime * m_speed * Vector2.down); 
        }  

         if (Input.GetAxis("Vertical") < 0f) 
        {
         m_rb2D.MovePosition(m_rb2D.position + Time.fixedDeltaTime * m_speed * Vector2.up); 
        } 
        
     

    }

        void OnCollisionEnter2D(Collision2D collision) 
        {    if (collision.gameObject.tag == "Coin") 
            {   Destroy(collision.gameObject);    
                m_score = m_score + 1;
                } 
        
           if (collision.gameObject.tag == "Ball") 
            {   Destroy(collision.gameObject);    
                m_items = m_items + 1;
                } 

        }

    

}
