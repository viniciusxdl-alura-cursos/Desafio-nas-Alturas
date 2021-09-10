using UnityEngine;

namespace Assets.Scripts
{
    [CreateAssetMenu(fileName = "variavel compartilhada", menuName = "Variavel Compartilhada / float")]
    public class VariavelCompartilhadaFloat : ScriptableObject
    {
        public float valor;
    }
}