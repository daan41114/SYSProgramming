using System.Drawing;


namespace Eindopdracht
{
    class Noddy : Sprite
    {
        public Noddy(RectangleF screenPosition)
        {
            this.screenPosition = screenPosition;
            imageFrame = new Rectangle(95, 339, 16, 16);
        }
    }
}
