// bibliotecas / libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// inicio da nossa classe
public class AnimaPersonagem : MonoBehaviour
{

    Animator meuAnimator;
    Rigidbody meuRb;
    float inputVertical;
    public float velocidade;

    float inputHorizontal;
    public float velocidade_giro;

    // ocorre uma vez no inicio do jogo
    void Start()
    {
        meuAnimator = GetComponent<Animator>();
        meuRb = GetComponent<Rigidbody>();
    }

    // ocorre uma vez por frame (fps)
    void Update()
    {
        inputVertical = Input.GetAxis("Vertical");
        inputHorizontal = Input.GetAxis("Horizontal");

        meuAnimator.SetFloat("Y", inputVertical);

        Vector3 dir = transform.forward * inputVertical * velocidade;
        meuRb.AddForce(dir, ForceMode.Force);

        Vector3 giro = transform.up * inputHorizontal * velocidade_giro;
        meuRb.AddTorque(giro, ForceMode.Force);

    }
}
