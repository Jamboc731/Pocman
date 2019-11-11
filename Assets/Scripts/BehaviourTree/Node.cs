using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct Node
{

    public List<Node> previousNode;
    
    public Node(Node pNode)
    {
        previousNode = new List<Node>();
        previousNode.Add(new Node(pNode));
    }

}

public enum nodeType
{

}