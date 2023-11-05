namespace ListBase;

public partial class ListDisplay : ContentView
{
    public static readonly BindableProperty SourceItemsProperty = BindableProperty.Create("SourceItems", typeof(List<NodeVM>), typeof(ListDisplay), new List<NodeVM>() { new NodeVM("tt") });

    public ListDisplay()
    {
        InitializeComponent();
    }

    public List<NodeVM> SourceItems
    {
        get => (List<NodeVM>)GetValue(SourceItemsProperty);
        set => SetValue(SourceItemsProperty, value);
    }

    static void OnSourceItemsChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var control = (ListDisplay)bindable;
        control.SourceItems = (List<NodeVM>)newValue;
    }
}
