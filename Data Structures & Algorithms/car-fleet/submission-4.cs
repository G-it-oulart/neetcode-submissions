public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        Car[] cars = new Car[position.Length];
        float steps = 0;
        Stack<float> stepsStack = new Stack<float>();
        for (int i = 0; i<position.Length;i++){
            cars[i] = new Car{
                Position = position[i],
                Speed = speed[i]
            };
        }
        Array.Sort(cars, (a, b) => b.Position.CompareTo(a.Position));
        stepsStack.Push((target - cars[0].Position)/cars[0].Speed);
        for(int i =1;i<cars.Length;i++){
            steps = (target - cars[i].Position)/cars[i].Speed;
            if(steps <= stepsStack.Peek()){
                continue;
            } else{
                stepsStack.Push(steps);
            }
        }
        return stepsStack.Count;
    }
}

public class Car
{
    public float Position;
    public float Speed;
}
