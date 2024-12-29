using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{
public class TestCustomObjectCode : MonoBehaviour
{
        CustomObject Agent_1 = new CustomObject(11011, "Phoenix");
        CustomObject Agent_2 = new CustomObject(22022, "Sage");

    void Start()
    {
        print("Agent Details: " + Agent_1.ToString());
        print(Agent_1 == Agent_2);
        print(Agent_1 != Agent_2);
    }


}
}