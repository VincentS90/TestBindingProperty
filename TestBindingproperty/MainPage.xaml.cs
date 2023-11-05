using System.Collections.Generic;
using ListBase;

namespace TestBindingproperty;

public partial class MainPage : ContentPage
{

    public List<NodeVM> ListNode { get; set; }

    public MainPage()
    {
        InitializeComponent();

        ListNode = new List<NodeVM>();

        ListNode.Add(new NodeVM("toto"));
        ListNode.Add(new NodeVM("tata"));
        ListNode.Add(new NodeVM("tutu"));
    }

  
}


