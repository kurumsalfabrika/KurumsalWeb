using System;

namespace GOSAS.VirtualPos.Core
{
    public class FormElementAttribute : Attribute
    {
        private readonly string[] names;

        public FormElementAttribute(params string[] names)
        {
            this.names = names;
        }

        public string[] Names
        {
            get
            {
                return names;
            }
        }
    }
}
