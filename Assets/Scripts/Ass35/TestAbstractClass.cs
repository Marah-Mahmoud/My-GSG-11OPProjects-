using UnityEngine;
namespace Assignment35
{

    public class TestAbstractClass : MonoBehaviour
    {
        void Start()
        {
            AbstractBaseClass instance = new DerivedClassExample();
            instance.PerformAction();
            instance.PrintInfo();
        }
    }
}