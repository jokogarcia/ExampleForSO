namespace ExampleForSO;

public class ValidatableEntry : ContentView
{
	public Entry Entry { get; set; } = new();
	public int MinimumLength { get; set; }
	public bool IsValid { get; set; }
	public ValidatableEntry()
	{
		this.Entry.TextChanged += OnTextChanged;
		Content = new VerticalStackLayout
		{
			Children = {
				Entry
			}
		};
		
	}

	private void OnTextChanged(object sender, TextChangedEventArgs e)
	{
		Entry entry = sender as Entry;
		IsValid = entry?.Text?.Length> MinimumLength; 
	}
}