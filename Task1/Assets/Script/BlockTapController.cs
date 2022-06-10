using UnityEngine;
using UnityEngine.AI;

public class BlockTapController : MonoBehaviour
{
    public LayerMask whatCanbeClicked;
    private NavMeshAgent myAgent;
    public BlockController isJoistiks;

    private void Start()
    {
        myAgent = GetComponent<NavMeshAgent>();
    }

    public void Update()
    {
        if (isJoistiks.isJoystick) return;
        var myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(myRay, out var hit, 100, whatCanbeClicked))
            myAgent.SetDestination(hit.point);
    }
}
