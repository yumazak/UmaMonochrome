using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
namespace Uma 
{
    [ExecuteInEditMode]
    [RequireComponent(typeof(Camera))]
    [AddComponentMenu("Uma Image Effects/Monochrome")]
    public class Monochrome : MonoBehaviour
    {
        #region Public Properties
        #endregion

        #region Private Properties
        [SerializeField]
        Shader _shader;
        Material _material;
        #endregion

        #region MonoBehaviour Functions
        private void OnRenderImage(RenderTexture source, RenderTexture destination)
        {
            if (_material == null)
            {
                _material = new Material(_shader);
                _material.hideFlags = HideFlags.DontSave;
            }
            Graphics.Blit(source, destination, _material);
        }
        #endregion
    }
}