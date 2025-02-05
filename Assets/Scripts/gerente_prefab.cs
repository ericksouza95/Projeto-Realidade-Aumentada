using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class gerente_prefab : MonoBehaviour
{
    [SerializeField] private GameObject ModeloLua;
    [SerializeField] private Vector3 prefabOffset;

    private GameObject modelo1;
    private ARTrackedImageManager aRTrackedImageManager;

    private void OnEnable()
    {
        aRTrackedImageManager = gameObject.GetComponent<ARTrackedImageManager>();

        aRTrackedImageManager.trackedImagesChanged += OnImageChanged; 
    }

    private void OnImageChanged(ARTrackedImagesChangedEventArgs obj)
    {
        foreach (ARTrackedImage image in obj.added)
        {
            modelo1 = Instantiate(ModeloLua, image.transform);
            modelo1.transform.position += prefabOffset;
        }

    }
}
