using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Link_Manager : MonoBehaviour
{
    [SerializeField] private Material highlightMaterial;
    [SerializeField] private string selectableTag2 = "Github";
    [SerializeField] private string selectableTag3 = "Twitter";
    [SerializeField] private string selectableTag4 = "LinkedIn";
    [SerializeField] private string selectableTag5 = "Youtube";
    [SerializeField] private string selectableTag6 = "GodsOS";
    [SerializeField] private string selectableTag7 = "InstaFitness";
    [SerializeField] private Material defaultMaterial;

    private Transform _selection;
    
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
            
            if (selection.CompareTag(selectableTag2))
            {
                
                var selectionRenderer = selection.GetComponent<Renderer>();
                if (selectionRenderer != null)
                {

                    selectionRenderer.material = highlightMaterial;

                }
                
                if (Input.GetMouseButtonDown(0))
                {

                   Application.OpenURL("https://github.com/ckusellagussin/");
                   
                }
                

                _selection = selection;
            }
            
            
            if (selection.CompareTag(selectableTag3))
            {
                
                var selectionRenderer = selection.GetComponent<Renderer>();
                if (selectionRenderer != null)
                {

                    selectionRenderer.material = highlightMaterial;

                }
                
                if (Input.GetMouseButtonDown(0))
                {

                    Application.OpenURL("https://twitter.com/CKGussinDev/");

                }
                

                _selection = selection;
            }
            
            if (selection.CompareTag(selectableTag4))
            {
                
                var selectionRenderer = selection.GetComponent<Renderer>();
                if (selectionRenderer != null)
                {

                    selectionRenderer.material = highlightMaterial;

                }
                
                if (Input.GetMouseButtonDown(0))
                {

                    Application.OpenURL("https://www.linkedin.com/in/casey-kusella-gussin-a911b675/");

                }
                

                _selection = selection;
            }
            
            if (selection.CompareTag(selectableTag5))
            {
                
                var selectionRenderer = selection.GetComponent<Renderer>();
                if (selectionRenderer != null)
                {

                    selectionRenderer.material = highlightMaterial;

                }
                
                if (Input.GetMouseButtonDown(0))
                {

                    Application.OpenURL("https://www.youtube.com/channel/UCx_gTGVxOKB_a08csWiwvGg");

                }
                

                _selection = selection;
            }
            
            if (selection.CompareTag(selectableTag6))
            {
                
                var selectionRenderer = selection.GetComponent<Renderer>();
                if (selectionRenderer != null)
                {

                    selectionRenderer.material = highlightMaterial;

                }
                
                if (Input.GetMouseButtonDown(0))
                {

                    Application.OpenURL("https://steamcommunity.com/sharedfiles/filedetails/?id=2497121194");

                }
                

                _selection = selection;
            }
            
            if (selection.CompareTag(selectableTag7))
            {
                
                var selectionRenderer = selection.GetComponent<Renderer>();
                if (selectionRenderer != null)
                {

                    selectionRenderer.material = highlightMaterial;

                }
                
                if (Input.GetMouseButtonDown(0))
                {

                    Application.OpenURL("https://www.instagram.com/ckg_fitness/");

                }
                

                _selection = selection;
            }
            
            
        }
        
        

    }
}
