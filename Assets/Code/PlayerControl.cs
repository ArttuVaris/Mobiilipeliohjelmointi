using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mobiiliesimerkki
{
    [RequireComponent(typeof(InputReader), typeof(Mover))]
    public class PlayerControl : MonoBehaviour
    {

        private InputReader _inputReader = null;

        private Mover _mover = null;
        // Start is called before the first frame update

        private void Awake()
        {
            _inputReader = GetComponent<InputReader>();
            _mover = GetComponent<Mover>();
        }

        // Update is called once per frame
        void Update()
        {
            Vector2 movement = _inputReader.Movement;
            _mover.Move(movement);
        }
    }
}
