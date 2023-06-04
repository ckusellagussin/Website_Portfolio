using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Selection_Manager : MonoBehaviour
{
    [SerializeField] private Material highlightMaterial;
    [SerializeField] private string selectableTag = "Selectable";
    [SerializeField] private Material defaultMaterial;
    [SerializeField] private string selectableTag8 = "GameJam";
    [SerializeField] private GameObject popupUI;
    [SerializeField] private GameObject popupUI2;
    private Transform _selection;
    
    private Vector3 direction;
    public float sphereRadius;
    public float maxDistance;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_selection != null)
        {
            var selectionRenderer = _selection.GetComponent<Renderer>();
            selectionRenderer.material = defaultMaterial;
            _selection = null;
        }

        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        RaycastHit hit;
        
        
        if (Physics.Raycast(ray, out hit, 50))
        {
            var selection = hit.transform;
            
            if (selection.CompareTag(selectableTag))
            {
                
                var selectionRenderer = selection.GetComponent<Renderer>();
                if (selectionRenderer != null)
                {

                    selectionRenderer.material = highlightMaterial;

                }
                
                if (Input.GetMouseButtonDown(0))
                {

                    if (popupUI.activeSelf != true)
                    {
        
                        popupUI.SetActive(true);
                        Debug.Log("You have hit the button with mouse and made the UI pop");

                    }
                    
                    else
                    {
                        
                         Debug.Log("You have hit the button and UI has hidden again");
                         popupUI.SetActive(false);
                         
                         
                    }
                    

                }
                

                _selection = selection;
            }
            
            
            if (selection.CompareTag(selectableTag8))
            {
                
                var selectionRenderer = selection.GetComponent<Renderer>();
                if (selectionRenderer != null)
                {

                    selectionRenderer.material = highlightMaterial;

                }
                
                if (Input.GetMouseButtonDown(0))
                {

                    if (popupUI2.activeSelf != true)
                    {
        
                        popupUI2.SetActive(true);
                        Debug.Log("You have hit the button with mouse and made the UI pop");

                    }
                    
                    else
                    {
                        
                        popupUI2.SetActive(false);
                        Debug.Log("You have hit the button and UI has hidden again");

                    }
                    

                }
                

                _selection = selection;
            }
            
            
        }
        
        

    }
}
