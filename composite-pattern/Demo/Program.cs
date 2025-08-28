
using Demo.Sample;

namespace Demo;

class Program
{
    static void Main(string[] args)
    {
        BaseComponent handR = new Composite("Right Hand");
        for (int i = 1; i <= 5; i++)
            handR.Add(new Leaf("Finger " + i));

        BaseComponent armR = new Composite("Right Arm");
        armR.Add(handR);

        BaseComponent shoulderR = new Composite("Right Shoulder");
        shoulderR.Add(armR);

        BaseComponent handL = new Composite("Left Hand");
        for (int i = 1; i <= 5; i++)
            handL.Add(new Leaf("Finger " + i));

        BaseComponent armL = new Composite("Left Arm");
        armL.Add(handL);

        BaseComponent shoulderL = new Composite("Left Shoulder");
        shoulderL.Add(armL);

        BaseComponent body = new Composite("Body");
        body.Add(shoulderL);
        body.Add(shoulderR);

        BaseComponent Base = new Leaf("Base");
        body.Add(Base);
        body.WireUp(1, "=*=");


        GameObject Go1 = new GameObject("Container");
        Component T1 = new Transform("ContainerTransform");
        Component S1 = new Script("ContainerScript");

        Go1.Add(T1);
        Go1.Add(S1);

        GameObject Go2 = new GameObject("CarBody");
        Component T2 = new Transform("BodyTransform");
        Component R1 = new Renderer("BodyRenderer");

        Go2.Add(T2);
        Go2.Add(R1);

        GameObject Go3 = new GameObject("CarWheels");
        Component T3 = new Transform("WheelsTranform");
        Component R2 = new Renderer("WheelsRenderer");
        Component A1 = new Animator("WheelsAnimator");

        Go3.Add(T3);
        Go3.Add(R2);
        Go3.Add(A1);

        Go1.Add(Go2);
        Go1.Add(Go3);
        Go1.TraceFwd();

        R1.TraceBck();
    }
}
