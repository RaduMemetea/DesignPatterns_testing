using System;

namespace Laborator_SP.Clase
{
    public interface Observer
    {
        public void update(String oldValue, String newValue, String type);
    }
}
