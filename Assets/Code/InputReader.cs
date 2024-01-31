using System.Collections;
using System.Collections.Generic;
using Mobiilipeliesimerkki;
using UnityEngine;

namespace Mobiiliesimerkki
{
    public class InputReader : MonoBehaviour
    {
        private Inputs _inputs = null;
        
        private Vector2 _movementInput;

        private bool _interactInput = false;

        public Vector2 Movement
        {
            get { return _movementInput; }
        }
        private void Awake()
        {
            _inputs = new Inputs();
        }

        private void OnEnable()
        {
            _inputs.Game.Enable();
        }

        // Start is called before the first frame update
        private void Start()
        {
            Vector3 vektori = new Vector3(1, 2, 3);
        }

        private void OnDisable()
        {
            
        }
        // Update is called once per frame
        void Update()
        {
            _movementInput = _inputs.Game.Move.ReadValue<Vector2>();
        }
        
    }
}