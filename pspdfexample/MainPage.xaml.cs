using PSPDFKit.Sdk;

namespace pspdfexample;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    private async void OnPDFViewInitialized(object sender, EventArgs e)
    {
        try
        {
            await PDFView.Controller.LoadDocumentFromAssetsAsync("test.docx", null);
        }
        catch (Exception ex)
        {
            // Handle exception.
        }
    }
}


