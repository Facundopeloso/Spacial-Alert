﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Events_Asteroide : MonoBehaviour
{

    public delegate void AsteroideExplota();
    public static event AsteroideExplota OnAsteroideExplota;
    public void _AsteroideExplota() => OnAsteroideExplota?.Invoke();


    
    public delegate void AsteroideImpactar();
    public static event AsteroideImpactar onAsteroideImpactar;
    public void _AsteroideImpactar() => onAsteroideImpactar?.Invoke();


}
