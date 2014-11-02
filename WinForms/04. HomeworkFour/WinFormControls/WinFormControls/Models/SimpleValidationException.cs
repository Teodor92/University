namespace WinFormControls.Models
{
    using System;
    using System.Windows.Forms;

    public class SimpleValidationException : Exception
    {
        public SimpleValidationException(string message)
            : base(message)
        {
        }
    }
}
