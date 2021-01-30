using System.Windows.Forms;

namespace System
{
    internal class KeyPressEventHandler
    {
        private Action<object, KeyPressEventArgs> textBoxNumCelular_KeyPress;

        public KeyPressEventHandler(Action<object, KeyPressEventArgs> textBoxNumCelular_KeyPress)
        {
            this.textBoxNumCelular_KeyPress = textBoxNumCelular_KeyPress;
        }
    }
}