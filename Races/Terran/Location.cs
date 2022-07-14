namespace SC1GameObj
{
    public class Location
    {
        public float X { get; set; }
        public float Y { get; set; }

        public Location(float X, float Y)
        {
            this.X = X;
            this.Y = Y;
        }
        

        public void ChangeLocationBy(float x, float y)
        {
            X += x;
            Y += y;
        }

    }
}