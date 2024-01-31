using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mobiiliesimerkki
{
    /// <summary>
    /// Tämä skripti vaihtaa spriten väriä.
    /// </summary>
    public class ColourChanger : MonoBehaviour
    {
        // Luokan jäsenmuuttujat

        // Merkataan aina jäsenmuuttujat alaviivalla _.
        // Viittaus SpriteRenderer-komponenttiin.
        private SpriteRenderer _spriteRender;

        [SerializeField]
        private Color[] _colours;

        // Start is called before the first frame update
        void Start()
        {
            _spriteRender = GetComponent<SpriteRenderer>();

            _spriteRender.color =_colours[0];
        }

        // Update is called once per frame
        void Update()
        {
            int index = (int)(Time.time % _colours.Length);
            _spriteRender.color = _colours[index];
        }
    }
}