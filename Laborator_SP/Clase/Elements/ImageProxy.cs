using System;

namespace Laborator_SP.Clase
{
    public class ImageProxy : Element
    {

        private string imageName { get; set; }
        private Image Image { get; set; }

        public ImageProxy(string imageName)
        {
            this.imageName = imageName ?? throw new ArgumentNullException(nameof(imageName));
            Image = null;
        }

        public void print()
        {
            if (Image == null)
                Image = new Image(imageName);

            Image.print();
        }

        public void accept(Visitor visitor)
        {
            visitor.visit(this);
        }
    }
}
