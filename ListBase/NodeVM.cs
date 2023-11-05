using System;
namespace ListBase
{
    public class NodeVM : ViewModelBaseVM
    {
        private string m_name;

        public string Name
        {
            get { return m_name; }
            set { m_name = value; OnPropertyChanged(); }
        }

        public NodeVM(string name)
        {
            Name = name;
        }

        
    }
}

