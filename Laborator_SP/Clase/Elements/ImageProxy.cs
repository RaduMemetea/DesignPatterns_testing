using System;
using System.Collections.Generic;

namespace Laborator_SP.Clase
{
    public class ImageProxy : Element,Observable
    {

        public string imageName { get; private set; }
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

        public void addObserver(Observer obs)
        {
            if(Image != null)
                Image.addObserver(obs);
        }

        public void removeObserver(Observer obs)
        {
            if (Image != null)
                Image.removeObserver(obs);
        }

        public void notifyObservers()
        {
            if (Image != null)
                Image.notifyObservers();

        }

        public void setNewValue(string newValue)
        {
            if (Image != null)
                Image.setNewValue(newValue);
        }

    }
}
